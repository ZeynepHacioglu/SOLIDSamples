using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir base class'dan bir derived class türüyorsa, derived class'ın davranışı base'i değiştirmemelidir.
             * 
             * Örnek: X sınıfı Y sınıfından miras alıyorsa birbirlerinin yerine İSTİSNASIZ kullanılabilir olmalıdır.
             */
            var dikdortgen = GetRectangle(8);            
            Console.WriteLine(dikdortgen.getArea());

        }

        static ICalculateArea GetRectangle(int width)
        {
            //dikkat! işlemlerden sonra:
            return new Square { Width = width };
        }


    }

    public interface ICalculateArea
    {
        double getArea();
    }
    public class Rectangle : ICalculateArea
    {
        protected double width;
        protected double height;

        public  double Width { set; get; }
        public  double Height { set; get; }

        public double getArea()
        {
            return width * height;
        }

    }

    public class Square: ICalculateArea
    {
        public double Width { get; set; }

        public double getArea()
        {
            throw new NotImplementedException();
        }
    }

    
}
