using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2.Repository
{
	public class StudentRepository
	{
		private ISorter shot;
		
		public StudentRepository()
		{
	
		}

		public StudentRepository(ISorter shot)
		{
			this.shot = shot;
		}

		public void Display(List<Student> studentList)
		{

			foreach (var student in shot.sort(studentList))
			{

				Console.WriteLine("matriculationname :" + student.matriculationname);
				Console.WriteLine("matriculationNumber:" + student.matriculationNumber);

				Console.WriteLine("\n");
			}
		}

		public List<Student> GetAllStudents()
		{
			List<Student> uni_student = new List<Student>()
			{
				new Student() {
					matriculationname = "Mosaddik" , matriculationNumber = "1",
				},
				new Student() {
					matriculationname = "COVIT-19" , matriculationNumber = "2",
				},
				new Student() {
					matriculationname = "Jack" , matriculationNumber = "3",
				}
			};
			return uni_student;
		}

	}
}
