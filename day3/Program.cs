class Program
{
    public int zeroCount = 0;
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("C:\\projects\\aoc15\\day3\\in.txt");
        var line = sr.ReadLine();
        var deliveries = new HashSet<(int, int)>();
        deliveries.Add((0, 0));
        var santaVertical = 0;
        var santaHorizontal = 0;
        var robosantaVertical = 0;
        var robosantaHorizontal = 0;
        var turn = false;
        while (line != null)
        {
            foreach (var c in line)
            {
                if (turn)
                {
                    if (c == '^')
                        robosantaVertical++;
                    else if (c == 'v')
                        robosantaVertical--;
                    else if (c == '>')
                        robosantaHorizontal++;
                    else if (c == '<')
                        robosantaHorizontal--;

                    var tuple = (robosantaHorizontal, robosantaVertical);
                    Console.WriteLine($"Delivering to: {tuple}");
                    deliveries.Add(tuple);
                    turn = false;
                    continue;
                }
                else 
                {
                    if (c == '^')
                        santaVertical++;
                    else if (c == 'v')
                        santaVertical--;
                    else if (c == '>')
                        santaHorizontal++;
                    else if (c == '<')
                        santaHorizontal--;
                        
                    var tuple = (santaHorizontal, santaVertical);
                    Console.WriteLine($"Delivering to: {tuple}");
                    deliveries.Add(tuple);
                }
                turn = !turn;
            }
            line = sr.ReadLine();
        }
        Console.WriteLine(deliveries.Count);
        sr.Close();
        Console.ReadLine();
    }
}