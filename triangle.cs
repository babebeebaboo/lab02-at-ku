/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: triangle.cs                       
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace triangle 
{
	class program
	{
		static void Main()
		{
			Console.Write("Enter c (cm) : ");
			double c = int.Parse(Console.ReadLine());
			Console.Write("Angle (degree) : ");
			double a = int.Parse(Console.ReadLine());
			a = Math.PI * a /180;
			Console.WriteLine("Triangle: {0:F2}, {1:F2}, {2:F2}",Math.Sin(a)*c,Math.Cos(a)*c,c);
		}
	}
}
