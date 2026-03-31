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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_CHangeLabel = new System.Windows.Forms.Label();
            this.btn_ChangeLable = new System.Windows.Forms.Button();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
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
            this.btn_Counter.Size = new System.Drawing.Size(175, 48);
            this.btn_Counter.TabIndex = 5;
            this.btn_Counter.Text = "按我一下";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Counter.Location = new System.Drawing.Point(196, 244);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(25, 27);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_ChangeLable);
            this.Controls.Add(this.lab_CHangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

