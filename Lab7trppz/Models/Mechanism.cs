using Lab7trppz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7trppz.Models
{
    public class Mechanism : Part, IMovableMechanism
    {
        public string Function { get; set; }
        public int MovingParts { get; set; }

        public Mechanism(string name, string material, double weight, string function, int movingParts)
            : base(name, material, weight)
        {
            Function = function;
            MovingParts = movingParts;
        }

        public override string GetInfo()
        {
            return $"Механізм: {Name}, Функція: {Function}, Рухомих частин: {MovingParts}";
        }

        public void Operate()
        {
            Console.WriteLine($"Механізм {Name} виконує функцію: {Function}.");
        }
    }

}
