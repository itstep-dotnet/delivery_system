using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    class Catalog
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void Display()
        {

        }
    }
}
