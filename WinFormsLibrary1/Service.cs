using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
   public class Service : INode
    {
        public Node MakeRoot(int key)
        {
            return new Node(key);
        }
        public int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public int GetHeight(Node current)
        {
            return current == null ? 0 : current.Height;
        }
        public int GetBalance(Node current)
        {
            return current == null ? 0 : (GetHeight(current.LeftChild) - GetHeight(current.RightChild));
        }
        public Node RotateLeft(Node current)
        {
            var y = current.RightChild;
            var T2 = y.LeftChild;
            y.LeftChild = current;
            current.RightChild = T2;
            current.Height = FindMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            y.Height = FindMax(GetHeight(y.LeftChild), GetHeight(y.RightChild)) + 1;
            return y;
        }
        public Node RotateRight(Node current)
        {
            var x = current.LeftChild;
            var T2 = x.RightChild;
            x.RightChild = current;
            current.LeftChild = T2;
            current.Height = FindMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            x.Height = FindMax(GetHeight(x.LeftChild), GetHeight(x.RightChild)) + 1;
            return x;
        }
        public Node Insert(Node current, int key)
        {
            if (current == null)
            {
                return MakeRoot(key);
            }

            if (key < current.Kay)
            {
                current.LeftChild = Insert(current.LeftChild, key);
            }
            else
            {
                current.RightChild = Insert(current.RightChild, key);
            }
            current.Height = FindMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            int balacne = GetBalance(current);
            //left left
            if (balacne > 1 && key < current.LeftChild.Kay)
            {
                return RotateRight(current);
            }
            //right right
            if (balacne < -1 && key > current.RightChild.Kay)
            {
                return RotateLeft(current);
            }
            //left right
            if (balacne > 1 && key > current.LeftChild.Kay)
            {
                current.LeftChild = RotateLeft(current.LeftChild);
                return RotateRight(current);
            }
            //right left
            if (balacne < -1 && key < current.RightChild.Kay)
            {
                current.RightChild = RotateRight(current.RightChild);
                return RotateLeft(current);
            }
            return current;
        }

    }
}
