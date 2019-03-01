using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    public partial class SayiOyunu : Form
    {
        public SayiOyunu()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void RENK()
        { 
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
        }
        private void RENK1()
        {
            button1.BackColor = Color.RoyalBlue;
            button2.BackColor = Color.RoyalBlue;
            button3.BackColor = Color.RoyalBlue;
            button4.BackColor = Color.RoyalBlue;
            button5.BackColor = Color.RoyalBlue;
            button6.BackColor = Color.RoyalBlue;
            button7.BackColor = Color.RoyalBlue;
            button8.BackColor = Color.RoyalBlue;
            button9.BackColor = Color.RoyalBlue;
            button10.BackColor = Color.RoyalBlue;
            button11.BackColor = Color.RoyalBlue;
            button12.BackColor = Color.RoyalBlue;
            button13.BackColor = Color.RoyalBlue;
            button14.BackColor = Color.RoyalBlue;
            button15.BackColor = Color.RoyalBlue;
            button16.BackColor = Color.RoyalBlue;
            button17.BackColor = Color.RoyalBlue;
            button18.BackColor = Color.RoyalBlue;
            button19.BackColor = Color.RoyalBlue;
            button20.BackColor = Color.RoyalBlue;
            button21.BackColor = Color.RoyalBlue;
            button22.BackColor = Color.RoyalBlue;
            button23.BackColor = Color.RoyalBlue;
            button24.BackColor = Color.RoyalBlue;
            button25.BackColor = Color.RoyalBlue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(sayac == 0) { RENK1(); }
            if (button1.Text == "" && button1.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button1.Text = sayac.ToString();
                if (button8.Text == "")
                { button8.BackColor = Color.RoyalBlue; }
                if (button12.Text == "")
                { button12.BackColor = Color.RoyalBlue; }
                if ((button8.Text != "") && (button12.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button2.Text == "" && button2.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button2.Text = sayac.ToString();
                if (button9.Text == "")
                { button9.BackColor = Color.RoyalBlue; }
                if (button11.Text == "")
                { button11.BackColor = Color.RoyalBlue; }
                if (button13.Text == "")
                { button13.BackColor = Color.RoyalBlue; }
                if ((button9.Text != "") && (button11.Text != "") && (button13.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button3.Text == "" && button3.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button3.Text = sayac.ToString();
                if (button6.Text == "")
                    { button6.BackColor = Color.RoyalBlue; }
                    if (button10.Text == "")
                    { button10.BackColor = Color.RoyalBlue; }
                    if (button12.Text == "")
                    { button12.BackColor = Color.RoyalBlue; }
                    if (button14.Text == "")
                    { button14.BackColor = Color.RoyalBlue; }
                    if ((button6.Text != "") && (button10.Text != "") && (button12.Text != "") && (button14.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button4.Text == "" && button4.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button4.Text = sayac.ToString();
                if (button7.Text == "")
                { button7.BackColor = Color.RoyalBlue; }
                if (button13.Text == "")
                { button13.BackColor = Color.RoyalBlue; }
                if (button15.Text == "")
                { button15.BackColor = Color.RoyalBlue; }
                if ((button7.Text != "") && (button13.Text != "") && (button15.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button5.Text == "" && button5.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button5.Text = sayac.ToString();
                if (button8.Text == "")
                { button8.BackColor = Color.RoyalBlue; }
                if (button14.Text == "")
                { button14.BackColor = Color.RoyalBlue; }
                if ((button8.Text != "") && (button14.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button6.Text == "" && button6.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button6.Text = sayac.ToString();
                if (button3.Text == "")
                { button3.BackColor = Color.RoyalBlue; }
                if (button13.Text == "")
                { button13.BackColor = Color.RoyalBlue; }
                if (button17.Text == "")
                { button17.BackColor = Color.RoyalBlue; }
                if ((button3.Text != "") && (button13.Text != "") && (button17.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button7.Text == "" && button7.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button7.Text = sayac.ToString();
                if (button4.Text == "")
                { button4.BackColor = Color.RoyalBlue; }
                if (button14.Text == "")
                { button14.BackColor = Color.RoyalBlue; }
                if (button16.Text == "")
                { button16.BackColor = Color.RoyalBlue; }
                if (button18.Text == "")
                { button18.BackColor = Color.RoyalBlue; }
                if ((button4.Text != "") && (button14.Text != "") && (button16.Text != "") && (button18.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button8.Text == "" && button8.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button8.Text = sayac.ToString();
                if (button1.Text == "")
                { button1.BackColor = Color.RoyalBlue; }
                if (button5.Text == "")
                { button5.BackColor = Color.RoyalBlue; }
                if (button11.Text == "")
                { button11.BackColor = Color.RoyalBlue; }
                if (button15.Text == "")
                { button15.BackColor = Color.RoyalBlue; }
                if(button17.Text == "")
                { button17.BackColor = Color.RoyalBlue; }
                if(button19.Text == "")
                { button19.BackColor = Color.RoyalBlue; }
                if ((button1.Text != "") && (button5.Text != "") && (button11.Text != "") && (button15.Text != "") && (button17.Text != "") && (button19.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button9.Text == "" && button9.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button9.Text = sayac.ToString();
                if (button2.Text == "")
                { button2.BackColor = Color.RoyalBlue; }
                if (button12.Text == "")
                { button12.BackColor = Color.RoyalBlue; }
                if (button18.Text == "")
                { button18.BackColor = Color.RoyalBlue; }
                if (button20.Text == "")
                { button20.BackColor = Color.RoyalBlue; }
                if ((button2.Text != "") && (button12.Text != "") && (button18.Text != "") && (button20.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button10.Text == "" && button10.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button10.Text = sayac.ToString();
                if (button3.Text == "")
                { button3.BackColor = Color.RoyalBlue; }
                if (button13.Text == "")
                { button13.BackColor = Color.RoyalBlue; }
                if (button19.Text == "")
                { button19.BackColor = Color.RoyalBlue; }
                if ((button3.Text != "") && (button13.Text != "") && (button19.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button11.Text == "" && button11.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button11.Text = sayac.ToString();
                if (button2.Text == "")
                    { button2.BackColor = Color.RoyalBlue; }
                    if (button8.Text == "")
                    { button8.BackColor = Color.RoyalBlue; }
                    if (button18.Text == "")
                    { button18.BackColor = Color.RoyalBlue; }
                    if (button22.Text == "")
                    { button22.BackColor = Color.RoyalBlue; }
                    if ((button2.Text != "") && (button8.Text != "") && (button18.Text != "") && (button22.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button12.Text == "" && button12.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button12.Text = sayac.ToString();
                    if (button1.Text == "")
                    { button1.BackColor = Color.RoyalBlue; }
                    if (button3.Text == "")
                    { button3.BackColor = Color.RoyalBlue; }
                    if(button9.Text == "")
                    { button9.BackColor = Color.RoyalBlue; }
                    if (button19.Text == "")
                    { button19.BackColor = Color.RoyalBlue; }
                    if (button21.Text == "")
                    { button21.BackColor = Color.RoyalBlue; }
                    if (button23.Text == "")
                    { button23.BackColor = Color.RoyalBlue; }
                    if ((button1.Text != "") && (button3.Text != "") && (button9.Text != "") && (button19.Text != "") && (button21.Text != "") && (button23.Text !=""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button13.Text == "" && button13.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button13.Text = sayac.ToString();
                    if (button2.Text == "")
                    { button2.BackColor = Color.RoyalBlue; }
                    if (button4.Text == "")
                    { button4.BackColor = Color.RoyalBlue; }
                    if (button6.Text == "")
                    { button6.BackColor = Color.RoyalBlue; }
                    if (button10.Text == "")
                    { button10.BackColor = Color.RoyalBlue; }
                    if(button16.Text == "")
                    { button16.BackColor = Color.RoyalBlue; }
                    if(button20.Text=="")
                    { button20.BackColor = Color.RoyalBlue; }
                    if(button22.Text=="")
                    { button22.BackColor = Color.RoyalBlue; }
                    if(button24.Text=="")
                    { button24.BackColor = Color.RoyalBlue; }
                    if ((button2.Text != "") && (button4.Text != "") && (button6.Text != "") && (button10.Text != "")&&(button16.Text !="")&&(button20.Text!="")&&(button22.Text!="")&&(button24.Text!=""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button14.Text == "" && button14.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button14.Text = sayac.ToString();
                    if (button3.Text == "")
                    { button3.BackColor = Color.RoyalBlue; }
                    if (button5.Text == "")
                    { button5.BackColor = Color.RoyalBlue; }
                    if(button7.Text == "")
                    { button7.BackColor = Color.RoyalBlue; }
                    if (button17.Text == "")
                    { button17.BackColor = Color.RoyalBlue; }
                    if (button23.Text == "")
                    { button23.BackColor = Color.RoyalBlue; }
                    if(button25.Text == "")
                    { button25.BackColor = Color.RoyalBlue; }
                    if ((button3.Text != "") && (button5.Text != "") && (button7.Text != "") && (button17.Text != "") && (button23.Text != "") &&(button25.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button15.Text == "" && button15.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button15.Text = sayac.ToString();
                    if (button4.Text == "")
                    { button4.BackColor = Color.RoyalBlue; }
                    if (button8.Text == "")
                    { button8.BackColor = Color.RoyalBlue; }
                    if (button18.Text == "")
                    { button18.BackColor = Color.RoyalBlue; }
                    if (button24.Text == "")
                    { button24.BackColor = Color.RoyalBlue; }
                    if ((button4.Text != "") && (button8.Text != "") && (button18.Text != "") && (button24.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button16.Text == "" && button16.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button16.Text = sayac.ToString();
                    if (button7.Text == "")
                    { button7.BackColor = Color.RoyalBlue; }
                    if (button13.Text == "")
                    { button13.BackColor = Color.RoyalBlue; }
                    if (button23.Text == "")
                    { button23.BackColor = Color.RoyalBlue; }
                    if ((button7.Text != "") && (button13.Text != "") && (button23.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button17.Text == "" && button17.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button17.Text = sayac.ToString();
                    if (button6.Text == "")
                    { button6.BackColor = Color.RoyalBlue; }
                    if (button8.Text == "")
                    { button8.BackColor = Color.RoyalBlue; }
                    if (button14.Text == "")
                    { button14.BackColor = Color.RoyalBlue; }
                    if (button24.Text == "")
                    { button24.BackColor = Color.RoyalBlue; }
                    if ((button6.Text != "") && (button8.Text != "") && (button14.Text != "") && (button24.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button18.Text == "" && button18.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button18.Text = sayac.ToString();
                    if (button7.Text == "")
                    { button7.BackColor = Color.RoyalBlue; }
                    if (button9.Text == "")
                    { button9.BackColor = Color.RoyalBlue; }
                    if (button11.Text == "")
                    { button11.BackColor = Color.RoyalBlue; }
                    if (button15.Text == "")
                    { button15.BackColor = Color.RoyalBlue; }
                    if(button21.Text == "")
                    {button21.BackColor = Color.RoyalBlue;}
                    if(button25.Text == "")
                    { button25.BackColor = Color.RoyalBlue; }
                    if ((button7.Text != "") && (button9.Text != "") && (button11.Text != "") && (button15.Text != "") && (button21.Text != "") && (button25.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button19.Text == "" && button19.BackColor == Color.RoyalBlue)
            {
                sayac++;
                RENK();
                button19.Text = sayac.ToString();
                if (button8.Text == "")
                { button8.BackColor = Color.RoyalBlue; }
                if (button10.Text == "")
                { button10.BackColor = Color.RoyalBlue; }
                if (button12.Text == "")
                { button12.BackColor = Color.RoyalBlue; }
                if (button22.Text == "")
                { button22.BackColor = Color.RoyalBlue; }
                if ((button8.Text != "") && (button10.Text != "") && (button12.Text != "") && (button22.Text != ""))
                {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
            else
                MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button20.Text == "" && button20.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button20.Text = sayac.ToString();
                    if (button9.Text == "")
                    { button9.BackColor = Color.RoyalBlue; }
                    if (button13.Text == "")
                    { button13.BackColor = Color.RoyalBlue; }
                    if (button23.Text == "")
                    { button23.BackColor = Color.RoyalBlue; }
                    if ((button9.Text != "") && (button13.Text != "") && (button23.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button21.Text == "" && button21.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button21.Text = sayac.ToString();
                    if (button12.Text == "")
                    { button12.BackColor = Color.RoyalBlue; }
                    if (button18.Text == "")
                    { button18.BackColor = Color.RoyalBlue; }
                    if ((button12.Text != "") && (button18.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button22.Text == "" && button22.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button22.Text = sayac.ToString();
                    if (button11.Text == "")
                    { button11.BackColor = Color.RoyalBlue; }
                    if (button13.Text == "")
                    { button13.BackColor = Color.RoyalBlue; }
                    if (button19.Text == "")
                    { button19.BackColor = Color.RoyalBlue; }
                    if ((button11.Text != "") && (button13.Text != "") && (button19.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button23.Text == "" && button23.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button23.Text = sayac.ToString();
                    if (button12.Text == "")
                    { button12.BackColor = Color.RoyalBlue; }
                    if (button14.Text == "")
                    { button14.BackColor = Color.RoyalBlue; }
                    if (button16.Text == "")
                    { button16.BackColor = Color.RoyalBlue; }
                    if (button20.Text == "")
                    { button20.BackColor = Color.RoyalBlue; }
                    if ((button12.Text != "") && (button20.Text != "") && (button14.Text != "") && (button16.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button24.Text == "" && button24.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button24.Text = sayac.ToString();
                    if (button13.Text == "")
                    { button13.BackColor = Color.RoyalBlue; }
                    if (button15.Text == "")
                    { button15.BackColor = Color.RoyalBlue; }
                    if (button17.Text == "")
                    { button17.BackColor = Color.RoyalBlue; }
                    if ((button13.Text != "") && (button15.Text != "") && (button17.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
            }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (sayac == 0) { RENK1(); }
            if (button25.Text == "" && button25.BackColor == Color.RoyalBlue)
                {
                sayac++;
                RENK();
                button25.Text = sayac.ToString();
                    if (button14.Text == "")
                    { button14.BackColor = Color.RoyalBlue; }
                    if (button18.Text == "")
                    { button18.BackColor = Color.RoyalBlue; }
                    if ((button14.Text != "") && (button18.Text != ""))
                    {
                    txt1.Text = "Yapilabilir hamle kalmadi!";
                    button26.Visible = true;
                }
                if (sayac == 25) { MessageBox.Show("OYUNU KAZANDINIZ!!"); Close(); }
                }
                else
                    MessageBox.Show("Boyle bir hamle yapamazsiniz");
        }
        private void button26_Click(object sender, EventArgs e)
        {
            sayac = 0;
            txt1.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Visible = false;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
