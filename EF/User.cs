using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }
        [StringLength(50)]
        public string password { get; set; }
        [StringLength(50)]
        public string firstname { get; set; }
        [StringLength(50)]
        public string lastname { get; set; }
        [StringLength(50)]
        
        public string email { get; set; }
        public bool status { get; set; }
    }
    public static class users
    {
        public static bool Isvalid(string user, string pass)
        {
            DB entity = new DB();
            bool result = entity.Users.Any(item => item.username == user && item.password == pass && item.status == true);
            return result;
        }
    }
}
