namespace WindowsFormsApp1
{
    partial class FindEmpSalary
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxBasicsal = new System.Windows.Forms.TextBox();
            this.boxHra = new System.Windows.Forms.TextBox();
            this.boxDa = new System.Windows.Forms.TextBox();
            this.boxTa = new System.Windows.Forms.TextBox();
            this.boxPf = new System.Windows.Forms.TextBox();
            this.boxPt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.boxGS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Sal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "HRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "TA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "PF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "PT";
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(300, 26);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(100, 22);
            this.boxId.TabIndex = 10;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(300, 63);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 22);
            this.boxName.TabIndex = 12;
            // 
            // boxBasicsal
            // 
            this.boxBasicsal.Location = new System.Drawing.Point(300, 102);
            this.boxBasicsal.Name = "boxBasicsal";
            this.boxBasicsal.Size = new System.Drawing.Size(100, 22);
            this.boxBasicsal.TabIndex = 13;
            // 
            // boxHra
            // 
            this.boxHra.Location = new System.Drawing.Point(300, 148);
            this.boxHra.Name = "boxHra";
            this.boxHra.ReadOnly = true;
            this.boxHra.Size = new System.Drawing.Size(100, 22);
            this.boxHra.TabIndex = 14;
            // 
            // boxDa
            // 
            this.boxDa.Location = new System.Drawing.Point(300, 194);
            this.boxDa.Name = "boxDa";
            this.boxDa.ReadOnly = true;
            this.boxDa.Size = new System.Drawing.Size(100, 22);
            this.boxDa.TabIndex = 15;
            // 
            // boxTa
            // 
            this.boxTa.Location = new System.Drawing.Point(300, 235);
            this.boxTa.Name = "boxTa";
            this.boxTa.ReadOnly = true;
            this.boxTa.Size = new System.Drawing.Size(100, 22);
            this.boxTa.TabIndex = 16;
            // 
            // boxPf
            // 
            this.boxPf.Location = new System.Drawing.Point(300, 285);
            this.boxPf.Name = "boxPf";
            this.boxPf.ReadOnly = true;
            this.boxPf.Size = new System.Drawing.Size(100, 22);
            this.boxPf.TabIndex = 17;
            // 
            // boxPt
            // 
            this.boxPt.Location = new System.Drawing.Point(300, 321);
            this.boxPt.Name = "boxPt";
            this.boxPt.ReadOnly = true;
            this.boxPt.Size = new System.Drawing.Size(100, 22);
            this.boxPt.TabIndex = 18;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(484, 102);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 19;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxGS
            // 
            this.boxGS.Location = new System.Drawing.Point(300, 365);
            this.boxGS.Name = "boxGS";
            this.boxGS.Size = new System.Drawing.Size(100, 22);
            this.boxGS.TabIndex = 20;
            this.boxGS.TextChanged += new System.EventHandler(this.boxGS_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gross Salary";
            // 
            // FindEmpSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxGS);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.boxPt);
            this.Controls.Add(this.boxPf);
            this.Controls.Add(this.boxTa);
            this.Controls.Add(this.boxDa);
            this.Controls.Add(this.boxHra);
            this.Controls.Add(this.boxBasicsal);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindEmpSalary";
            this.Text = "TA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxBasicsal;
        private System.Windows.Forms.TextBox boxHra;
        private System.Windows.Forms.TextBox boxDa;
        private System.Windows.Forms.TextBox boxTa;
        private System.Windows.Forms.TextBox boxPf;
        private System.Windows.Forms.TextBox boxPt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox boxGS;
        private System.Windows.Forms.Label label9;
    }
}