/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: factor.cs                         
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
	class FuckingProblem
	{
		static void Main()
		{
			Console.Write("Input A: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Input B: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Input C: ");
			int c = int.Parse(Console.ReadLine());
			Console.Write("Input D: ");
			int d = int.Parse(Console.ReadLine());
			Console.Write("Input K: ");
			int k = int.Parse(Console.ReadLine());
			int xx = (a*b+a*c+a*d+b*c+b*d+c*d)*k*k-(a*b*c+a*b*d+a*c*d+b*c*d)*k-(a+b+c+d)*k*k*k+a*b*c*d;
			Console.WriteLine("x:-({0}+{1}+{2}+{3}){4}^3+({5}+{6}+{7}+{8}+{9}+{10}){4}^2-({11}+{12}+{13}+{14}){4}+{15} = {16}",a,b,c,d,k,a*b,a*c,a*d,b*c,b*d,c*d,a*b*c,a*b*d,a*c*d,b*c*d,a*b*c*d,xx);
			int yy = (k-a)*(k-b)*(k-c)*(k-d)-k*k*k*k;
			Console.WriteLine("y: ({0}-{1})({0}-{2})({0}-{3})({0}-{4})-{0}^4 = {5}",k,a,b,c,d,yy);
			//Console.WriteLine(xx==yy);
			if(xx==yy)
			Console.WriteLine("true");
			else 
			Console.WriteLine("false");
		}
	}
}
