namespace Problems.입출력과사칙연산;
internal class _1001
{
    void Solve()
    {
        //3 2 => 1
        string input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input))
        {
            string[] inputs = input.Split(' ');
            var result = inputs.Select(item => int.Parse(item)).ToArray();
            if(result.Count() == 2)
            {
                Console.WriteLine(result[0] - result[1]);
            }
        }
    }
}
