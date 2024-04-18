using System.Collections;

// Arrays
string[] myStrings = { "Marty", "Solomon", "Tanner", "Ben", "Mitch", "Austin", "Sam", "Kyle", "Grant"};

string[] yourString = new string[9];

yourString[0] = myStrings[8];

// Queues
Queue myQueue = new Queue(); // Explicitly stating the type on both sides of the =
var yourQueue = new Queue(); // Sets the type on the left based on the type stated on the right o the = 
Queue hisQueue = new(); // Assumes/implies the type as stated on the left side of the =
// var notAQueue = new(); // Not a valid declaration
myQueue.Enqueue("My next task");
var look = myQueue.Peek();
var myNextTask = myQueue.Dequeue();

// Lists
List<int> intList = new();
intList.Add(42);
intList.Add(86);
intList.Add(3);
intList.Remove(42);
intList.Count();

// Dictionary
Dictionary<int, string> myDictionary = new Dictionary<int, string>();
myDictionary.Add(42, "Marty");
myDictionary.Add(86, "Timmy");
myDictionary.Add(13, "Satan");
foreach (KeyValuePair<int, string> kvp in myDictionary)
{
    System.Console.WriteLine(kvp.Key + " " + kvp.Value);
}