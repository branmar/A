//C# A2

//1 - Array Copy
int[] array1 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
int[] array2 = new int[array1.Length];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array1[i];
}
foreach (int num in array1)
{
    Console.Write(num + " ");
}
Console.WriteLine();
foreach (int num in array2)
{
    Console.Write(num + " ");
}

//2 - List Menu

bool flag = true;
List<string> items = new();
while (flag)
{
    Console.WriteLine("Enter command (+ item, - item, -- to clear, x to exit)):");
    string menuInput = Console.ReadLine();
    menuInput = menuInput == "x" ? "x " : menuInput;
    string op = menuInput[..2];
    switch (op)
    {
        case "+ ":
            items.Add(menuInput[2..]);
            break;
        case "- ":
            items.Remove(menuInput[2..]);
            break;
        case "--":
            items.Clear();
            break;
        case "x ":
            flag = false;
            break;
        default:
            Console.WriteLine("No operation");
            break;
    }
    if (items.Capacity > 0)
    {
        Console.WriteLine("Current list:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}

//3 - Find Primes

int[] primes = FindPrimesInRange(0, 100);
foreach (int num in primes)
{
    Console.WriteLine(num + " ");
}
static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> vals = new();
    bool isPrime = true;
    if (startNum == 0)
    {
        startNum = 1;
    }
    for (int i = startNum; i < endNum; i++)
    {
        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime == true && i != 1)
        {
            vals.Add(i);
        }
        isPrime = true;
    }
    return vals.ToArray();
}

//4 - Rotation

Console.WriteLine("Enter array:");
string[] str = Console.ReadLine().Split(" ");
Console.WriteLine("How many rotations:");
int r = Convert.ToInt32(Console.ReadLine());
int[] array = new int[str.Length];
int[] sums = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(str[i]);
    sums[i] = 0;
}
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < sums.Length; j++)
    {
        sums[j] = sums[j] + array[j];
    }
    int last = array[array.Length - 1];
    for (int j = 1; j < array.Length; j++)
    {
        array[j] = array[j - 1];
    }
    array[0] = last;
}
foreach (int num in sums)
{
    Console.Write(num + " ");
}

//5 - Repeated Number

Console.WriteLine("Enter input:");
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int count = 1;
int repNum = input[0];
int numOfNums = 1;

for (int i = 1; i < input.Length; i++)
{
    if (input[i] != input[i - 1])
    {
        count = 0;
    }

    count++;
    if (count > numOfNums)
    {
        numOfNums = count;
        repNum = input[i];
    }
}
for (int i = 0; i < numOfNums; i++)
{
    Console.Write(repNum + " ");
}

//7 - Most Common Number

Console.WriteLine("Enter input:");
int[] mcInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Dictionary<int, int> nums = new Dictionary<int, int>();
int largest = 0;
int largestCount = 0;
for (int i = 0; i < mcInput.Length; i++)
{
    if (nums.ContainsKey(mcInput[i]))
    {
        nums[mcInput[i]] += 1;
    }
    else
    {
        nums.Add(mcInput[i], 1);
    }
}
foreach (KeyValuePair<int, int> entry in nums)
{
    if (entry.Value > largestCount)
    {

        largestCount = entry.Value;
        largest = entry.Key;
    }
}
Console.WriteLine("The number {0} is the most frequent, it occurs {1} times.", largest, largestCount);


//----Strings----//
//1 - Reverse

Console.WriteLine("Enter word to reverse:");
string word = Console.ReadLine();
char[] revArray = new char[word.Length];
string output = "";

for (int i = 0; i < word.Length; i++)
{
    revArray[i] = word[i];
}

for (int i = revArray.Length - 1; i >= 0; i--)
{
    output += revArray[i];
}
Console.WriteLine(output);

//2 - Reverse words
Console.WriteLine("Enter input:");
string[] revWordsInput = Console.ReadLine().Split(' ');

for (int i = 0; i < revWordsInput.Length; i++)
{
    Console.Write(revWordsInput[revWordsInput.Length - 1 - i] + " ");
}

//3 - Palindromes

char[] separators = { ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
Console.WriteLine("Enter input:");
string[] palInput = Console.ReadLine().Split(separators);
List<string> pals = new();

for (int i = 0; i < palInput.Length; i++)
{
    bool palCheck = false;
    for (int j = 0; j < palInput[i].Length / 2; j++)
    {

        if (palInput[i][j] != palInput[i][palInput[i].Length - j - 1])
        {
            palCheck = false;
            break;
        }
        else
        {
            palCheck = true;
        }
    }
    if (palCheck == true)
    {
        pals.Add(palInput[i]);
    }
}
if (pals.Count > 0)
{
    Console.Write(pals[0]);
    for (int i = 1; i < pals.Count; i++)
    {
        Console.Write(", " + pals[i]);
    }
}

//4 - URL Sections

Console.WriteLine("Enter url:");
string url = Console.ReadLine();
char[] splitters = { ':', '/' };
string[] sections = url.Split(splitters, 3, StringSplitOptions.RemoveEmptyEntries);
Array.Resize(ref sections, 3);
if (sections[1] == null)
{
    sections[1] = sections[0];
    sections[0] = "";
    sections[2] = "";
}
if (sections[2] == null)
{
    if (!url.Contains(':'))
    {
        sections[1] = sections[2];
        sections[0] = sections[1];
        sections[0] = "";
    }
}

Console.WriteLine("[protocol] = \"{0}\"\n[server]  = \"{1}\"\n[resource] = \"{2}\"", sections[0], sections[1], sections[2]);