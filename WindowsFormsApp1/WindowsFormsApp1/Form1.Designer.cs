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
            this.CurPathInfoButtonTymoshenko = new System.Windows.Forms.Button();
            this.groupBoxChangeColor = new System.Windows.Forms.GroupBox();
            this.comboBoxChangeColor = new System.Windows.Forms.ComboBox();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.labelChangeColor = new System.Windows.Forms.Label();
            this.groupBoxChangeColor.SuspendLayout();
            this.textBoxCloseApp = new System.Windows.Forms.TextBox();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(240, 252);
            this.buttonClick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(100, 28);
            this.buttonClick.TabIndex = 0;
            this.buttonClick.Text = "Click me!";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // CurPathInfoButtonTymoshenko
            // 
            this.CurPathInfoButtonTymoshenko.Location = new System.Drawing.Point(799, 487);
            this.CurPathInfoButtonTymoshenko.Name = "CurPathInfoButtonTymoshenko";
            this.CurPathInfoButtonTymoshenko.Size = new System.Drawing.Size(232, 41);
            this.CurPathInfoButtonTymoshenko.TabIndex = 1;
            this.CurPathInfoButtonTymoshenko.Text = "Current Path Information";
            this.CurPathInfoButtonTymoshenko.UseVisualStyleBackColor = true;
            this.CurPathInfoButtonTymoshenko.Click += new System.EventHandler(this.CurPathInfoButtonTymoshenko_Click);
            // groupBoxChangeColor
            // 
            this.groupBoxChangeColor.Controls.Add(this.labelChangeColor);
            this.groupBoxChangeColor.Controls.Add(this.buttonChangeColor);
            this.groupBoxChangeColor.Controls.Add(this.comboBoxChangeColor);
            this.groupBoxChangeColor.Location = new System.Drawing.Point(855, 12);
            this.groupBoxChangeColor.Name = "groupBoxChangeColor";
            this.groupBoxChangeColor.Size = new System.Drawing.Size(175, 85);
            this.groupBoxChangeColor.TabIndex = 1;
            this.groupBoxChangeColor.TabStop = false;
            this.groupBoxChangeColor.Text = "Change color";
            // 
            // comboBoxChangeColor
            // 
            this.comboBoxChangeColor.FormattingEnabled = true;
            this.comboBoxChangeColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Yellow",
            "Green",
            "Blue",
            "Red",
            "Purple",
            "Pink"});
            this.comboBoxChangeColor.Location = new System.Drawing.Point(57, 21);
            this.comboBoxChangeColor.Name = "comboBoxChangeColor";
            this.comboBoxChangeColor.Size = new System.Drawing.Size(109, 24);
            this.comboBoxChangeColor.TabIndex = 0;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(77, 51);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(75, 25);
            this.buttonChangeColor.TabIndex = 1;
            this.buttonChangeColor.Text = "Change";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // labelChangeColor
            // 
            this.labelChangeColor.AutoSize = true;
            this.labelChangeColor.Location = new System.Drawing.Point(6, 24);
            this.labelChangeColor.Name = "labelChangeColor";
            this.labelChangeColor.Size = new System.Drawing.Size(45, 17);
            this.labelChangeColor.TabIndex = 2;
            this.labelChangeColor.Text = "Color:";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CurPathInfoButtonTymoshenko);
            this.Controls.Add(this.groupBoxChangeColor);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.textBoxCloseApp);
            this.Controls.Add(this.buttonClick);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxChangeColor.ResumeLayout(false);
            this.groupBoxChangeColor.PerformLayout();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Button CurPathInfoButtonTymoshenko;
        private System.Windows.Forms.GroupBox groupBoxChangeColor;
        private System.Windows.Forms.Label labelChangeColor;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.ComboBox comboBoxChangeColor;
        private System.Windows.Forms.TextBox textBoxCloseApp;
        private System.Windows.Forms.Button buttonCloseApp;
    }
}

