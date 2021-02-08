namespace HTTP_Status_Code_Checker
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
            this.URLs = new System.Windows.Forms.RichTextBox();
            this.CheckStatusButton = new System.Windows.Forms.Button();
            this.statusCodes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // URLs
            // 
            this.URLs.Location = new System.Drawing.Point(22, 13);
            this.URLs.Name = "URLs";
            this.URLs.Size = new System.Drawing.Size(325, 425);
            this.URLs.TabIndex = 0;
            this.URLs.Text = "";
            // 
            // CheckStatusButton
            // 
            this.CheckStatusButton.Location = new System.Drawing.Point(664, 396);
            this.CheckStatusButton.Name = "CheckStatusButton";
            this.CheckStatusButton.Size = new System.Drawing.Size(124, 42);
            this.CheckStatusButton.TabIndex = 1;
            this.CheckStatusButton.Text = "Check Status";
            this.CheckStatusButton.UseVisualStyleBackColor = true;
            this.CheckStatusButton.Click += new System.EventHandler(this.CheckStatusButton_Click);
            // 
            // statusCodes
            // 
            this.statusCodes.Location = new System.Drawing.Point(353, 12);
            this.statusCodes.Name = "statusCodes";
            this.statusCodes.Size = new System.Drawing.Size(253, 425);
            this.statusCodes.TabIndex = 2;
            this.statusCodes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusCodes);
            this.Controls.Add(this.CheckStatusButton);
            this.Controls.Add(this.URLs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox URLs;
        private System.Windows.Forms.Button CheckStatusButton;
        private System.Windows.Forms.RichTextBox statusCodes;
    }
}

