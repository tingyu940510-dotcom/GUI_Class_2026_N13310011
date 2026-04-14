namespace N13310011
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.btn_ChangLabel = new System.Windows.Forms.Button();
            this.lab_ChangeLabel = new System.Windows.Forms.Label();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.btnbigger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "N13310011 Gmi";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ClickMe.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClickMe.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ClickMe.Location = new System.Drawing.Point(12, 56);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(159, 60);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = false;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_clickme_Click);
            // 
            // btn_ChangLabel
            // 
            this.btn_ChangLabel.BackColor = System.Drawing.Color.Yellow;
            this.btn_ChangLabel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ChangLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ChangLabel.Location = new System.Drawing.Point(18, 139);
            this.btn_ChangLabel.Name = "btn_ChangLabel";
            this.btn_ChangLabel.Size = new System.Drawing.Size(125, 31);
            this.btn_ChangLabel.TabIndex = 2;
            this.btn_ChangLabel.Text = "按我切換標籤";
            this.btn_ChangLabel.UseVisualStyleBackColor = false;
            this.btn_ChangLabel.Click += new System.EventHandler(this.btn_ChangLabel_Click);
            // 
            // lab_ChangeLabel
            // 
            this.lab_ChangeLabel.AutoSize = true;
            this.lab_ChangeLabel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ChangeLabel.ForeColor = System.Drawing.Color.Purple;
            this.lab_ChangeLabel.Location = new System.Drawing.Point(149, 140);
            this.lab_ChangeLabel.Name = "lab_ChangeLabel";
            this.lab_ChangeLabel.Size = new System.Drawing.Size(88, 24);
            this.lab_ChangeLabel.TabIndex = 3;
            this.lab_ChangeLabel.Text = "label2";
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_Counter.Location = new System.Drawing.Point(149, 186);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(23, 24);
            this.lab_Counter.TabIndex = 5;
            this.lab_Counter.Text = "0";
            // 
            // btn_Counter
            // 
            this.btn_Counter.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Counter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Counter.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Counter.Location = new System.Drawing.Point(18, 185);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(125, 31);
            this.btn_Counter.TabIndex = 4;
            this.btn_Counter.Text = "按我加1";
            this.btn_Counter.UseVisualStyleBackColor = false;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // btnbigger
            // 
            this.btnbigger.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnbigger.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbigger.ForeColor = System.Drawing.Color.Black;
            this.btnbigger.Location = new System.Drawing.Point(248, 56);
            this.btnbigger.Name = "btnbigger";
            this.btnbigger.Size = new System.Drawing.Size(101, 57);
            this.btnbigger.TabIndex = 6;
            this.btnbigger.Text = "按我變大";
            this.btnbigger.UseVisualStyleBackColor = false;
            this.btnbigger.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(568, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "CtrlCV";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(563, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbigger);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_ChangeLabel);
            this.Controls.Add(this.btn_ChangLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Button btn_ChangLabel;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Button btnbigger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

