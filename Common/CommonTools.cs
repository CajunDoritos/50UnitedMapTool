using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _50UnitedMapTool
{
    class CommonTools
    {

        public static string[] StringListToArray(List<string> list)
        {
            int length = list.Count;
            string[] array = new string[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = list[i];
            }

            return array;
        }

        public static Vector2[] Vector2ListToArray(List<Vector2> list)
        {
            int length = list.Count;
            Vector2[] array = new Vector2[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = list[i];
            }

            return array;
        }

    }
}
