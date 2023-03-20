using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Field
    {
        public char[] cells;

        public Field(int length)
        {
            cells = new char[length];

            for (int i = 0; i < length; i++)
            {
                cells[i] = (char)((i + 1) + '0');
            }
        }

        public void ShowField(char[] cells)
        {
            Console.WriteLine(" {0} | {1} | {2}", cells[0], cells[1], cells[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2}", cells[3], cells[4], cells[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2}\n", cells[6], cells[7], cells[8]);
        }
    }
}
