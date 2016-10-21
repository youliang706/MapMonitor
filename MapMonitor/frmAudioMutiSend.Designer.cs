namespace MapMonitor
{
    partial class frmAudioMutiSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioMutiSend));
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_SendContent = new System.Windows.Forms.TextBox();
            this.comboBox_Example = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLines = new System.Windows.Forms.ComboBox();
            this.lstBuses = new System.Windows.Forms.ListBox();
            this.lstBuses2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Send.Location = new System.Drawing.Point(654, 175);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(90, 26);
            this.button_Send.TabIndex = 7;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_SendContent
            // 
            this.textBox_SendContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SendContent.Location = new System.Drawing.Point(388, 48);
            this.textBox_SendContent.MaxLength = 70;
            this.textBox_SendContent.Multiline = true;
            this.textBox_SendContent.Name = "textBox_SendContent";
            this.textBox_SendContent.Size = new System.Drawing.Size(356, 114);
            this.textBox_SendContent.TabIndex = 6;
            // 
            // comboBox_Example
            // 
            this.comboBox_Example.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Example.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Example.FormattingEnabled = true;
            this.comboBox_Example.Location = new System.Drawing.Point(454, 13);
            this.comboBox_Example.Name = "comboBox_Example";
            this.comboBox_Example.Size = new System.Drawing.Size(290, 25);
            this.comboBox_Example.TabIndex = 5;
            this.comboBox_Example.SelectedIndexChanged += new System.EventHandler(this.comboBox_Example_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(385, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "常用短语：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "线路：";
            // 
            // cboLines
            // 
            this.cboLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLines.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboLines.FormattingEnabled = true;
            this.cboLines.Location = new System.Drawing.Point(57, 13);
            this.cboLines.Name = "cboLines";
            this.cboLines.Size = new System.Drawing.Size(100, 25);
            this.cboLines.TabIndex = 9;
            this.cboLines.SelectedIndexChanged += new System.EventHandler(this.cboLines_SelectedIndexChanged);
            // 
            // lstBuses
            // 
            this.lstBuses.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstBuses.FormattingEnabled = true;
            this.lstBuses.ItemHeight = 17;
            this.lstBuses.Location = new System.Drawing.Point(15, 48);
            this.lstBuses.Name = "lstBuses";
            this.lstBuses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBuses.Size = new System.Drawing.Size(142, 293);
            this.lstBuses.TabIndex = 10;
            // 
            // lstBuses2
            // 
            this.lstBuses2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstBuses2.FormattingEnabled = true;
            this.lstBuses2.ItemHeight = 17;
            this.lstBuses2.Location = new System.Drawing.Point(214, 48);
            this.lstBuses2.Name = "lstBuses2";
            this.lstBuses2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBuses2.Size = new System.Drawing.Size(142, 293);
            this.lstBuses2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Location = new System.Drawing.Point(163, 192);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 27);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(211, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "已选车辆：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNum.Location = new System.Drawing.Point(385, 237);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(83, 17);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "已选择 0 辆车";
            // 
            // frmAudioMutiSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 361);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBuses2);
            this.Controls.Add(this.lstBuses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_SendContent);
            this.Controls.Add(this.comboBox_Example);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioMutiSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音下发";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_SendContent;
        private System.Windows.Forms.ComboBox comboBox_Example;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLines;
        private System.Windows.Forms.ListBox lstBuses;
        private System.Windows.Forms.ListBox lstBuses2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum;
    }
}