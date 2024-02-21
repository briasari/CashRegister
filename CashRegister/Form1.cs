using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //required to commands like Thread.Sleep();
using System.Media; //required to use media in properties (audio, etc.)

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //public/shared variables

        //setting price of objects
        double pattyPrice = 1.11;
        double baconPrice = 0.16;
        double cheesePrice = 0.13;
        double lettucePrice = 0.07;
        double tomatoPrice = 0.02;
        double ratPrice = 1.11;

        //turning # of objects into int
        int numOfPatty;
        int numOfBacon;
        int numOfCheese;
        int numOfLettuce;
        int numOfTomato;
        int numOfRat;

        //setting tax rate, creaing double variables
        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalPrice;
        double tenderedAmount;
        double changeAmount;



        public Form1()
        {
            InitializeComponent();

            //parenting register interface to groupbox (all put on group box)
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

        private async void tenderedButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedAmount = Convert.ToInt32(tenderedInput.Text);
                changeAmount = tenderedAmount - totalPrice;
                tenderedOutput.Text = $"{changeAmount.ToString("C")}";
            }
            catch
            {
                tenderedOutput.Text = "ERROR";
            }

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            //change first number (colour intensity)
            startButton.BackColor = Color.FromArgb(225, 255, 255, 255);



            //Opacity = 0.9;
            //Thread.Sleep(100);
            //Opacity = 0.8;
            //Thread.Sleep(100);
            //Opacity = 0.7;
            //Thread.Sleep(100);
            //Opacity = 0.6;
            //Thread.Sleep(100);
            //Opacity = 0.5;
            //Thread.Sleep(100);
            //Opacity = 0.4;
            //Thread.Sleep(100);
            //Opacity = 0.3;
            //Thread.Sleep(100);
            //Opacity = 0.2;
            //Thread.Sleep(100);
            //Opacity = 0.1;
            //Thread.Sleep(100);
            //Opacity = 0.0;
            //Thread.Sleep(100);
            //startButton.Visible = false;
            //Opacity = 0.0;
            //Thread.Sleep(100);
            //Opacity = 0.1;
            //Thread.Sleep(100);
            //Opacity = 0.2;
            //Thread.Sleep(100);
            //Opacity = 0.3;
            //Thread.Sleep(100);
            //Opacity = 0.4;
            //Thread.Sleep(100);
            //Opacity = 0.5;
            //Thread.Sleep(100);
            //Opacity = 0.6;
            //Thread.Sleep(100);
            //Opacity = 0.7;
            //Thread.Sleep(100);
            //Opacity = 0.8;
            //Thread.Sleep(100);
            //Opacity = 0.9;
            //Thread.Sleep(100);
            //Opacity = 1.0;
            //Thread.Sleep(100);

        }
    }
}
