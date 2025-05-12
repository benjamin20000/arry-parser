// See https://aka.ms/new-console-template for more information

class ArrayParser
{

    //validate
    //1: their are 3 items in arr
    //2: the items are numbers not strings
    //3: the numbers are positive
    static bool ValidateList(string[] inputArray) 
    {
        if (inputArray.Length < 3)
        {
            return false;
        }

        foreach (string item in inputArray)
        {
            foreach (char ch in item)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
        }
        return true;
    }
    static string[] GetInput()
    {
        Console.WriteLine("enter your numbers: ");
        string input = Console.ReadLine();
        return input.Split(' ');
    }
    // static int DisplayMenu() {}
    // static void Implement(int action, int[]  list) {}

    static void Print(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }
    // static int[]  convertStrsToInts(string[]  strs) {}
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
            Console.WriteLine("good");
            // int[]  secondList = convertStrsToInts(inputArr);
            // int action = DisplayMenu();
            // if (action != 6)
            // {
            //     Implement(action, secondList);
            // }
        }
    }

    static void Main(string[] args)
    {
        play();
    }
}
