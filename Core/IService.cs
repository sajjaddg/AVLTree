using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public interface IService
    {
        Node MakeRoot(int key);
        int FindMax(int a, int b);
        int GetHeight(Node current);
        int GetBalance(Node current);
        Node RotateLeft(Node current);
        Node RotateRight(Node current);
        Node Insert(Node current, int key);
    }
}
