namespace Hangman
{
    partial class GameOptionsForm
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.englishRadioBtn = new System.Windows.Forms.RadioButton();
            this.polishRadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mathRadioBtn = new System.Windows.Forms.RadioButton();
            this.cartoonTitlesRadioBtn = new System.Windows.Forms.RadioButton();
            this.cartoonCharsRadioBtn = new System.Windows.Forms.RadioButton();
            this.colorsRadioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hardRadioBtn = new System.Windows.Forms.RadioButton();
            this.mediumRadioBtn = new System.Windows.Forms.RadioButton();
            this.easyRadioBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose language\r\nof the\r\npassword";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnBtn.Location = new System.Drawing.Point(150, 305);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(95, 45);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "GAME OPTIONS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.englishRadioBtn);
            this.groupBox1.Controls.Add(this.polishRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(123, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // englishRadioBtn
            // 
            this.englishRadioBtn.AutoSize = true;
            this.englishRadioBtn.Location = new System.Drawing.Point(6, 34);
            this.englishRadioBtn.Name = "englishRadioBtn";
            this.englishRadioBtn.Size = new System.Drawing.Size(58, 17);
            this.englishRadioBtn.TabIndex = 1;
            this.englishRadioBtn.TabStop = true;
            this.englishRadioBtn.Text = "english";
            this.englishRadioBtn.UseVisualStyleBackColor = true;
            // 
            // polishRadioBtn
            // 
            this.polishRadioBtn.AutoSize = true;
            this.polishRadioBtn.Location = new System.Drawing.Point(7, 11);
            this.polishRadioBtn.Name = "polishRadioBtn";
            this.polishRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.polishRadioBtn.TabIndex = 0;
            this.polishRadioBtn.TabStop = true;
            this.polishRadioBtn.Text = "polish";
            this.polishRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose category\r\nof the\r\npassword";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mathRadioBtn);
            this.groupBox2.Controls.Add(this.cartoonTitlesRadioBtn);
            this.groupBox2.Controls.Add(this.cartoonCharsRadioBtn);
            this.groupBox2.Controls.Add(this.colorsRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(123, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // mathRadioBtn
            // 
            this.mathRadioBtn.AutoSize = true;
            this.mathRadioBtn.Location = new System.Drawing.Point(6, 80);
            this.mathRadioBtn.Name = "mathRadioBtn";
            this.mathRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.mathRadioBtn.TabIndex = 3;
            this.mathRadioBtn.TabStop = true;
            this.mathRadioBtn.Text = "mathematic";
            this.mathRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cartoonTitlesRadioBtn
            // 
            this.cartoonTitlesRadioBtn.AutoSize = true;
            this.cartoonTitlesRadioBtn.Location = new System.Drawing.Point(6, 57);
            this.cartoonTitlesRadioBtn.Name = "cartoonTitlesRadioBtn";
            this.cartoonTitlesRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.cartoonTitlesRadioBtn.TabIndex = 2;
            this.cartoonTitlesRadioBtn.TabStop = true;
            this.cartoonTitlesRadioBtn.Text = "cartoon titles";
            this.cartoonTitlesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cartoonCharsRadioBtn
            // 
            this.cartoonCharsRadioBtn.AutoSize = true;
            this.cartoonCharsRadioBtn.Location = new System.Drawing.Point(6, 34);
            this.cartoonCharsRadioBtn.Name = "cartoonCharsRadioBtn";
            this.cartoonCharsRadioBtn.Size = new System.Drawing.Size(114, 17);
            this.cartoonCharsRadioBtn.TabIndex = 1;
            this.cartoonCharsRadioBtn.TabStop = true;
            this.cartoonCharsRadioBtn.Text = "cartoon characters";
            this.cartoonCharsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // colorsRadioBtn
            // 
            this.colorsRadioBtn.AutoSize = true;
            this.colorsRadioBtn.Location = new System.Drawing.Point(7, 11);
            this.colorsRadioBtn.Name = "colorsRadioBtn";
            this.colorsRadioBtn.Size = new System.Drawing.Size(53, 17);
            this.colorsRadioBtn.TabIndex = 0;
            this.colorsRadioBtn.TabStop = true;
            this.colorsRadioBtn.Text = "colors";
            this.colorsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose difficulty";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hardRadioBtn);
            this.groupBox3.Controls.Add(this.mediumRadioBtn);
            this.groupBox3.Controls.Add(this.easyRadioBtn);
            this.groupBox3.Location = new System.Drawing.Point(123, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 81);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // hardRadioBtn
            // 
            this.hardRadioBtn.AutoSize = true;
            this.hardRadioBtn.Location = new System.Drawing.Point(6, 57);
            this.hardRadioBtn.Name = "hardRadioBtn";
            this.hardRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.hardRadioBtn.TabIndex = 2;
            this.hardRadioBtn.TabStop = true;
            this.hardRadioBtn.Text = "hard";
            this.hardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // mediumRadioBtn
            // 
            this.mediumRadioBtn.AutoSize = true;
            this.mediumRadioBtn.Location = new System.Drawing.Point(6, 34);
            this.mediumRadioBtn.Name = "mediumRadioBtn";
            this.mediumRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.mediumRadioBtn.TabIndex = 1;
            this.mediumRadioBtn.TabStop = true;
            this.mediumRadioBtn.Text = "medium";
            this.mediumRadioBtn.UseVisualStyleBackColor = true;
            // 
            // easyRadioBtn
            // 
            this.easyRadioBtn.AutoSize = true;
            this.easyRadioBtn.Location = new System.Drawing.Point(7, 11);
            this.easyRadioBtn.Name = "easyRadioBtn";
            this.easyRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.easyRadioBtn.TabIndex = 0;
            this.easyRadioBtn.TabStop = true;
            this.easyRadioBtn.Text = "easy";
            this.easyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBtn.Location = new System.Drawing.Point(40, 305);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(95, 45);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // GameOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Name = "GameOptionsForm";
            this.Text = "Game Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton englishRadioBtn;
        private System.Windows.Forms.RadioButton polishRadioBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton mathRadioBtn;
        private System.Windows.Forms.RadioButton cartoonTitlesRadioBtn;
        private System.Windows.Forms.RadioButton cartoonCharsRadioBtn;
        private System.Windows.Forms.RadioButton colorsRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton hardRadioBtn;
        private System.Windows.Forms.RadioButton mediumRadioBtn;
        private System.Windows.Forms.RadioButton easyRadioBtn;
        private System.Windows.Forms.Button okBtn;
    }
}