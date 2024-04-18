string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

// We're concatenating a new string with only a space here
// Noteice we can combine it with the variables from above
string concatenatedResult = first + " " + second;

Console.WriteLine(concatenatedResult);

// Composite Formatting
string firstName = "Solomon";
string lastName = "Haynes";

// Here we're using the string.Format method that supports composite formatting
string compositeResult = string.Format("His name is {0} {1}", firstName, lastName);

Console.WriteLine(compositeResult);
Console.WriteLine("His name is {0} {1}", firstName, lastName);

// String Interpoloation
string interpolatedResult = $"His name is {firstName} {lastName}!";
Console.WriteLine(interpolatedResult);
Console.WriteLine($"His name is {firstName} {lastName}!");