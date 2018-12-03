namespace parametersFinder
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.memNum = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.parent_a = new System.Windows.Forms.Label();
            this.parent_b = new System.Windows.Forms.Label();
            this.parent_c = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mutationRate = new System.Windows.Forms.TrackBar();
            this.mutationRatePercentage = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.derivative = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRate)).BeginInit();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(34, 66);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 22);
            this.x1.TabIndex = 1;
            this.x1.Text = "-3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ax^2+bx+c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "f(";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = ")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = ")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "f(";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(34, 94);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 22);
            this.x2.TabIndex = 5;
            this.x2.Text = "1";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(34, 122);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 30);
            this.go.TabIndex = 8;
            this.go.Text = "Let\'s go!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // memNum
            // 
            this.memNum.Location = new System.Drawing.Point(34, 38);
            this.memNum.Name = "memNum";
            this.memNum.Size = new System.Drawing.Size(100, 22);
            this.memNum.TabIndex = 9;
            this.memNum.Text = "1000";
            // 
            // refresh
            // 
            this.refresh.Interval = 1;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // parent_a
            // 
            this.parent_a.AutoSize = true;
            this.parent_a.Location = new System.Drawing.Point(83, 159);
            this.parent_a.Name = "parent_a";
            this.parent_a.Size = new System.Drawing.Size(13, 17);
            this.parent_a.TabIndex = 10;
            this.parent_a.Text = "-";
            // 
            // parent_b
            // 
            this.parent_b.AutoSize = true;
            this.parent_b.Location = new System.Drawing.Point(83, 176);
            this.parent_b.Name = "parent_b";
            this.parent_b.Size = new System.Drawing.Size(13, 17);
            this.parent_b.TabIndex = 11;
            this.parent_b.Text = "-";
            // 
            // parent_c
            // 
            this.parent_c.AutoSize = true;
            this.parent_c.Location = new System.Drawing.Point(83, 193);
            this.parent_c.Name = "parent_c";
            this.parent_c.Size = new System.Drawing.Size(13, 17);
            this.parent_c.TabIndex = 12;
            this.parent_c.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "a:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "c:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "b:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "accuracy:";
            // 
            // accuracy
            // 
            this.accuracy.AutoSize = true;
            this.accuracy.Location = new System.Drawing.Point(83, 210);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(13, 17);
            this.accuracy.TabIndex = 17;
            this.accuracy.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1079, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "mutation rate";
            // 
            // mutationRate
            // 
            this.mutationRate.Location = new System.Drawing.Point(250, 32);
            this.mutationRate.Maximum = 100;
            this.mutationRate.Name = "mutationRate";
            this.mutationRate.Size = new System.Drawing.Size(809, 56);
            this.mutationRate.TabIndex = 22;
            this.mutationRate.Value = 10;
            this.mutationRate.ValueChanged += new System.EventHandler(this.mutationRate_ValueChanged);
            // 
            // mutationRatePercentage
            // 
            this.mutationRatePercentage.AutoSize = true;
            this.mutationRatePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mutationRatePercentage.Location = new System.Drawing.Point(511, 69);
            this.mutationRatePercentage.Name = "mutationRatePercentage";
            this.mutationRatePercentage.Size = new System.Drawing.Size(320, 132);
            this.mutationRatePercentage.TabIndex = 23;
            this.mutationRatePercentage.Text = "10 %";
            this.mutationRatePercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(115, 122);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 30);
            this.reset.TabIndex = 25;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "= 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "= 0";
            // 
            // derivative
            // 
            this.derivative.Enabled = false;
            this.derivative.Location = new System.Drawing.Point(196, 122);
            this.derivative.Name = "derivative";
            this.derivative.Size = new System.Drawing.Size(80, 30);
            this.derivative.TabIndex = 28;
            this.derivative.Text = "derivative";
            this.derivative.UseVisualStyleBackColor = true;
            this.derivative.Click += new System.EventHandler(this.derivative_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 232);
            this.Controls.Add(this.derivative);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.mutationRatePercentage);
            this.Controls.Add(this.mutationRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parent_c);
            this.Controls.Add(this.parent_b);
            this.Controls.Add(this.parent_a);
            this.Controls.Add(this.memNum);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Finder";
            ((System.ComponentModel.ISupportInitialize)(this.mutationRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox memNum;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Label parent_a;
        private System.Windows.Forms.Label parent_b;
        private System.Windows.Forms.Label parent_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label accuracy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar mutationRate;
        private System.Windows.Forms.Label mutationRatePercentage;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button derivative;
    }
}

