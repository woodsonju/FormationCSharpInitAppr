using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public class ProductBDDImpl : IProduct
    {
        public void AddProduct(Product product)
        {
           //SQL - Requête d'insertion
        }

        public void DeleteProduct(Product product)
        {
            //SQL - Requête de suppression
        }

        public List<Product> FindAll()
        {
            //SQL - Requête de selection 
            return null;
        }

        public void UpdateProduct(Product product)
        {
           //SQL - Requête de mise à jour
        }
    }
}
