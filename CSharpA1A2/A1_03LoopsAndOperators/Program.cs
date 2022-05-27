//C#A1 - 03 Loops and Operators

//1 - FizzBuzz
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

//2 - Asterix Pyramid
int rows = 5; //change to change size of pyramid
int pBase = rows * 2 + 1;
int center = pBase / 2;
int stars = 1;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < pBase; j++)
    {
        if (j < center || j >= center + stars)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    center--;
    stars += 2;
    Console.WriteLine();
}

//3 - Random Number Guessing
int randMax = 3;
int correctNumber = new Random().Next(randMax) + 1;
int guessedNumber = -1;
while (guessedNumber != correctNumber)
{
    Console.WriteLine("Guess a number");
    guessedNumber = Convert.ToInt32(Console.ReadLine());
    if (guessedNumber < correctNumber)
    {
        Console.WriteLine("Low");
    }
    else if (guessedNumber > correctNumber)
    {
        Console.WriteLine("High");
    }
}
Console.WriteLine("Correct");

//4 - Days From Birthday
DateTime birthday = new DateTime(1999, 5, 1);
DateTime today = DateTime.Today;
int days = (today - birthday).Days;
Console.WriteLine($"{days} days old");
DateTime ann = birthday.AddDays(10000);
Console.WriteLine($"10000 days old on {ann}");

//5 - Greeeting Based on Time
DateTime now = DateTime.Now;
if (now.Hour > 3 && now.Hour <= 11)
{
    Console.WriteLine("Good Morning");
}
else if (now.Hour > 11 && now.Hour <= 16)
{
    Console.WriteLine("Good Afternoon");
}
else if (now.Hour > 16 && now.Hour <= 20)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

//6 - Count to 24
for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
    {
        if (j == 24)
        {
            Console.WriteLine(j);
        }
        else
        {
            Console.Write(j + ", ");
        }
    }
    Console.WriteLine();
}