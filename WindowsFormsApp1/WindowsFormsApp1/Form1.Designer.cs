namespace WindowsFormsApp1
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
            this.buttonClick = new System.Windows.Forms.Button();
            this.textBoxCloseApp = new System.Windows.Forms.TextBox();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(180, 205);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(75, 23);
            this.buttonClick.TabIndex = 0;
            this.buttonClick.Text = "Click me!";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // textBoxCloseApp
            // 
            this.textBoxCloseApp.Location = new System.Drawing.Point(319, 343);
            this.textBoxCloseApp.Name = "textBoxCloseApp";
            this.textBoxCloseApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCloseApp.TabIndex = 1;
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Location = new System.Drawing.Point(319, 370);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(100, 23);
            this.buttonCloseApp.TabIndex = 2;
            this.buttonCloseApp.Text = "Close App";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.textBoxCloseApp);
            this.Controls.Add(this.buttonClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.TextBox textBoxCloseApp;
        private System.Windows.Forms.Button buttonCloseApp;
    }
}

