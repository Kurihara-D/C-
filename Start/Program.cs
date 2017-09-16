using System;
using Start.Properties;
namespace Start
{
    class MainClass
    {
        public static void Main(){
			var dice = new Random();
			int omikuji = dice.Next(1, 7);
            var calc = new EmptyClass(omikuji);
		}
    }
}
