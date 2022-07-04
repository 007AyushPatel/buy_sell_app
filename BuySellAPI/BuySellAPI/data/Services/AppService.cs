using BuySellAPI.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySellAPI.data.Models;

namespace BuySellAPI.data.Services
{
    public class AppService
    {
        private AppDbContext _context;

        public AppService(AppDbContext context)
        {
            _context = context;
        }


        public void AddUSERS(USERSVM users)
        {
            var _users = new Users()
            {
                UserMobile = users.UserMobile,
                UserName = users.UserName,
                UserMail = users.UserMail,
                UserPassword = users.UserPassword
            };
            _context.USERS.Add(_users);
            _context.SaveChanges();

        }

        public List<Users> GetAllUsers() => _context.USERS.ToList();

        public Users GetUsersByMobile(long usersMobile) => _context.USERS.FirstOrDefault(n => n.UserMobile == usersMobile);

        public Users UpdateUserByUserMobile(long userMobile, USERSVM users)
        {
            var _users = _context.USERS.FirstOrDefault(n => n.UserMobile == userMobile);
            if (_users != null)
            {
                _users.UserMobile = users.UserMobile;
                _users.UserName = users.UserName;
                _users.UserMail = users.UserMail;
                _users.UserPassword = users.UserPassword;

                _context.SaveChanges();
            }
            return _users;
        }
        public void DeleteUserByUserMobile(long userMobile)
        {
            var _users = _context.USERS.FirstOrDefault(n => n.UserMobile == userMobile);
            if (_users != null)
            {
                _context.USERS.Remove(_users);
                _context.SaveChanges();
            }
        }

        public void AddPRODUCTS(PRODUCTSVM products)
        {
            var _products = new Products()
            {
                UserMobile = products.UserMobile,
                ProductName = products.ProductName,
                ProductCategory = products.ProductCategory,
                ProductPrice = products.ProductPrice,
                ProductLocation = products.ProductLocation,
                ProductDescription = products.ProductDescription,
                ProductImageUrl = products.ProductImageUrl,
                Privacy = products.Privacy,
            };
            _products.ProductId = Guid.NewGuid();
            _context.PRODUCTS.Add(_products);
            _context.SaveChanges();

        }

        public List<Products> GetAllProducts() => _context.PRODUCTS.ToList();

        public Products GetProductsByMobile(long usersMobile) => _context.PRODUCTS.FirstOrDefault(n => n.UserMobile == usersMobile);

        public Products GetProductsByName(string ProductName) => _context.PRODUCTS.FirstOrDefault(n => n.ProductName == ProductName);

        public Products GetProductsByProductId(Guid ProductId) => _context.PRODUCTS.FirstOrDefault(n => n.ProductId == ProductId);

        public void DeleteProductByProductId(Guid productId)
        {
            var _products = _context.PRODUCTS.FirstOrDefault(n => n.ProductId == productId);
            if (_products != null)
            {
                _context.PRODUCTS.Remove(_products);
                _context.SaveChanges();
            }
        }

        public Users UserAvailable(string userMail, string userPassword) => _context.USERS.FirstOrDefault(n => n.UserMail == userMail && n.UserPassword == userPassword);
        
        public Products UpdateProductbyProductId(Guid productID, PRODUCTSVM products)
        {
            var _products = _context.PRODUCTS.FirstOrDefault(n => n.ProductId == productID);
            if (_products != null)
            {
                _products.UserMobile = products.UserMobile;
                _products.ProductName = products.ProductName;
                _products.ProductCategory = products.ProductCategory;
                _products.ProductPrice = products.ProductPrice;
                _products.ProductLocation = products.ProductLocation;
                _products.ProductDescription = products.ProductDescription;
                _products.ProductImageUrl = products.ProductImageUrl;
                _products.Privacy = products.Privacy;

                _context.SaveChanges();
            }
            return _products;
        }
           

    }

}
