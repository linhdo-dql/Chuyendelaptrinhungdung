using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangCayCanh
{
    public class Common
    {
        public static int CheckEmptyId(DataTable dt, string columOfId)
        {
            int number = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i != GetNumberOfId(dt.Rows[i][columOfId].ToString()))
                {
                    number = i; break;
                }
            }
            return number == 0 ? GetMaxId(dt, columOfId) + 1 : number;
        }

        public static int GetNumberOfId(string strId)
        {
            return int.Parse(strId.Split("_")[1]);
        }

        public static int GetMaxId(DataTable dt, string columOfId)
        {
            if(dt.Rows.Count < 1)
            {
                return -1;
            }
            int maxId = GetNumberOfId(dt.Rows[0][columOfId].ToString());
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                int value = GetNumberOfId(dt.Rows[i][columOfId].ToString());
                if (value > maxId)
                {
                    maxId = value;
                }
            }
            return maxId;
        }
    }
}
