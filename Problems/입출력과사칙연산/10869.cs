namespace Problems.입출력과사칙연산;
internal class _10869
{
    internal void Solve()
    {
        /* 7 3 =>
         * 
         * 10
         * 4
         * 21
         * 2
         * 1
         * 
         */
        string? input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input))
        {
            string[] inputs = input.Split(' ');
            int[] result = inputs.Select(item => int.Parse(item)).ToArray();
            if(result.Length == 2)
            {
                Console.WriteLine(result[0] + result[1]);
                Console.WriteLine(result[0] - result[1]);
                Console.WriteLine(result[0] * result[1]);
                Console.WriteLine(result[0] / result[1]);
                Console.WriteLine(result[0] % result[1]);
            }
        }
    }
}
