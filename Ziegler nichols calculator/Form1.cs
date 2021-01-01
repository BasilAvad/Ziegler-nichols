using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ziegler_nichols_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(this.T_tbx.Text);
                double l = Convert.ToDouble(this.L_tbx.Text);
                double kp = t / l;
                kp_1.Text = kp.ToString();
                double kp2 = 0.9 * t / l;
                kp_2.Text = kp2.ToString();
                double kp3 = 1.2 * t / l;
                kp_3.Text = kp3.ToString();
                string ti = "Inf";
                ti_1.Text = ti;
                double ti2 = l / 0.3;
                ti_2.Text = ti2.ToString();
                double ti3 = 2 * l;
                ti_3.Text = ti3.ToString();
                int td = 0;
                td_1.Text = td.ToString();
                int td2 = 0;
                td_2.Text = td2.ToString();
                double td3 = 0.5 * l;
                td_3.Text = td3.ToString();
            }
            catch (Exception)
            {

                label11.Text = "Lütfen T ve L dğerleri giriniz";
                _ = Color.Red;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double kcr = Convert.ToDouble(this.Kcr_tbx.Text);
                double pcr = Convert.ToDouble(this.Pcr_tbx.Text);
                double kp = 0.5*kcr;
                Kp_tbx.Text = kp.ToString();
                double kp2 = 0.45*kcr;
                Kp2_tbx.Text = kp2.ToString();
                double kp3 =0.6*kcr;
                Kp3_tbx.Text = kp3.ToString();
                string ti = "Inf";
                ti_tbx.Text = ti;
                double ti2 = 1/(1*pcr);
                ti2_tbx.Text = ti2.ToString();
                double ti3 = 0.5*pcr;
                ti3_tbx.Text = ti3.ToString();
                int td = 0;
                td_tbx.Text = td.ToString();
                int td2 = 0;
                td2_tbx.Text = td2.ToString();
                double td3 = 0.125*pcr;
                td3_tbx.Text = td3.ToString();
            }
            catch (Exception)
            {

                label11.Text = "Lütfen Kcr ve Pcr dğerleri giriniz";
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            td_1.Text = null;
            td_2.Text = null;
            td_3.Text = null;
            kp_1.Text = null;
            kp_2.Text = null;
            kp_3.Text = null;
            ti_1.Text = null;
            ti_2.Text = null;
            ti_3.Text = null;
            L_tbx.Text = null;
            T_tbx.Text = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kp_tbx.Text = null;
            Kp2_tbx.Text = null;
            Kp3_tbx.Text = null;
            ti_tbx.Text = null;
            ti2_tbx.Text = null;
            ti3_tbx.Text = null;
            td_tbx.Text = null;
            td2_tbx.Text = null;
            td3_tbx.Text = null;
            Pcr_tbx.Text = null;
            Kcr_tbx.Text = null;
        }
    }
}
