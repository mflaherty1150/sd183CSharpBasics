System.Console.WriteLine("Enter your age: ");
string response = Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote! Yay!" : "You're too young to vote. Sorry.";

System.Console.WriteLine(output);