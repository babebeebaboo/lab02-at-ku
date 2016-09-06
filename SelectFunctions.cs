/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: SelectFunctions.cs                
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
	class FuckingProblem
	{
		static void Main()
		{	
			int ans=0;
			Console.Write("Input A: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Input B: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Number of Function : ");
			int no = int.Parse(Console.ReadLine());
			if(no==1)
			{
			Console.WriteLine("max = {0}, min = {1}, avr = {2}, function = {3}",Math.Max(a,b),Math.Min(a,b),(a+b)/2.0,a+b);	
			}
			else if(no==2)
			{
				
			Console.WriteLine("max = {0}, min = {1}, avr = {2}, function = {3}",Math.Max(a,b),Math.Min(a,b),(a+b)/2.0,Math.Abs(a-b));	
			}
			else if(no==3)
			{
			Console.WriteLine("max = {0}, min = {1}, avr = {2}, function = {3}",Math.Max(a,b),Math.Min(a,b),(a+b)/2.0,a*b);	
				
			}
			else if(no==4)
			{
			Console.WriteLine("max = {0}, min = {1}, avr = {2}, function = {3}",Math.Max(a,b),Math.Min(a,b),(a+b)/2.0,Math.Max(a,b)/Math.Min(a,b));	
				
			}
			else if(no==5)
			{
				for(int i=Math.Min(a,b);i<=Math.Max(a,b);i++){ans+=i;}
				Console.WriteLine("max = {0}, min = {1}, avr = {2}, function = {3}",Math.Max(a,b),Math.Min(a,b),(a+b)/2.0,ans);	
				
			}
		}
	}
}
