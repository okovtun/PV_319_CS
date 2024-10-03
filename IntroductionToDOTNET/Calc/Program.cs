using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			//Enter arithmetical expression
			Console.Write("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			expression = expression.Replace(',', '.');   //Метод Replace() заменяет первый указанный символ вторым
														 //(или первую указанную строку второй) и возвращает измененную строку,
														 //при этом исходная строка остается неизменной!!!

			//Console.WriteLine(expression);
			char[] delimiters = new char[] { '+', '-', '*', '/' };
			string[] numbers = expression.Split(delimiters);
			//В классе 'string' есть метод Split(...),
			//который принимает набор разделителей,
			//и возвращает токены ("разрезанную" строку по указанным разделителям)
			//в виде массива строк.
			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);

				#region IFcalc
				//if(expression.Contains('+'))Console.WriteLine($"{a} + {b} = {a+b}");
				//else if(expression.Contains("-"))Console.WriteLine($"{a} - {b} = {a-b}");
				//else if(expression.Contains('*'))Console.WriteLine($"{a} * {b} = {a*b}");
				//else if(expression.Contains('/'))Console.WriteLine($"{a} / {b} = {a/b}"); 
				#endregion

				//Метод IndexOfAny() возвращает индекс найденного символа, в данном случае символа из массива 'delimiters',
				//если символ не найден, метод возвращает -1.

				switch (expression[expression.IndexOfAny(delimiters)])
				{
					case '+': Console.WriteLine($"{numbers[0]} + {numbers[1]} = {a + b}"); break;
					case '-': Console.WriteLine($"{numbers[0]} - {numbers[1]} = {a - b}"); break;
					case '*': Console.WriteLine($"{numbers[0]} * {numbers[1]} = {a * b}"); break;
					case '/': Console.WriteLine($"{numbers[0]} / {numbers[1]} = {a / b}"); break;

					default: Console.WriteLine("Error: No operation"); break;   //Не работает
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			//Метод Contains() определяет, содержит ли строка указанный символ, или указанную подстроку.
			Main(args);
		}
	}
}
