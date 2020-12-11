namespace WindowsFormsApp1
{
    partial class RegisterRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regtxt1 = new System.Windows.Forms.TextBox();
            this.regtxt3 = new System.Windows.Forms.TextBox();
            this.regtxt2 = new System.Windows.Forms.TextBox();
            this.regtxt4 = new System.Windows.Forms.TextBox();
            this.regbtn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regbtnref = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.regcb1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regbt2 = new System.Windows.Forms.Button();
            this.prgbtn = new System.Windows.Forms.Button();
            this.regview1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Rate";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // regtxt1
            // 
            this.regtxt1.Location = new System.Drawing.Point(174, 151);
            this.regtxt1.Name = "regtxt1";
            this.regtxt1.Size = new System.Drawing.Size(166, 20);
            this.regtxt1.TabIndex = 8;
            // 
            // regtxt3
            // 
            this.regtxt3.Location = new System.Drawing.Point(174, 221);
            this.regtxt3.Name = "regtxt3";
            this.regtxt3.Size = new System.Drawing.Size(166, 20);
            this.regtxt3.TabIndex = 9;
            // 
            // regtxt2
            // 
            this.regtxt2.Location = new System.Drawing.Point(174, 183);
            this.regtxt2.Name = "regtxt2";
            this.regtxt2.Size = new System.Drawing.Size(166, 20);
            this.regtxt2.TabIndex = 10;
            this.regtxt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // regtxt4
            // 
            this.regtxt4.Location = new System.Drawing.Point(174, 264);
            this.regtxt4.Name = "regtxt4";
            this.regtxt4.Size = new System.Drawing.Size(166, 20);
            this.regtxt4.TabIndex = 11;
            // 
            // regbtn1
            // 
            this.regbtn1.Location = new System.Drawing.Point(58, 325);
            this.regbtn1.Name = "regbtn1";
            this.regbtn1.Size = new System.Drawing.Size(91, 38);
            this.regbtn1.TabIndex = 12;
            this.regbtn1.Text = "Add Room";
            this.regbtn1.UseVisualStyleBackColor = true;
            this.regbtn1.Click += new System.EventHandler(this.regbtn1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.regview1);
            this.panel1.Controls.Add(this.regbtnref);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.regcb1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(453, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 592);
            this.panel1.TabIndex = 13;
            // 
            // regbtnref
            // 
            this.regbtnref.Location = new System.Drawing.Point(9, 74);
            this.regbtnref.Name = "regbtnref";
            this.regbtnref.Size = new System.Drawing.Size(75, 23);
            this.regbtnref.TabIndex = 4;
            this.regbtnref.Text = "Refresh";
            this.regbtnref.UseVisualStyleBackColor = true;
            this.regbtnref.Click += new System.EventHandler(this.regbtnref_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Room List";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // regcb1
            // 
            this.regcb1.FormattingEnabled = true;
            this.regcb1.Location = new System.Drawing.Point(9, 33);
            this.regcb1.Name = "regcb1";
            this.regcb1.Size = new System.Drawing.Size(166, 21);
            this.regcb1.TabIndex = 1;
            this.regcb1.SelectedIndexChanged += new System.EventHandler(this.regcb1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room Types";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status and Room List";
            // 
            // regbt2
            // 
            this.regbt2.Location = new System.Drawing.Point(58, 614);
            this.regbt2.Name = "regbt2";
            this.regbt2.Size = new System.Drawing.Size(75, 23);
            this.regbt2.TabIndex = 15;
            this.regbt2.Text = "Return";
            this.regbt2.UseVisualStyleBackColor = true;
            this.regbt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prgbtn
            // 
            this.prgbtn.Location = new System.Drawing.Point(264, 614);
            this.prgbtn.Name = "prgbtn";
            this.prgbtn.Size = new System.Drawing.Size(75, 23);
            this.prgbtn.TabIndex = 16;
            this.prgbtn.Text = "Purge Table";
            this.prgbtn.UseVisualStyleBackColor = true;
            this.prgbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // regview1
            // 
            this.regview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regview1.Location = new System.Drawing.Point(12, 128);
            this.regview1.Name = "regview1";
            this.regview1.Size = new System.Drawing.Size(703, 291);
            this.regview1.TabIndex = 5;
            // 
            // RegisterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.prgbtn);
            this.Controls.Add(this.regbt2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regbtn1);
            this.Controls.Add(this.regtxt4);
            this.Controls.Add(this.regtxt2);
            this.Controls.Add(this.regtxt3);
            this.Controls.Add(this.regtxt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterRoom";
            this.Text = "RegisterRoom";
            this.Load += new System.EventHandler(this.RegisterRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regtxt1;
        private System.Windows.Forms.TextBox regtxt3;
        private System.Windows.Forms.TextBox regtxt2;
        private System.Windows.Forms.TextBox regtxt4;
        private System.Windows.Forms.Button regbtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox regcb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button regbt2;
        private System.Windows.Forms.Button prgbtn;
        private System.Windows.Forms.Button regbtnref;
        private System.Windows.Forms.DataGridView regview1;
    }
}