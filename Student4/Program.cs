namespace Student4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int studentsCount = int.Parse(Console.ReadLine());

			List<string> students = new List<string>();

			for (int i = 0; i < studentsCount; i++)
			{
				students = Console.ReadLine().Split(" ").ToList();

			}
		}

		public class Student
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public decimal Grade { get; set; }
		}
	}
}
