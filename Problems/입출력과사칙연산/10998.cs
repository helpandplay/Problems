namespace Problems.입출력과사칙연산;
internal class _10998
{
    void Solve()
    {
        //1 2 => 2
        //3 4 => 12
        string? input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input))
        {
            string[] inputs = input.Split(' ');
            int[] result = inputs.Select(item => int.Parse(item)).ToArray();
            if(result.Length == 2)
            {
                Console.WriteLine(result[0] * result[1]);
            }
        }
    }
}
