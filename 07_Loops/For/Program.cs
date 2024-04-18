// int number = 100;

// for (int i = 0; i <= number; i += 3)
// {
//     System.Console.WriteLine(i);
// }

int limit = 50;
int loopCount = 0;

for (;loopCount < limit; loopCount++)
{
    System.Console.WriteLine(loopCount);
}

for (;loopCount < limit * 2;)
{
    System.Console.WriteLine(loopCount);
    loopCount += 10;
}

for (;;)
{
    System.Console.WriteLine(loopCount);
    loopCount += 20;
    if (loopCount > 200)
    {
        break;
    }
}

System.Console.WriteLine("Final loopCount value is: " + loopCount);