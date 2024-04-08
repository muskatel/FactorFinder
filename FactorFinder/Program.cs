// See https://aka.ms/new-console-template for more information
int num = 733;

Console.WriteLine($"Given {num}\n factors are:");

foreach (int i in Finder(num))
{
    Console.WriteLine($"{i}");
}

// returns prime factors of a number
// IE   8   -> 2 x 2 x 2
//      14  -> 2 x 7
List<int> Finder(int num)
{
    List<int> factors = new List<int>();
    List<int> usedFactors = new List<int>();
    for (int i = 2; i <= num; i++)
    {
        foreach (int usedFactor in usedFactors)
        {
            if (i % usedFactor == 0)
            {
                //divisible by a previous number
                goto skip;
            }
        }
        if (num % i == 0)
        {
            factors.Add(i);
            
            usedFactors.Add(i);
        }
        skip: ;
    }

    return factors;
}

