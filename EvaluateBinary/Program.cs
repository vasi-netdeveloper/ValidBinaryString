internal class Program
{
    public static bool CheckBinaryString(string s)
    {
        for (int i = 0; i < s.Length; i++)
            for (int j = i; j < s.Length - 1; j++)
            {
                string newSub = s.Substring(i, s.Length - j);
                if (newSub.Length % 2 == 0 && newSub.Length >= 2)
                {
                    string subLeft = newSub.Substring(0, newSub.Length / 2);
                    string subRight = newSub.Substring(newSub.Length / 2, newSub.Length / 2);
                    int leftSum = subLeft.Sum(x => x - '0');
                    int rightSum = subRight.Sum(x => x - '0');
                    if ((leftSum == subLeft.Length && rightSum == 0) ||
                       (rightSum == subRight.Length && leftSum == 0))
                    {
                        Console.WriteLine(newSub);
                        if (newSub.Count(c => c == '1') < newSub.Count(x => x == '0'))
                            return false;
                    }
                        
                }
            }

        int ones = s.Count(c => c == '1');
        int zeros = s.Count(c => c == '0');

        if (ones == zeros)
            return true;

        return false;

    }
    private static void Main()
    {
        Console.WriteLine("Enter binary string");
        var binaryString = Console.ReadLine();

        if (CheckBinaryString(binaryString))
        {
            Console.WriteLine("Valid String");
        }
        else
        {
            Console.WriteLine("Invalid String");
        }
    }
}