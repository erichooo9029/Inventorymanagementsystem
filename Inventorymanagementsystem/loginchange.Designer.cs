namespace Inventorymanagementsystem
{
    partial class loginchange
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logindataDataSet = new Inventorymanagementsystem.logindataDataSet();
            this.logindataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindataTableAdapter = new Inventorymanagementsystem.logindataDataSetTableAdapters.logindataTableAdapter();
            this.tableAdapterManager = new Inventorymanagementsystem.logindataDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewlogin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "退出帳號編輯視窗";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號:";
            // 
            // logindataDataSet
            // 
            this.logindataDataSet.DataSetName = "logindataDataSet";
            this.logindataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logindataBindingSource
            // 
            this.logindataBindingSource.DataMember = "logindata";
            this.logindataBindingSource.DataSource = this.logindataDataSet;
            // 
            // logindataTableAdapter
            // 
            this.logindataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.logindataTableAdapter = this.logindataTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inventorymanagementsystem.logindataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "新增帳號";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "更改密碼";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "觀看現有帳戶";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewlogin
            // 
            this.dataGridViewlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlogin.Location = new System.Drawing.Point(408, 12);
            this.dataGridViewlogin.Name = "dataGridViewlogin";
            this.dataGridViewlogin.RowTemplate.Height = 24;
            this.dataGridViewlogin.Size = new System.Drawing.Size(254, 362);
            this.dataGridViewlogin.TabIndex = 8;
            // 
            // loginchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 408);
            this.Controls.Add(this.dataGridViewlogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "loginchange";
            this.Text = "loginchange";
            this.Load += new System.EventHandler(this.loginchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private logindataDataSet logindataDataSet;
        private System.Windows.Forms.BindingSource logindataBindingSource;
        private logindataDataSetTableAdapters.logindataTableAdapter logindataTableAdapter;
        private logindataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewlogin;
    }
}