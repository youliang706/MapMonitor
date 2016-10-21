namespace MapMonitor
{
    partial class frmAudioSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioSend));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Example = new System.Windows.Forms.ComboBox();
            this.textBox_SendContent = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "常用短语：";
            // 
            // comboBox_Example
            // 
            this.comboBox_Example.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Example.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Example.FormattingEnabled = true;
            this.comboBox_Example.Location = new System.Drawing.Point(82, 15);
            this.comboBox_Example.Name = "comboBox_Example";
            this.comboBox_Example.Size = new System.Drawing.Size(290, 25);
            this.comboBox_Example.TabIndex = 1;
            this.comboBox_Example.SelectedIndexChanged += new System.EventHandler(this.comboBox_Example_SelectedIndexChanged);
            // 
            // textBox_SendContent
            // 
            this.textBox_SendContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SendContent.Location = new System.Drawing.Point(15, 50);
            this.textBox_SendContent.MaxLength = 70;
            this.textBox_SendContent.Multiline = true;
            this.textBox_SendContent.Name = "textBox_SendContent";
            this.textBox_SendContent.Size = new System.Drawing.Size(357, 114);
            this.textBox_SendContent.TabIndex = 2;
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Send.Location = new System.Drawing.Point(148, 175);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(90, 26);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // frmAudioSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_SendContent);
            this.Controls.Add(this.comboBox_Example);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音下发";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Example;
        private System.Windows.Forms.TextBox textBox_SendContent;
        private System.Windows.Forms.Button button_Send;
    }
}