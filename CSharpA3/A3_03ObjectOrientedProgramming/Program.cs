//C# A3 Part 1

//1 - Numbers
try
{
    int[] numbers = GenerateNumbers();
    Reverse(numbers);
    PrintNumbers(numbers);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

//2 - Fibonacci

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

static int Fibonacci(int index)
{
    int a = 0;
    int b = 1;
    int val = 1;
    for (int i = 0; i < index; i++)
    {
        val = a + b;
        a = b;
        b = val;
    }
    return val;
}

static int[] GenerateNumbers()
{
        Console.WriteLine("Enter numbers in format: 1, 2, 3,...");
        int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        return input;
}

static void Reverse(int[] nums)
{
    for (int i = 0; i < nums.Length / 2; i++)
    {
        (nums[nums.Length - i - 1], nums[i]) = (nums[i], nums[nums.Length - i - 1]);
    }
}

static void PrintNumbers(int[] nums)
{
    Console.Write(nums[0]);
    for (int i = 1; i < nums.Length; i++)
    {
        Console.Write(", " + nums[i]);
    }
}