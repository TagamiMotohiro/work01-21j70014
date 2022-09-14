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
        private void Input_Pos(int input)
        {
            bool parcesuccess = false;
            while (!parcesuccess)
            {
                string sx = Console.ReadLine();
                parcesuccess = int.TryParse(sx, out input);
                if (!parcesuccess||input>2)
                {
                    Console.WriteLine("無効な数値が入力されました。");
                }
            }
        }
        public void XY_Input()
        {
            Console.WriteLine("Xの値を入力してください");
            Input_Pos(this.pos.x);
            Console.WriteLine("Yの値を入力してください");
            Input_Pos(this.pos.y);
        }
    }
}
