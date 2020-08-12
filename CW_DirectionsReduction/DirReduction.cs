using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_DirectionsReduction
{
    public class DirReduction
    {
        public string[] dirReduc(String[] arr, int from = 0)
        {
            //Console.WriteLine("Input: " + string.Join(", ", arr));
            var list = arr.ToList();
            var next = from + 1;
            var isNull = new string[] { "NORTH", "SOUTH", "WEST", "EAST" };
            if (list == null)
                return isNull;
            else if (list.Count == 0)
                return isNull;
            else if (list.Count == 1)
                return list.ToArray();
            else if (from >= list.Count)
                return isNull;
            else if (from < 0)
                from = 0;
            
            if ((from < list.Count - 1) && (list[from] == "NORTH" && list[next] == "SOUTH" || list[from] == "SOUTH" && list[next] == "NORTH" || list[from] == "WEST" && list[next] == "EAST" || list[from] == "EAST" && list[next] == "WEST"))
            {
                list.Remove(list[next]);
                list.Remove(list[from]);
                return dirReduc(list.ToArray(), 0);
            }
            return dirReduc(list.ToArray(), from + 1);

        }
    }
}
