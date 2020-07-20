using System;
using System.Collections.Generic;
using System.Linq;

namespace MySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortingAlgos();

            //longestUniqueSubstring();

            //NameSpaceRequire();

            //TreeAlogs();

            //FindDupTrees();

            Console.WriteLine(Average(2, 1));
        }

        public static double Average(int a, int b)
        {
            double c = a + b;
            return  (c / 2);
        }

        static void FindDuplicateSubtrees()
        {


        }

        static void NameSpaceRequire()
        {
            MySortingAlgo msa = new MySortingAlgo();
            msa.NameSpaceRequire();
        }

        static void longestUniqueSubstring()
        {
            /*   Longest unique sub string in a given string. */
            string str = "geeksforgeeks";
            int count = StringAlgos.longestUniqueSubstring(str);
            Console.WriteLine(count);
            Console.Read();

        }

        static void SortingAlgos()
        {
            int[] array1 = { 4, 2, 3, 5, 1 };
            MySortingAlgo srt = new MySortingAlgo();
            //srt.BubbleSort(array1);
            //srt.SelectionSort(array1);
            srt.InsertionSort(array1);
            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i]);
        }

        static void FindDupTrees()
        {
            Tree bst = GetBST();

           // var result = TreeExt.FindDuplicateSubtrees(bst);


        }


        static Tree GetBST()
        {
            // //Tree
            Tree bst = new Tree();
            bst.Insert(7);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(1);
            bst.Insert(9);
            bst.Insert(10);
            bst.Insert(18);

            // bst.PrintTree();
            // //bst.PrintHeight();
            // bst.TraverseLevelOrder();
            // Console.WriteLine("Size of tree: " + bst.size());

            return bst;
        }

        static void TreeAlogs()
        {
            // //Tree
            // Tree bst = new Tree();
            // bst.Insert(7);
            // bst.Insert(4);
            // bst.Insert(6);
            // bst.Insert(1);
            // bst.Insert(9);
            // bst.Insert(10);
            // bst.Insert(18);

            // bst.PrintTree();
            // //bst.PrintHeight();
            // bst.TraverseLevelOrder();
            // Console.WriteLine("Size of tree: " + bst.size());

            // Tree bst1 = new Tree();
            // bst1.Insert(7);
            // bst1.Insert(4);
            // bst1.Insert(6);
            // bst1.Insert(1);
            // bst1.Insert(9);
            // bst1.Insert(10);
            // bst1.Insert(8);

            // bst.isEqual(bst1);
        }

    }
}
