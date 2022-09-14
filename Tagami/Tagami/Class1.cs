using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagami
{
    public class Vector2
    {
        public int x=0;
        public int y=0;
        Vector2 Setpos(int x,int y)
        {
            Vector2 pos=new Vector2();
            pos.x=x;
            pos.y=y;
            return pos;
        }
    }
}
