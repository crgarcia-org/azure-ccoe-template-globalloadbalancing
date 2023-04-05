// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const int numberOfExperiements = 100;
Random rnd = new Random();
List<int> experiments = new List<int>(numberOfExperiements);

for (int i = 0; i < numberOfExperiements; i++)
{
    List<int> keys = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    int rightKey = keys[rnd.Next(keys.Count)];

    for (int attempt = 0; attempt < 10; attempt++)
    {
        int selectedIndex = rnd.Next(keys.Count);
        int selected = keys[selectedIndex];
        if (selected == rightKey)
        {
            experiments.Add(selected);
            Console.WriteLine("Winner: " + selected);
        }
        keys.RemoveAt(selectedIndex);
    }
}

SortedDictionary<int, int> results = new SortedDictionary<int, int>();
foreach (int experiment in experiments)
{
    int resultsForValue = results.GetValueOrDefault(experiment, 0);
    results[experiment] = resultsForValue + 1;
}


foreach (int key in results.Keys)
{
    Console.WriteLine($"{key}: {results[key]}");
}

