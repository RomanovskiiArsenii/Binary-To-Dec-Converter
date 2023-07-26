class Program
{
    /// <summary>
    /// Returns dec representation of bin number
    /// </summary>
    /// <param name="BinaryArray">Binary number as array</param>
    /// <returns>Decimal number</returns>
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        string num = string.Join("", BinaryArray);
        return Convert.ToInt32(num, 2);
    }
    /// <summary>
    /// Returns dec representation of bin number (but via cycle)
    /// </summary>
    /// <param name="BinaryArray">Binary number as array</param>
    /// <returns>Decimal number</returns>
    public static int binaryArrayToNumberCycle(int[] BinaryArray)
    {
        string strNum = string.Join("", BinaryArray);
        int decNum = 0;

        for (int i = 0; i < strNum.Length; i++)
        {
            char bit = strNum[i];
            if (bit == '1')
            {
                int power = strNum.Length - i - 1;
                decNum += (int)Math.Pow(2, power);
            }
        }
        return decNum;
    }
    static void Main()
    {
        int[] BinaryArray = { 1, 0, 0, 0, 0, 1, 1, 0, 1 };
        Console.WriteLine(binaryArrayToNumber(BinaryArray));
        Console.WriteLine(binaryArrayToNumberCycle(BinaryArray));
    }
}