class Program
{
    public int zeroCount = 0;
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("C:\\projects\\aoc15\\day1\\in.txt");
        var line = sr.ReadLine();
        var floor = 0;
        while (line != null)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                    floor++;
                else if (line[i] == ')')
                    floor--;

                if (floor == -1)
                {
                    Console.WriteLine($"Basement entered: {i + 1}");
                }
            }
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine($"Final floor: {floor}");
        Console.ReadLine();
    }
}