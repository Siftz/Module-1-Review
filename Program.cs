using System;
using System.Collections.Generic;

namespace AreaFinder;

class Program
{
    //method to calc area of a circle
    public static double CalculateCircleArea(double radius)
    {
      //check if input is valid
      if (radius <= 0)
      {
          Console.WriteLine("Radius must be greater than 0");
          return 0;
      }
      
      //formula for area of a circle is  π * r^2
      return Math.PI * Math.Pow(radius, 2);
    }
    // Method for finding area of a triangle
    public static double CalculateTriangleArea(double baseLength, double height)
    {
        // check if input is valid
        if (baseLength <= 0 || height <= 0)
        {
            Console.WriteLine("Error: Base length and height must be greater than 0");
            return 0; // returns 0 if wrong input
        }
        // formula for triangle is .5 * base * height
        return 0.5 * baseLength * height;
    }
    // method for rectangle
    public static double CalculateRectangleArea(double length, double width)
    {
        //check valid input
        if (length <= 0 || width <= 0)
        {
            // return a 0 when wrong input
            Console.WriteLine("Error: Length and Width must be greater than 0");
            return 0;
        }
        // formula for rectangle area is length * width
        return length * width;
    }
    //Method for area of square
    public static double CalculateSquareArea(double side)
    {
        // check valid input
        if (side <= 0)
        {
            Console.WriteLine("Side length must be greater than 0");
            return 0;
        }
        // formula of square area is side squared or power of 2
        return Math.Pow(side, 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Let me help you find the AREA of certain shapes!");
        // allow user input

        Console.WriteLine("\nEnter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine()); // this converts users input to double for floating point numbers
        double circleArea = CalculateCircleArea(radius);
        if (circleArea > 0)
        {
            Console.WriteLine($"The Area of the circle is: {circleArea:F2}"); // F2 floating value point to 2 decimal places
        }
        //user input for triangles
        Console.WriteLine("\nEnter the base length of the triangle:");
        double baseLength = Convert.ToDouble(Console.ReadLine()); // turns the user input into a double 
        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine()); // user input into a double again
        double triangleArea = CalculateTriangleArea(baseLength, height);
        if (triangleArea > 0)
        {
            Console.WriteLine("Area of the triangle is : {triangleArea:F2}");
        }
        //user input for rectangle
        Console.WriteLine("\nEnter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine()); // user input to double
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine()); // user input to double
        double rectangleArea = CalculateRectangleArea(length, width);
        if (rectangleArea > 0)
        {
            Console.WriteLine("The area of the the rectangle is: {rectangleArea:F2}");
        }
        // user input for squares
        Console.WriteLine("\nEnter the side length of the square:");
        double side = Convert.ToDouble(Console.ReadLine()); // user input to double
        double squareArea = CalculateSquareArea(side);
        if (squareArea > 0)
        {
            Console.WriteLine("The area of the square is: {squareArea:F2}");
        }
    }
}