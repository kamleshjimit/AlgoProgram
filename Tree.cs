using System;
using System.Collections;

namespace MySorting
{
    public class Node
    {
        public int value;
        public Node LeftChild;
        public Node RightChild;

        public Node(int value)
        {
            this.value = value;
        }

        public override String ToString()
        {
            return "Node =" + value;
        }
    }

    public class Tree
    {
       
        public Node root;

        public void Insert(int value)
        {
            var node = new Node(value);
            if (root == null)
            {
                root = node;
                return;
            }

            Node current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        break;
                    }

                    current = current.RightChild;
                }

            }

        }
        public void PrintTree()
        {
            TraversePreOrder(this.root);
        }
        private void TraversePreOrder(Node current)
        {
            if (current == null)
                return;
            Console.Write(" " + current.value);
            TraversePreOrder(current.LeftChild);
            TraversePreOrder(current.RightChild);

        }
        private bool isLeaf(Node current)
        {
            return (current.LeftChild == null && current.RightChild == null);
        }
        public void PrintHeight()
        {
            Console.WriteLine("\n Tree Height: " + FindHeight(root));
        }

        private int FindHeight(Node current)
        {
            if (isLeaf(current))
                return 0;

            return 1 + Math.Max(FindHeight(current.LeftChild), FindHeight(current.RightChild));
        }

        public void PrintMinValue()
        {
            Console.WriteLine("\n Tree minValue : " + MinValue(root));
        }
        private int MinValue(Node current)
        {
            if (isLeaf(current))
                return current.value;

            return Math.Min(MinValue(current.LeftChild), MinValue(current.RightChild));
        }

        public void isEqual(Tree second)
        {
            Tree first = this;

            Console.WriteLine("Is Equal :- " + isEqual(first.root, second.root));
        }

        private bool isEqual(Node first, Node second)
        {
            if (first == null && second == null)
                return true;
            if ((first != null && second != null))
            {
                return first.value == second.value && (isEqual(first.LeftChild, second.LeftChild)
                && isEqual(first.RightChild, second.RightChild));
            }
            return false;
        }


        /// Level order traverser using queue
        public void TraverseLevelOrder()
        {
            Queue t = new Queue();

            TraverseLevelOrder(root, t);

        }

        private void TraverseLevelOrder(Node root, Queue t)
        {
            t.Enqueue(root);

            Node current = (Node)t.Dequeue();
            Console.WriteLine("Traverse Level Order");
            while (current != null)
            {
                Console.WriteLine(current.value);

                if (current.LeftChild != null)
                    t.Enqueue(current.LeftChild);
                if (current.RightChild != null)
                    t.Enqueue(current.RightChild);

                if (t.Count > 0)
                    current = (Node)t.Dequeue();
                else
                    current = null;
            }
            return;
        }

        public int size()
        {
            return size(root);
        }

        private int size(Node root)
        {
            if (root == null)
                return 0;

            if (isLeaf(root))
                return 1;

            return 1 + size(root.LeftChild) + size(root.RightChild);
        }

      

    }
}