System.Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5":
        System.Console.WriteLine("That's great to hear!");
        break;
    case "4":
        System.Console.WriteLine("Good stuff");
        break;
    case "3":
        System.Console.WriteLine("Hope things improve.");
        break;
    case "2":
        System.Console.WriteLine("Oh. Sorry to hear that.");
        break;
    case "1":
        System.Console.WriteLine("Dang. We hope your day gets better!");
        break;
    default:
        System.Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}


string userName = Console.ReadLine();
string greeting = userName switch
{
    "Pete" => "Hello Pete!",
    "Solomon" => "'Sup, Solomon",
    _ => "Who are you?"
};

System.Console.WriteLine(greeting);