class Program
{
    public int zeroCount = 0;
    static void Main(string[] args)
    {
        var input = "iwrupvqb";
        var found = false;
        for (int i = 0; !found; i++)
        {
            var toHash = input + i;
            using var md5 = System.Security.Cryptography.MD5.Create();
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(toHash);
            var hashBytes = md5.ComputeHash(inputBytes);
            var hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            if (hashString.StartsWith("000000"))
            {
                Console.WriteLine($"Found: {i}");
                found = true;
            }
        }
        Console.ReadLine();
    }
}