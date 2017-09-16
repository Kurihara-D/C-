using System;
namespace Start
{
    public class OmikujiClass
    {
        public OmikujiClass()
        {
        }

        public OmikujiClass(int random)
        {
            if (random == 1) {
                Console.WriteLine("大吉");
            }
            else if(random == 2){
                Console.WriteLine("中吉");
            }
            else if (random <=4){
                Console.WriteLine("小吉");
            }
            else{
                Console.WriteLine("凶");
            }
        }
    }
}
