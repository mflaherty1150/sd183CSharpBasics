int number = 0;

while (true)
{
    if (number % 15 == 0)
    {
        number += 5;
        continue;
    }
    System.Console.WriteLine(number);
    number += 5;
    if (number > 200)
    {
        break;
    }
}