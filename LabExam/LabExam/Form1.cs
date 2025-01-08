using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void lblpersee_Click(object sender, EventArgs e)
        {

        }

        private void lblperse_Click(object sender, EventArgs e)
        {

        }

        private void lblpersp_Click(object sender, EventArgs e)
        {

        }

        private void lblpersq_Click(object sender, EventArgs e)
        {

        }

        private void lblpercc_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void lblse_Click(object sender, EventArgs e)
        {

        }

        private void lblsp_Click(object sender, EventArgs e)
        {

        }

        private void lblsq_Click(object sender, EventArgs e)
        {

        }

        private void lblcc_Click(object sender, EventArgs e)
        {

        }

        private void lblp_Click(object sender, EventArgs e)
        {

        }

        private void txtsee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsq_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblperp_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, num5, num6, Total, Obtain, p1, p2, p3, p4, p5, p6, per;
            num1 = Convert.ToInt32(txtp.Text);
            num2 = Convert.ToInt32(txtcc.Text);
            num3 = Convert.ToInt32(txtsq.Text);
            num4 = Convert.ToInt32(txtsp.Text);
            num5 = Convert.ToInt32(txtse.Text);
            num6 = Convert.ToInt32(txtsee.Text);



            Total = num1+num2+num3+num4+num5+num6;
            lblpertotal.Text = Total.ToString();

            int A;

            A = Convert.ToInt32(txtp.Text);
            if (A >= 80 && A <= 100) { lblp.Text = "A+"; }
            if (A >= 70 && A <= 79 ) { lblp.Text = "A"; }
            if (A >= 60 && A <= 69) { lblp.Text = "B"; }
            if (A >= 50 && A <= 59) { lblp.Text = "C"; }
            if (A < 50) { lblp.Text = "Fail"; }


            int B;

            B = Convert.ToInt32(txtcc.Text);
            if (B >= 80 && B <= 100) { lblcc.Text = "A+"; }
            if (B >= 70 && B <= 79) { lblcc.Text = "A"; }
            if (B >= 60 && B <= 69) { lblcc.Text = "B"; }
            if (B >= 50 && B <= 59) { lblcc.Text = "C"; }
            if (B < 50) { lblcc.Text = "Fail"; }


            int C;

            C = Convert.ToInt32(txtsq.Text);
            if (C >= 80 && C <= 100) { lblsq.Text = "A+"; }
            if (C >= 70 && C <= 79) { lblsq.Text = "A"; }
            if (C >= 60 && C <= 69) { lblsq.Text = "B"; }
            if (C >= 50 && C <= 59) { lblsq.Text = "C"; }
            if (C < 50) { lblsq.Text = "Fail"; }


             int D;

            D = Convert.ToInt32(txtsp.Text);
            if (D >= 80 && D <= 100) { lblsp.Text = "A+"; }
            if (D >= 70 && D <= 79 ) { lblsp.Text = "A"; }
            if (D >= 60 && D <= 69) { lblsp.Text = "B"; }
            if (D >= 50 && D <= 59) { lblsp.Text = "C"; }
            if (D < 50) { lblsp.Text = "Fail"; }

            int E;

            E = Convert.ToInt32(txtse.Text);
            if (E >= 80 && E <= 100) { lblse.Text = "A+"; }
            if (E >= 70 && E <= 79) { lblse.Text = "A"; }
            if (E >= 60 && E <= 69) { lblse.Text = "B"; }
            if (E >= 50 && E <= 59) { lblse.Text = "C"; }
            if (E < 50) { lblse.Text = "Fail"; }

            int F;

            F = Convert.ToInt32(txtsee.Text);
            if (F >= 80 && F <= 100) { lblsee.Text = "A+"; }
            if (F >= 70 && F <= 79) { lblsee.Text = "A"; }
            if (F >= 60 && F <= 69) { lblsee.Text = "B"; }
            if (F >= 50 && F <= 59) { lblsee.Text = "C"; }
            if (F < 50) { lblsee.Text = "Fail"; }


            Total = Convert.ToInt32(lblpertotal.Text);
            if (Total >= 480 && Total <= 600) { lblgrade.Text = "A+"; }
            if (Total >= 420 && Total <= 479) { lblgrade.Text = "A"; }
            if (Total >= 360 && Total <= 419) { lblgrade.Text = "B"; }
            if (Total >= 300 && Total <= 359) { lblgrade.Text = "C"; }
            if (Total < 300) { lblgrade.Text = "Fail"; }


            p1 = num1 * 100 / 100;
            lblperp.Text = p1.ToString();
            p2 = num2 * 100 / 100;
            lblpercc.Text = p2.ToString();
            p3 = num3 * 100 / 100;
            lblpersq.Text = p3.ToString();
            p4 = num4 * 100 / 100;
            lblpersp.Text = p4.ToString();
            p5 = num5 * 100 / 100;
            lblperse.Text = p5.ToString();
            p6 = num6 * 100 / 100;
            lblpersee.Text = p6.ToString();

            per = Total / 6;
            lblpercentage.Text = per.ToString();

            per = Convert.ToInt32(lblpercentage.Text);

            if (per >= 85 && per <= 100) lblgpa.Text = "4.0";
            else if (per >= 80 && per <= 84) lblgpa.Text = "3.7";
            else if (per >= 75 && per <= 79) lblgpa.Text = "3.3";
            else if (per >= 70 && per <= 74) lblgpa.Text = "3.0";
            else if (per >= 65 && per <= 69) lblgpa.Text = "2.7";
            else if (per >= 61 && per <= 64) lblgpa.Text = "2.3";
            else if (per >= 58 && per <= 60) lblgpa.Text = "2.0";
            else if (per >= 55 && per <= 57) lblgpa.Text = "1.7";
            else if (per >= 50 && per <= 54) lblgpa.Text = "1.0";
            else if (per < 50) lblgpa.Text = "0";



        }
    }
}
