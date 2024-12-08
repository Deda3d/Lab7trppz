using Lab7trppz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7trppz.Models
{
    public class Part : MyObject, IRepairable
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public static string[] materials = { "Дерево", "Пластик", "Залізо", "Алюміній" };

        public Part(string name, string material, double weight)
        {
            Name = name;
            Material = material;
            Weight = weight;
        }

        public override string GetInfo()
        {
            return $"Деталь: {Name}, Матеріал: {Material}, Вага: {Weight} кг";
        }

        public void PerformRepair()
        {
            Console.WriteLine($"Деталь {Name} ремонтується.");
        }
    }

}
