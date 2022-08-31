using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //  public string Description { get; set; }

        private string description; 

        public string Description
        {
            get 
            { 
                return description; 
            }
            set
            { 
                description = value; 
            }
        }

        public Product()
        {
        }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return "Name : " + Name + " - "  +"Description : " + Description;
        }
    }
}
