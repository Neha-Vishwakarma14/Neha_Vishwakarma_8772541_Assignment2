using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neha_Vishwakarma_8772541_Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length for the Rectangle:");
            string lengthStr = Console.ReadLine();
            int length = validateSide(lengthStr);


            Console.WriteLine("Enter width for the Rectangle:");
            string widthStr = Console.ReadLine();
            int width = validateSide(widthStr);


            Rectangle rectangleObj = new Rectangle();
            rectangleObj.SetLength(length);
            rectangleObj.SetWidth(width);
            int selectedOption;

            do
            {
                selectedOption = showMenu();

                if (selectedOption == 1)
                {
                    Console.WriteLine("Rectangle Length:");
                    Console.WriteLine(rectangleObj.GetLength());
                }
                else if (selectedOption == 2)
                {
                    Console.WriteLine("Enter length for the Rectangle:");
                    string newLengthStr = Console.ReadLine();
                    int newLength = validateSide(newLengthStr);
                    rectangleObj.SetLength(newLength);
                }
                else if (selectedOption == 3)
                {
                    Console.WriteLine("Rectangle Width:");
                    Console.WriteLine(rectangleObj.GetWidth());
                }
                else if (selectedOption == 4)
                {

                    Console.WriteLine("Enter width for the Rectangle:");
                    widthStr = Console.ReadLine();
                    width = validateSide(widthStr);
                    rectangleObj.SetWidth(width);
                }
                else if (selectedOption == 5)
                {
                    int perimeter = rectangleObj.GetPerimeter();
                    Console.WriteLine("The perimeter of Rectangle:" + perimeter.ToString());
                }
                else if (selectedOption == 6)
                {
                    int area = rectangleObj.GetArea();
                    Console.WriteLine("The area of Rectangle:" + area.ToString());
                }
                else if (selectedOption == 7)
                {
                    Environment.Exit(0);
                }

            } while (selectedOption != 7);


            Console.ReadLine();
        }
        public static int showMenu()
        {

            Console.WriteLine("Rectangle Menu:");
            Console.WriteLine("1. Get the Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get the Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");

            string selectedOption = Console.ReadLine();
            int[] optionsArray = { 1, 2, 3, 4, 5, 6, 7 };
            string select = validateInput(selectedOption, optionsArray);

            return int.Parse(select);

        }
        public static string validateInput(string selectedOption, int[] optionsArray)
        {
            int testInt;
            while (!int.TryParse(selectedOption, out testInt) || !optionsArray.Contains(int.Parse(selectedOption)))
            {
                Console.Clear();
                Console.WriteLine("Invalid Input, Please choose from the given list");
                showMenu();
                selectedOption = Console.ReadLine();
            }
            return selectedOption;
        }
        public static int validateSide(string input)
        {
            int side;

            while (!int.TryParse(input, out side) || (int.Parse(input) < 1))
            {
                Console.WriteLine("Please Enter a valid integer value!");
                input = Console.ReadLine();

            }
            return int.Parse(input);
        }
    }
}
