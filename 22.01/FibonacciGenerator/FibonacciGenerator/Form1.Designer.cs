namespace FibonacciGenerator
{
    partial class Form1
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
            this.textBoxLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUpper = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxFibonacci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижняя граница  ";
            // 
            // textBoxLower
            // 
            this.textBoxLower.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLower.Location = new System.Drawing.Point(224, 81);
            this.textBoxLower.Name = "textBoxLower";
            this.textBoxLower.Size = new System.Drawing.Size(162, 24);
            this.textBoxLower.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Верхняя граница ";
            // 
            // textBoxUpper
            // 
            this.textBoxUpper.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUpper.Location = new System.Drawing.Point(224, 24);
            this.textBoxUpper.Name = "textBoxUpper";
            this.textBoxUpper.Size = new System.Drawing.Size(162, 24);
            this.textBoxUpper.TabIndex = 3;
            //this.textBoxUpper.TextChanged += new System.EventHandler(this.textBoxUpper_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(35, 158);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 34);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(224, 160);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(162, 32);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Остановить";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listBoxFibonacci
            // 
            this.listBoxFibonacci.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxFibonacci.FormattingEnabled = true;
            this.listBoxFibonacci.Location = new System.Drawing.Point(416, 24);
            this.listBoxFibonacci.Name = "listBoxFibonacci";
            this.listBoxFibonacci.Size = new System.Drawing.Size(180, 173);
            this.listBoxFibonacci.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 214);
            this.Controls.Add(this.listBoxFibonacci);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxUpper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLower);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUpper;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBoxFibonacci;
    }
}

