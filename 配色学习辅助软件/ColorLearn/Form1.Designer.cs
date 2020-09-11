namespace ColorLearn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorSelect1 = new ColorLearn.ColorSelect();
            this.colorPanel1 = new ColorLearn.ColorPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 21);
            this.textBox1.TabIndex = 2;
            // 
            // colorSelect1
            // 
            this.colorSelect1.Location = new System.Drawing.Point(339, 44);
            this.colorSelect1.Name = "colorSelect1";
            this.colorSelect1.Size = new System.Drawing.Size(650, 494);
            this.colorSelect1.TabIndex = 1;
            this.colorSelect1.colorClick += new MyEvent.ColorClick(this.colorSelect1_colorClick);
            // 
            // colorPanel1
            // 
            this.colorPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorPanel1.Location = new System.Drawing.Point(33, 81);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(111, 101);
            this.colorPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 599);
            this.Controls.Add(this.colorPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.colorSelect1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorSelect colorSelect1;
        private System.Windows.Forms.TextBox textBox1;
        private ColorPanel colorPanel1;
    }
}

