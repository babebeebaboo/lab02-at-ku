/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: a_z_cycle.cs                      
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace cascii 
{
	class program
	{
		static void Main()
		{
			Console.Write("Input your number : ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Input character   : ");
			int b = Console.Read();
			//b+=a;
			/*b-=96;
			b+=a;
			b%=26;
			b+=96;*/
			b= (b-96+a)%26+96;
			Console.WriteLine("Output character  : {0}",Convert.ToChar(b));
		}
	}
}
