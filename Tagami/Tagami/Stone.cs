using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagami
{
    public class Stone
    {
        
        public string icon;
        public Stone(string iconName)
        {
            icon = iconName;
        }
        public Vector2 pos
        {
            get;private set; 
        }=new Vector2();
        private int Input_Pos()
        {
            int input=0;
            bool parcesuccess = false;
            while (!parcesuccess)
            {
                string sx = Console.ReadLine();
                parcesuccess = int.TryParse(sx, out input);
                if (!parcesuccess||input>Bord.bord_Max_Length)
                {
                    Console.WriteLine("無効な数値が入力されました。");
                }
            }
            return input;
        }
        public void XY_Input()
        {
            Console.WriteLine("横の値を入力してください");
            this.pos.x=Input_Pos();
            Console.WriteLine("縦の値を入力してください");
            this.pos.y=Input_Pos();
        }
    }
}
