namespace Hangman
{
    partial class NameForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.MaskedTextBox();
            this.sexGB = new System.Windows.Forms.GroupBox();
            this.boyRadioBtn = new System.Windows.Forms.RadioButton();
            this.girlRadioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greenRadioBtn = new System.Windows.Forms.RadioButton();
            this.yellowRadioBtn = new System.Windows.Forms.RadioButton();
            this.redRadioBtn = new System.Windows.Forms.RadioButton();
            this.blueRadioBtn = new System.Windows.Forms.RadioButton();
            this.returnBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.sexGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Let us to know you...";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTB.Location = new System.Drawing.Point(90, 77);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(114, 22);
            this.nameTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // ageTB
            // 
            this.ageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageTB.Location = new System.Drawing.Point(90, 107);
            this.ageTB.Mask = "00";
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(28, 22);
            this.ageTB.TabIndex = 5;
            // 
            // sexGB
            // 
            this.sexGB.Controls.Add(this.boyRadioBtn);
            this.sexGB.Controls.Add(this.girlRadioBtn);
            this.sexGB.Location = new System.Drawing.Point(90, 133);
            this.sexGB.Name = "sexGB";
            this.sexGB.Size = new System.Drawing.Size(58, 57);
            this.sexGB.TabIndex = 6;
            this.sexGB.TabStop = false;
            // 
            // boyRadioBtn
            // 
            this.boyRadioBtn.AutoSize = true;
            this.boyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boyRadioBtn.Location = new System.Drawing.Point(7, 34);
            this.boyRadioBtn.Name = "boyRadioBtn";
            this.boyRadioBtn.Size = new System.Drawing.Size(49, 20);
            this.boyRadioBtn.TabIndex = 1;
            this.boyRadioBtn.TabStop = true;
            this.boyRadioBtn.Text = "boy";
            this.boyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // girlRadioBtn
            // 
            this.girlRadioBtn.AutoSize = true;
            this.girlRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.girlRadioBtn.Location = new System.Drawing.Point(6, 10);
            this.girlRadioBtn.Name = "girlRadioBtn";
            this.girlRadioBtn.Size = new System.Drawing.Size(44, 20);
            this.girlRadioBtn.TabIndex = 0;
            this.girlRadioBtn.TabStop = true;
            this.girlRadioBtn.Text = "girl";
            this.girlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Favourite\r\ncolor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.greenRadioBtn);
            this.groupBox2.Controls.Add(this.yellowRadioBtn);
            this.groupBox2.Controls.Add(this.redRadioBtn);
            this.groupBox2.Controls.Add(this.blueRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(90, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // greenRadioBtn
            // 
            this.greenRadioBtn.AutoSize = true;
            this.greenRadioBtn.Location = new System.Drawing.Point(6, 77);
            this.greenRadioBtn.Name = "greenRadioBtn";
            this.greenRadioBtn.Size = new System.Drawing.Size(61, 20);
            this.greenRadioBtn.TabIndex = 3;
            this.greenRadioBtn.TabStop = true;
            this.greenRadioBtn.Text = "green";
            this.greenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // yellowRadioBtn
            // 
            this.yellowRadioBtn.AutoSize = true;
            this.yellowRadioBtn.Location = new System.Drawing.Point(6, 55);
            this.yellowRadioBtn.Name = "yellowRadioBtn";
            this.yellowRadioBtn.Size = new System.Drawing.Size(64, 20);
            this.yellowRadioBtn.TabIndex = 2;
            this.yellowRadioBtn.TabStop = true;
            this.yellowRadioBtn.Text = "yellow";
            this.yellowRadioBtn.UseVisualStyleBackColor = true;
            // 
            // redRadioBtn
            // 
            this.redRadioBtn.AutoSize = true;
            this.redRadioBtn.Location = new System.Drawing.Point(6, 32);
            this.redRadioBtn.Name = "redRadioBtn";
            this.redRadioBtn.Size = new System.Drawing.Size(46, 20);
            this.redRadioBtn.TabIndex = 1;
            this.redRadioBtn.TabStop = true;
            this.redRadioBtn.Text = "red";
            this.redRadioBtn.UseVisualStyleBackColor = true;
            // 
            // blueRadioBtn
            // 
            this.blueRadioBtn.AutoSize = true;
            this.blueRadioBtn.Location = new System.Drawing.Point(6, 9);
            this.blueRadioBtn.Name = "blueRadioBtn";
            this.blueRadioBtn.Size = new System.Drawing.Size(52, 20);
            this.blueRadioBtn.TabIndex = 0;
            this.blueRadioBtn.TabStop = true;
            this.blueRadioBtn.Text = "blue";
            this.blueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnBtn.Location = new System.Drawing.Point(149, 311);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(95, 45);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBtn.Location = new System.Drawing.Point(35, 311);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(95, 45);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sexGB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NameForm";
            this.Text = "Name Form";
            this.sexGB.ResumeLayout(false);
            this.sexGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ageTB;
        private System.Windows.Forms.GroupBox sexGB;
        private System.Windows.Forms.RadioButton boyRadioBtn;
        private System.Windows.Forms.RadioButton girlRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton greenRadioBtn;
        private System.Windows.Forms.RadioButton yellowRadioBtn;
        private System.Windows.Forms.RadioButton redRadioBtn;
        private System.Windows.Forms.RadioButton blueRadioBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button okBtn;
    }
}