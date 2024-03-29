﻿using System;
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

//currently no reprecussion for getting order wrong
//rat hasn't been added yet

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

        Random randGen = new Random();
        int patty1Num;
        int bacon1Num;
        int cheese1Num;
        int lettuce1Num;
        int tomato1Num;
        int rat1Num;

        public Form1()
        {

            InitializeComponent();

            //telling program that [item]1num = random number between 1 and 20
            patty1Num = randGen.Next(1, 20);
            bacon1Num = randGen.Next(1, 20);
            cheese1Num = randGen.Next(1, 20);
            lettuce1Num = randGen.Next(1, 20);
            tomato1Num = randGen.Next(1, 20);
            rat1Num = randGen.Next(1, 20);

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

            //hiding receipt (couldn't click it so i just did it in code)
            receiptTextLabel.Parent = receiptGroupBox;
            receiptGroupBox.Visible = false;

            //disabled other buttons
            tenderedButton.Enabled = false;
            takeOrderButton.Enabled = false;
            receiptButton.Enabled = false;
            resetButton.Enabled = false;
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
                //.ToString(".00") to make it two decimals; "C" for currency of whatever country user is in

                tenderedButton.Enabled = true;

            }

            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = string.Empty;
                totalOutput.Text = string.Empty;
            }

            resetButton.Enabled = true;

        }

        private async void tenderedButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedAmount = Convert.ToInt32(tenderedInput.Text);
                changeAmount = tenderedAmount - totalPrice;
                if (changeAmount >= 0)
                {
                    tenderedOutput.Text = $"{changeAmount.ToString("C")}";
                }
                else
                {
                    tenderedOutput.Text = "ERROR";

                }
            }
            catch
            {
                //else statement took over for this
                tenderedOutput.Text = "ERROR";
            }

            receiptButton.Enabled = true;

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            takeOrderButton.Enabled = true;

            //change first number(colour intensity)
            //startButton.BackColor = Color.FromArgb(225, 255, 255, 255);
            //Thread.Sleep(100);

            Opacity = 0.9;
            Thread.Sleep(100);
            Opacity = 0.8;
            Thread.Sleep(100);
            Opacity = 0.7;
            Thread.Sleep(100);
            Opacity = 0.6;
            Thread.Sleep(100);
            Opacity = 0.5;
            Thread.Sleep(100);
            Opacity = 0.4;
            Thread.Sleep(100);
            Opacity = 0.3;
            Thread.Sleep(100);
            Opacity = 0.2;
            Thread.Sleep(100);
            Opacity = 0.1;
            Thread.Sleep(100);
            Opacity = 0.0;
            Thread.Sleep(100);
            startButton.Visible = false;
            startButton.Text = "";
            Opacity = 0.0;
            Thread.Sleep(100);
            Opacity = 0.1;
            Thread.Sleep(100);
            Opacity = 0.2;
            Thread.Sleep(100);
            Opacity = 0.3;
            Thread.Sleep(100);
            Opacity = 0.4;
            Thread.Sleep(100);
            Opacity = 0.5;
            Thread.Sleep(100);
            Opacity = 0.6;
            Thread.Sleep(100);
            Opacity = 0.7;
            Thread.Sleep(100);
            Opacity = 0.8;
            Thread.Sleep(100);
            Opacity = 0.9;
            Thread.Sleep(100);
            Opacity = 0.95;
            Thread.Sleep(100);
            Opacity = 1.0;
            Thread.Sleep(100);

            Thread.Sleep(2000);

            //first customer appears
            Opacity = 0.9;
            Thread.Sleep(50);
            Opacity = 0.8;
            Thread.Sleep(50);
            Opacity = 0.7;
            Thread.Sleep(50);
            Opacity = 0.6;
            Thread.Sleep(50);
            Opacity = 0.5;
            Thread.Sleep(50);
            Opacity = 0.4;
            Thread.Sleep(50);
            Opacity = 0.3;
            Thread.Sleep(50);
            Opacity = 0.2;
            Thread.Sleep(50);
            Opacity = 0.1;
            Thread.Sleep(50);
            Opacity = 0.0;
            Thread.Sleep(50);
            customer1.Visible = true;
            customer1Speech.Visible = true;
            Opacity = 0.0;
            Thread.Sleep(110);
            Opacity = 0.1;
            Thread.Sleep(50);
            Opacity = 0.2;
            Thread.Sleep(50);
            Opacity = 0.3;
            Thread.Sleep(50);
            Opacity = 0.4;
            Thread.Sleep(50);
            Opacity = 0.5;
            Thread.Sleep(50);
            Opacity = 0.6;
            Thread.Sleep(50);
            Opacity = 0.7;
            Thread.Sleep(50);
            Opacity = 0.8;
            Thread.Sleep(50);
            Opacity = 0.9;
            Thread.Sleep(50);
            Opacity = 0.95;
            Thread.Sleep(50);
            Opacity = 1.0;
            Thread.Sleep(10);
        }


        private void newOrderButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            receiptGroupBox.Visible = false;
            //cash groupbox visible, receipt groupbox hidden

            tenderedOutput.Text = "";
            tenderedInput.Text = "";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            pattyInput.Text = "";
            lettuceInput.Text = "";
            tomatoInput.Text = "";
            cheeseInput.Text = "";
            baconInput.Text = "";
            //clearing text boxes

            //disabled other buttons
            tenderedButton.Enabled = false;
            takeOrderButton.Enabled = false;
            receiptButton.Enabled = false;
            resetButton.Enabled = false;

            int numOfPatty;
            int numOfBacon;
            int numOfCheese;
            int numOfLettuce;
            int numOfTomato;
        }

        private void takeOrderButton_Click(object sender, EventArgs e)
        {
            string text = $"give me {patty1Num}x patty, {bacon1Num}x bacon, {lettuce1Num}x lettuce, {cheese1Num}x cheese, and {tomato1Num}x tomato";
            customer1Speech.Text = "";

            foreach (char c in text)
            {
                customer1Speech.Text += c;
                Thread.Sleep(50);
                customer1Speech.Refresh();
            }
        }
         
        private void receiptButton_Click(object sender, EventArgs e)
        {
            if (tenderedAmount <= totalPrice)
            {
                tenderedInput.Text = "not enough";
            }
            else
            {
                groupBox1.Visible = false;
                tenderedOutput.Visible = false;
                receiptGroupBox.Visible = true;
                receiptTextLabel.Visible = true;
                Refresh();

                SoundPlayer print = new SoundPlayer(Properties.Resources.print);
                print.Play();
                print.Play();
                //made soundplayer, played sound twice because it wasn't long enough (could've found a longer audio clip)

                string receipt = $"\n\nhappy burger\ni'm lovin' it (more)\n\n\n\n#product\n{patty1Num}                      {pattyPrice * numOfPatty}\n{bacon1Num}                      {baconPrice * numOfBacon}\n{lettuce1Num}                       {lettucePrice * numOfLettuce}\n{cheese1Num}                       {cheesePrice * numOfCheese}\n{tomato1Num}                      {tomatoPrice * numOfTomato}";

                foreach (char c in receipt)
                {
                    receiptTextLabel.Text += c;
                    Thread.Sleep(50);
                    receiptTextLabel.Refresh();
                }

            }
        }
    }
}
