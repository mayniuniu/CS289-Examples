namespace WinForm
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
            this.nameLlabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLlabel
            // 
            this.nameLlabel.AutoSize = true;
            this.nameLlabel.Location = new System.Drawing.Point(27, 26);
            this.nameLlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLlabel.Name = "nameLlabel";
            this.nameLlabel.Size = new System.Drawing.Size(174, 20);
            this.nameLlabel.TabIndex = 0;
            this.nameLlabel.Text = "請輸入 Pokemon 名字:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(27, 67);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(174, 20);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "請輸入 Pokemon 身高:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(27, 107);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(174, 20);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "請輸入 Pokemon 體重:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(202, 22);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(164, 29);
            this.nameTextbox.TabIndex = 3;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(202, 63);
            this.heightTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(164, 29);
            this.heightTextbox.TabIndex = 4;
            // 
            // weightTextbox
            // 
            this.weightTextbox.Location = new System.Drawing.Point(202, 103);
            this.weightTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(164, 29);
            this.weightTextbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "完成輸入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(376, 31);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(73, 20);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "資料輸出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 207);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weightTextbox);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nameLlabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Pokemon Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLlabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputLabel;
    }
}

