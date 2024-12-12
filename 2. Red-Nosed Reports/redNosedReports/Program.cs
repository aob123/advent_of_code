

using (StreamReader sr = new StreamReader("/Users/alexanderbeswick/Documents/Dev/advent_of_code/2. Red-Nosed Reports/redNosedReports/input.txt"))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        string[] items = line.Split(" ");
        System.Console.WriteLine(items[0]); 
    }
}