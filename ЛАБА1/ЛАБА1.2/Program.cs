using System.Text.Json;

bool ContinueProgramExecutionRequest()
{
    Console.WriteLine("Retry the program?(True / False)");
    bool response = false;
    try
    {
        response = bool.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid value entered. Press any key to exit the program.");
        Console.ReadKey();
    }
    Console.Clear();
    return response;
}

Dictionary<int,char> DictionaryChanger(Dictionary<int, char> lettersNumbers)
{   
    lettersNumbers.Remove(FindMinValue(lettersNumbers));
    lettersNumbers.Remove(FindMaxValue(lettersNumbers));
    lettersNumbers = lettersNumbers.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);   
    return lettersNumbers;
}

#region MinMax
int FindMinValue(Dictionary<int, char> lettersNumbers)
{
    int min = 100, max = -1;
    foreach(var number in lettersNumbers)
        min = Math.Min(min, number.Key);
    return min;
}

int FindMaxValue(Dictionary<int, char> lettersNumbers)
{
    int min = 100, max = -1;
    foreach (var number in lettersNumbers)
        max = Math.Max(max, number.Key);
    return max;
}
#endregion

void ProgramExecution()
{
    Dictionary <int, char> lettersNumbers = new Dictionary<int,char >()
    {
        {5,'e'},
        {4,'h' },
        {12,'o' },
        {8,'l' },
        {2,'u' },
        {10,'l' },
        {17,'m' }
    };

 Console.WriteLine( JsonSerializer.Serialize(DictionaryChanger(lettersNumbers)));
}


do
{
    ProgramExecution();
}
while (ContinueProgramExecutionRequest() == true);