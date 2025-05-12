// See https://aka.ms/new-console-template for more information

class ArrayParser
{

    //validate
    //1: their are 3 items in arr
    //2: the items are numbers not strings
    //3: the numbers are positive
    //4: their is not empty input
    static bool ValidateInput(string[] inputArray) 
    {
        if (inputArray.Length < 3)
        {
            return false;
        }

        foreach (string item in inputArray)
        {
            if (item.Length == 0)
            {
                return false;
            }
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
    // static void Implement(int action, int[]  list) {}

    static void Print(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }

    static int[] convertStrsToInts(string[] strs)
    {
        int[] newArr = new int[strs.Length];
        for (int inx = 0; inx < strs.Length; inx++ )
        {
            newArr[inx] = int.Parse(strs[inx]);
        }
        return newArr;
    }

    static string DisplayMenu()
    {
        Console.WriteLine(" Welcome to ArrayParser ");
        Console.WriteLine("type your chosen numbers:");
        Console.WriteLine("1: Get new input.");
        Console.WriteLine("2: Display the series in the order it was entered.");
        Console.WriteLine("3: Display the series in the reversed order it was entered.");
        Console.WriteLine("4: Display the series in sorted order (from low to high).");
        Console.WriteLine("5: Display the Max value of the series.");
        Console.WriteLine("6: Display the Min value of the series.");
        Console.WriteLine("7: Display the Average of the series.");
        Console.WriteLine("8: Display the Number of elements in the series.");
        Console.WriteLine("9: Display the Sum of the series.");
        Console.WriteLine("10: Display the Sum of the series.");
        string action = Console.ReadLine();
        return action;
    }

    static bool ValidateAction(string action)
    {
        return true;
    }

    static void play()
    {
        string[] inputArr = GetInput();
        bool listValid = ValidateInput(inputArr);
        if (!listValid)
        {
            play();
        }
        else
        {
            Console.WriteLine("good");
            int[]  numbersArrey = convertStrsToInts(inputArr);
            Print(numbersArrey);
            string action = DisplayMenu();
            bool actionValid = ValidateAction(action);
            
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
