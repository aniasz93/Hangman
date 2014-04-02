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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "HANGMAN";
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.rankBtn);
            this.Controls.Add(this.instrBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.newBtn);
            this.Name = "OpenForm";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button instrBtn;
        private System.Windows.Forms.Button rankBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label label1;
    }
}

