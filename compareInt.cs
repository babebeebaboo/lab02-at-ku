/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: compareInt.cs                     
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace tazan 
{
	class program
	{
		static void Main()
		{
			Console.Write("A: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("B: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Compare: ");
			char c = Convert.ToChar(Console.Read());
			bool ans=false;
			if(c == '>')
			{
				if(a>b)ans = true;
				else ans = false;
			}
			if(c=='<')
			{
				if(a<b) ans=true;
				else ans=false;
			}
			if(c=='=')	
			{
				if(a==b)ans=true;
				else ans=false;
			}
			Console.Write("\nResult: ");
			if(ans)Console.WriteLine("True");
			else Console.WriteLine("False");
		}
	}
}
