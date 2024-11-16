using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartsController(AppDbContext context)
        {
            _context = context;
        }


        // GET: api/Carts/5
        //[Authorize]
        [HttpGet("{idUser}")]
        public async Task<ActionResult<Cart>> GetCartByIdUser(Guid idUser)
        {

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)

                .FirstOrDefaultAsync(c=> c.UserId == idUser)
                ;

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

    }
}
