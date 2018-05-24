/*
 * Created by: Jadon F
 * Created on: 24-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Find Max Value
 * This program generates random numbers from 1 to 500 and returns the max value
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getMaxValue(int[] tmpArray)
        {
            int tmpMax = 0;
            int counter;

            for (counter = 0; counter < tmpArray.Length; counter++)
            {
                if(tmpArray[counter] > tmpMax)
                {
                    tmpMax = tmpArray[counter];
                }
            }

            return tmpMax;

            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //clear list
            lstValues.Items.Clear();

            //locals
            const int MAX_ARRAY = 10;
            const int MAX_NUMBER = 500;
            int[] arrayOfValues = new int[MAX_ARRAY];
            int counter, random, maxValue;
            Random rGenerator = new Random();

            //for loop
            for (counter = 0; counter < MAX_ARRAY; counter++)
            {
                random = rGenerator.Next(1, MAX_NUMBER + 1);

                lstValues.Items.Add(random);

                arrayOfValues[counter] = random;
            }

            maxValue = getMaxValue(arrayOfValues);

            //show message
            MessageBox.Show("The max value is " + maxValue, "Max Value");
        }
    }
}
