using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			Student studentSortedByName = new Student(new NameSorted());
			Student studentSortedByNumber = new Student(new NumberSorter());

		


			
			Console.WriteLine("Name Sort ... ");
			studentSortedByName.sortedDisplay(studentSortedByName.GetAllStudents());

			
			Console.WriteLine("Number Sort ... ");
			studentSortedByNumber.sortedDisplay(studentSortedByName.GetAllStudents());

			Console.ReadKey();




		}
	}
}
