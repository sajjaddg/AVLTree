using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
   public interface INode
    {
        public Node MakeRoot(int key);
        public int FindMax(int a, int b);
        public int GetHeight(Node current);
        public int GetBalance(Node current);
        public Node RotateLeft(Node current);
        public Node RotateRight(Node current);
        public Node Insert(Node current, int key);
    }
}
