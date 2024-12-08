using Lab7trppz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7trppz.Models
{
    public class Assembly : Mechanism, IAssembly
    {
        public int ComponentsCount { get; set; }
        public string AssemblyType { get; set; }

        public Assembly(string name, string material, double weight, string function, int movingParts, int componentsCount, string assemblyType)
            : base(name, material, weight, function, movingParts)
        {
            ComponentsCount = componentsCount;
            AssemblyType = assemblyType;
        }

        public override string GetInfo()
        {
            return $"Вузол: {Name}, Тип: {AssemblyType}, Кількість компонентів: {ComponentsCount}";
        }

        public void Assemble()
        {
            Console.WriteLine($"Вузол {Name} збирається.");
        }
    }

}
