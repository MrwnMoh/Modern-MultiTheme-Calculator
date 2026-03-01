namespace Calculator.net
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonDellet = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonDivid = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEqq = new System.Windows.Forms.Button();
            this.ProgramName = new System.Windows.Forms.Label();
            this.ProgramNamePanel = new System.Windows.Forms.Panel();
            this.CalculationsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResultText = new System.Windows.Forms.Label();
            this.CalculationTrackerBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.buttonLight = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.ButtonNuterl = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.ProgramNamePanel.SuspendLayout();
            this.CalculationsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.buttonAC);
            this.MainPanel.Controls.Add(this.buttonDellet);
            this.MainPanel.Controls.Add(this.buttonMod);
            this.MainPanel.Controls.Add(this.button7);
            this.MainPanel.Controls.Add(this.button8);
            this.MainPanel.Controls.Add(this.button9);
            this.MainPanel.Controls.Add(this.button4);
            this.MainPanel.Controls.Add(this.button5);
            this.MainPanel.Controls.Add(this.button6);
            this.MainPanel.Controls.Add(this.buttonDivid);
            this.MainPanel.Controls.Add(this.buttonMultiply);
            this.MainPanel.Controls.Add(this.buttonMinus);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.buttonDot);
            this.MainPanel.Controls.Add(this.button0);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.buttonAdd);
            this.MainPanel.Controls.Add(this.buttonEqq);
            this.MainPanel.Location = new System.Drawing.Point(141, 71);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(510, 819);
            this.MainPanel.TabIndex = 0;
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonAC.FlatAppearance.BorderSize = 0;
            this.buttonAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAC.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAC.Location = new System.Drawing.Point(20, 193);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(112, 117);
            this.buttonAC.TabIndex = 18;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonDellet
            // 
            this.buttonDellet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonDellet.FlatAppearance.BorderSize = 0;
            this.buttonDellet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDellet.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDellet.Location = new System.Drawing.Point(139, 193);
            this.buttonDellet.Name = "buttonDellet";
            this.buttonDellet.Size = new System.Drawing.Size(112, 117);
            this.buttonDellet.TabIndex = 17;
            this.buttonDellet.Text = "Del";
            this.buttonDellet.UseVisualStyleBackColor = false;
            this.buttonDellet.Click += new System.EventHandler(this.buttonDellet_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMod.FlatAppearance.BorderSize = 0;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMod.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(258, 193);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(112, 117);
            this.buttonMod.TabIndex = 16;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(20, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 117);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(139, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 117);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(258, 316);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 117);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 117);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(139, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 117);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(258, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 117);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonDivid
            // 
            this.buttonDivid.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonDivid.FlatAppearance.BorderSize = 0;
            this.buttonDivid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivid.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivid.Location = new System.Drawing.Point(377, 193);
            this.buttonDivid.Name = "buttonDivid";
            this.buttonDivid.Size = new System.Drawing.Size(112, 117);
            this.buttonDivid.TabIndex = 15;
            this.buttonDivid.Text = "/";
            this.buttonDivid.UseVisualStyleBackColor = false;
            this.buttonDivid.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(377, 316);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(112, 117);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(377, 439);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(112, 117);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(139, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 117);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(179, 685);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(112, 117);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(20, 685);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(153, 117);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(258, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 117);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(377, 562);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 117);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEqq
            // 
            this.buttonEqq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonEqq.FlatAppearance.BorderSize = 0;
            this.buttonEqq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqq.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqq.Location = new System.Drawing.Point(297, 685);
            this.buttonEqq.Name = "buttonEqq";
            this.buttonEqq.Size = new System.Drawing.Size(192, 117);
            this.buttonEqq.TabIndex = 11;
            this.buttonEqq.Text = "=";
            this.buttonEqq.UseVisualStyleBackColor = false;
            this.buttonEqq.Click += new System.EventHandler(this.buttonEqq_Click);
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Helvetica Rounded", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramName.ForeColor = System.Drawing.Color.Snow;
            this.ProgramName.Location = new System.Drawing.Point(3, 3);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(265, 56);
            this.ProgramName.TabIndex = 1;
            this.ProgramName.Text = "Calculator";
            // 
            // ProgramNamePanel
            // 
            this.ProgramNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgramNamePanel.Controls.Add(this.buttonLight);
            this.ProgramNamePanel.Controls.Add(this.buttonDark);
            this.ProgramNamePanel.Controls.Add(this.ButtonNuterl);
            this.ProgramNamePanel.Controls.Add(this.ProgramName);
            this.ProgramNamePanel.Location = new System.Drawing.Point(141, 68);
            this.ProgramNamePanel.Name = "ProgramNamePanel";
            this.ProgramNamePanel.Size = new System.Drawing.Size(510, 64);
            this.ProgramNamePanel.TabIndex = 1;
            // 
            // CalculationsPanel
            // 
            this.CalculationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CalculationsPanel.Controls.Add(this.panel1);
            this.CalculationsPanel.Controls.Add(this.CalculationTrackerBox);
            this.CalculationsPanel.Controls.Add(this.InputTextBox);
            this.CalculationsPanel.Location = new System.Drawing.Point(141, 117);
            this.CalculationsPanel.Name = "CalculationsPanel";
            this.CalculationsPanel.Size = new System.Drawing.Size(510, 141);
            this.CalculationsPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ResultText);
            this.panel1.Location = new System.Drawing.Point(20, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 43);
            this.panel1.TabIndex = 2;
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Helvetica Rounded", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.ForeColor = System.Drawing.Color.Snow;
            this.ResultText.Location = new System.Drawing.Point(3, 7);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(31, 32);
            this.ResultText.TabIndex = 2;
            this.ResultText.Text = "0";
            this.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalculationTrackerBox
            // 
            this.CalculationTrackerBox.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationTrackerBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CalculationTrackerBox.Location = new System.Drawing.Point(324, 32);
            this.CalculationTrackerBox.Multiline = true;
            this.CalculationTrackerBox.Name = "CalculationTrackerBox";
            this.CalculationTrackerBox.ReadOnly = true;
            this.CalculationTrackerBox.Size = new System.Drawing.Size(167, 57);
            this.CalculationTrackerBox.TabIndex = 2;
            this.CalculationTrackerBox.TabStop = false;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(20, 32);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.ShortcutsEnabled = false;
            this.InputTextBox.Size = new System.Drawing.Size(298, 57);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TabStop = false;
            // 
            // buttonLight
            // 
            this.buttonLight.BackColor = System.Drawing.Color.Transparent;
            this.buttonLight.BackgroundImage = global::Calculator.net.Properties.Resources.Gemini_Generated_Image_pa6u3epa6u3epa6u_removebg_preview;
            this.buttonLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLight.FlatAppearance.BorderSize = 0;
            this.buttonLight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLight.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLight.Location = new System.Drawing.Point(353, 10);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(50, 42);
            this.buttonLight.TabIndex = 21;
            this.buttonLight.UseVisualStyleBackColor = false;
            this.buttonLight.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.BackColor = System.Drawing.Color.Transparent;
            this.buttonDark.BackgroundImage = global::Calculator.net.Properties.Resources.Gemini_Generated_Image_36sj8036sj8036sj_removebg_preview;
            this.buttonDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDark.FlatAppearance.BorderSize = 0;
            this.buttonDark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDark.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDark.Location = new System.Drawing.Point(403, 10);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(50, 42);
            this.buttonDark.TabIndex = 20;
            this.buttonDark.UseVisualStyleBackColor = false;
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // ButtonNuterl
            // 
            this.ButtonNuterl.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNuterl.BackgroundImage = global::Calculator.net.Properties.Resources.Gemini_Generated_Image_a1vh1va1vh1va1vh_removebg_preview;
            this.ButtonNuterl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNuterl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNuterl.FlatAppearance.BorderSize = 0;
            this.ButtonNuterl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonNuterl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonNuterl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNuterl.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonNuterl.Location = new System.Drawing.Point(453, 6);
            this.ButtonNuterl.Name = "ButtonNuterl";
            this.ButtonNuterl.Size = new System.Drawing.Size(50, 50);
            this.ButtonNuterl.TabIndex = 19;
            this.ButtonNuterl.UseVisualStyleBackColor = false;
            this.ButtonNuterl.Click += new System.EventHandler(this.ButtonNuterl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 938);
            this.Controls.Add(this.ProgramNamePanel);
            this.Controls.Add(this.CalculationsPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.MainPanel.ResumeLayout(false);
            this.ProgramNamePanel.ResumeLayout(false);
            this.ProgramNamePanel.PerformLayout();
            this.CalculationsPanel.ResumeLayout(false);
            this.CalculationsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Panel ProgramNamePanel;
        private System.Windows.Forms.Panel CalculationsPanel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEqq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDivid;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonDellet;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox CalculationTrackerBox;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonNuterl;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.Button buttonLight;
    }
}

