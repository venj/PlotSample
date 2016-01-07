namespace PlotSample
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
            this.plotBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // plotBox
            // 
            this.plotBox.Location = new System.Drawing.Point(12, 12);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(401, 249);
            this.plotBox.TabIndex = 0;
            this.plotBox.TabStop = false;
            this.plotBox.Text = "Plot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 321);
            this.Controls.Add(this.plotBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox plotBox;
    }
}

