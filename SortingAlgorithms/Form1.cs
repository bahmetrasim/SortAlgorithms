using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        List<List<int>> mini = new List<List<int>>();
        Stopwatch stopwatch = new Stopwatch();
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
            stopwatch.Reset();

            foreach (string nbr in txtNumbers)
            {
                int number = int.Parse(nbr);
                textboxlist.Add(number);
            }
            if (choice == "B")
            {
                bool isswap;
                stopwatch.Start();
                do
                {
                    isswap = false;
                    for (int i = 0; i < textboxlist.Count - 1; i++)
                    {
                        if (textboxlist[i] > textboxlist[i + 1])
                        {
                            swap(textboxlist, i, i + 1);
                            isswap = true;
                        }
                    }
                }
                while (isswap == true);
                stopwatch.Stop();
                time.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            }
            else
            {
                stopwatch.Start();
                textboxlist = tomergesort(dividelist(textboxlist));
                stopwatch.Stop();
                time.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            }
            foreach (var nbrs in textboxlist)
            {
                sortedlist.Text = sortedlist.Text + nbrs + "; ";
            }
            
        }
        public List<int> swap(List<int> tochange, int bigorder, int smallorder)
        {
            int temp = tochange[bigorder];
            tochange[bigorder] = tochange[smallorder];
            tochange[smallorder] = temp;
            return tochange;
        }
        public List<List<int>> dividelist(List<int> todivide)
        {
            int newcount = (todivide.Count / 2) % 2 == 0 ? (todivide.Count / 2) : (todivide.Count / 2)+1;
            
            if (todivide.Count == 1)
            {
                mini.Add(todivide);
                return mini;
            }
            else if (todivide.Count == 2)
            {
                if (todivide[0] > todivide[1])
                {
                    todivide = swap(todivide, 0, 1);
                }
                mini.Add(todivide);
                return mini;
            }
            else
            {

                dividelist(todivide.GetRange(0, newcount));
                dividelist(todivide.GetRange(newcount, todivide.Count-newcount));
                return mini;

            }

        }
        public List<int> tomergesort(List<List<int>> fromdivide)
        {
            List<int> final = new List<int>();
            return final; 
        }

    }
}
