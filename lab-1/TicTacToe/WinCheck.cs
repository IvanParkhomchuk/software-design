using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class WinCheck
    {
        public bool CheckResult(char[,] matrix)
        {
            if (CheckByRows(matrix) || CheckByColumns(matrix) || CheckByDiagonals(matrix))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckByRows(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] == matrix[i, 1] && matrix[i, 0] == matrix[i, 2])
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckByColumns(char[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[0, j] == matrix[1, j] && matrix[0, j] == matrix[2, j])
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckByDiagonals(char[,] matrix)
        {
            if ((matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2]) ||
                (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0]))
            {
                return true;
            }

            return false;
        }
    }
}
