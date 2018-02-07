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
        Stopwatch stopwatch2 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            Controls["mergesort"].MouseClick += Buttons_Click;
            Controls["bubblesort"].MouseClick += Buttons_Click;

        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button name = (Button)sender;
            sortedlist.Text = "";
            mini.Clear();
            string choice = name.Text.Substring(0, 1);
            List<int> textboxlist = new List<int>();
            string[] txtNumbers = textBox1.Text.Split(';');
            stopwatch.Reset();

            foreach (string nbr in txtNumbers)
            {
                int number = int.Parse(nbr);
                textboxlist.Add(number);
            }
            if (choice != "B")
            {
                stopwatch.Start();
                textboxlist = bubble(textboxlist);
                stopwatch.Stop();
                time.Text = stopwatch.Elapsed.ToString();
            }
            else
            {
                stopwatch.Start();
                textboxlist = tomergesort(dividelist(textboxlist));
                stopwatch.Stop();
                time.Text = stopwatch.Elapsed.ToString();
            }
            stopwatch2.Reset();
            stopwatch2.Start();
            foreach (var nbrs in textboxlist)
            {
                sortedlist.Text = sortedlist.Text + nbrs + "; ";
            }
            stopwatch2.Stop();
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
            int newcount = (todivide.Count / 2) % 1 == 0 ? (todivide.Count / 2) : (todivide.Count / 2) + 1;

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
                dividelist(todivide.GetRange(newcount, todivide.Count - newcount));
                return mini;
            }

        }
        public List<int> tomergesort(List<List<int>> fromdivide)
        {
            
            List<List<int>> finallists = new List<List<int>>();
            if (fromdivide.Count == 1)
            {
                return fromdivide[0];
            }
            else
            {
                for (int i = 0; i < fromdivide.Count; i += 2)
                {
                    List<int> final = new List<int>();
                    int n = 0;
                    if (i + 2 > fromdivide.Count)
                    {
                        finallists.Add(fromdivide[i]);
                    }
                    else
                    {
                        for (int j = 0; j < fromdivide[i + 1].Count; j++)
                        {
                            if (fromdivide[i][n] > fromdivide[i + 1][j])
                            {
                                final.Add(fromdivide[i + 1][j]);
                            }
                            else
                            {
                                if (n == fromdivide[i].Count - 1 && final.Count + 1 == fromdivide[i].Count + fromdivide[i + 1].Count)
                                {
                                    final.Add(fromdivide[i][n]);
                                    break;
                                }
                                else if (n == fromdivide[i].Count - 1)
                                {
                                    final.Add(fromdivide[i][n]);
                                    List<int> temp = new List<int>();
                                    temp = fromdivide[i + 1].GetRange(j, fromdivide[i + 1].Count - j);
                                    final.AddRange(temp);
                                    break;
                                }
                                else
                                {
                                    final.Add(fromdivide[i][n]);
                                    n++;
                                    j--;
                                }

                            }
                        }
                        if (final.Count != fromdivide[i].Count + fromdivide[i + 1].Count)
                        {
                            List<int> temp = new List<int>();
                            temp = fromdivide[i].GetRange(n, fromdivide[i].Count - n);
                            final.AddRange(temp);
                        }
                        finallists.Add(final);
                    }
                }
                return tomergesort(finallists);
            }
        }
        public List<int> bubble (List<int> textbox)
        {
            bool isswap;
            do
            {
                isswap = false;
                for (int i = 0; i < textbox.Count - 1; i++)
                {
                    if (textbox[i] > textbox[i + 1])
                    {
                        swap(textbox, i, i + 1);
                        isswap = true;
                    }
                }
            }
            while (isswap == true);
            return textbox;
        }
    }
}
