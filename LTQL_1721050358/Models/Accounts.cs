using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050358.Models
{
    public class Accounts
    {
        [Key]
        public string UserName { get; set; }
        public string password { get; set; }
    }
}