using System;

namespace ShapeCounter
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape shape = new Triangle(8,9);

            Console.WriteLine("First enter a width: ");
            string input = Console.ReadLine();
            double width = Convert.ToDouble(input);


            Console.WriteLine("First enter a height: ");
            input = Console.ReadLine();
            double height = Convert.ToDouble(input);

            Console.WriteLine("You have entered: " + width + " and " + height );

            Console.WriteLine("Do you want o calculate the area and circumference of a Triangle or a Rektangle: ");
            string choose = Console.ReadLine();

            if(choose == "T" || choose == "Triangle" || choose == "t" || choose == "triangle")
            {
                shape = new Triangle(width, height);
            }
            else if(choose == "R" || choose == "Rektangle" || choose == "r" || choose == "rektangle")
            {
                shape = new Rektangle(width, height);
            }
            else
            {
                Console.WriteLine("wrong imput");
            }

            Console.WriteLine(shape.Area());
            Console.WriteLine(shape.Circumference());
        }
    }
}
