using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StoreAPI.Models;
using System.Text;

namespace StoreAPI.Data.Repositories
{
    public interface ICartRepository
    {
        Task<CartItem> GetCartItem(int cartItemId);
         Task<List<CartItem>> GetCartItemsByIdCart(int idCart);
        Task<bool> UpdateCartTotalAsync(CartItem cartItemId);
        Task<bool> DeleteCartItemAsync(CartItem cartItem);
    }
    public class CartRepository: ICartRepository
    {
        private readonly AppDbContext _dbContext;

        public CartRepository(AppDbContext dbContext,
            IConfiguration configuration)
        {
            _dbContext = dbContext;
        }

        public async Task<CartItem> GetCartItem(int cartItemId)
        {
            var cartItem = await _dbContext.CartItems
            .Include(ci => ci.Cart) // Incluir datos del carrito si es necesario
            .Include(ci => ci.Product) // Incluir datos del producto
            .FirstOrDefaultAsync(ci => ci.CartItemId == cartItemId);
            return cartItem;
        }

        public async Task<List<CartItem>> GetCartItemsByIdCart(int idCart)
        {
            List<CartItem> cart = await _dbContext.CartItems
                //.Include(c => ci.)
                .Where(ci => ci.CartId == idCart)
                .ToListAsync();
            return cart;
        }

        public async Task<bool> UpdateCartTotalAsync(CartItem cartItem)
        {
            List<CartItem> cartItems = await GetCartItemsByIdCart(cartItem.CartId);
            double totalAmount = 0;
            foreach (var item in cartItems)
            {
                totalAmount += item.Amount;
            }
            cartItem.Cart.TotalAmount = totalAmount;
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InvalidOperationException("Error al actualizar en la base de datos", ex);
            }

        }

        public async Task<bool> DeleteCartItemAsync(CartItem cartItem)
        {
            List<CartItem> cartItems = await GetCartItemsByIdCart(cartItem.CartId);
            double totalAmount = 0;
            foreach (var item in cartItems)
            {
                totalAmount += item.Amount;
            }
            cartItem.Cart.TotalAmount = totalAmount - cartItem.Amount;
            try
            {
                await _dbContext.SaveChangesAsync();
                _dbContext.CartItems.Remove(cartItem);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InvalidOperationException("Error al actualizar en la base de datos", ex);
            }

        }
    }
}
