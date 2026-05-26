namespace GUl_Class_N13310030
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_CHangeLabel = new System.Windows.Forms.Label();
            this.btn_ChangeLable = new System.Windows.Forms.Button();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.BtnBigger = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label222 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "N13310030-翔";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClickMe.Location = new System.Drawing.Point(1, 82);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(199, 68);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // lab_CHangeLabel
            // 
            this.lab_CHangeLabel.AutoSize = true;
            this.lab_CHangeLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_CHangeLabel.Location = new System.Drawing.Point(196, 177);
            this.lab_CHangeLabel.Name = "lab_CHangeLabel";
            this.lab_CHangeLabel.Size = new System.Drawing.Size(38, 27);
            this.lab_CHangeLabel.TabIndex = 2;
            this.lab_CHangeLabel.Text = "HI";
            // 
            // btn_ChangeLable
            // 
            this.btn_ChangeLable.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ChangeLable.ForeColor = System.Drawing.Color.Crimson;
            this.btn_ChangeLable.Location = new System.Drawing.Point(1, 168);
            this.btn_ChangeLable.Name = "btn_ChangeLable";
            this.btn_ChangeLable.Size = new System.Drawing.Size(175, 48);
            this.btn_ChangeLable.TabIndex = 3;
            this.btn_ChangeLable.Text = "按我切換標籤";
            this.btn_ChangeLable.UseVisualStyleBackColor = true;
            this.btn_ChangeLable.Click += new System.EventHandler(this.btn_ChangeLable_Click);
            // 
            // btn_Counter
            // 
            this.btn_Counter.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Counter.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Counter.Location = new System.Drawing.Point(1, 235);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(199, 55);
            this.btn_Counter.TabIndex = 5;
            this.btn_Counter.Text = "按我一下";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Counter.Location = new System.Drawing.Point(209, 246);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(25, 27);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // BtnBigger
            // 
            this.BtnBigger.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnBigger.Location = new System.Drawing.Point(245, 82);
            this.BtnBigger.Name = "BtnBigger";
            this.BtnBigger.Size = new System.Drawing.Size(170, 62);
            this.BtnBigger.TabIndex = 6;
            this.BtnBigger.Text = "按鈕放大";
            this.BtnBigger.UseVisualStyleBackColor = true;
            this.BtnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "按我複製至串到Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 20F);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(272, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "按我一下-1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(10, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "計算機";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(461, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(336, 51);
            this.button4.TabIndex = 12;
            this.button4.Text = "期中考-攝氏轉華氏";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label222.ForeColor = System.Drawing.Color.Crimson;
            this.label222.Location = new System.Drawing.Point(337, 315);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(19, 19);
            this.label222.TabIndex = 13;
            this.label222.Text = "0";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(245, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 45);
            this.button5.TabIndex = 14;
            this.button5.Text = "開始";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(384, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 41);
            this.button6.TabIndex = 15;
            this.button6.Text = "暫停";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(490, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 40);
            this.button7.TabIndex = 16;
            this.button7.Text = "歸0";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.ForeColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(448, 367);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(237, 53);
            this.button8.TabIndex = 17;
            this.button8.Text = "checkBox";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(245, 367);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 53);
            this.button9.TabIndex = 18;
            this.button9.Text = "Layout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label222);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnBigger);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_ChangeLable);
            this.Controls.Add(this.lab_CHangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_CHangeLabel;
        private System.Windows.Forms.Button btn_ChangeLable;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button BtnBigger;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

