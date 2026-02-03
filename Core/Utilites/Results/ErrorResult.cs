using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message):base(false,message) //Result sınıfının 1.constructor'ını çağırıyoruz
        {
        }
        public ErrorResult(bool success):base(false) //Result sınıfının 2.constructor'ını çağırıyoruz
        {
            
        }


    }
}
