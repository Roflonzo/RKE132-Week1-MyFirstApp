//app kysib kasutajalt tema nime
//app tervitab teda nimepidi

Console.WriteLine("Enter your name");
//string - sõne
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName}!");
