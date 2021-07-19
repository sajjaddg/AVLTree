using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Tree
{
    public partial class Form1 : Form
    {
        public Node root { get; set; }
        public Color nodeColor;
        public Color lineColor;
        private int x, y, size;
        public IService Service { get; set; }
        public Form1()
        {
            nodeColor = Color.Black;
            lineColor = Color.Blue;
            x = 476;
            y = 30;
            size = 23;
            Service = new Service();
            InitializeComponent();
        }

        private void NewTreeButton_Click(object sender, EventArgs e)
        {
            root = null;
            ShowPanel.Refresh();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Do();
        }

        private void Do()
        {
            try
            {
                Add(int.Parse(TBNumber.Text));
                TBNumber.Text = String.Empty;
                ShowPanel.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void Add(int value)
        {
            if (root != null)
            {
                root = Service.Insert(root, value);
            }
            else
            {
                root = Service.MakeRoot(value);
            }
        }

        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RefreshAVLTreeHelper(x, y, root, g, 150);
        }

        private void TBNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Do();
            }
        }
        private void RefreshAVLTreeHelper(int x, int y, Node aux, Graphics g, int factor)
        {
            Pen nodePen = new Pen(nodeColor);
            Pen linePen = new Pen(lineColor);
            if (aux == null)
                return;
            else
            {
                string value = aux.Kay.ToString();
                Font font = new Font("Arial", 8);
                SolidBrush solidbrush = new SolidBrush(nodeColor);

                g.DrawEllipse(nodePen, x, y, size, size);
                g.DrawString(value, font, solidbrush, x, y - size);

                RefreshAVLTreeHelper(x - factor, y + 30, aux.LeftChild, g, factor / 2);
                RefreshAVLTreeHelper(x + factor, y + 30, aux.RightChild, g, factor / 2);
                if (aux.LeftChild != null)
                    g.DrawLine(linePen, x + 7, y + size, x - factor + 7, y + 30);
                if (aux.RightChild != null)
                    g.DrawLine(linePen, x + 7, y + size, x + factor + 7, y + 30);
            }
        }
    }
}
