// See https://aka.ms/new-console-template for more information
int num = 42;

Console.WriteLine($"Given {num}");

foreach (int i in Finder(num))
{
    Console.WriteLine($"{i} is a factor");
}

// returns prime factors of a number
// IE   8   -> 2 x 2 x 2
//      14  -> 2 x 7
// num will always be less than 1000
List<int> Finder(int num)
{
    
    List<int> factors = new List<int>();


    return factors;
}

