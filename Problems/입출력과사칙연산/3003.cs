using System.Text;

namespace Problems.입출력과사칙연산;
internal class _3003
{
    internal void Solve()
    {
        //0 1 2 2 2 7 => 1 0 0 0 0 1
        //2 1 2 1 2 1 => -1 0 0 1 0 7

        int[] chressUnit = new int[6] { 1, 1, 2, 2, 2, 8 };

        string? input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input))
        {
            int[] inputs = input.Split(' ').Select(x => int.Parse(x.ToString())).ToArray();
            for(int i = 0; i < inputs.Count(); i++)
            {
                inputs[i] = chressUnit[i] - inputs[i];
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var i in inputs)
            {
                stringBuilder.Append($"{i} ");
            }
            Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }
    }
}
