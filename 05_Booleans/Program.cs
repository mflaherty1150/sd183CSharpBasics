bool isCool = false;
bool isNice = false;
bool hasTeeth = true;
bool isOld = true;

isCool = true;

// Negation Operator - !
bool isTrue = !isNice;
bool isFalse = !isTrue;
Console.WriteLine("isTrue: " + isTrue + "\t" + "isFalse: " + isFalse);

// AND Operator - &&
bool trueAndExample = isTrue && isTrue;
bool falseAndExample = isTrue && isFalse;
// bool rediculousExample = ((isTrue && isTrue) && !(isFalse && isFalse) && !isFalse( && !isTrue));
Console.WriteLine($"{trueAndExample}  ===   {falseAndExample}");

// OR Operator - ||
bool trueOrExample = isFalse || isTrue;
bool falseOrExample = isFalse || isFalse;
Console.WriteLine("{0}  ===  {1}", trueOrExample, falseOrExample);

// XOR Operator - ^
bool trueExclusiveOr = isTrue ^ isFalse;
bool falseExclusiveOr = isTrue ^ isTrue;
Console.WriteLine("{0}  -  {1}", trueExclusiveOr, falseExclusiveOr);

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool equality = 17 == 9;
bool inequality = 17 != 9;
Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively!");