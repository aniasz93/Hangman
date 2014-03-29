namespace Hangman
{
    partial class InstrForm
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
            this.instrTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instrTB
            // 
            this.instrTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instrTB.Location = new System.Drawing.Point(35, 60);
            this.instrTB.Name = "instrTB";
            this.instrTB.ReadOnly = true;
            this.instrTB.Size = new System.Drawing.Size(215, 235);
            this.instrTB.TabIndex = 0;
            this.instrTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOW TO PLAY?";
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnBtn.Location = new System.Drawing.Point(95, 305);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(95, 45);
            this.returnBtn.TabIndex = 5;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // InstrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instrTB);
            this.Name = "InstrForm";
            this.Text = "Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox instrTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
    }
}