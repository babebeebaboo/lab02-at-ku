/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: pokeball.cs                       
//DATE: 18 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace pokeball
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PokeBall Real Size");
			double rcm = 2.54*2.5/2;
			Console.WriteLine("radius = {0}",2.5*2.54);
			//int r = int.Parse(Console.ReadLine());
			double surface = 4*Math.PI*rcm*rcm;
			Console.WriteLine("surface area = {0} cm.^2",surface);	
			double volume=4.0/3.0*Math.PI*rcm*rcm*rcm;
			Console.WriteLine("volume = {0} cm.^3", volume) ;
			Console.Write("Enter Pokeballs' thickness (in cm.): ");
			double thick = double.Parse(Console.ReadLine());
			while(thick>rcm)
			{
				Console.WriteLine("Error, Please try again....");
				Console.Write("Enter Pokeballs' thickness (in cm.): ");
				thick = double.Parse(Console.ReadLine());
			}
			volume=0;
			int numball= (int)(rcm/thick);
			for (int i=0;i<numball;i++)
			{
				rcm-=thick;
				surface += 4*Math.PI*rcm*rcm;
				volume+=4.0/3.0*Math.PI*rcm*rcm*rcm;
			}
			Console.WriteLine("number of Pokeball = {0}",numball);
			Console.WriteLine("sum of Pokeballs' surface area = {0} cm.^2",surface);
			Console.WriteLine("sum of Pokeballs' volume = {0} cm.^3 ",volume);
		}	
	}
}
