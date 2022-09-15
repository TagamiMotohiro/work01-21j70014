using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagami
{
    public class Bord
    {
        public const int bord_Max_Length=10;
        string[,] mark=new string[bord_Max_Length,bord_Max_Length];
        string winMark;
        public void Bord_Init()
        {
            for (int i = 0; i < bord_Max_Length ; i++)
            {
                for (int j = 0; j < bord_Max_Length; j++)
                {
                    mark[i, j] = " ";
                }
            }
            Console.WriteLine("盤面を初期化しました。");
        }
        public void Bord_Draw()
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int i = 0; i < bord_Max_Length ; i++)
            {
                Console.Write(i.ToString());
                for (int j = 0;j < bord_Max_Length;j++)
                {
                    Console.Write(" "+mark[j,i]);
                }
                Console.Write("\n");
               // Console.WriteLine(i.ToString()+mark[i,0]+" "+mark[i,1]+" "+mark[i,2]); 
            }
        }
        public void Bord_input(int x,int y,string input_Mark)
        {
            if (mark[x, y] != " ")
            {
                Console.WriteLine("無効な入力です");
                return;
            }
            mark[x, y] = input_Mark;
        }

        public bool Win_Output()
        { 
            bool isWin=false;
            bool diagonalWin=false;
            bool xWin=false;
            bool yWin=false;
            if(Bord_search(9, 9, -1, -1,out winMark)||Bord_search(0, 0, 1, 1,out winMark))
            {
                diagonalWin = true;
            }
            for (int i = 0;i < bord_Max_Length-1;i++)
            {
                if(Bord_search(i,0,0,1,out winMark))
                {
                    yWin = true;
                }
            }
            for (int i = 0; i < bord_Max_Length-1; i++)
            {
                if (Bord_search(0, i, 1, 0,out winMark))
                {
                    xWin = true;
                }
            }
            if(diagonalWin||xWin||yWin)
            {
                isWin=true;
                Console.WriteLine(winMark+"が勝利しました。");
            }
            
            return isWin;
        }
        bool Bord_search(int start_Pos_X, int start_Pos_y, int move_X, int move_Y,out string winMark)
        {
            bool isWin=false;
            string input_Mark = mark[start_Pos_X, start_Pos_X];
            int ren_Count = 0;
            for (int i=0;i<bord_Max_Length-1;i++)
            {
                start_Pos_X+=move_X;
                start_Pos_y+=move_Y;
                if(input_Mark==mark[start_Pos_X,start_Pos_y]&&mark[start_Pos_X,start_Pos_y]!=" ")
                {
                    ren_Count++;
                }else
                {
                    
                    ren_Count = 0;
                    if (mark[start_Pos_X, start_Pos_y] != " ")
                    {
                        input_Mark = mark[start_Pos_X, start_Pos_y];
                    }
                }
            }
            if(ren_Count>=5)
            {
                isWin = true;
                winMark = input_Mark;
            }
            winMark = input_Mark;
            return isWin;
        }
    }
}
