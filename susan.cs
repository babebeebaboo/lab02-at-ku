/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: susan.cs                          
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
	class FuckingProblem
	{
		static int  Main()
		{	
			double a;
			while(1==1)
			{
				Console.Write("Input Distance [0-500 meter] : ");
				a = double.Parse(Console.ReadLine());
				if(a==0){Console.WriteLine("Ba-ba-ba-ba-ba-nana-banana-ah-ah\nFound Banana [0.00 meter]");
				return 0;}
				else if(a<=125)
				{	
					Console.Write("Distance D [{0}]",a);
				}
				else if(a<250)
				{
					Console.Write("Distance C [{0}]",a);
				}
				else if(a<375)
				{
					Console.Write("Distance B [{0}]",a);
				}
				else if(a<500)
				{
					Console.Write("Distance A [{0}]",a);
				}
				else
				{
					Console.Write("Not found Banana [{0}]",a);
				}				
			}
		}
	}
}
