namespace WatermarkTextBoxDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.watermaskTextBox2 = new CSharpWin.WatermarkTextBox();
            this.watermaskTextBox1 = new CSharpWin.WatermarkTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "密 码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "账 号";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(171, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(258, 14);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.csharpwin.com(CS 程序员之窗)";
            // 
            // watermaskTextBox2
            // 
            this.watermaskTextBox2.EmptyTextTip = "请输入你的账号";
            this.watermaskTextBox2.Location = new System.Drawing.Point(78, 6);
            this.watermaskTextBox2.Name = "watermaskTextBox2";
            this.watermaskTextBox2.Size = new System.Drawing.Size(150, 21);
            this.watermaskTextBox2.TabIndex = 1;
            // 
            // watermaskTextBox1
            // 
            this.watermaskTextBox1.EmptyTextTip = "请输入密码";
            this.watermaskTextBox1.Location = new System.Drawing.Point(78, 41);
            this.watermaskTextBox1.Name = "watermaskTextBox1";
            this.watermaskTextBox1.Size = new System.Drawing.Size(150, 21);
            this.watermaskTextBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 101);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.watermaskTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watermaskTextBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CS 程序员之窗 - 水印输入控件 WatermarkTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharpWin.WatermarkTextBox watermaskTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CSharpWin.WatermarkTextBox watermaskTextBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}

