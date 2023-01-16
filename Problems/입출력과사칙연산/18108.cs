namespace Problems.입출력과사칙연산;
internal class _18108
{
    internal void Solve()
    {
        int padding = 543;
        /* 2543 => 1998 
         * 불기와 서기 차이: 543년
         */
        string? input = Console.ReadLine();
        if(!string.IsNullOrEmpty(input) &&
           int.TryParse(input, out int parseNumber))
        {
            Console.WriteLine($"{parseNumber - padding}");
        }
    }
}
