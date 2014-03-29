namespace Hangman
{
    partial class GameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letterTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usedLetterLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.guessingWordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryLabel.Location = new System.Drawing.Point(108, 36);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 20);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the letter:";
            // 
            // letterTB
            // 
            this.letterTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterTB.Location = new System.Drawing.Point(130, 164);
            this.letterTB.MaxLength = 1;
            this.letterTB.Name = "letterTB";
            this.letterTB.Size = new System.Drawing.Size(35, 26);
            this.letterTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Used:";
            // 
            // usedLetterLabel
            // 
            this.usedLetterLabel.AutoSize = true;
            this.usedLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usedLetterLabel.Location = new System.Drawing.Point(67, 206);
            this.usedLetterLabel.Name = "usedLetterLabel";
            this.usedLetterLabel.Size = new System.Drawing.Size(0, 20);
            this.usedLetterLabel.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBtn.Location = new System.Drawing.Point(200, 164);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(44, 26);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(229, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(196, 268);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 20);
            this.timeLabel.TabIndex = 8;
            // 
            // endBtn
            // 
            this.endBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endBtn.Location = new System.Drawing.Point(96, 312);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(86, 38);
            this.endBtn.TabIndex = 9;
            this.endBtn.Text = "END";
            this.endBtn.UseVisualStyleBackColor = true;
            // 
            // guessingWordLabel
            // 
            this.guessingWordLabel.AutoSize = true;
            this.guessingWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessingWordLabel.Location = new System.Drawing.Point(21, 90);
            this.guessingWordLabel.Name = "guessingWordLabel";
            this.guessingWordLabel.Size = new System.Drawing.Size(66, 24);
            this.guessingWordLabel.TabIndex = 10;
            this.guessingWordLabel.Text = "label5";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.guessingWordLabel);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.usedLetterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letterTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letterTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usedLetterLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label guessingWordLabel;
    }
}