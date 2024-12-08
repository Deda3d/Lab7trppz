using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7trppz.Models
{
    public class Product : Assembly
    {
        public string ProductType { get; set; }
        public string Manufacturer { get; set; }

        public Product(string name, string material, double weight, string function, int movingParts, int componentsCount, string assemblyType, string productType, string manufacturer)
            : base(name, material, weight, function, movingParts, componentsCount, assemblyType)
        {
            ProductType = productType;
            Manufacturer = manufacturer;
        }

        public override string GetInfo()
        {
            return $"Виріб: {Name}, Тип виробу: {ProductType}, Виробник: {Manufacturer}";
        }
    }

}
