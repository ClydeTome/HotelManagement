namespace WindowsFormsApp1
{
    partial class Check_In
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkingrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttnAddChildren = new System.Windows.Forms.Button();
            this.bttnAddAdult = new System.Windows.Forms.Button();
            this.bttnSubChildren = new System.Windows.Forms.Button();
            this.bttnSubAdult = new System.Windows.Forms.Button();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcombo1 = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkingrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.checkingrid);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.bttnAddChildren);
            this.panel1.Controls.Add(this.bttnAddAdult);
            this.panel1.Controls.Add(this.bttnSubChildren);
            this.panel1.Controls.Add(this.bttnSubAdult);
            this.panel1.Controls.Add(this.txtAdults);
            this.panel1.Controls.Add(this.txtChildren);
            this.panel1.Controls.Add(this.Label12);
            this.panel1.Controls.Add(this.Label10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtcombo1);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 508);
            this.panel1.TabIndex = 0;
            // 
            // checkingrid
            // 
            this.checkingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkingrid.Location = new System.Drawing.Point(443, 12);
            this.checkingrid.Name = "checkingrid";
            this.checkingrid.Size = new System.Drawing.Size(754, 344);
            this.checkingrid.TabIndex = 85;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(187, 302);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 84;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 82;
            // 
            // bttnAddChildren
            // 
            this.bttnAddChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddChildren.Location = new System.Drawing.Point(310, 211);
            this.bttnAddChildren.Name = "bttnAddChildren";
            this.bttnAddChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnAddChildren.TabIndex = 81;
            this.bttnAddChildren.Text = ">";
            this.bttnAddChildren.UseVisualStyleBackColor = true;
            this.bttnAddChildren.Click += new System.EventHandler(this.bttnAddChildren_Click);
            // 
            // bttnAddAdult
            // 
            this.bttnAddAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddAdult.Location = new System.Drawing.Point(310, 177);
            this.bttnAddAdult.Name = "bttnAddAdult";
            this.bttnAddAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnAddAdult.TabIndex = 80;
            this.bttnAddAdult.Text = ">";
            this.bttnAddAdult.UseVisualStyleBackColor = true;
            this.bttnAddAdult.Click += new System.EventHandler(this.bttnAddAdult_Click);
            // 
            // bttnSubChildren
            // 
            this.bttnSubChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubChildren.Location = new System.Drawing.Point(281, 211);
            this.bttnSubChildren.Name = "bttnSubChildren";
            this.bttnSubChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnSubChildren.TabIndex = 79;
            this.bttnSubChildren.Text = "<";
            this.bttnSubChildren.UseVisualStyleBackColor = true;
            this.bttnSubChildren.Click += new System.EventHandler(this.bttnSubChildren_Click);
            // 
            // bttnSubAdult
            // 
            this.bttnSubAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubAdult.Location = new System.Drawing.Point(281, 177);
            this.bttnSubAdult.Name = "bttnSubAdult";
            this.bttnSubAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnSubAdult.TabIndex = 78;
            this.bttnSubAdult.Text = "<";
            this.bttnSubAdult.UseVisualStyleBackColor = true;
            this.bttnSubAdult.Click += new System.EventHandler(this.bttnSubAdult_Click);
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(187, 178);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.ReadOnly = true;
            this.txtAdults.Size = new System.Drawing.Size(75, 25);
            this.txtAdults.TabIndex = 77;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(187, 209);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.ReadOnly = true;
            this.txtChildren.Size = new System.Drawing.Size(75, 25);
            this.txtChildren.TabIndex = 76;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(68, 215);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 16);
            this.Label12.TabIndex = 75;
            this.Label12.Text = "No. Of Children";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(79, 184);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 16);
            this.Label10.TabIndex = 74;
            this.Label10.Text = "No. Of Adults";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1047, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Check-In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcombo1
            // 
            this.txtcombo1.FormattingEnabled = true;
            this.txtcombo1.Location = new System.Drawing.Point(187, 111);
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(176, 21);
            this.txtcombo1.TabIndex = 61;
            this.txtcombo1.SelectedIndexChanged += new System.EventHandler(this.txtcombo1_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(187, 408);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(176, 25);
            this.txtTotal.TabIndex = 59;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check Out Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check In Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Name\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction ID\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK IN FORM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 363);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Room Rate";
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Check_In";
            this.Text = "Check_In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkingrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtcombo1;
        internal System.Windows.Forms.Button bttnAddChildren;
        internal System.Windows.Forms.Button bttnAddAdult;
        internal System.Windows.Forms.Button bttnSubChildren;
        internal System.Windows.Forms.Button bttnSubAdult;
        internal System.Windows.Forms.TextBox txtAdults;
        internal System.Windows.Forms.TextBox txtChildren;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView checkingrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
    }
}