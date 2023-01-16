using System;

class Program
{	
	static void Main()
	{

		Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

		Console.WriteLine("What is your name?");
		string fName = Console.ReadLine();

		Console.WriteLine("What course are you on?");
		string courseName = Console.ReadLine();

		Console.WriteLine("What page number?");
		int pageNum = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
		string answer = Console.ReadLine();
		bool needHelp;
		if (answer == "true")
        {
			needHelp = true;
        }
		else
        {
			needHelp = false;
        }

		Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
		string posExp = Console.ReadLine();

		Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
		string feedback = Console.ReadLine();

		Console.WriteLine("How many hours did you study today?");
		int hrsStudied = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!");
		Console.ReadLine();
	}
}
