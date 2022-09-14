using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagami
{
    public class Bord
    {
        string[,] mark=new string[3,3];
        public const int bord_Max_Num=2;
        
        public void Bord_Init()
        {
            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mark[i, j] = " ";
                }
            }
            Console.WriteLine("盤面を初期化しました。");
        }
        public void Bord_Draw()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine(i.ToString()+mark[i,0]+" "+mark[i,1]+" "+mark[i,2]);
            }
        }
        public void Bord_input(int x,int y,string input_Mark)
        {
            if (mark[x, y] != " ")
            {
                Console.WriteLine("無効な入力です");
            }
            mark[x, y] = input_Mark;
        }
    }
}
