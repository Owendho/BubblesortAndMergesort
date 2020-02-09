using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortThisShit
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        List<int> MitArray = new List<int>();

        private int ticks;

        private void btnOne_Click(object sender, EventArgs e)
        {
            timer1.Start();
            



            //fjerner tekst i vores listbox of clear vores array så man ikke behøver at luk programmet hver eneste gang.
            sortedList.Items.Clear();
            MitArray.Clear();
            //int Range; 
            int length = int.Parse(txtBox1.Text);
            int max = int.Parse(txtBox2.Text);
            var rand = new Random();
            //string reset = sortedList.Text;
            //reset = " ";
            //Range.Add(længde);
            //MitArray.AddRange();


            //generer fra 0 til hvad brugeren har valgt.
            for (int i = 0; i < length; i++)

            {
                MitArray.Add(rand.Next(0, max));

            }

            int temp;


            for (int j = 0; j <= MitArray.Count - 2; j++)
            {
                for (int i = 0; i <= MitArray.Count - 2; i++)
                {
                    if (MitArray[i] > MitArray[i + 1])
                    {
                        temp = MitArray[i + 1];
                        MitArray[i + 1] = MitArray[i];
                        MitArray[i] = temp;
                    }
                }
            }

            //printer vores sorted array ud i vores sorted listbox
            for (int p = 0; p < MitArray.Count; p++)
            {
                sortedList.Items.Add(MitArray[p].ToString());
            }

            /*foreach (int p in MitArray)
            {

                sortedList.Items.Add(MitArray[p].ToString());
            }*/




        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            sortedList.Items.Clear();
            MitArray.Clear();
            int length = int.Parse(txtBox1.Text);
            int max = int.Parse(txtBox2.Text);
            var rand = new Random();

            List<int> unsorted = new List<int>();
            List<int> sorted;

            for (int i = 0; i < length; i++)
            {
                unsorted.Add(rand.Next(0, max));
            }

            sorted = Mergesort(unsorted);

            foreach (int item in sorted)
            {
                sortedList.Items.Add(sorted.ToString());

            }

            /*for (int i = 0; i < MitArray.Count / 2; i++)
			{
                

			}
            */


        }


        //kilde til noget af koden: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
        //laver en funktion som bliver kaldt i knappen. Denne funktion er til at splitte numrene op så de kan klive sorteret efter.
        private static List<int> Mergesort(List<int> unsorted)
        {         

            if (unsorted.Count <= 0)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            //Når unsorted bliver divideret med 2 bliver den 5, men når jeg sætter den ind i en int variable, bliver variablen 0. Why?
            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = 0; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);


            }

            left = Mergesort(left);
            right = Mergesort(right);
            return merge(left, right);

        }

        //Mergesort funktionen har splittet alle vores elementer. Nu laver vi en funktion som sortere dem og merger dem.
        private static List<int> merge(List<int> right, List<int> left)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        right.Remove(left.First());


                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());

                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }

            }
            return result;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            txtTimer.Text = ticks.ToString();



        }
    }
}
