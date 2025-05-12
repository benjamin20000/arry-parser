// See https://aka.ms/new-console-template for more information

class ArrayParser
{
    
    static bool ValidateList(List<string> list) {}
    static List<string> GetInput() {}
    static int DisplayMenu() {}
    static void Implement(int action, List<int> list) {}
    static void Print(List<int> list) {}
    static List<int> convertStrsToInts(List<string> strs) {}
    static void play()
    {
        List<string> firstList = GetInput();
        bool listValid = ValidateList(firstList);
        if (!listValid)
        {
            play();
        }
        else
        {
            List<int> secondList = convertStrsToInts(firstList);
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
