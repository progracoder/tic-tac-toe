using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tic_tac
{
    public partial class Form1 : Form
    {
        bool choise;
        int winx=0;
        int wino=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblwin_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            foreach (Button item in panel2.Controls)
            {
                item.Text = "";
                item.BackgroundImage = global::tic_tac.Properties.Resources.Rectangle_90px;
                item.Enabled = true;
            }
        }

        private void winer()
        {
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
            {
                lbl1.ForeColor = btn1.ForeColor;
                lbl1.Text = btn1.Text;
                if (btn1.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn1.Text == "X")
                    lblwinx.Text = (++winx).ToString();

                desabel();
            }

            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
            {
                lbl1.ForeColor = btn1.ForeColor;
                lbl1.Text = btn1.Text;
                if (btn1.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn1.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();
            }


            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
            {
                lbl1.ForeColor = btn1.ForeColor;
                lbl1.Text = btn1.Text;
                if (btn1.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn1.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();
            }



            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
            {
                lbl1.ForeColor = btn2.ForeColor;
                lbl1.Text = btn2.Text;
                if (btn2.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn2.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();
            }

            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
            {
                lbl1.ForeColor = btn4.ForeColor;
                lbl1.Text = btn4.Text;
                if (btn4.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn4.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();                
            }

            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            {
                lbl1.ForeColor = btn3.ForeColor;
                lbl1.Text = btn3.Text;
                if (btn3.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn3.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();                
            }

            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
            {
                lbl1.ForeColor = btn3.ForeColor;
                lbl1.Text = btn3.Text;
                if (btn3.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn3.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();
            }

            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
            {
                lbl1.ForeColor = btn7.ForeColor;
                lbl1.Text = btn7.Text;
                if (btn7.Text == "O")
                    lblwino.Text = (++wino).ToString();
                else if (btn7.Text == "X")
                    lblwinx.Text = (++winx).ToString();
                desabel();                
            }
        }

        private void desabel()
        {
            foreach (Button item in panel2.Controls)
            {
                item.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (choise)
            {
                lbl2.Text = "Player 1";
                lbl2.ForeColor = Color.Blue;
               b.BackgroundImage = global::tic_tac.Properties.Resources.PicsArt_1493933579239;
               b.ForeColor = Color.Red;
                b.Text = "X";

            }
            else
            {
                lbl2.Text = "Player 2";
                lbl2.ForeColor = Color.Red;
                b.ForeColor = Color.Blue;
                b.BackgroundImage = global::tic_tac.Properties.Resources.PicsArt_1493987941900;
                b.Text = "O";

            }
            b.Enabled = false;
            choise = !choise;
            winer();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By --> Yusuf Azizi","About");
        }

    }
}
