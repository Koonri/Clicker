namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.upgradebutton = new System.Windows.Forms.Button();
            this.buttonleveltextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa: 0$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 144);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upgradebutton
            // 
            this.upgradebutton.Location = new System.Drawing.Point(453, 415);
            this.upgradebutton.Name = "upgradebutton";
            this.upgradebutton.Size = new System.Drawing.Size(75, 23);
            this.upgradebutton.TabIndex = 2;
            this.upgradebutton.Text = "Upgrade";
            this.upgradebutton.UseVisualStyleBackColor = true;
            this.upgradebutton.Click += new System.EventHandler(this.upgradebutton_Click);
            // 
            // buttonleveltextbox
            // 
            this.buttonleveltextbox.Location = new System.Drawing.Point(449, 356);
            this.buttonleveltextbox.Name = "buttonleveltextbox";
            this.buttonleveltextbox.Size = new System.Drawing.Size(79, 23);
            this.buttonleveltextbox.TabIndex = 3;
            this.buttonleveltextbox.Text = "1";
            this.buttonleveltextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonleveltextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonleveltextbox);
            this.Controls.Add(this.upgradebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button upgradebutton;
        private TextBox buttonleveltextbox;
    }
}