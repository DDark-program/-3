using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_2
{
    /// <summary>
    /// Находит номер столбца содержащий равное количество положительных и отрицательных элементов
    /// </summary>
    /// <param res >основной счетчик</param>
    /// <param countNeg >счетчик отрицательных элементов</param>
    /// <param countPos >счетчик положительных элементов</param>
    public class TaskMatr
    {
        public static int FindClone(DataGridView matr)
        {
            int res = -1;
            int countNeg = 0;
            int countPos = 0;
            for(int i = 0; i < matr.ColumnCount; i++)
            {
                countNeg = 0;
                countPos = 0;
                for (int j = 0; j < matr.RowCount; j++)
                {
                    if ((int)matr[i, j].Value > 0) 
                    {
                        countPos++;
                    }
                    if ((int)matr[i, j].Value < 0) 
                    {
                        countNeg++;
                    }
                }
                if (countPos == countNeg)
                {
                    res = i;
                }
            }
            return res;
        }
    }
}
