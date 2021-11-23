namespace HashCalculator
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
            this.tB_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_md5 = new System.Windows.Forms.TextBox();
            this.tb_sha1 = new System.Windows.Forms.TextBox();
            this.tb_sha2 = new System.Windows.Forms.TextBox();
            this.bt_ex = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tB_input
            // 
            this.tB_input.Location = new System.Drawing.Point(12, 25);
            this.tB_input.Name = "tB_input";
            this.tB_input.Size = new System.Drawing.Size(848, 20);
            this.tB_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Format";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MD-5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SHA-1";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SHA-256";
            // 
            // tb_md5
            // 
            this.tb_md5.Location = new System.Drawing.Point(12, 108);
            this.tb_md5.Name = "tb_md5";
            this.tb_md5.ReadOnly = true;
            this.tb_md5.Size = new System.Drawing.Size(846, 20);
            this.tb_md5.TabIndex = 7;
            // 
            // tb_sha1
            // 
            this.tb_sha1.Location = new System.Drawing.Point(12, 147);
            this.tb_sha1.Name = "tb_sha1";
            this.tb_sha1.ReadOnly = true;
            this.tb_sha1.Size = new System.Drawing.Size(846, 20);
            this.tb_sha1.TabIndex = 8;
            // 
            // tb_sha2
            // 
            this.tb_sha2.Location = new System.Drawing.Point(12, 186);
            this.tb_sha2.Name = "tb_sha2";
            this.tb_sha2.ReadOnly = true;
            this.tb_sha2.Size = new System.Drawing.Size(846, 20);
            this.tb_sha2.TabIndex = 9;
            // 
            // bt_ex
            // 
            this.bt_ex.Location = new System.Drawing.Point(12, 212);
            this.bt_ex.Name = "bt_ex";
            this.bt_ex.Size = new System.Drawing.Size(75, 23);
            this.bt_ex.TabIndex = 10;
            this.bt_ex.Text = "Tính Toán";
            this.bt_ex.UseVisualStyleBackColor = true;
            this.bt_ex.Click += new System.EventHandler(this.bt_ex_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.Location = new System.Drawing.Point(93, 212);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(75, 23);
            this.btn_erase.TabIndex = 11;
            this.btn_erase.Text = "Xóa";
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(81, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Text Format";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hex Format";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(263, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Binary File";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 247);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.bt_ex);
            this.Controls.Add(this.tb_sha2);
            this.Controls.Add(this.tb_sha1);
            this.Controls.Add(this.tb_md5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_input);
            this.Name = "Form1";
            this.Text = "Hash Calulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_md5;
        private System.Windows.Forms.TextBox tb_sha1;
        private System.Windows.Forms.TextBox tb_sha2;
        private System.Windows.Forms.Button bt_ex;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

