using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_DirectionsReduction
{
    public class DirReduction
    {
        public string[] dirReduc(String[] arr)
        {
            var lastDir = "";
            var list = arr.ToList();
            var isNull = new string[] { "NORTH", "SOUTH", "WEST", "EAST" };
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "NORTH":
                        if (lastDir == "SOUTH")
                        {
                            list.Remove(list[i]);
                            i--;
                            list.Remove(list[i]);
                            i--;
                            if (i < 0)
                            {
                                i = 0;
                            }
                            lastDir = list[i];
                            break;
                        }
                        if (list.Count == 0)
                        {
                            return isNull;
                        }
                        lastDir = list[i];
                        break;

                    case "SOUTH":
                        if (lastDir == "NORTH")
                        {
                            list.Remove(list[i]);
                            i--;
                            list.Remove(list[i]);
                            i--;
                            if (i < 0)
                            {
                                i = 0;
                            }
                            lastDir = list[i];
                            break;
                        }
                        if (list.Count == 0)
                        {
                            return isNull;
                        }
                        lastDir = list[i];
                        break;

                    case "WEST":
                        if (lastDir == "EAST")
                        {
                            list.Remove(list[i]);
                            i--;
                            list.Remove(list[i]);
                            i--;
                            if (i < 0)
                            {
                                i = 0;
                            }
                            if (list.Count == 0)
                            {
                                return isNull;
                            }
                            lastDir = list[i];
                            break;
                        }
                        lastDir = list[i];
                        break;

                    default:
                        if (lastDir == "WEST")
                        {
                            list.Remove(list[i]);
                            i--;
                            list.Remove(list[i]);
                            i--;
                            if (i < 0)
                            {
                                i = 0;
                            }
                            if (list.Count == 0)
                            {
                                return isNull;
                            }
                            lastDir = list[i];
                            break;
                        }
                        lastDir = list[i];
                        break;
                }
            }
            return list.ToArray();
        }
    }
}
