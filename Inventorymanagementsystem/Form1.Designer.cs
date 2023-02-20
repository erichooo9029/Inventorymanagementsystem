namespace Inventorymanagementsystem
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wronglabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nametextBox.Location = new System.Drawing.Point(70, 39);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(247, 36);
            this.nametextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "帳號";
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.ForeColor = System.Drawing.Color.Red;
            this.wronglabel.Location = new System.Drawing.Point(65, 163);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(0, 27);
            this.wronglabel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginbutton);
            this.groupBox1.Controls.Add(this.wronglabel);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陸系統";
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginbutton.Location = new System.Drawing.Point(70, 207);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(157, 46);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "登入";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordtextBox.Location = new System.Drawing.Point(70, 103);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(247, 36);
            this.passwordtextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(626, 387);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtextBox;
    }
}

