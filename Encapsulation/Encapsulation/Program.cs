﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = 22;
			A.Y = 33;
			A.Print();
		}
	}
}
/*
------------------------------
private 
public  
protected 
internal - доступны везде в пределах сборки
protected internal - доступны для дочерних классов сборки
------------------------------
Properties
 */