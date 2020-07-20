using System;
using System.Collections.Generic;
using System.Text;

namespace MySorting
{
    public static class TreeExt
    {
        //incomplete
        /*
         * 
    //int t;
    static Dictionary<string, int> trees;
    static Dictionary<int, int> count;
    static List<Tree> ans;

    public static IList<Tree> FindDuplicateSubtrees(Tree root)
    {
        //t = 1;
        trees = new Dictionary<string, int>();
        count = new Dictionary<int, int>();
        ans = new List<Tree>();
        lookup(root.root);
        return ans;

    }

    public static int lookup(Node node)
    {
        if (node == null) return 0;

        string serial = node.value + "," + lookup(node.LeftChild) + "," + lookup(node.RightChild);

        bool uid = trees.TryAdd(serial, t++);
        count.put(uid, count.getOrDefault(uid, 0) + 1);
        if (count.get(uid) == 2)
            ans.add(node);
        return uid;  
       
    }    */
    }
}
