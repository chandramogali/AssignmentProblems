using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Review3
{
    public class DeleteArray
    {
        public void DeleteMethod<T>(T[] Arr, T element)
        {
            int j = 0;
            T[] temp = new T[Arr.Length];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Equals(element))
                {
                    continue;
                }
                else
                {
                    temp[j] = Arr[i];
                    j++;
                }
            }

            for(int i = 0; i< temp.Length-1; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
