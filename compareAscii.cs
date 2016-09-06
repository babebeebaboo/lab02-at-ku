/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: compareAscii.cs                   
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace cascii 
{
	class program
	{
		static void Main()
		{
			Console.Write("Set1 - 1: ");
			int a1 = (Console.Read());			
			
			Console.Write("Set1 - 2: ");
			int a2 =(Console.Read());
			Console.Write("Set1 - 3: ");
			int a3 = (Console.Read());
			Console.Write("Set2 - 1: ");
			int a4 = (Console.Read());
			Console.Write("Set2 - 2: ");
			int a5 = (Console.Read());
			Console.Write("Set2 - 3: ");
			int a6 = (Console.Read());
			int aa=a1+a2+a3;
			int ab=a4+a5+a6;
			if(aa>ab)Console.WriteLine("\nSet 1");
			else if(aa<ab)Console.WriteLine("\nSet 2");
			else Console.WriteLine("\nEqual");
		}
	}
}
