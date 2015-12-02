using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            ////////////// The code you sent me /////////////////////////////
                //try
                //{
                //    int number1, number2, number3, number4, number5, number6, number7, total;
                //    StreamReader inputFile;
                //    inputFile = File.OpenText("Sales.txt");

                //    number1 = int.Parse(inputFile.ReadLine());
                //    number2 = int.Parse(inputFile.ReadLine());
                //    number3 = int.Parse(inputFile.ReadLine());
                //    number4 = int.Parse(inputFile.ReadLine());
                //    number5 = int.Parse(inputFile.ReadLine());
                //    number6 = int.Parse(inputFile.ReadLine());
                //    number7 = int.Parse(inputFile.ReadLine());

                //    total = number1 + number2 + number3 + number4 + number5 + number6 + number7;

                //    MessageBox.Show("The total is " + total);

                //    inputFile.Close();
                //}
                //catch (Exception ex)
                //{
                    
                //}

            ////////////// My code to do the same thing /////////////////////

            //---------------------------------------------------------------------------
            //1) Declare & create variables
            const int SIZE = 20;
            StreamReader InputFile;    //to access text file
            decimal[] sales = new decimal[SIZE];            //decimal is best for money
            int index = 0;
            decimal temp;
            decimal total = 0;

            //---------------------------------------------------------------------------
            //2) Open & read numeric strings from text file into array
            //      This file must be in folder TotalSales/TotalSales/bin/debug
            //      (The copy you had there was corrupted.)
            //      This must be done in a try block in case the file does not
            //          exist or does not open correctly or is in the wrong format, etc.
            try
            {
                InputFile = File.OpenText("sales.txt"); //open file

                index = 0;                              //set index to first subscript
                while (!InputFile.EndOfStream && index < SIZE)          //loop until done
                {
                    temp = decimal.Parse(InputFile.ReadLine()); //get next num 
                    
                    sales[index] = temp;
                    index++;                                            //increment counter
                }

                InputFile.Close();  //close the file

                // Display array contents in list box on Form1
                foreach( decimal d in sales)
                {
                    salesListbox.Items.Add(d);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        //display the message for the exception
            }                                       //that happened so that we used the catch

            //---------------------------------------------------------------------------
            // Determine wether to continue processing
            // Alternatively, this whole section could be included in the try
            // block above without the "IF".

            if (index == 0) //if index is zero, no items were successfully read
            {
                MessageBox.Show("No items read, either an error occurred or file is empty.");
            }
            else
            {
                //3) Find the total of the numbers in sales array
                total = 0;
                foreach (decimal d in sales)
                {
                    total += d;
                }

                //4) Display total on Form1
                txtTotal.Text = total.ToString();

                //5) Fin the average, minimum and maximum & display on Form1

                //6) Either:
                //      sort the array, see example in text
                //   OR
                //      copy the contents of sales into a List<decimal> salesList
                //      then call the sort ...  salesList.Sort();
                //      then copy the items in the list into the list box for output

                //7) Display the sorted list in the list box on Form1
            }
        }
    }
}
