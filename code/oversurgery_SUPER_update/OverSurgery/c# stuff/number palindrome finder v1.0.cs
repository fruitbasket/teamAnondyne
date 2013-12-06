/*
 * Created by SharpDevelop.
 * User: tf232
 * Date: 10/11/2013
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;

namespace pal
{
	class Program
	{
		public static void Main(string[] args)
		{
			string textfile = "palins.txt";
			StreamWriter textWriter = new StreamWriter(textfile);

			for(int i = 0;i < 100001; i++)
			{
				string j = i.ToString();
				
				if(CountNonSpaceChars(j)%2 == 0)
				{
					char[] charArray = j.ToCharArray();
					Array.Reverse(charArray);
					string l = new string(charArray);
					if(j == l)
					{
						Console.WriteLine(j);
						textWriter.WriteLine(j);
					}
				}
			}
			Console.ReadKey();
		}

		static int CountNonSpaceChars(string value)
		{
		    int result = 0;
		    foreach (char c in value)
		    {
				if (!char.IsWhiteSpace(c))
				{
				    result++;
				}
		    }
		    return result;
		}
	}
}