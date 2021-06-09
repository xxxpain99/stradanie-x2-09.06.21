using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> ert = new MyList<int>();
			ert.Add(45);
			ert.Add(55);
			ert.Add(65);
			ert.AddFront(89);
			ert.Print();
			ert.PushBack(10); //dobavlyaem element v nachale spiska
			ert.PushFront(50);

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("Perviy element spiska");
			Console.WriteLine(ert.Get(1));
			Console.WriteLine();

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("Posledniy element spiska");
			Console.WriteLine(ert.Get(4));
			Console.WriteLine();

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("Spisok v obratnom poryadke");
			Console.WriteLine(50);
		}
	}
}
