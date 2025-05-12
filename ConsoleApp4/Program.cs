// See https://aka.ms/new-console-template for more information

class ArrayParser
{

    //validate
    //1: their are 3 items in arr
    //2: the items are numbers not strings
    //3: the numbers are positive
    //4: no empty item in input
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
   
    static int[] ConvertStrsToInts(string[] strs)
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
        Console.WriteLine("Welcome to ArrayParser ");
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
        Console.WriteLine("10: Exit.");
        string action = Console.ReadLine();
        return action;
    }
    static void PrintArr(int[] arr)
    {
        for (int cher = 0; cher < arr.Length - 1; cher++)
        {
            Console.Write(arr[cher] + ", ");
        }
        Console.Write(arr[arr.Length-1]);
        Console.Write('\n');
    }
    
    static void PrintReversArray(int[] arr)
    {
        for (int cher = arr.Length-1; cher > 0; cher--)
        {
            Console.Write(arr[cher] + ", ");
        }
        Console.Write(arr[0]);
        Console.Write('\n');
    }

    static int[] MargeSort(int[] arr)
    {
        if (arr.Length <= 1 )
        {
            return arr;
        }
        int[] leftArr = MargeSort(arr[..(arr.Length / 2)]);
        int[] rightArr = MargeSort(arr[(arr.Length / 2)..]);
        int[] sortedArray = new int[leftArr.Length + rightArr.Length];
        int inx1, inx2, inx3;
        inx1 = inx2 = inx3 = 0;
        while (inx3 < sortedArray.Length)
        {
            if (inx1 == leftArr.Length)
            {
                sortedArray[inx3] = rightArr[inx2];
                inx2++;
                inx3++;
            }
            else if (inx2 == rightArr.Length)
            {
                sortedArray[inx3] = leftArr[inx1];
                inx1++;
                inx3++;
                
            }
            else if (leftArr[inx1] < rightArr[inx2])
            {
                sortedArray[inx3] = leftArr[inx1];
                inx1++;
                inx3++;
            }
            else 
            {
                sortedArray[inx3] = rightArr[inx2];
                inx2++;
                inx3++;
            }
        }
        return sortedArray;
        
    }
    static void Implement(string action, int[] arr)
    {
        switch (action)
        {
            case "1":
                play();
                break;
            case "2":
                PrintArr(arr);
                break;
            case "3":
                PrintReversArray(arr);
                break;
            case "4":
                PrintArr(MargeSort(arr));
                break;
            case "5":
                Console.WriteLine("the max:" + arr.Max());
                break;
            case "6":
                Console.WriteLine("the min: " + arr.Min());
                break;
            case "7":
                Console.WriteLine("the average: " + arr.Sum()/arr.Length);
                break;
            case "8":
                Console.WriteLine("the length: " + arr.Length);
                break;
            case "9":
                Console.WriteLine("the sum is: " + arr.Sum());
                break;
            case "10":
                break;
            default:
                Console.WriteLine("Invalid action");
                break;
        }
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
            int[] numbersArray = ConvertStrsToInts(inputArr);
            string action = "";
            while (action!="10")
            {
                action = DisplayMenu();
                Implement(action, numbersArray);
            }
        }
    }

    static void Main(string[] args)
    {
        play();
    }
}
