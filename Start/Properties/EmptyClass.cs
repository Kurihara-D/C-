using System;
namespace Start.Properties
{
    public class EmptyClass
    {
        public EmptyClass(int omikuji)
        {
			if (omikuji == 1)
			{
				Console.WriteLine("大吉");
			}
			else if (omikuji == 2)
			{
				Console.WriteLine("中吉");
			}
			else if (omikuji <= 4)
			{
				Console.WriteLine("小吉");
			}
			else
			{
				Console.WriteLine("凶");
			}
        }
    }
}
