﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tragaperras
{
    public partial class btnMoneyinReturned : Form
    {
        public const int COINS_20 = 20;
        public const int COINS_10 = 10;
        public const int COINS_5 = 5;
        public const int COINS_2 = 2;
        public const int COINS_1 = 1;
        public const int COINS_0 = 0;
        public const int WINNERMARIO8BITS = 40;
        public const int WINNERMARIO = 20;
        public const int WINNERLUIGI = 20;
        public const int WINNERYOSHI = 30;
        public const int WINNERBOWSERJR = 10;
        static PictureBox[] boxes = new PictureBox[3];
        static Label[] labels = new Label[1];
        static CheckBox[] checkBox = new CheckBox[5];

        static Image firstimg = Image.FromFile("C:/Users/Usuario/Pictures/mariochido.PNG");
        static Image secimg = Image.FromFile("C:/Users/Usuario/Pictures/luigichido.PNG");
        static Image thirdimg = Image.FromFile("C:/Users/Usuario/Pictures/yoshichido.PNG");
        static Image fourthimg = Image.FromFile("C:/Users/Usuario/Pictures/bowserjrchido.PNG");
        static Image fifthimg = Image.FromFile("C:/Users/Usuario/Pictures/mario8bitschido.PNG");
        static Queue<int> myq = new Queue<int>();

        public btnMoneyinReturned()
        {
            InitializeComponent();
            boxes[0] = pictureBox1;
            boxes[1] = pictureBox2;
            boxes[2] = pictureBox3;
            pictureBox1.Image = firstimg;
            pictureBox2.Image = secimg;
            pictureBox3.Image = thirdimg;
            labels[0] = lblCoins;
            checkBox[0] = this.chbox1;
            checkBox[1] = this.chbox2;
            checkBox[2] = this.chbox5;
            checkBox[3] = this.chbox10;
            checkBox[4] = this.chbox20;
            myq.Enqueue(20);
            myq.Enqueue(30);
            myq.Enqueue(60);
            myq.Enqueue(60);
            myq.Enqueue(30);
            myq.Enqueue(20);
            myq.Enqueue(20);
            myq.Enqueue(30);
            myq.Enqueue(60);
            myq.Enqueue(60);
            myq.Enqueue(30);
            myq.Enqueue(20);
        }

        public static class GlobalData
        {
            public static int totalcoins = 0;
            public static int image = 0;
            public static int solution = 0;//La solucion en monedas, en int
            public static string result = "";//La solucion final en monedas, en string
        }

        private void Btn20coins_Click(object sender, EventArgs e)
        {
            GlobalData.totalcoins = GlobalData.totalcoins + COINS_20;
            this.lblCoins.Text = GlobalData.totalcoins.ToString();
        }

        private void Btn10coins_Click(object sender, EventArgs e)
        {
            GlobalData.totalcoins = GlobalData.totalcoins + COINS_10;
            this.lblCoins.Text = GlobalData.totalcoins.ToString();
        }

        private void Btn5coins_Click(object sender, EventArgs e)
        {
            GlobalData.totalcoins = GlobalData.totalcoins + COINS_5;
            this.lblCoins.Text = GlobalData.totalcoins.ToString();
        }

        private void Btn2coins_Click(object sender, EventArgs e)
        {
            GlobalData.totalcoins = GlobalData.totalcoins + COINS_2;
            this.lblCoins.Text = GlobalData.totalcoins.ToString();
        }

        private void Btn1coins_Click(object sender, EventArgs e)
        {
            GlobalData.totalcoins = GlobalData.totalcoins + COINS_1;
            this.lblCoins.Text = GlobalData.totalcoins.ToString();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (GlobalData.totalcoins >= 7)
            {
                GlobalData.totalcoins = GlobalData.totalcoins - 7;
                labels[0].Text = GlobalData.totalcoins.ToString();
                confirm();
            }
            else
            {
                MessageBox.Show("No hay suficientes créditos");
            }
        }

        private static async void SpinSlots1()
        {
            int espera = myq.Dequeue();
            int i = 0;
            do
            {
                Random rdn = new Random();
                int a = rdn.Next(0, 6);

                if(a == 1)
                {
                    boxes[0].Image = firstimg;
                }
                if (a == 2)
                {
                    boxes[0].Image = secimg;
                }
                if (a == 3)
                {
                    boxes[0].Image = thirdimg;
                }
                if (a == 4)
                {
                    boxes[0].Image = fourthimg;
                }
                if (a == 5)
                {
                    boxes[0].Image = fifthimg;
                }
                i++;
                await Task.Delay(90);
            } while (i <= espera);
        }

        static async void SpinSlots2()
        {
            int espera = myq.Dequeue();
            int i = 0;
            do
            {
                Random rdn = new Random();
                int a = rdn.Next(0, 6);

                if (a == 1)
                {
                    boxes[1].Image = firstimg;
                }
                if (a == 2)
                {
                    boxes[1].Image = secimg;
                }
                if (a == 3)
                {
                    boxes[1].Image = thirdimg;
                }
                if (a == 4)
                {
                    boxes[1].Image = fourthimg;
                }
                if (a == 5)
                {
                    boxes[1].Image = fifthimg;
                }
                i++;
                await Task.Delay(90);
            } while (i <= espera);
        }

        static async void SpinSlots3()
        {
            int espera = myq.Dequeue();
            int i = 0;
            do
            {
                Random rdn = new Random();
                int a = rdn.Next(0, 6);
                if (a == 1)
                {
                    boxes[2].Image = firstimg;
                }
                if (a == 2)
                {
                    boxes[2].Image = secimg;
                }
                if (a == 3)
                {
                    boxes[2].Image = thirdimg;
                }
                if (a == 4)
                {
                    boxes[2].Image = fourthimg;
                }
                if (a == 5)
                {
                    boxes[2].Image = fifthimg;
                }
                i++;
                await Task.Delay(90);
            } while (i <= espera);
        }

        static async void confirm()
        {
            await elmein();
            //boxes[0].Image = firstimg;
            //boxes[1].Image = firstimg;
            //boxes[2].Image = firstimg;
            if (boxes[0].Image == boxes[1].Image && boxes[0].Image == boxes[2].Image)
            {
                if(boxes[0].Image == fifthimg)
                {
                    GlobalData.totalcoins = GlobalData.totalcoins + WINNERMARIO8BITS;
                    MessageBox.Show("WINNER WINNER CHICKEN DINNER");
                }
                else if (boxes[0].Image == firstimg)
                {
                    GlobalData.totalcoins = GlobalData.totalcoins + WINNERMARIO;
                    labels[0].Text = GlobalData.totalcoins.ToString();
                    MessageBox.Show("PREMIO BUENO");
                }
                else if (boxes[0].Image == secimg)
                {
                    GlobalData.totalcoins = GlobalData.totalcoins + WINNERLUIGI;
                    labels[0].Text = GlobalData.totalcoins.ToString();
                    MessageBox.Show("PREMIO BUENO");
                }
                else if (boxes[0].Image == thirdimg)
                {
                    GlobalData.totalcoins = GlobalData.totalcoins + WINNERYOSHI;
                    labels[0].Text = GlobalData.totalcoins.ToString();
                    MessageBox.Show("PREMIO EXCELENTE");
                }
                else if (boxes[0].Image == fourthimg)
                {
                    GlobalData.totalcoins = GlobalData.totalcoins + WINNERBOWSERJR;
                    labels[0].Text = GlobalData.totalcoins.ToString();
                    MessageBox.Show("PREMIO REGULAR");
                }
            }
            else
            {
                MessageBox.Show("¡Suerte para la proxima!");
                boxes[0].Image = firstimg;
                boxes[1].Image = secimg;
                boxes[2].Image = thirdimg;
            }
        }

        static async Task elmein()
        {
            int i = 0;
            bool flag = true;
            Thread spinslot1 = new Thread(SpinSlots1);
            Thread spinslot2 = new Thread(SpinSlots2);
            Thread spinslot3 = new Thread(SpinSlots3);
            spinslot1.Start();
            spinslot2.Start();
            spinslot3.Start();
            do
            {
                i++;
                await Task.Delay(90);

            } while (i < 60);
        }

        public string solution(int amountcoins, int[] coins)
        {
            int i = 0;
            GlobalData.result = "Solucion: ";
            while (GlobalData.solution != amountcoins)
            {
                i = coins.Length - 1;
                while (i >= 0)
                {
                    if (GlobalData.solution + coins[i] <= amountcoins)//Mientras que las soluciones que se encuentran sean menores a la cantidad a dar cambio
                    {
                        GlobalData.solution = GlobalData.solution + coins[i];
                        GlobalData.result += "\n Una moneda de : " + coins[i];
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
            }
            MessageBox.Show(GlobalData.result);
            GlobalData.totalcoins = 0;
            labels[0].Text = GlobalData.totalcoins.ToString();
            GlobalData.result = "";
            GlobalData.solution = 0;
            return amountcoins.ToString();
        }

        private void BtnMoneyReturned_Click(object sender, EventArgs e)
        {
            int amountcoins = Int32.Parse(labels[0].Text);
            List<int> finalcoins = new List<int>();
            int[] coins = new int[5];
            coins[0] = COINS_1;
            coins[1] = COINS_2;
            coins[2] = COINS_5;
            coins[3] = COINS_10;
            coins[4] = COINS_20;
            for (int i =0; i < checkBox.Length; i++)
            {
                if (checkBox[i].Checked)
                {
                    finalcoins.Add(coins[i]);
                }
            }
            solution(amountcoins, finalcoins.ToArray());
        }
    }
}
