using System.ComponentModel;

namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Diff = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            numericUpDown4 = new NumericUpDown();
            listBox2 = new ListBox();
            label4 = new Label();
            numericUpDown6 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            tabPage3 = new TabPage();
            label13 = new Label();
            label12 = new Label();
            numericUpDown9 = new NumericUpDown();
            button4 = new Button();
            numericUpDown8 = new NumericUpDown();
            trackBar1 = new TrackBar();
            numericUpDown5 = new NumericUpDown();
            listBox3 = new ListBox();
            label8 = new Label();
            numericUpDown7 = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button3 = new Button();
            tabPage4 = new TabPage();
            progressBar1 = new ProgressBar();
            label15 = new Label();
            numericUpDown11 = new NumericUpDown();
            label14 = new Label();
            numericUpDown10 = new NumericUpDown();
            button5 = new Button();
            trackBar2 = new TrackBar();
            numericUpDown12 = new NumericUpDown();
            listBox4 = new ListBox();
            label16 = new Label();
            numericUpDown13 = new NumericUpDown();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button6 = new Button();
            backgroundWorker1 = new BackgroundWorker();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            ((ISupportInitialize)numericUpDown3).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((ISupportInitialize)numericUpDown4).BeginInit();
            ((ISupportInitialize)numericUpDown6).BeginInit();
            tabPage3.SuspendLayout();
            ((ISupportInitialize)numericUpDown9).BeginInit();
            ((ISupportInitialize)numericUpDown8).BeginInit();
            ((ISupportInitialize)trackBar1).BeginInit();
            ((ISupportInitialize)numericUpDown5).BeginInit();
            ((ISupportInitialize)numericUpDown7).BeginInit();
            tabPage4.SuspendLayout();
            ((ISupportInitialize)numericUpDown11).BeginInit();
            ((ISupportInitialize)numericUpDown10).BeginInit();
            ((ISupportInitialize)trackBar2).BeginInit();
            ((ISupportInitialize)numericUpDown12).BeginInit();
            ((ISupportInitialize)numericUpDown13).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(867, 58);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Diff
            // 
            Diff.AutoSize = true;
            Diff.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Diff.Location = new Point(37, 56);
            Diff.Name = "Diff";
            Diff.Size = new Size(22, 25);
            Diff.TabIndex = 2;
            Diff.Text = "a";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(65, 56);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(198, 34);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(295, 56);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 7;
            label1.Text = "b";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Location = new Point(335, 56);
            numericUpDown2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(198, 34);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(594, 56);
            numericUpDown3.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(198, 34);
            numericUpDown3.TabIndex = 10;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(567, 58);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 9;
            label2.Text = "c";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(345, 12);
            label3.Name = "label3";
            label3.Size = new Size(417, 25);
            label3.TabIndex = 12;
            label3.Text = "((b-a)/b)^c を計算し、確率を出すシステムです。";
            label3.Click += label3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(50, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1026, 404);
            listBox1.TabIndex = 13;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1162, 613);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(numericUpDown3);
            tabPage1.Controls.Add(Diff);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1154, 575);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "mode 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(numericUpDown4);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(numericUpDown6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1154, 575);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "mode 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 3;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(240, 81);
            numericUpDown4.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(198, 34);
            numericUpDown4.TabIndex = 16;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(71, 146);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(1026, 404);
            listBox2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(265, 25);
            label4.Name = "label4";
            label4.Size = new Size(690, 25);
            label4.TabIndex = 21;
            label4.Text = "((100-a)/100)^b で試行を行い、確率を出すシステムです。（aはパーセント表示）";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(526, 82);
            numericUpDown6.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown6.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(198, 34);
            numericUpDown6.TabIndex = 20;
            numericUpDown6.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(212, 87);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 15;
            label5.Text = "a";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(444, 87);
            label6.Name = "label6";
            label6.Size = new Size(27, 25);
            label6.TabIndex = 19;
            label6.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(498, 87);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 17;
            label7.Text = "b";
            // 
            // button2
            // 
            button2.Location = new Point(759, 81);
            button2.Name = "button2";
            button2.Size = new Size(123, 33);
            button2.TabIndex = 14;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(numericUpDown9);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(numericUpDown8);
            tabPage3.Controls.Add(trackBar1);
            tabPage3.Controls.Add(numericUpDown5);
            tabPage3.Controls.Add(listBox3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(numericUpDown7);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1154, 574);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Multi";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label13.Location = new Point(519, 132);
            label13.Name = "label13";
            label13.Size = new Size(71, 25);
            label13.TabIndex = 36;
            label13.Text = "column";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.Location = new Point(539, 176);
            label12.Name = "label12";
            label12.Size = new Size(42, 25);
            label12.TabIndex = 35;
            label12.Text = "diff";
            // 
            // numericUpDown9
            // 
            numericUpDown9.Location = new Point(613, 127);
            numericUpDown9.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            numericUpDown9.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(198, 34);
            numericUpDown9.TabIndex = 34;
            numericUpDown9.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown9.ValueChanged += numericUpDown9_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(843, 132);
            button4.Name = "button4";
            button4.Size = new Size(123, 34);
            button4.TabIndex = 33;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown8
            // 
            numericUpDown8.DecimalPlaces = 3;
            numericUpDown8.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown8.Location = new Point(613, 167);
            numericUpDown8.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown8.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(198, 34);
            numericUpDown8.TabIndex = 32;
            numericUpDown8.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(156, 132);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(357, 69);
            trackBar1.TabIndex = 31;
            trackBar1.TickFrequency = 100;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 3;
            numericUpDown5.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown5.Location = new Point(291, 79);
            numericUpDown5.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(198, 34);
            numericUpDown5.TabIndex = 25;
            numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(64, 224);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(1026, 329);
            listBox3.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.Location = new Point(277, 22);
            label8.Name = "label8";
            label8.Size = new Size(654, 25);
            label8.TabIndex = 29;
            label8.Text = "((100-a)/100)^b を計算し、確率を出すシステムです。（aはパーセント表示）";
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(613, 79);
            numericUpDown7.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown7.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(198, 34);
            numericUpDown7.TabIndex = 28;
            numericUpDown7.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.Location = new Point(263, 85);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 24;
            label9.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(495, 85);
            label10.Name = "label10";
            label10.Size = new Size(27, 25);
            label10.TabIndex = 27;
            label10.Text = "%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label11.Location = new Point(549, 85);
            label11.Name = "label11";
            label11.Size = new Size(22, 25);
            label11.TabIndex = 26;
            label11.Text = "b";
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.Location = new Point(843, 79);
            button3.Name = "button3";
            button3.Size = new Size(123, 35);
            button3.TabIndex = 23;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(progressBar1);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(numericUpDown11);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(numericUpDown10);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(trackBar2);
            tabPage4.Controls.Add(numericUpDown12);
            tabPage4.Controls.Add(listBox4);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(numericUpDown13);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(button6);
            tabPage4.Location = new Point(4, 35);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1154, 574);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Test";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(91, 240);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(945, 34);
            progressBar1.TabIndex = 53;
            progressBar1.Click += progressBar1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label15.Location = new Point(523, 182);
            label15.Name = "label15";
            label15.Size = new Size(84, 25);
            label15.TabIndex = 52;
            label15.Text = "検証回数";
            // 
            // numericUpDown11
            // 
            numericUpDown11.Location = new Point(613, 180);
            numericUpDown11.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown11.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown11.Name = "numericUpDown11";
            numericUpDown11.Size = new Size(198, 34);
            numericUpDown11.TabIndex = 51;
            numericUpDown11.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown11.ValueChanged += numericUpDown11_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label14.Location = new Point(523, 136);
            label14.Name = "label14";
            label14.Size = new Size(84, 25);
            label14.TabIndex = 50;
            label14.Text = "試行回数";
            // 
            // numericUpDown10
            // 
            numericUpDown10.Location = new Point(613, 127);
            numericUpDown10.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown10.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown10.Name = "numericUpDown10";
            numericUpDown10.Size = new Size(198, 34);
            numericUpDown10.TabIndex = 48;
            numericUpDown10.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // button5
            // 
            button5.Location = new Point(843, 132);
            button5.Name = "button5";
            button5.Size = new Size(123, 34);
            button5.TabIndex = 47;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 200;
            trackBar2.Location = new Point(156, 132);
            trackBar2.Maximum = 10000;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(357, 69);
            trackBar2.TabIndex = 45;
            trackBar2.TickFrequency = 1000;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // numericUpDown12
            // 
            numericUpDown12.DecimalPlaces = 3;
            numericUpDown12.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown12.Location = new Point(291, 79);
            numericUpDown12.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown12.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(198, 34);
            numericUpDown12.TabIndex = 39;
            numericUpDown12.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown12.ValueChanged += numericUpDown12_ValueChanged;
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Mgen+ 2m regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(59, 290);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(1026, 279);
            listBox4.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label16.Location = new Point(265, 26);
            label16.Name = "label16";
            label16.Size = new Size(588, 25);
            label16.TabIndex = 43;
            label16.Text = "試行におけるある確率に対し、すべて外す確率を試行から出すシステム";
            // 
            // numericUpDown13
            // 
            numericUpDown13.Location = new Point(613, 79);
            numericUpDown13.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown13.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown13.Name = "numericUpDown13";
            numericUpDown13.Size = new Size(198, 34);
            numericUpDown13.TabIndex = 42;
            numericUpDown13.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label17.Location = new Point(237, 81);
            label17.Name = "label17";
            label17.Size = new Size(48, 25);
            label17.TabIndex = 38;
            label17.Text = "確率";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label18.Location = new Point(495, 85);
            label18.Name = "label18";
            label18.Size = new Size(27, 25);
            label18.TabIndex = 41;
            label18.Text = "%";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label19.Location = new Point(523, 85);
            label19.Name = "label19";
            label19.Size = new Size(84, 25);
            label19.TabIndex = 40;
            label19.Text = "引く回数";
            // 
            // button6
            // 
            button6.AllowDrop = true;
            button6.Location = new Point(843, 79);
            button6.Name = "button6";
            button6.Size = new Size(123, 35);
            button6.TabIndex = 37;
            button6.Text = "Calculate";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 653);
            Controls.Add(tabControl1);
            Font = new Font("Mgen+ 2p regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "Form1";
            Text = "TestApp";
            Load += Form1_Load;
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ((ISupportInitialize)numericUpDown3).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((ISupportInitialize)numericUpDown4).EndInit();
            ((ISupportInitialize)numericUpDown6).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((ISupportInitialize)numericUpDown9).EndInit();
            ((ISupportInitialize)numericUpDown8).EndInit();
            ((ISupportInitialize)trackBar1).EndInit();
            ((ISupportInitialize)numericUpDown5).EndInit();
            ((ISupportInitialize)numericUpDown7).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((ISupportInitialize)numericUpDown11).EndInit();
            ((ISupportInitialize)numericUpDown10).EndInit();
            ((ISupportInitialize)trackBar2).EndInit();
            ((ISupportInitialize)numericUpDown12).EndInit();
            ((ISupportInitialize)numericUpDown13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label Diff;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private NumericUpDown numericUpDown4;
        private ListBox listBox2;
        private Label label4;
        private NumericUpDown numericUpDown6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private TabPage tabPage3;
        private NumericUpDown numericUpDown5;
        private ListBox listBox3;
        private Label label8;
        private NumericUpDown numericUpDown7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button3;
        private NumericUpDown numericUpDown8;
        private TrackBar trackBar1;
        private Button button4;
        private Label label13;
        private Label label12;
        private NumericUpDown numericUpDown9;
        private TabPage tabPage4;
        private Label label14;
        private NumericUpDown numericUpDown10;
        private Button button5;
        private TrackBar trackBar2;
        private NumericUpDown numericUpDown12;
        private ListBox listBox4;
        private Label label16;
        private NumericUpDown numericUpDown13;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button6;
        private Label label15;
        private NumericUpDown numericUpDown11;
        private ProgressBar progressBar1;
        private BackgroundWorker backgroundWorker1;
    }
}
