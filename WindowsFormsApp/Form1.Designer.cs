namespace WindowsFormsApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_A = new System.Windows.Forms.TextBox();
            this.tbx_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_alpha = new System.Windows.Forms.NumericUpDown();
            this.numeric_beta = new System.Windows.Forms.NumericUpDown();
            this.btn_computeTime = new System.Windows.Forms.Button();
            this.btn_ProbableSequence = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_beta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequence A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sequence B";
            // 
            // tbx_A
            // 
            this.tbx_A.Location = new System.Drawing.Point(84, 18);
            this.tbx_A.Name = "tbx_A";
            this.tbx_A.Size = new System.Drawing.Size(417, 20);
            this.tbx_A.TabIndex = 2;
            // 
            // tbx_B
            // 
            this.tbx_B.Location = new System.Drawing.Point(85, 54);
            this.tbx_B.Name = "tbx_B";
            this.tbx_B.Size = new System.Drawing.Size(416, 20);
            this.tbx_B.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "transition rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "transversion rate";
            // 
            // numeric_alpha
            // 
            this.numeric_alpha.DecimalPlaces = 2;
            this.numeric_alpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric_alpha.Location = new System.Drawing.Point(85, 88);
            this.numeric_alpha.Name = "numeric_alpha";
            this.numeric_alpha.Size = new System.Drawing.Size(160, 20);
            this.numeric_alpha.TabIndex = 6;
            // 
            // numeric_beta
            // 
            this.numeric_beta.DecimalPlaces = 2;
            this.numeric_beta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric_beta.Location = new System.Drawing.Point(353, 88);
            this.numeric_beta.Name = "numeric_beta";
            this.numeric_beta.Size = new System.Drawing.Size(148, 20);
            this.numeric_beta.TabIndex = 7;
            // 
            // btn_computeTime
            // 
            this.btn_computeTime.Location = new System.Drawing.Point(13, 123);
            this.btn_computeTime.Name = "btn_computeTime";
            this.btn_computeTime.Size = new System.Drawing.Size(124, 23);
            this.btn_computeTime.TabIndex = 8;
            this.btn_computeTime.Text = "Compute Time";
            this.btn_computeTime.UseVisualStyleBackColor = true;
            this.btn_computeTime.Click += new System.EventHandler(this.btn_computeTime_Click);
            // 
            // btn_ProbableSequence
            // 
            this.btn_ProbableSequence.Location = new System.Drawing.Point(143, 123);
            this.btn_ProbableSequence.Name = "btn_ProbableSequence";
            this.btn_ProbableSequence.Size = new System.Drawing.Size(176, 23);
            this.btn_ProbableSequence.TabIndex = 9;
            this.btn_ProbableSequence.Text = "Compute Probable Sequence";
            this.btn_ProbableSequence.UseVisualStyleBackColor = true;
            this.btn_ProbableSequence.Click += new System.EventHandler(this.btn_ProbableSequence_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(386, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "time input";
            // 
            // tbx_output
            // 
            this.tbx_output.Location = new System.Drawing.Point(84, 152);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.Size = new System.Drawing.Size(417, 85);
            this.tbx_output.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 250);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_ProbableSequence);
            this.Controls.Add(this.btn_computeTime);
            this.Controls.Add(this.numeric_beta);
            this.Controls.Add(this.numeric_alpha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_B);
            this.Controls.Add(this.tbx_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Elementy Bioinformatyki Projekt 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_beta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_A;
        private System.Windows.Forms.TextBox tbx_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_alpha;
        private System.Windows.Forms.NumericUpDown numeric_beta;
        private System.Windows.Forms.Button btn_computeTime;
        private System.Windows.Forms.Button btn_ProbableSequence;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Label label6;
    }
}

