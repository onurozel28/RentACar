using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public interface IDataResult<T>: IResult //generic kullanma sebebimiz farklı tiplerde data döndürebilmek için.Bunlar int,string,object vs olabilir.
    {
        T Data { get; } 
    
    }
}
