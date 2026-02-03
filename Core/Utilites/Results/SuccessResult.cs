using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message) //Result sınıfının 1.constructor'ını çağırıyoruz
        {
        }
        public SuccessResult():base(true) //Result sınıfının 2.constructor'ını çağırıyoruz
        {
        }
    
    }
}
