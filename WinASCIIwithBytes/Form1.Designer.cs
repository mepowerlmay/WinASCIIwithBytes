namespace WinASCIIwithBytes
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTrans = new System.Windows.Forms.Button();
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultASCII = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtResult10 = new System.Windows.Forms.TextBox();
            this.txtResult16 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrans.Location = new System.Drawing.Point(382, 9);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(83, 51);
            this.btnTrans.TabIndex = 0;
            this.btnTrans.Text = "轉換";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // txtFromValue
            // 
            this.txtFromValue.Location = new System.Drawing.Point(94, 41);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(282, 22);
            this.txtFromValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "來源資料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "來源類型";
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Location = new System.Drawing.Point(5, 4);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(53, 16);
            this.rbASCII.TabIndex = 8;
            this.rbASCII.TabStop = true;
            this.rbASCII.Text = "ASCII";
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(64, 4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(53, 16);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "2進位";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(123, 4);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(59, 16);
            this.rb10.TabIndex = 10;
            this.rb10.TabStop = true;
            this.rb10.Text = "10進位";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(187, 4);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(59, 16);
            this.rb16.TabIndex = 11;
            this.rb16.TabStop = true;
            this.rb16.Text = "16進位";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb16);
            this.panel1.Controls.Add(this.rbASCII);
            this.panel1.Controls.Add(this.rb10);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Location = new System.Drawing.Point(94, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 23);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ASCII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "2進位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "10進位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "16進位";
            // 
            // txtResultASCII
            // 
            this.txtResultASCII.Location = new System.Drawing.Point(77, 89);
            this.txtResultASCII.Name = "txtResultASCII";
            this.txtResultASCII.Size = new System.Drawing.Size(282, 22);
            this.txtResultASCII.TabIndex = 18;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(77, 121);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(282, 22);
            this.txtResult2.TabIndex = 19;
            // 
            // txtResult10
            // 
            this.txtResult10.Location = new System.Drawing.Point(77, 149);
            this.txtResult10.Name = "txtResult10";
            this.txtResult10.Size = new System.Drawing.Size(282, 22);
            this.txtResult10.TabIndex = 20;
            // 
            // txtResult16
            // 
            this.txtResult16.Location = new System.Drawing.Point(77, 182);
            this.txtResult16.Name = "txtResult16";
            this.txtResult16.Size = new System.Drawing.Size(282, 22);
            this.txtResult16.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 212);
            this.Controls.Add(this.txtResult16);
            this.Controls.Add(this.txtResult10);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResultASCII);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFromValue);
            this.Controls.Add(this.btnTrans);
            this.MinimumSize = new System.Drawing.Size(550, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII TO 2 10 16";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.TextBox txtFromValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbASCII;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultASCII;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtResult10;
        private System.Windows.Forms.TextBox txtResult16;
    }
}

