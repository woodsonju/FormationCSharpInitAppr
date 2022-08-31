using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public interface IProduct
    {
        //Interface  : Ne peut contenir que des signature des méthodes 
        void AddProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> FindAll();
    }
}
