using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
	public class NumberSorter : ISorter
	{
		public List<Student> sort(List<Student> list)
		{
			return list.OrderBy(x => x.matriculationNumber).ToList();
		}
	}
}
