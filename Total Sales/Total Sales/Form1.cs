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

        private void ReadSales(List<int> salesList)
        { 
        try
            {
                StreamReader inputFile = File.OpenText("Sales2.txt");
                while (!inputFile.EndOfStream)
                {
                    salesList.Add(int.Parse(inputFile.ReadLine()));   
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySales(List<int> salesList)
        {
            foreach (int sale in salesList)
            {
                salesListbox.Items.Add(sale);
            }
        }

        
        private void btnTotal_Click(object sender, EventArgs e)
        {
            

            List<int> salesList = new List<int>();

            ReadSales(salesList);

            int intTotal=0;
            int intCounter;
            double dblAdd;

            for(intCounter = 0; intCounter <=salesListbox.Items.Count -1; intCounter++)
            {
            intTotal+=Convert.ToInt32(salesListbox.Items[intCounter]);
            }

            dblAdd = (double)intTotal;
            txtTotal.Text=string.Format("{0:F}",dblAdd);
         
        }
        
    
    }
}
