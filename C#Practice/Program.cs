Console.WriteLine("Hello World!");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote first lines of code");
Console.WriteLine();
Console.WriteLine("Congratulations!");
Console.Write("you wrote first lines of code");
Console.WriteLine();
Console.WriteLine("This is the first line.");
Console.Write("This ");
Console.Write("is the ");
Console.Write("second ");
Console.Write("line.");
Console.WriteLine();

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

string name = "Bob";
int number = 3;
decimal value = 34.4m;

Console.WriteLine("Hello, " + name + "! You have " + number + " messages in your inbox. The temparature is " + value + " celsius.");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine(@"c:\source\repos");

Console.WriteLine(@"c:\source\repos
					(this is where your code goes)");

Console.WriteLine("Generating the invoices of the customer \"Contoso Group\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutputDirectory:\t");
Console.Write(@"c:\source\repos");
Console.WriteLine();

string person = "Bob";
string message = "Hello " + person;
Console.WriteLine(message);

string secondName = "Bob";
string greeting = "Hello";
string message2 = greeting + " " + secondName + " !";
Console.WriteLine(message2);
Console.WriteLine(greeting + " " + secondName + "!");
string message3 = $"{greeting} {secondName}";
Console.WriteLine(message3);
string message4 = $"Hello {secondName}";
Console.WriteLine(message4);

int version = 11;
string updateText = "Update to Windows";
string message5 = $"{updateText} {version}";
Console.WriteLine(message5);

string project_name = "First-Project";
Console.WriteLine($@"C:\Output\{project_name}\Data");

string projectName = "ACME";
string message6 = $@"C:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{message6}");





