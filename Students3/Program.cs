namespace Students3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int studentsCount = int.Parse(Console.ReadLine());

			List<string> students = new List<string>();

			Student student = new Student();

			for (int i = 0; i < studentsCount; i++)
			{
				students = Console.ReadLine().Split(" ").ToList();
				student.FirstName = students[0];
				student.LastName = students[1];
				student.Grade = Convert.ToDecimal(students[2]);
			}
		}

		public class Student
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public decimal Grade { get; set; }

			public override string ToString()
			{
				return $"{FirstName} {LastName}: {Grade}";
			}
		}
	}
}