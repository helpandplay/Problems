namespace Problems.입출력과사칙연산;
internal class _1000
{
    void Solve()
    {
        //1 2 => 3
        string? input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input))
        {
            string[] inputs = input.Split(' ');
            int result = inputs.Select(item => int.Parse(item)).Sum();
            Console.WriteLine(result);
        }
    }
}
