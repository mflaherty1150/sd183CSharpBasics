bool isRaining = true;
bool isGoingOutside = true;

// if (true/false) 
// {
    // 
//}
if (isRaining)
{
    Console.WriteLine("It's raining out!");
}

if (isGoingOutside && isRaining)
{
    Console.WriteLine("Better bring an umbrella!");
}

if (!isRaining) 
{
    System.Console.WriteLine("I will go cut the grass.");
}
else
{
    System.Console.WriteLine("I guess I can't cut the grass.");
}

if (!isRaining)
{
    System.Console.WriteLine("I should cut the grass.");
}
else if (isGoingOutside)
{
    System.Console.WriteLine("You might want to think twice about that.");
}
else 
{
    System.Console.WriteLine("Some default verbiage.");
}

/*
If Else If Statements with User Interaction
We're going to walk through one more example but we'd like for you to try it out first.

We want to ask the user how they are doing and then capture their response through the console. Specifically, we will ask how they are doing on a scale of 1-5, with 5 being the best.

It was shown how we can get values from the terminal before, but if you need to review it go ahead and check out when we discussed the Console methods.

We then want to run nested if else statements based on their input with something similar to the following responses:

1. Dang. We hope your day gets better!
2. Oh. Sorry to hear that.
3. Hope things improve!
4. Good stuff!
5. That's great to hear!
If the response doesn't match our conditions, we also want to let the user know that.

Your task is to take the above information and try and write something that works for it.
*/


