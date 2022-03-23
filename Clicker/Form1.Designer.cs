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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.upgradebutton = new System.Windows.Forms.Button();
            this.buttonleveltextbox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmount = new System.Windows.Forms.Button();
            this.A1AmountTextbox = new System.Windows.Forms.TextBox();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.upgradebutton.Location = new System.Drawing.Point(453, 385);
            this.upgradebutton.Name = "upgradebutton";
            this.upgradebutton.Size = new System.Drawing.Size(75, 53);
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
            // A1UpgradeAmount
            // 
            this.A1UpgradeAmount.Location = new System.Drawing.Point(207, 5);
            this.A1UpgradeAmount.Name = "A1UpgradeAmount";
            this.A1UpgradeAmount.Size = new System.Drawing.Size(100, 54);
            this.A1UpgradeAmount.TabIndex = 4;
            this.A1UpgradeAmount.Text = "Ulepsz ilość";
            this.A1UpgradeAmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmount.Click += new System.EventHandler(this.button2_Click);
            // 
            // A1AmountTextbox
            // 
            this.A1AmountTextbox.Location = new System.Drawing.Point(101, 22);
            this.A1AmountTextbox.Name = "A1AmountTextbox";
            this.A1AmountTextbox.Size = new System.Drawing.Size(100, 23);
            this.A1AmountTextbox.TabIndex = 5;
            this.A1AmountTextbox.Text = "0";
            this.A1AmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(419, 9);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(97, 54);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(12, 25);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(83, 15);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "Autoupgrade1";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(313, 22);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1timer
            // 
            this.A1timer.Tick += new System.EventHandler(this.A1tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1AmountTextbox);
            this.Controls.Add(this.A1UpgradeAmount);
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
        private Button A1UpgradeAmount;
        private TextBox A1AmountTextbox;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}