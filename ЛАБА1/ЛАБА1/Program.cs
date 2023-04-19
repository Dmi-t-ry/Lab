using System.Diagnostics.Metrics;

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

void ShowInputOutputData(List<string> text,string status)
{
    Console.WriteLine($"{status} text:");
    for(int i = 0; i < text.Count; i++)
    {
        Console.WriteLine(text[i]);
    }
}

List<string> ElementSwap(List<string>text,int counter)
{   
    
    for (int i = 0; i < text.Count; i++)
        if (i < text.Count - counter)
        {   
            var tmp=text[i];
            text[i] = text[i + 1];
            text[i + 1] = tmp;
            i++;
        }
    return text;
}
    void ProgramExecution()
{
    List<string> text = new List<string>()
    {
    "first",
    "second",
    "third",
    "fourth",
    "words",
    "something"
    };
    ShowInputOutputData(text,"Original");
    int counter = (text.Count % 2==0)?1:2;
    var swappedText = ElementSwap(text, counter);    
    ShowInputOutputData(swappedText, "Swapped");
}

do
{
    ProgramExecution();
}
while (ContinueProgramExecutionRequest() == true);