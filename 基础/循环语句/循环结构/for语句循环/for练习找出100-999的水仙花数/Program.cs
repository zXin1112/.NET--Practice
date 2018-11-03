using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for练习找出100_999的水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //水仙花数就是  百位立方  加  十位立方  加  个位立方
            int b;
            int s;
            int g;
            int i;
            for (i = 100; i <=999; i++)
            {
                b=i /100;
                s =i %100/10;
                g =i %10;
                if (b *b *b +s *s *s+g* g *g ==i )
                {
                    Console .WriteLine ("水仙花数有{0}",i );
                }
                
            }
            Console .ReadKey ();
        }
    }
}
