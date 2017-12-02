using Polygons.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEndAspNet.Class1.Task.Exercise5
{
    public static class DisplayClass
    {
        public static void GeometricFiguresDisplay()
        {
            var square = new Square(5);
            DisplayPolygon("Cuadrado", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triángulo", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octágono", octagon);

            Console.Read();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Número de lados: {1}", polygonType, polygon.NumberOfSides);
                Console.WriteLine("{0} Largo de lado: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perímetro: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción lanzada al intentar procesar {0}:\n   {1}",
                    polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}
