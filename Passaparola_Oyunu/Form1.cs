using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlıs = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text =yanlıs.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "paris")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "rize")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "sarı")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tek")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "vazo")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yeşil")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zürafa")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruno++;
            this.Text=soruno .ToString ();
            textBox1.Clear();
            //this.Text formun sol üst köşesi oluyor

            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyamızın ısı kaynağı?";
                button7.BackColor = Color.Yellow;

            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                button8.BackColor = Color.Yellow;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersi ilidin diğer adı?";
                button10.BackColor = Color.Yellow;

            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluktur?";
                button11.BackColor = Color.Yellow;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi nedir?";
                button12.BackColor = Color.Yellow;

            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Meşhur çiçek festivali?";
                button13.BackColor = Color.Yellow;

            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                button14.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;

            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Fransanın başkenti?";
                button17.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Çayı ile meşhur ilimiz nedir?";
                button18.BackColor = Color.Yellow;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Güneşin rengi nedir?";
                button19.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Çift kelimesinin zıt anlamı?";
                button20.BackColor = Color.Yellow;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit keimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;

            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Çiçeklerin konulduğu eşya?";
                button22.BackColor = Color.Yellow;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Klorofilin çiçeklere hangi rengi verir?";
                button23.BackColor = Color.Yellow;

            }
            if (soruno == 24)
            {
                richTextBox1.Text = "En uzun boylu hayvan hangisidir?";
                button24.BackColor = Color.Yellow;

            }

        }
    }
}
