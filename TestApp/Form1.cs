using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace TestApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting data = new Setting();
            this.AcceptButton = this.button3;
            listBox4.Items.Add("ここに結果が表示されます...");
        }

        public void DrawGraph()
        {
            a = (int)numericUpDown1.Value;
            b = (int)numericUpDown2.Value;
            c = (int)numericUpDown3.Value;
            double s = (((double)numericUpDown2.Value - (double)numericUpDown1.Value) / (double)numericUpDown2.Value);
            double result = Math.Pow(s, (double)numericUpDown3.Value);
            string strResult = result.ToString("F6");
            listBox1.Items.Add("Result = " + strResult);

        }
        public void culculate()
        {
            double t = 1.00 - ((double)numericUpDown4.Value * 0.01);
            double result2 = Math.Pow(t, (double)numericUpDown6.Value);
            string strResult2 = result2.ToString("F6");
            listBox2.Items.Add("Result = " + strResult2);
        }
        public void Run()
        {
            double x = (double)numericUpDown5.Value;
            listBox3.Items.Add("<Result>");

            for (int i = 0; i < numericUpDown9.Value; i++)
            {
                double t = 1.00 - (x * 0.01);
                double result2 = Math.Pow(t, (double)numericUpDown7.Value);
                string strResult2 = result2.ToString("F6");
                listBox3.Items.Add(x.ToString("0.000") + " | " + strResult2);
                x += (double)numericUpDown8.Value;
            }
            listBox3.Items.Add("</Result>");
        }
        public void Test()
        {
            double x = (double)numericUpDown12.Value;
            listBox4.Items.Add("<Result>");
            Random rand = new Random();

            double[] Result6 = new double[(int)numericUpDown11.Value];
            for (int m = 0; m < numericUpDown11.Value; m++)
            {
                double Accurate = 0;
                string strResult4 = "";
                double[] result3 = new double[(int)numericUpDown10.Value];
                List<double> result5 = new List<double>();
                for (int n = 0; n < (int)numericUpDown10.Value; n++)
                {
                    int Count = 0;

                    for (int i = 0; i < (int)numericUpDown13.Value; i++)
                    {
                        double r = rand.NextDouble();
                        if (r < x * 0.01)
                        {
                            Count++;
                        }
                    }
                    double result = Count / (double)numericUpDown13.Value;
                    string strResult2 = result.ToString("F6");
                    //listBox4.Items.Add(n.ToString("000000") + " | " + strResult2);
                    result3[n] = result;
                    result5.Add(result);
                }
                int LastCount = 0;
                foreach (var s in result5)
                {
                    if (s == 0.000000)
                    {
                        LastCount++;
                    }
                }
                Accurate = LastCount / (double)numericUpDown10.Value;
                strResult4 = Accurate.ToString("F6");
                listBox4.Items.Add((m + 1).ToString("000000") + " | " + strResult4);
                Result6[m] = Accurate;
            }
            double LastResult = Result6.Average();
            string strResult5 = LastResult.ToString("F6");
            listBox4.Items.Add(" ");
            listBox4.Items.Add("Result | " + strResult5);
            listBox4.Items.Add("</Result>");
        }

        public void Clear()
        {
            listBox3.Items.Clear();
        }
        public void Clear2()
        {
            listBox4.Items.Clear();
        }
        public struct Setting
        {
            public double L1;
            public double L2;
            public double R1;
            public double R2;
            public double M1;
            public double M2;
            public double dt;
            public double[] t;
            public double tMax;
            public double G;
            public double[] state;
        }

        public int nowvalue;
        public int a;
        public int b;
        public int c;
        public void Set(Setting data)
        {
            data.L1 = 1.0;
            data.L2 = 0.5;
            data.R1 = 60;
            data.R2 = 120;
            data.M1 = 2;
            data.M2 = 1;
            data.dt = 0.5;

            data.tMax = 15;
            data.G = 9.8;


        }

        public struct Point
        {
            public double x;
            public double y;
            public double time;
        }
        public string? path;
        public struct Line
        {
            public double x1;
            public double y1;
            public double x2;
            public double y2;
            public double time;
        }
        public struct data_alpha
        {
            public double[] data;
        }

        public enum TabPageIndex
        {
            None = 0,
            Mode1 = 1,
            Mode2 = 2,
            Multi = 3
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DrawGraph();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            a = (int)numericUpDown1.Value;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            b = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            c = (int)numericUpDown3.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.culculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Run();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Clear2();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Test();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown9.Value > 1000)
            {
                trackBar1.Value = 1000;
            }
            else
            {
                trackBar1.Value = (int)numericUpDown9.Value;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown9.Value = (int)trackBar1.Value;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = (int)numericUpDown11.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown11.Value = (int)trackBar2.Value; 
        }
    }
}
