using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
	class Test
	{
		static void Main(string[] args)
		{
			var students = new[] { 
				new Student("Petar", "Ivanov", "00001", "+3592555555","Petar@abv.bg", 1, new[] { 2, 2, 3, 5, 6 }),
				new Student("Vasil", "Petrov", "00002", "+3592565565","Vas@gmail.com", 2, new[] { 4, 2, 5, 5, 6 }),
				new Student("Dimitar", "Mihailov", "00003", "+3592455455","Dimi@gmail.com", 3, new[] { 2, 2, 6, 5, 3 }),
				new Student("Georgi", "Valentinov", "00004", "+3592355355","GVal@abv.bg", 1, new[] { 2, 2, 3, 2, 3 }),
				new Student("Ivan", "Marinov", "00005", "+3592525575","Ivan@abv.bg", 2, new[] { 6, 6, 4, 5, 6 }),
				new Student("Radoslav", "Popov", "00006", "+3592577755","Radi@gmail.com", 3, new[] { 2, 3, 5, 5, 6 }),
				new Student("Todor", "Stefanov", "00007", "+359353455","Tod@gmail.com", 1, new[] { 4, 4, 3, 5, 6 }),
				new Student("Petar", "Mihilov", "00008", "+3595675555","PMihailov@abv.bg", 2, new[] { 6, 6, 5, 5, 6 }),
				new Student("Mladen", "Petrov", "00009", "+3572558885","Mladen@gmail.com", 3, new[] { 2, 2, 4, 2, 4 }),
				new Student("Stefan", "Marinov", "00010", "+3552558555","Stefan@abv.bg", 1, new[] { 5, 4, 4, 5, 5 }),
			};

			Console.WriteLine("Students: ");
			Print(students);

			var studentsFromSEcondGroup =
				from student in students
				where student.GroupNumber == 2
				orderby student.FirstName
				select student;

			Console.WriteLine("\nStudents from group two sorted by first name:");
			Print(studentsFromSEcondGroup);


			var studentsFromSEcondGroupExtensions = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);

			Console.WriteLine("\nStudents from group two sorted by first name with extensions:");
			Print(studentsFromSEcondGroup);

			var studentsInAbv =
				from student in students
				where student.Email.EndsWith("abv.bg")
				select student;

			Console.WriteLine("\nStudents from abv.bg:");
			Print(studentsInAbv);

			var studentsWithTelInSofia =
				from student in students
				where student.Tel.StartsWith("+3592")
				select student;

			Console.WriteLine("\nStudents with phone in Sofia:");
			Print(studentsWithTelInSofia);

			var studentsWithMarkSix =
				from student in students
				where student.Marks.Any(m => m == 6)
				select new { Fullname = student.FirstName + " " + student.LastName, Marks = student.Marks };

			Console.WriteLine("\nStudents with mark six:");
			Print(studentsWithMarkSix);

			var studentswithTwoMarks = students.Where(s => s.Marks.Where(m => m == 2).Count() == 2);

			Console.WriteLine("\nStudents with two two marks:");
			Print(studentswithTwoMarks);

			var longestString =
				(
				from student in students
				select student.ToString()
				).MaxWithoutChange(s => s.Length);

			Console.WriteLine("\nStudent with longest string:");
			Console.WriteLine(longestString);
		}

		private static void Print<T>(IEnumerable<T> collection)
		{
			foreach (var element in collection)
			{
				Console.WriteLine(element);
			}
		}
	}

	public static class Extensions
	{
		public static T MaxWithoutChange<T>(this IEnumerable<T> collection, Func<T, int> func)
		{
			T result = collection.First();

			foreach (var item in collection)
			{
				if (func(result) < func(item))
				{
					result = item;
				}
			}

			return result;
		}
	}
}
