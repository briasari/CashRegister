using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {

        double pattyPrice = 1.11;
        double baconPrice = 0.16;
        double cheesePrice = 0.13;
        double lettucePrice = 0.07;
        double tomatoPrice = 0.02;
        double ratPrice = 1.11;
        int numOfPatty;
        int numOfBacon;
        int numOfCheese;
        int numOfLettuce;
        int numOfTomato;
        int numOfRat;

        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalPrice;



        public Form1()
        {
            InitializeComponent();


            pattyLabel.Parent = groupBox1;
            baconLabel.Parent = groupBox1;
            lettuceLabel.Parent = groupBox1;
            tomatoLabel.Parent = groupBox1;
            cheeseLabel.Parent = groupBox1;
            calculateButton.Parent = groupBox1;
            tenderedButton.Parent = groupBox1;
            subtotalLabel.Parent = groupBox1;
            totalLabel.Parent = groupBox1;
            taxLabel.Parent = groupBox1;
            subtotalOutput.Parent = groupBox1;
            totalOutput.Parent = groupBox1;


        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfPatty = Convert.ToInt32(pattyInput.Text);
                numOfBacon = Convert.ToInt32(baconInput.Text);
                numOfLettuce = Convert.ToInt32(lettuceInput.Text);
                numOfTomato = Convert.ToInt32(tomatoInput.Text);
                numOfCheese = Convert.ToInt32(cheeseInput.Text);
                //numOfRat = Convert.ToInt32(ratInput.Text);


                subtotal = pattyPrice * numOfPatty + baconPrice * numOfBacon + lettucePrice * numOfLettuce + tomatoPrice * numOfTomato + cheesePrice * numOfCheese + ratPrice * numOfRat;
                taxAmount = taxRate * subtotal;
                totalPrice = subtotal + taxAmount;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalPrice.ToString("C")}";
                //.ToString(".00") to make it two decimals
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = string.Empty;
                totalOutput.Text = string.Empty;
            }

        }

    }
}
