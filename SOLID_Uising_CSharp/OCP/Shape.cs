using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.OCP
{
    //a class should be open for extension but closed for modification.
    //This means that you should be able to add new functionality to a class without altering its existing code.
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    //we can create specific classes for each shape, inheriting from an abstract base class Shape
    public class Circle : Shape
    {
        public double Redius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Redius, 2);
        }
    }

    public class Square : Shape
    {
        public double SideLen { get; set; }
        public override double CalculateArea()
        {
            return Math.Pow(SideLen, 2);
        }
    }
}
