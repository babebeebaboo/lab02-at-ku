/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: susieTheEater.cs                  
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace tazan 
{
	class program
	{
		static void Main()
		{
			int eat =1;
			Console.Write("Is susie hungry?(y,n): ");
			char a = Convert.ToChar(Console.Read());
			if (a=='y')
			{
				eat++;
			}
			Console.Write("Is susie happy?(y,n): ");
			char b = Convert.ToChar(Console.Read());
			if (b=='y')
			{
				eat++;
			}
			if(b=='n' && a=='y') eat++;
			Console.Write("Is susie sick?(y,n): ");
			char c = Convert.ToChar(Console.Read());
			if (c=='y')
			{
				eat--;
			}
			Console.WriteLine("Susie eats {0} plate",eat);
		}

	}
}
