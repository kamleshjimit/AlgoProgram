using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace MySorting
{
    public class MySortingAlgo
    {
        public void BubbleSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
                for (int j = 1; j < Array.Length; j++)
                    if (Array[j - 1] > Array[j])
                        Swap(Array, j - 1, j);
        }

        public void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
                for (int j = i + 1; j < Array.Length; j++)
                    if (Array[i] > Array[j])
                        Swap(Array, i, j);
        }

        public void InsertionSort(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                int current = Array[i];
                int j = i - 1;
                while (j >= 0 && Array[j] > current)
                {
                    Array[j + 1] = Array[j];
                    j--;
                }
                Array[j + 1] = current;
            }
        }

        private void Swap(int[] Array, int i, int j)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }

        public void NameSpaceRequire()
        {
            //System.Xml.Linq linqobj = new System.Xml.Linq();
            List<int> listobj = new List<int>();

            Dictionary<int, string> test = new Dictionary<int, string>();

            int[] t = new int[] { 1, 2, 3, 4, 5 };

            t.Append(3);
            t.Append(1);

            Console.WriteLine(t.Length);
        }
    }
}