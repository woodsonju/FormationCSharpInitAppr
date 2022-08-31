using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public class ProductFileImpl : IProduct
    {
        public void AddProduct(Product product)
        {
           //Ajouter un produit dans un fichier
        }

        public void DeleteProduct(Product product)
        {
            //Supprimer un produit
        }

        public List<Product> FindAll()
        {
            //Lister la liste de produit dans un fichier 
            return null;
        }

        public void UpdateProduct(Product product)
        {
           //Mettre à jour un produit dans un fichier
        }
    }
}
