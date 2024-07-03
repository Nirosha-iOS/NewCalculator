namespace NewCalculator
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(77, 139);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 37);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox.Location = new System.Drawing.Point(77, 63);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(227, 40);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(136, 139);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 37);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(200, 139);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 37);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.add.Location = new System.Drawing.Point(267, 139);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 37);
            this.add.TabIndex = 4;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.min.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.min.Location = new System.Drawing.Point(267, 198);
            this.min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(40, 37);
            this.min.TabIndex = 8;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Location = new System.Drawing.Point(200, 198);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 37);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Location = new System.Drawing.Point(136, 198);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 37);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Location = new System.Drawing.Point(77, 198);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 37);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Location = new System.Drawing.Point(200, 255);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 37);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Location = new System.Drawing.Point(136, 255);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 37);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Location = new System.Drawing.Point(77, 255);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 37);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOperation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOperation.Location = new System.Drawing.Point(200, 313);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(40, 37);
            this.btnOperation.TabIndex = 14;
            this.btnOperation.Text = "=";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Location = new System.Drawing.Point(136, 313);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 37);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Location = new System.Drawing.Point(77, 313);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 37);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button14_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.div.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.div.Location = new System.Drawing.Point(267, 313);
            this.div.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(40, 37);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mul.Location = new System.Drawing.Point(267, 255);
            this.mul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(40, 37);
            this.mul.TabIndex = 15;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDel.Location = new System.Drawing.Point(77, 388);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(229, 49);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 597);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.min);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
    }
}

