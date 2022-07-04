using BuySellAPI.data.Services;
using BuySellAPI.data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySellAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        public AppService _usersService;
        public AppController(AppService usersService)
        {
            _usersService = usersService;
        }



        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var allUsers = _usersService.GetAllUsers();
            return Ok(allUsers);
        }

        [HttpGet("get-user-by-UserMobile/{UserMobile}")]
        public IActionResult GetUsersByMobile(long UserMobile)
        {
            var user = _usersService.GetUsersByMobile(UserMobile);
            return Ok(user);
        }

        [HttpPost("add-users")]
        public IActionResult AddUSERS([FromBody] USERSVM users)
        {
            _usersService.AddUSERS(users);
            return Ok();
        }

        [HttpPut("update-user-by-mobile/{UserMobile}")]
        public IActionResult UpdateUserByUserMobile(long UserMobile, [FromBody] USERSVM users)
        {
            var updateduser = _usersService.UpdateUserByUserMobile(UserMobile, users);
            return Ok(updateduser);
        }

        [HttpDelete("delete-user-by-usermobile/{UserMobile}")]
        public IActionResult DeleteUserByUserMobile(long UserMobile)
        {
            _usersService.DeleteUserByUserMobile(UserMobile);
            return Ok();
        }

        [HttpGet("get-all-products")]
        public IActionResult GetAllProducts()
        {
            var allProducts = _usersService.GetAllProducts();
            return Ok(allProducts);
        }

        [HttpGet("get-product-by-UserMobile/{UserMobile}")]
        public IActionResult GetProductsByMobile(long UserMobile)
        {
            var product = _usersService.GetProductsByMobile(UserMobile);
            return Ok(product);
        }

        [HttpPost("add-products")]
        public IActionResult AddPRODUCTS([FromBody] PRODUCTSVM products)
        {
            _usersService.AddPRODUCTS(products);
            return Ok();
        }


        [HttpDelete("delete-product-by-productId/{ProductId}")]
        public IActionResult DeleteProductByProductId(Guid ProductId)
        {
            _usersService.DeleteProductByProductId(ProductId);
            return Ok();
        }

        [HttpGet("get-product-by-ProductName/{ProductName}")]
        public IActionResult GetProductsByName(string ProductName)
        {
            var product = _usersService.GetProductsByName(ProductName);
            return Ok(product);
        }

        [HttpGet("get-product-by-ProductId/{ProductId}")]
        public IActionResult GetProductsByProductId(Guid ProductId)
        {
            var product = _usersService.GetProductsByProductId(ProductId);
            return Ok(product);
        }

        [HttpPost("User-Authentication/{UserMail},{UserPassword}")]
        public IActionResult UserAvailable(string UserMail, string UserPassword)
        {

            var userAvailable = _usersService.UserAvailable(UserMail, UserPassword);
            if (userAvailable != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();

            }

        }
        [HttpPut("update-product-by-productId/{ProductId}")]
        public IActionResult UpdateProductbyProductId(Guid ProductId, [FromBody] PRODUCTSVM products)
        {
            var updatedproduct = _usersService.UpdateProductbyProductId(ProductId, products);
            return Ok(updatedproduct);
        }
    }
}
