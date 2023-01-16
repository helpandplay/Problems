namespace Problems.입출력과사칙연산;
internal class _1008
{
    internal void Solve()
    {
        //1 3 => 0.33333333333333333333333333333333
        //4 5 => 0.8
        string? input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input))
        {
            string[] inputs = input.Split(' ');
            int[] result = inputs.Select(item => int.Parse(item)).ToArray();
            if(result.Length == 2)
            {
                Console.WriteLine(result[0] / ( result[1] * 1.0 ));
            }
        }
    }
}
