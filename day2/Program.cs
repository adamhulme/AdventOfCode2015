class Program
{
    public int zeroCount = 0;
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("C:\\projects\\aoc15\\day2\\in.txt");
        var line = sr.ReadLine();
        var totalWrappingPaper = 0;
        var totalRibbon = 0;
        while (line != null)
        {
            var dimensions = line.Split('x').Select(int.Parse).ToArray();
            var l = dimensions[0];
            var w = dimensions[1];
            var h = dimensions[2];
            var side1 = l * w;
            var side2 = w * h;
            var side3 = h * l;
            var surfaceArea = 2 * side1 + 2 * side2 + 2 * side3 + Math.Min(side1, Math.Min(side2, side3));
            totalWrappingPaper += surfaceArea;

            var maxSide = Math.Max(l, Math.Max(w, h));
            var perimeter = 2 * (l + w + h - maxSide);
            var bow = l * w * h;
            totalRibbon += perimeter + bow;
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine($"Total wrapping paper: {totalWrappingPaper}");
        Console.WriteLine($"Total ribbon: {totalRibbon}");
        Console.ReadLine();
    }
}