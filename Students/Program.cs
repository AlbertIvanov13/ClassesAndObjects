using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Channels;

int number = int.Parse(Console.ReadLine());

List<string> elements = new List<string>();

string firstName = string.Empty;
string lastName = string.Empty;
decimal grade = 0;

List<string> newList = new List<string>();

for (int i = 0; i < number; i++)
{
	elements = Console.ReadLine().Split(" ").ToList();
	firstName = elements[0];
	lastName = elements[1];
	grade = Convert.ToDecimal(elements[2]);

	newList.Add(firstName);
	newList.Add(lastName);
	newList.Add(grade.ToString());

}

//for (int i = 0; i < newList.Count; i+=2)
//{
//	Console.WriteLine($"{newList[0]}" + $"{newList[1]}" + $"{newList[2]}");
//}



//elements.Sort((a, b) => b.CompareTo(a));
//foreach (var gradee in elements)
//{
//	Console.WriteLine($"{elements[0]} {elements[1]}: {elements[2]}");
//}