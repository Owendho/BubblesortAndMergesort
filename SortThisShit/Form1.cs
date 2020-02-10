using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;


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

            //Laver en timer som skal printe hvor lang tid programmet bruger på kør igennem
            Stopwatch Timer = new Stopwatch();
            Timer.Start();

            //fjerner tekst i vores listbox of clear vores array så man ikke behøver at luk programmet hver eneste gang.
            sortedList.Items.Clear();
            MitArray.Clear();
            //int Range; 
            int length = int.Parse(txtBox1.Text);
            int max = int.Parse(txtBox2.Text);
            var rand = new Random();


            //generer fra 0 til hvad brugeren har valgt.
            for (int i = 0; i < length; i++)

            {
                MitArray.Add(rand.Next(0, max));

            }

            int temp;

            //Bubblesort kode
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

            //printer vores sorted array fra bubblesort ud i vores sorted listbox
            for (int p = 0; p < MitArray.Count; p++)
            {
                sortedList.Items.Add(MitArray[p].ToString());
            }

            //Stopper vores timer.
            Timer.Stop();

            //Sørger for at 
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

        }


        //Start på et forberet mergesort program da det andet ikke virkede. Det andet kode ligger i et github branch
        private static List<int> Mergesort(List<int> unsorted)
        {
            //Laver to lister som skal indeholde de divideret elementer fra unsorted lsit
            int middle;
            List<int> R = new List<int>();
            List<int> L = new List<int>();

            if (R.Count < L.Count)
            {
                middle = (R.Count + L.Count) / 2;



            }

            return unsorted;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
