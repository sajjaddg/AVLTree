using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
   public class Node
    {
        public int Kay;
        public Node RightChild;
        public Node LeftChild;
        public int Height;
        public Node(int key)
        {
            this.Kay = key;
            Height = 1;
        }
    }
}
