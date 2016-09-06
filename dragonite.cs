/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: dragonite.cs                      
//DATE: 19 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
    class tt
    {
        static void Main()  
        {
//while(1==1){
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            /*if(a<b)
            {  
                Console.WriteLine(b/c);
            }
            else
            {
                Console.WriteLine( b/c +1);
            }*/
				int s = n%k;
				int t= (m-(s))/k;
				if(m>n)t-=(m-n)/k;
				//else if(m<n)
				t++;
				if (s>m)t=0;
				Console.WriteLine(t);
//				}
        }
    }
}
