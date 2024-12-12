
using System.Globalization;

List<int> numsA = [];
List<int> numsB = [];
List<int> distances = [];


try
{
    //Read file, split by spaces (3) and add to list A/B
    using (StreamReader sr = new StreamReader("/Users/alexanderbeswick/Documents/Dev/advent_of_code/1. Historian hysteria/historianHysteria/input.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {

            string[] items = line.Split("   ");
            int numA = int.Parse(items[0]);
            int numB = int.Parse(items[1]);
            numsA.Add(numA);
            numsB.Add(numB);
        }
    }
}
catch (Exception e)
{
    // Let the user know what went wrong.
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}

//Sort list smallest to largest
numsA.Sort();
numsB.Sort();

for (int i = 0; i < numsA.Count; i++)
{
    //Print list to see that it is sorted
    System.Console.WriteLine($"A: {numsA[i]} || B: {numsB[i]}");

    //Check which number of the pair is largest, perform substraction and add distance to list
    if (numsA[i] > numsB[i])
    {
        int total = numsA[i] - numsB[i];
        distances.Add(total);

    }
    else if (numsB[i] > numsA[i])
    {
        int total = numsB[i] - numsA[i];
        distances.Add(total);
    }

}

// Sum the list of distances and print to console
int finalSum = distances.Sum();
System.Console.WriteLine(finalSum);

//Check how many times number A appears in list numsB

List<int> numsSimilarity = [];
int multiplier = 0;

for (int i = 0; i < numsA.Count; i++)
{

    for (int j = 0; j < numsB.Count; j++)
    {
        if (numsA[i] == numsB[j])
        {
            multiplier++;
        }
    }

    numsSimilarity.Add(numsA[i] * multiplier);
    // System.Console.WriteLine(multiplier);
    multiplier = 0;
}



// foreach (int n in numsSimilarity)
// {
//     System.Console.WriteLine(n);
// }

//Sum of numsSimilairty
int finalSumTwo = numsSimilarity.Sum();
System.Console.WriteLine(finalSumTwo);