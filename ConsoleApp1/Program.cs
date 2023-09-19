// See https://aka.ms/new-console-template for more information


string hello = "Hello there!";
Console.WriteLine(hello);

string myName = "My Name is Jon";
Console.WriteLine(myName);

string askName = "What's your name?";
Console.WriteLine(askName);
string userName = Console.ReadLine();

string helloUser = $"Hello, {userName}";
Console.WriteLine(helloUser);

string context = "I've been asleep for so long... What year is it?";
Console.WriteLine(context);

string currentYear = Console.ReadLine();

int currentYearNum = int.Parse(currentYear);
int myBirthYear = 1987;
int myAge = currentYearNum - myBirthYear;

string wow = $"Wow! I am {myAge} years old!";
Console.WriteLine(wow);
