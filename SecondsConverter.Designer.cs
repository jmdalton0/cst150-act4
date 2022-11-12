namespace Act4
{
    partial class SecondsConverter
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
            this.numSecondsLabel = new System.Windows.Forms.Label();
            this.numSecondsTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numSecondsLabel
            // 
            this.numSecondsLabel.AutoSize = true;
            this.numSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numSecondsLabel.Location = new System.Drawing.Point(145, 157);
            this.numSecondsLabel.Name = "numSecondsLabel";
            this.numSecondsLabel.Size = new System.Drawing.Size(230, 20);
            this.numSecondsLabel.TabIndex = 0;
            this.numSecondsLabel.Text = "Enter the number of seconds:";
            // 
            // numSecondsTextBox
            // 
            this.numSecondsTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numSecondsTextBox.Location = new System.Drawing.Point(464, 157);
            this.numSecondsTextBox.Name = "numSecondsTextBox";
            this.numSecondsTextBox.Size = new System.Drawing.Size(274, 22);
            this.numSecondsTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertButton.Location = new System.Drawing.Point(464, 302);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(195, 53);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultLabel.Location = new System.Drawing.Point(97, 200);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(278, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "The number of seconds amounts to:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultTextBox.Location = new System.Drawing.Point(464, 200);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(274, 22);
            this.resultTextBox.TabIndex = 4;
            // 
            // SecondsConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(910, 464);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.numSecondsTextBox);
            this.Controls.Add(this.numSecondsLabel);
            this.Name = "SecondsConverter";
            this.Text = "Seconds Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numSecondsLabel;
        private System.Windows.Forms.TextBox numSecondsTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}