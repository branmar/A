//C#A1 - 02 Understanding Types

//1
string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
"ulong", "float", "double", "decimal"};
int[] sizes = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16 };
string[] minVal = {"-128", "0", "-32,768", "0", "-2,147,483,648", "0", "-2^63",
"0", "-3.4e38", "-1.7e308", "-7.9228e28"};
string[] maxVal = {"127", "255", "32,767", "65535", "2,147,483,648", "4,294,967,295", "2^63 - 1",
"2^63", "3.4e38", "1.7e308", "7.9228e28"};

Console.WriteLine(" {0,-10} {1,-12}   {2,-16} {3,-16}\n", "Type", "Size (bytes)", "Minimum", "Maximum");
for (int i = 0; i < types.Length; i++)
{
    Console.WriteLine(" {0,-10} {1,-12}   {2,-16} {3,-16}\n", types[i], sizes[i], minVal[i], maxVal[i]);
}

//2
Console.WriteLine("Enter amount of centuries: ");
double cent = Convert.ToUInt32(Console.ReadLine());
double years = cent * 100;
double days = Convert.ToUInt32(years * 365.24219);
double hours = days * 24;
double mins = hours * 60;
double secs = mins * 60;
double mSecs = secs * 1000;
double uSecs = mSecs * 1000;
double nSecs = uSecs * 1000;

Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = " +
    $"{mins} minutes = {secs} seconds = {mSecs} milliseconds = {uSecs} microseconds = " +
    $"{nSecs} nanoseconds");
