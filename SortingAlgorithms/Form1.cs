using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls["mergesort"].MouseClick += Buttons_Click;
            Controls["bubblesort"].MouseClick += Buttons_Click;
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button name = (Button)sender;
            string choice = name.Text.Substring(0, 1);
            List<int> textboxlist = new List<int>();
            string[] txtNumbers = textBox1.Text.Split(';');

            foreach (string nbr in txtNumbers)
            {
                int number = int.Parse(nbr);
                textboxlist.Add(number);
            }
            if (choice == "B")
            {

            }
            else
            {

            }
            textboxlist.Sort();
            foreach (var nbrs in textboxlist)
            {
                sortedlist.Text = sortedlist.Text + nbrs + "; ";
            }
        }
       
    }
}
