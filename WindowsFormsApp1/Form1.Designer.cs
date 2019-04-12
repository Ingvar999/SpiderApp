namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.turnBar = new System.Windows.Forms.TrackBar();
            this.heightBar = new System.Windows.Forms.TrackBar();
            this.radiusBar = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.legsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HRlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Turnlabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.sketchBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turnBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightSalmon;
            this.textBox1.Location = new System.Drawing.Point(21, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(237, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.richTextBox1.Location = new System.Drawing.Point(21, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(533, 296);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(376, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 373);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // turnBar
            // 
            this.turnBar.Enabled = false;
            this.turnBar.LargeChange = 0;
            this.turnBar.Location = new System.Drawing.Point(560, 311);
            this.turnBar.Maximum = 90;
            this.turnBar.Minimum = -90;
            this.turnBar.Name = "turnBar";
            this.turnBar.Size = new System.Drawing.Size(293, 56);
            this.turnBar.TabIndex = 5;
            this.turnBar.ValueChanged += new System.EventHandler(this.turnBar_ValueChanged);
            this.turnBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.turnBar_MouseUp);
            // 
            // heightBar
            // 
            this.heightBar.Enabled = false;
            this.heightBar.LargeChange = 0;
            this.heightBar.Location = new System.Drawing.Point(726, 34);
            this.heightBar.Maximum = 50;
            this.heightBar.Minimum = -50;
            this.heightBar.Name = "heightBar";
            this.heightBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.heightBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heightBar.Size = new System.Drawing.Size(56, 271);
            this.heightBar.TabIndex = 6;
            this.heightBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.heightBar.ValueChanged += new System.EventHandler(this.heightBar_ValueChanged);
            this.heightBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.heightBar_MouseUp);
            // 
            // radiusBar
            // 
            this.radiusBar.Enabled = false;
            this.radiusBar.LargeChange = 0;
            this.radiusBar.Location = new System.Drawing.Point(797, 34);
            this.radiusBar.Maximum = 50;
            this.radiusBar.Minimum = -50;
            this.radiusBar.Name = "radiusBar";
            this.radiusBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radiusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radiusBar.Size = new System.Drawing.Size(56, 270);
            this.radiusBar.TabIndex = 7;
            this.radiusBar.Tag = "";
            this.radiusBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.radiusBar.ValueChanged += new System.EventHandler(this.heightBar_ValueChanged);
            this.radiusBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radiusBar_MouseUp);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(587, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Release";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(587, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Fix";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // legsBox
            // 
            this.legsBox.Enabled = false;
            this.legsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legsBox.FormattingEnabled = true;
            this.legsBox.Items.AddRange(new object[] {
            "-150",
            "-90",
            "-30",
            "30",
            "90",
            "150"});
            this.legsBox.Location = new System.Drawing.Point(587, 125);
            this.legsBox.Name = "legsBox";
            this.legsBox.Size = new System.Drawing.Size(121, 26);
            this.legsBox.TabIndex = 10;
            this.legsBox.Text = "-30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(584, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Leg allocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(803, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(735, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "H";
            // 
            // HRlabel
            // 
            this.HRlabel.AutoSize = true;
            this.HRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HRlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HRlabel.Location = new System.Drawing.Point(765, 161);
            this.HRlabel.Name = "HRlabel";
            this.HRlabel.Size = new System.Drawing.Size(17, 18);
            this.HRlabel.TabIndex = 14;
            this.HRlabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(762, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(762, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "-50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(569, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "-90";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(824, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "90";
            // 
            // Turnlabel
            // 
            this.Turnlabel.AutoSize = true;
            this.Turnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Turnlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Turnlabel.Location = new System.Drawing.Point(698, 349);
            this.Turnlabel.Name = "Turnlabel";
            this.Turnlabel.Size = new System.Drawing.Size(17, 18);
            this.Turnlabel.TabIndex = 20;
            this.Turnlabel.Text = "0";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(859, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 32);
            this.button5.TabIndex = 21;
            this.button5.Text = "Run sketch";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sketchBox
            // 
            this.sketchBox.Enabled = false;
            this.sketchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sketchBox.FormattingEnabled = true;
            this.sketchBox.Items.AddRange(new object[] {
            "test",
            "hit"});
            this.sketchBox.Location = new System.Drawing.Point(859, 43);
            this.sketchBox.Name = "sketchBox";
            this.sketchBox.Size = new System.Drawing.Size(121, 26);
            this.sketchBox.TabIndex = 22;
            this.sketchBox.Text = "test";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(859, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 32);
            this.button6.TabIndex = 23;
            this.button6.Text = "Abort";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(859, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 32);
            this.button7.TabIndex = 24;
            this.button7.Text = "Rotate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.sketchBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Turnlabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HRlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legsBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radiusBar);
            this.Controls.Add(this.heightBar);
            this.Controls.Add(this.turnBar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpiderApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar turnBar;
        private System.Windows.Forms.TrackBar heightBar;
        private System.Windows.Forms.TrackBar radiusBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox legsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HRlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Turnlabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox sketchBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

