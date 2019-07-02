using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshoopapps
{
    public partial class Form1 : Form
    {

        const int size = 100;


        string[] cname = new string[size];
        int[] cno = new int[size];
        string[] add = new string[size];
        string[] oder = new string[size];
        string[] qty = new string[size];
        string[] total = new string[size];


        int index =  1;
        int cindex = 1;
        int aindex = 1;
        int oindex = 1;
        int qindex = 1;
        int tindex = 1;


        int price;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveData_Click(object sender, EventArgs e)
        {
            
            cname[index] = iNputnAme.Text;
            cno[cindex] = Convert.ToInt32(contactNo.Text);
            add[aindex] = address.Text;
            oder[oindex] = order.Text;
            qty[qindex] = quantity.Text;




            if (oder[oindex].Equals("Math"))
            {
                price = 120;

            }
            else if (oder[oindex].Equals("English"))
            {
                price = 100;

            }
            else if (oder[oindex].Equals("Bangla"))
            {
                price = 90;

            }
            else if (oder[oindex].Equals("Art"))
            {
                price = 80;

            }

            total[tindex] = (Convert.ToInt32(qty[qindex]) * price).ToString();


            string message = "";




            for (int vLoop = 0; vLoop < size; vLoop++)


            {


                if (cno[vLoop] != 0)

                   message = message + "\t\t CUSTOMER INFORMATION " + vLoop + "\n------------------------------------------------------------" + "\nCustomer Name\t:" + cname[vLoop].ToString() + "\nContact No\t\t:" + cno[vLoop].ToString() + "\nAddress\t\t\t:" + add[vLoop].ToString() + "\nOrder\t\t\t:" + oder[vLoop].ToString() + "\nQuantity\t\t\t:" + qty[vLoop].ToString() + "\nTotal Amount \t\t:" + total[vLoop].ToString() + "\n";


            }
           richTextBox1.Text = message;

            index++;
            cindex++;
            aindex++;
            oindex++;
            qindex++;
            tindex++;
            // richTextBox1.Text =" \t \t Customer Information "+"\n\n\t-------------------------------------------------" +"\n\n\nName\t\t: \t\t" + customerName.Text +"\nContact No\t:\t\t" + contactNo.Text + "\nAddress\t\t:\t\t" + address.Text + "\nOrder\t\t:\t\t" + order.Text + "\nQuantity\t\t:\t\t" + quantity.Text;

            iNputnAme.Clear();
            contactNo.Clear();
            address.Clear();
            order.ResetText();
            quantity.Clear();

        }
    }
}
