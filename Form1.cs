using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIST_7a8_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> list = new List<char>();
        public void Vypis(List<char> list, ListBox l)
        {
            l.Items.Clear();
            foreach (char c in list)
            {
                l.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string znak in textBox1.Lines)
            {
                list.Add(znak[0]);
            }
            Vypis(list, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xy = 0;
            while (xy < list.Count())
            {
                if (list[xy] >= 'a' && list[xy] <= 'z' || list[xy] >= '0' && list[xy] <= '9')
                {
                    list.Remove(list[xy]);
                }
                else
                {
                    xy++;
                }
            }
            Vypis(list, listBox2);
        }
    }
}
