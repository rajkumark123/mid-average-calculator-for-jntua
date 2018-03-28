using System;

namespace Mid_helper
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {      
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        double[] c = new double[2];
        double d = 0;

        private void Click(object sender, EventArgs e)
        {
           
         button1.Text = "ENTER";
            textBox1.Enabled = true;
            textBox1.ReadOnly = false;
            if (a == 2)
            {
                label1.Text = "Enter Mid-1 Marks";
                textBox1.Clear();
                a = 0;
            }
            else
            {
                bool b = double.TryParse(textBox1.Text, out c[a]);

                if (b == false || c[a] > 30 || c[a] < 0)
                {
                    label1.Text = "Entered Incorrectly";
                    button1.Text = "RESET";
                    a = 2;
                    textBox1.Clear();
                    textBox1.Enabled = false;

                }
                else
                {
                    if (a == 0)
                    {
                        textBox1.Clear();
                        label1.Text = "Enter Mid-2 Marks";
                    }
                    if (a == 1)
                    {
                        textBox1.Clear();
                        label1.Text = "Total Average";
                        if (c[0] >= c[1])
                        {
                            c[1] = ((0.8 * c[0]) + (0.2 * c[1]));
                        }
                        else
                        {
                            c[1] = ((0.2 * c[0]) + (0.8 * c[1]));
                        }
                        button1.Text = "RESET";
                        if (c[1] < 10)
                        {
                            c[1] = c[1] + 1;
                            textBox1.Text = "0" + c[1];
                        }
                        else
                        {
                            c[1] = c[1] + 1;
                            textBox1.Text = "" + c[1];
                        }
                        textBox1.ReadOnly = true;

                    }
                    a = a + 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "ENTER";
            textBox2.Enabled = true;
            textBox2.ReadOnly = false;
            if (a == 1)
            {
                label3.Text = "Use Tab in Keyboard to work easily";
                textBox2.Clear();
                a = 0;
            }
            else
            {
                bool b = double.TryParse(textBox2.Text, out d);

                if (b == false || d > 30 || d < 0)
                {
                    label3.Text = "Entered Incorrectly";
                    button2.Text = "RESET";
                    a = 1;
                    textBox2.Clear();
                    textBox2.Enabled = false;

                }
                else
                {
                    if (a == 0)
                    {
                        textBox2.Clear();
                        label3.Text = "Use Tab in Keyboard to work easily";
                        button2.Text = "RESET";
                        if (d == 30)
                            d = 29;
                        d = d * 2;
                        d = d / 3;
                        if (d < 10)
                        {
                            d = d + 1;
                            textBox2.Text = "0" + (int)d;
                        }                        
                        else
                        {
                            d = d + 1;
                            textBox2.Text = "" + (int)d;
                        }
                        textBox2.ReadOnly = true;
                    }
                    a = a + 1;
                }
            }
        }
    }
}
