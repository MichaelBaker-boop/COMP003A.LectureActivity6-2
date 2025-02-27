// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Display and practice using Polymorphism
namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating Method Overloading
            ShapeCalculator calculator = new ShapeCalculator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5, 10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5, 10, true)}");

            // Demonstrating Method Overriding
            // Creating a base class reference to a derived class object for polymorphism
            Shape myCircle = new Circle(7);
            // Creating a base class reference to a derived class object for polymorphism
            Shape myRectangle = new Rectangle(4, 8);

            // Calling the DisplayArea method for the Circle and Rectangle Objects
            myCircle.DisplayArea();
            myRectangle.DisplayArea();
            
        }
    }
}
