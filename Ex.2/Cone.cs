using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class Cone
    {
        private double _radius;

        private double _height;

        private const double PI = MathF.PI;

        private double _lateralArea; //Боковая площадь

        public Cone(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }

        public void CalculateLateralArea()
        {
            double formative; //Образующая конуса

            formative = Math.Sqrt((double)Math.Pow(_radius, 2) + (double)Math.Pow(_height, 2));

            _lateralArea = PI * _radius * formative;
                
            Console.WriteLine("{0:f2}", _lateralArea);
        }

        public void CalculateFullArea()
        {
            double baseArea, fullArea;

            baseArea = PI * Math.Pow(_radius, 2);

            fullArea = baseArea + _lateralArea;

            Console.WriteLine("{0:f2}", fullArea);
        }

        
    }
}
