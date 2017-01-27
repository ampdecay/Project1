namespace Project1_Daigle_Lange
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_wordLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox_buttonGroup = new System.Windows.Forms.GroupBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_startStop = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wordLength)).BeginInit();
            this.groupBox_buttonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Size";
            this.label1.Visible = false;
            // 
            // numericUpDown_wordLength
            // 
            this.numericUpDown_wordLength.Location = new System.Drawing.Point(104, 144);
            this.numericUpDown_wordLength.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_wordLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_wordLength.Name = "numericUpDown_wordLength";
            this.numericUpDown_wordLength.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_wordLength.TabIndex = 1;
            this.numericUpDown_wordLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_wordLength.Visible = false;
            this.numericUpDown_wordLength.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox_buttonGroup
            // 
            this.groupBox_buttonGroup.AutoSize = true;
            this.groupBox_buttonGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_buttonGroup.Controls.Add(this.button_1);
            this.groupBox_buttonGroup.Controls.Add(this.button_2);
            this.groupBox_buttonGroup.Controls.Add(this.button_3);
            this.groupBox_buttonGroup.Controls.Add(this.button_4);
            this.groupBox_buttonGroup.Controls.Add(this.button_5);
            this.groupBox_buttonGroup.Controls.Add(this.button_6);
            this.groupBox_buttonGroup.Controls.Add(this.button_7);
            this.groupBox_buttonGroup.Location = new System.Drawing.Point(12, 56);
            this.groupBox_buttonGroup.Name = "groupBox_buttonGroup";
            this.groupBox_buttonGroup.Size = new System.Drawing.Size(336, 82);
            this.groupBox_buttonGroup.TabIndex = 2;
            this.groupBox_buttonGroup.TabStop = false;
            // 
            // button_1
            // 
            this.button_1.Enabled = false;
            this.button_1.Location = new System.Drawing.Point(7, 28);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(41, 35);
            this.button_1.TabIndex = 0;
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Visible = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Enabled = false;
            this.button_2.Location = new System.Drawing.Point(54, 28);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(41, 35);
            this.button_2.TabIndex = 1;
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Visible = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Enabled = false;
            this.button_3.Location = new System.Drawing.Point(101, 28);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(41, 35);
            this.button_3.TabIndex = 2;
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Visible = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_4
            // 
            this.button_4.Enabled = false;
            this.button_4.Location = new System.Drawing.Point(148, 28);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(41, 35);
            this.button_4.TabIndex = 3;
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Visible = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Enabled = false;
            this.button_5.Location = new System.Drawing.Point(195, 28);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(41, 35);
            this.button_5.TabIndex = 4;
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Visible = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Enabled = false;
            this.button_6.Location = new System.Drawing.Point(242, 28);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(41, 35);
            this.button_6.TabIndex = 5;
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Visible = false;
            // 
            // button_7
            // 
            this.button_7.Enabled = false;
            this.button_7.Location = new System.Drawing.Point(289, 28);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(41, 35);
            this.button_7.TabIndex = 6;
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Visible = false;
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.Location = new System.Drawing.Point(12, 144);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(77, 108);
            this.wordListBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_startStop
            // 
            this.button_startStop.BackColor = System.Drawing.Color.Green;
            this.button_startStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_startStop.Location = new System.Drawing.Point(12, 27);
            this.button_startStop.Name = "button_startStop";
            this.button_startStop.Size = new System.Drawing.Size(75, 23);
            this.button_startStop.TabIndex = 4;
            this.button_startStop.Text = "Go";
            this.button_startStop.UseVisualStyleBackColor = false;
            this.button_startStop.Click += new System.EventHandler(this.button_startStop_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(104, 27);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(362, 271);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_startStop);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.groupBox_buttonGroup);
            this.Controls.Add(this.numericUpDown_wordLength);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Wordz";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wordLength)).EndInit();
            this.groupBox_buttonGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_wordLength;
        private System.Windows.Forms.GroupBox groupBox_buttonGroup;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_startStop;
        private System.Windows.Forms.Button button_reset;
    }
}

