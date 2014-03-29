namespace Hangman
{
    partial class OpenForm
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
            this.newBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.instrBtn = new System.Windows.Forms.Button();
            this.rankBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.langLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newBtn.Location = new System.Drawing.Point(100, 90);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(95, 45);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "NEW GAME";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadBtn.Location = new System.Drawing.Point(100, 141);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(95, 45);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "LOAD GAME";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // instrBtn
            // 
            this.instrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instrBtn.Location = new System.Drawing.Point(100, 192);
            this.instrBtn.Name = "instrBtn";
            this.instrBtn.Size = new System.Drawing.Size(95, 45);
            this.instrBtn.TabIndex = 2;
            this.instrBtn.Text = "HOW TO PLAY";
            this.instrBtn.UseVisualStyleBackColor = true;
            this.instrBtn.Click += new System.EventHandler(this.instrBtn_Click);
            // 
            // rankBtn
            // 
            this.rankBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rankBtn.Location = new System.Drawing.Point(100, 243);
            this.rankBtn.Name = "rankBtn";
            this.rankBtn.Size = new System.Drawing.Size(95, 45);
            this.rankBtn.TabIndex = 3;
            this.rankBtn.Text = "RANKING";
            this.rankBtn.UseVisualStyleBackColor = true;
            this.rankBtn.Click += new System.EventHandler(this.rankBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quitBtn.Location = new System.Drawing.Point(100, 294);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(95, 45);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "QUIT";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.langLabel.Location = new System.Drawing.Point(50, 30);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(72, 16);
            this.langLabel.TabIndex = 5;
            this.langLabel.Text = "Language:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(120, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "english";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "polski";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.rankBtn);
            this.Controls.Add(this.instrBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.newBtn);
            this.Name = "OpenForm";
            this.Text = "Hangman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button instrBtn;
        private System.Windows.Forms.Button rankBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

