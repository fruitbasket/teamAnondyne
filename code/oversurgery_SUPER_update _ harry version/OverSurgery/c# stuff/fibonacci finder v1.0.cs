/*
 * Created by SharpDevelop.
 * User: tf232
 * Date: 10/11/2013
 * Time: 16:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace fibo
{
	class Program
	{
		public static void Main(string[] args)
		{
			double i = 0;
			double j = 1;
			bool a = true;
			while(a)
			{
				double k = i;
				i = j;
				j = k + i;
				Console.WriteLine(i);
			}
			
			Console.ReadKey();
		}
	}
}