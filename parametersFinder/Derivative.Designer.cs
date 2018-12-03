namespace parametersFinder
{
    partial class Derivative
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
            this.clipboard = new System.Windows.Forms.Button();
            this.derivativeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clipboard
            // 
            this.clipboard.Location = new System.Drawing.Point(94, 98);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(141, 39);
            this.clipboard.TabIndex = 0;
            this.clipboard.Text = "copy to clipboard";
            this.clipboard.UseVisualStyleBackColor = true;
            // 
            // derivativeValue
            // 
            this.derivativeValue.AutoSize = true;
            this.derivativeValue.Location = new System.Drawing.Point(91, 56);
            this.derivativeValue.Name = "derivativeValue";
            this.derivativeValue.Size = new System.Drawing.Size(13, 17);
            this.derivativeValue.TabIndex = 1;
            this.derivativeValue.Text = "-";
            // 
            // Derivative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 159);
            this.Controls.Add(this.derivativeValue);
            this.Controls.Add(this.clipboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Derivative";
            this.Text = "Derivative";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.Label derivativeValue;
    }
}