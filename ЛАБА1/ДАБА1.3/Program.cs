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

void FindCountOfPositive(List<int> listOfNumbers)
{
    Console.WriteLine($"Count of positive:{(from n in listOfNumbers where n > 0 select n).Count()}"); 
}
void FindSumOfOdd(List<int> listOfNumbers)
{
    Console.WriteLine($"Sum of odd:{(from n in listOfNumbers where n%2!=0 & n>0 select n).Sum()}");
}

void ProgramExecution()
{
    List<int> listOfNumbers = new List<int>()
    {
        1,
        -13,
        42,
        3,
        -2,
        5,
        7,
        4,
        3
    };
    FindCountOfPositive(listOfNumbers);
    FindSumOfOdd(listOfNumbers);
}

do
{
    ProgramExecution();
}
while (ContinueProgramExecutionRequest() == true);
