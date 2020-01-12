namespace WindowsFormsApplication1
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
            this.file_path_textbox = new System.Windows.Forms.TextBox();
            this.select_file_button = new System.Windows.Forms.Button();
            this.check_file_button = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // file_path_textbox
            // 
            this.file_path_textbox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.file_path_textbox.Location = new System.Drawing.Point(32, 26);
            this.file_path_textbox.Name = "file_path_textbox";
            this.file_path_textbox.ReadOnly = true;
            this.file_path_textbox.Size = new System.Drawing.Size(451, 21);
            this.file_path_textbox.TabIndex = 0;
            this.file_path_textbox.Text = "选择需要校验的CSV格式的文件";
            // 
            // select_file_button
            // 
            this.select_file_button.Location = new System.Drawing.Point(508, 24);
            this.select_file_button.Name = "select_file_button";
            this.select_file_button.Size = new System.Drawing.Size(160, 23);
            this.select_file_button.TabIndex = 1;
            this.select_file_button.Text = "选择需要校验的文件";
            this.select_file_button.UseVisualStyleBackColor = true;
            this.select_file_button.Click += new System.EventHandler(this.select_file_button_Click);
            // 
            // check_file_button
            // 
            this.check_file_button.Enabled = false;
            this.check_file_button.Location = new System.Drawing.Point(508, 81);
            this.check_file_button.Name = "check_file_button";
            this.check_file_button.Size = new System.Drawing.Size(160, 23);
            this.check_file_button.TabIndex = 2;
            this.check_file_button.Text = "校验";
            this.check_file_button.UseVisualStyleBackColor = true;
            this.check_file_button.Click += new System.EventHandler(this.check_file_button_Click);
            // 
            // result_text
            // 
            this.result_text.ForeColor = System.Drawing.Color.Red;
            this.result_text.Location = new System.Drawing.Point(32, 127);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(636, 123);
            this.result_text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 262);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.check_file_button);
            this.Controls.Add(this.select_file_button);
            this.Controls.Add(this.file_path_textbox);
            this.Name = "Form1";
            this.Text = "工资加密代发校验工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_path_textbox;
        private System.Windows.Forms.Button select_file_button;
        private System.Windows.Forms.Button check_file_button;
        private System.Windows.Forms.TextBox result_text;
    }
}

