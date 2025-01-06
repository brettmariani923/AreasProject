
using System;

public class Program
{ //Creating methods to find the area for each given shape, I'm doing this
  //so that when the input is recieved it can go directly into the
  //equation
    static double AreaCircle(double a, double b)
    {
        return a * (b * 2);
    }

    static double AreaTriangle(double h, double b)
    {
        return (h * b) / 2;
    }

    static double AreaRectangle(double l, double w)
    {
        return l * w;
    }

    static double AreaSquare(double x)
    {
        return x * x;
    }

    public static void Main(string[] args)
    {
        //Asking which specific shape the user needs so that it can assign them
        //to the correct formula

        Console.WriteLine("Do you need to find the area for a circle, a triangle, a rectangle, or a square?");
        var whatShape = Console.ReadLine();

        if (whatShape == "circle")
        {

            //Asking for the radius input so the user can adjust as needed.
            //The following shape choices follow this same pattern for their 
            //specific inputs.

            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14159;

            double rSquared = radius;

            double answer = AreaCircle(pi, rSquared);

            //Adding the answer to a string so that it is clear to the user
            //that they recieved the answer. The following equations do the
            //same thing

            Console.WriteLine("The area of the circle is: " + answer);
        }

        if (whatShape == "triangle")
        {

            Console.WriteLine("Enter the base length: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double answer = AreaTriangle(height, baseLength);

            Console.WriteLine("The area of the triangle is : " + answer);

        }

        if (whatShape == "rectangle")
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double answer = AreaRectangle(length, width);

            Console.WriteLine("The area of the rectangle is: " + answer);
        }

        if (whatShape == "square")
        {
            Console.WriteLine("Enter the height of the square: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double answer = AreaSquare(height);

            Console.WriteLine("The area of the square is: " + answer);
        }
    }

        
}