using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			//Variables declarations...  and maybe some initializations... why not?
			string mainHeader = "This program calculates the Perimeter, the Area, and/or the Volume of geometrical figures.\n";
			string mainMenu = "1) Perimeter \n2) Area \n3) Volume";
			string secondMenu1 = "1) Square \n2) Rectangle \n3) Triangle \n4) Circle";
			string secondMenu2 = "1) Cube \n2) Rectangular Prism \n3) Triangular Pyramid \n4) Sphere";  //for calculating Volume only.
			const double pi = 3.14159265359;
			string mainMenuUserInput;
			string secondMenuUserInput;			

			bool programStart = true;

			while (programStart == true)
			{
				Console.Clear();

				Display(mainHeader);
				Display("Menu:\n");
				Display(mainMenu);

				Console.WriteLine("\nWhat would you like to calculate?");
				mainMenuUserInput = Console.ReadLine();

				switch (mainMenuUserInput)
				{

					case "1": //PERIMETER
						Console.Clear();
						Display("What geometrical figure would you like to use for calculating Perimeter?\n");
						Display(secondMenu1);
						secondMenuUserInput = Console.ReadLine();
						if (secondMenuUserInput == "1") //of square.
						{
							Console.Clear();
							double squareSide = 0;
							Display("Enter the LENGTH of one of the sides of the square in meters: ");
							squareSide = Convert.ToDouble(Console.ReadLine());
							double result = PerimeterOfSquare(squareSide);
							ShowResult();
							Display("The perimeter of the square is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "2") //of rectangle.
						{
							Console.Clear();
							double squareLength = 0;
							double squareWidth = 0;
							Display("Enter the LENGTH of the rectangle in meters: ");
							squareLength = Convert.ToDouble(Console.ReadLine());
							Display("\nEnter the WIDTH of the rectangle in meters: ");
							squareWidth = Convert.ToDouble(Console.ReadLine());
							double result = PerimeterOfRectangle(squareLength, squareWidth);
							ShowResult();
							Display("The perimeter of the rectangle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "3") //of triangle.
						{
							Console.Clear();
							double baseSide = 0;
							double side1 = 0;
							double side2 = 0;
							Display("Enter the BASE side of the triangle in meters: ");
							baseSide = Convert.ToDouble(Console.ReadLine());
							Display("Enter the SIDE 1 of the triangle in meters: ");
							side1 = Convert.ToDouble(Console.ReadLine());
							Display("Enter the SIDE 2 of the triangle in meters: ");
							side2 = Convert.ToDouble(Console.ReadLine());
							double result = PerimeterOfTriangle(baseSide, side1, side2);
							ShowResult();
							Display("The perimeter of the triangle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "4") //of circle.
						{
							Console.Clear();
							double radius = 0;
							Display("Enter the RADIUS of the triangle in meters: ");
							radius = Convert.ToDouble(Console.ReadLine());
							double result = Math.Round(PerimeterOfCircle(pi, radius), 2);
							ShowResult();
							Display("The perimeter of the circle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else
						{
							Console.Clear();
							ShowWarning();
							Display("You selection does NOT match any of our options");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						break;

					case "2": //AREA
						Console.Clear();
						Display("What geometrical figure would you like to use for calculating Area?\n");
						Display(secondMenu1);
						secondMenuUserInput = Console.ReadLine();
						if (secondMenuUserInput == "1")// of square.
						{
							Console.Clear();
							double squareSide = 0;
							Display("Please, enter the LENGTH of one of the sides of the square in meters: ");
							squareSide = Convert.ToDouble(Console.ReadLine());
							double result = AreaOfSquare(squareSide);
							ShowResult();
							Display("The area of the square is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "2")//of rectangle.
						{
							Console.Clear();
							double squareLength = 0;
							double squareWidth = 0;
							Display("Enter the LENGTH of the rectangle in meters: ");
							squareLength = Convert.ToDouble(Console.ReadLine());
							Display("\nEnter the WIDTH of the rectangle in meters: ");
							squareWidth = Convert.ToDouble(Console.ReadLine());
							double result = AreaOfRectangle(squareLength, squareWidth);
							ShowResult();
							Display("The area of the rectangle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "3")//of triangle
						{
							Console.Clear();
							double baseSide = 0;
							double height = 0;
							Display("Enter the lenght of the BASE side of the triangle in meters: ");
							baseSide = Convert.ToDouble(Console.ReadLine());
							Display("\nEnter the HEIGHT of the triangle in meters: ");
							height = Convert.ToDouble(Console.ReadLine());
							double result = AreaOfTriangle(height, baseSide);
							ShowResult();
							Display("The area of the triangle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "4")//of circle
						{
							Console.Clear();
							double radius = 0;
							Display("Enter the RADIUS of the triangle in meters: ");
							radius = Convert.ToDouble(Console.ReadLine());
							double result = Math.Round(AreaOfCircle(pi, radius), 2);
							ShowResult();
							Display("The area of the circle is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else
						{
							Console.Clear();
							ShowWarning();
							Display("You selection does NOT match any of our options");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						break;

					case "3": //VOLUME
						Console.Clear();
						Display("What geometrical figure would you like to use for calculating Volume?\n");
						Display(secondMenu2);
						secondMenuUserInput = Console.ReadLine();
						if (secondMenuUserInput == "1")//of Cube
						{
							Console.Clear();
							double edge = 0;
							Display("Enter the EDGE of the cube in meters: ");
							edge = Convert.ToDouble(Console.ReadLine());
							double result = VolumeOfCube(edge);
							ShowResult();
							Display("The volume of the cube is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "2")//of Rectangular Prism 
						{
							Console.Clear();
							double width = 0;
							double height = 0;
							double length = 0;
							Display("Enter the HEIGHT of the rectangular prism in meters: ");
							height = Convert.ToDouble(Console.ReadLine());
							Display("Enter the WIDTH of the rectangular prism in meters: ");
							width = Convert.ToDouble(Console.ReadLine());
							Display("Enter the LENGTH of the rectangular prism in meters: ");
							length = Convert.ToDouble(Console.ReadLine());
							double result = VolumeOfRectangularPrism(height, width, length);
							ShowResult();
							Display("The volume of the rectangular prism is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "3")//of Triangular Pyramid
						{
							Console.Clear();
							double baseSide = 0;
							double triangleHeight = 0;
							double pyramidHeight = 0;

							Display("Enter the BASE side of the triangular pyramid in meters: ");
							baseSide = Convert.ToDouble(Console.ReadLine());
							Display("Enter the HEIGHT of the triangle in meters: ");
							triangleHeight = Convert.ToDouble(Console.ReadLine());
							Display("Enter the HEIGHT of the pyramid in meters: ");
							pyramidHeight = Convert.ToDouble(Console.ReadLine());
							double result = VolumeOfTriangularPyramid(baseSide, pyramidHeight, triangleHeight);
							ShowResult();
							Display("The volume of the triangular pyramid is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else if (secondMenuUserInput == "4")//of Sphere
						{
							Console.Clear();
							double radius = 0;
							Display("Enter the RADIUS of the sphere in meters: ");
							radius = Convert.ToDouble(Console.ReadLine());
							double result = Math.Round(VolumeOfSphere(pi, radius), 2);
							ShowResult();
							Display("The volume of the sphere is " + result + " meters");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						else
						{
							Console.Clear();
							ShowWarning();
							Display("You selection does NOT match any of our options");
							Console.ResetColor();
							GiveChoice(ref programStart);
						}
						break;

					default:
						Console.Clear();
						ShowWarning();
						Display("You selection does NOT match any of our options");
						Console.ResetColor();
						GiveChoice(ref programStart); ;
						break;
				}
			}
		}


		//Helper Methods__________________________________________________________________________________________________________________________________
		public static void Display(string a)
		{
			Console.WriteLine(a);
		}

		public static void ShowWarning()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Beep();
		}

		public static void ShowResult()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
		}

		public static void GiveChoice(ref bool continueToRun)
		{
			Display("\nDo you want to try again?    'y' or 'n'");
			string choice = Convert.ToString(Console.ReadLine().ToLower());
			if (!(choice == "y" || choice == "yes"))
			{
				continueToRun = false;
			}
		}

		//Perimeter Methods_______________________________________________________________________________________________________________________________
		public static double PerimeterOfSquare(double side)
		{
			Display("The perimeter of the square is: ");
			return side * 4;
		}
		public static double PerimeterOfRectangle(double lenght, double width)
		{
			Display("The perimeter of the rectangle is: ");
			return 2 * (lenght + width);
		}
		public static double PerimeterOfTriangle(double Base, double side1,  double side2)
		{
			Display("The perimeter of the triangle is: ");
			return Base + side1 + side2;
		}
		public static double PerimeterOfCircle(double pi, double radius)
		{
			Display("The perimeter of the circle is: ");
			return 2 * (pi * radius);
		}

		//Area Methods____________________________________________________________________________________________________________________________________
		public static double AreaOfSquare(double side)
		{
			Display("The area of the square is: ");
			return side * side;
		}
		public static double AreaOfRectangle(double lenght, double width)
		{
			Display("The area of the rectangle is: ");
			return lenght * width;
		}
		public static double AreaOfTriangle(double height, double Base)
		{
			Display("The area of the triangle is: ");
			return (Base * height) / 2;
		}
		public static double AreaOfCircle(double pi, double radius)
		{
			Display("The area of the circle is: ");
			return pi * (radius * radius);
		}

		//Volume Methods__________________________________________________________________________________________________________________________________
		public static double VolumeOfCube(double edge)
		{
			Display("The volume of the cube is: ");
			return edge * edge * edge;
		}
		public static double VolumeOfRectangularPrism(double height, double width, double lenght)
		{
			Display("The volume of the rectangular prism is: ");
			return height * width * lenght;
		}
		public static double VolumeOfTriangularPyramid(double Base, double pyramidheight, double triangleheight)
		{
			Display("The volume of the triangular pyramid is: ");
			return 0.33 * (0.5 * Base * triangleheight) * pyramidheight;
		}
		public static double VolumeOfSphere(double pi, double radius)
		{
			Display("The volume of the sphere is: ");
			return 0.75 * pi * radius * radius * radius;
		}
	}
}