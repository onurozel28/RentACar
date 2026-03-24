using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }                     //token json web token değerimizin ta kendisi.
        public DateTime Expiration { get; set; }
    }
}
