// See https://aka.ms/new-console-template for more information

class ArrayParser
{
    
    static bool ValidateList(string[] inputArray) {}
    static string[] GetInput()
    {
        Console.WriteLine("enter your numbers: ");
        string input = Console.ReadLine();
        return input.Split(' ');
    }
    static int DisplayMenu() {}
    static void Implement(int action, int[]  list) {}
    static void Print(List<int> list) {}
    static int[]  convertStrsToInts(string[]  strs) {}
    static void play()
    {
        string[] inputArr = GetInput();
        bool listValid = ValidateList(inputArr);
        if (!listValid)
        {
            play();
        }
        else
        {
            int[]  secondList = convertStrsToInts(inputArr);
            int action = DisplayMenu();
            if (action != 6)
            {
                Implement(action, secondList);
            }
        }
    }

    static void Main(string[] args)
    {
        play();
    }
}
