using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        static Image firstimg = Image.FromFile("C:/Users/Uriel/Pictures/mariochido.PNG");
        static Image secimg = Image.FromFile("C:/Users/Uriel/Pictures/luigichido.PNG");
        static Image thirdimg = Image.FromFile("C:/Users/Uriel/Pictures/yoshichido.PNG");
        static Image fourthimg = Image.FromFile("C:/Users/Uriel/Pictures/bowserjrchido.PNG");
        static Image fifthimg = Image.FromFile("C:/Users/Uriel/Pictures/mario8bitschido.PNG");

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
            //Metodo para incrementar el tamaño del FORM a pantalla completa
            WindowState = FormWindowState.Maximized;
            TopMost = true;
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

        static async Task SpinSlots1(bool flag)
        {
            Queue myq = new Queue();
            myq.Enqueue(20);
            myq.Enqueue(30);
            myq.Enqueue(20);
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
            } while (i <= 20);
        }

        static async Task SpinSlots2(bool flag)
        {
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
            } while (i <= 30);
        }

        static async Task SpinSlots3(bool flag)
        {
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
            } while (i <= 60);
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
            SpinSlots1(flag);
            SpinSlots2(flag);
            SpinSlots3(flag);
            do
            {
                i++;
                await Task.Delay(90);

            } while (i < 60);
        }

        public string solution(int amountcoins, int[] coins)//Recibe la cantidad de creditos y el arreglo de las monedas que se requieren
        {
            int i = 0;
            GlobalData.result = "Créditos devueltos: ";
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
            int amountcoins = Int32.Parse(labels[0].Text);//La cantidad de dinero que se le regresara se sacara del label que controla cuantos creditos tiene la maquinas
            List<int> finalcoins = new List<int>();//Se crea una lista para almacenar que tipo de monedas querra el usuario su cambio
            int[] coins = new int[5];//Se declara el arreglo de monedas
            coins[0] = COINS_1;
            coins[1] = COINS_2;
            coins[2] = COINS_5;
            coins[3] = COINS_10;
            coins[4] = COINS_20;
            for (int i =0; i < checkBox.Length; i++)
            {
                if (checkBox[i].Checked)//Si se encuentran en check entraran en el if
                {
                    finalcoins.Add(coins[i]);//Aqui la posicion que haya entrado ahora entrara en la lista
                }
            }
            solution(amountcoins, finalcoins.ToArray());
        }

        public void pantallaCompleta()
        {
            int lx, ly;
            int sw, sh;
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
