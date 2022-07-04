using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuySellAPI.data.Models
{
    public class Users
    {
        [Key]
        public long UserMobile { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }

    }
}
