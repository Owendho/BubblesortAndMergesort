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
using System.Diagnostics;

namespace SortThisShit
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        List<int> MitArray = new List<int>();

        private void btnOne_Click(object sender, EventArgs e)
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            

            
            //Fjerner tekst i vores listbox of clear vores array så man ikke behøver at luk programmet hver eneste gang.
            sortedList.Items.Clear();
            MitArray.Clear();
            //int Range; 
            int length = int.Parse(txtBox1.Text);
            int max = int.Parse(txtBox2.Text);
            var rand = new Random();

            //Generer fra 0 til hvad brugeren har valgt.
            for (int i = 0; i < length; i++)

            {
                MitArray.Add(rand.Next(0, max));

            }

            int temp;

            //vores bubblesort. 
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


           Timer.Stop();
           txtTimer.Text = Timer.ElapsedMilliseconds.ToString(); 

           
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

            //sorted = Mergesort(unsorted);

            /*foreach (int item in sorted)
            {
                sortedList.Items.Add(sorted.ToString());

            }*/




        }


        //laver en funktion som bliver kaldt i knappen. Denne funktion er til at splitte numrene op så de kan klive sorteret efter.


        //Laver en funktion som deler vores elementer op
        private static List<int> Mergesort(List<int> unsorted)
        {
            int middle;
            List<int> R = new List<int>();
            List<int> L = new List<int>();

            if(R.Count < L.Count)
            {
                middle = (R.Count + L.Count) / 2;



            }




            return unsorted;
        }


        private static List<int> Merge(List<int> R, List<int> L)
        {


            return R;

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {


        }


    }

}
