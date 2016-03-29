using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation
{
    public class Controller
    {
         
         public string validar() {
            string result = "";
            using (var ctx = new AuxiliarEntities())
            {
                var product = (from s in ctx.Mis_ar_product
                               where s.ACCOUNT_NUM == "7856036"
                               select s).FirstOrDefault<Mis_ar_product>().PRODUCT_ID;
                result = product.ToString();
            }
            return result;
        }
    }
}
