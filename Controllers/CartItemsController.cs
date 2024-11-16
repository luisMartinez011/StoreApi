using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Data.Repositories;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ICartRepository _cartRepository;

        public CartItemsController(AppDbContext context, ICartRepository cartRepository)
        {
            _context = context;
            _cartRepository = cartRepository;
        }


        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{cartItemId}/{productId}/{quantity}")]
        public async Task<IActionResult> PutCartItem(int cartItemId, int productId, int quantity)
        {

            var cartItem = await _cartRepository.GetCartItem(cartItemId);

            if (cartItem == null)
            {
                return NotFound(new { message = "Cart item not found." });
            }

            // Update properties
            cartItem.Quantity = quantity;
            cartItem.Amount = quantity * cartItem.Product.Price;
            cartItem.ProductId = productId;

            try
            {
                await _context.SaveChangesAsync();
                await _cartRepository.UpdateCartTotalAsync(cartItem);


            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(cartItem);
        }

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("{idUser}/{productId}/{quantity}")]
        public async Task<IActionResult> PostCartItem(Guid idUser, int productId, int quantity)
        {
            try
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(c => c.UserId == idUser);
                var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
                
                CartItem cartItem = new CartItem
                {
                    CartId = cart.CartId,
                    ProductId = productId,
                    Quantity = quantity,
                    Amount = quantity * product.Price

                };


                _context.CartItems.Add(cartItem);

                await _context.SaveChangesAsync();
                await _cartRepository.UpdateCartTotalAsync(cartItem);
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    success = false,
                    message = ex.Message
                });
            }
            
        }

        // DELETE: api/CartItems/5
        [Authorize]
        [HttpDelete("{cartItemId}")]
        public async Task<IActionResult> DeleteCartItem(int cartItemId)
        {
            CartItem cartItem = await _cartRepository.GetCartItem(cartItemId);
            if (cartItem == null)
            {
                return NotFound();
            }

            await _cartRepository.DeleteCartItemAsync(cartItem);
            
            return NoContent();
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItems.Any(e => e.CartItemId == id);
        }

        
    }
}
