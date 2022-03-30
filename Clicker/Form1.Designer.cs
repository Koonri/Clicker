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
            this.A2Label = new System.Windows.Forms.Label();
            this.A2AmountTextbox = new System.Windows.Forms.TextBox();
            this.A2IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A2UpgradeAmount = new System.Windows.Forms.Button();
            this.A2UpgradeInterval = new System.Windows.Forms.Button();
            this.MultiplyBotTextBox = new System.Windows.Forms.TextBox();
            this.MultiplyBotButton = new System.Windows.Forms.Button();
            this.MultiplyBot = new System.Windows.Forms.Label();
            this.A3IntervalButton = new System.Windows.Forms.Button();
            this.A3AmountButton = new System.Windows.Forms.Button();
            this.A3Label = new System.Windows.Forms.Label();
            this.A3AmountTextBox = new System.Windows.Forms.TextBox();
            this.A3IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Tumer = new System.Windows.Forms.Timer(this.components);
            this.A2Tamer = new System.Windows.Forms.Timer(this.components);
            this.A3Tumer = new System.Windows.Forms.Timer(this.components);
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
            this.A1Label.Location = new System.Drawing.Point(25, 25);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(31, 15);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "Bot1";
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
            // A2Label
            // 
            this.A2Label.AutoSize = true;
            this.A2Label.Location = new System.Drawing.Point(25, 110);
            this.A2Label.Name = "A2Label";
            this.A2Label.Size = new System.Drawing.Size(31, 15);
            this.A2Label.TabIndex = 9;
            this.A2Label.Text = "Bot2";
            // 
            // A2AmountTextbox
            // 
            this.A2AmountTextbox.Location = new System.Drawing.Point(101, 102);
            this.A2AmountTextbox.Name = "A2AmountTextbox";
            this.A2AmountTextbox.Size = new System.Drawing.Size(100, 23);
            this.A2AmountTextbox.TabIndex = 10;
            this.A2AmountTextbox.Text = "0";
            this.A2AmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A2IntervalTextBox
            // 
            this.A2IntervalTextBox.Location = new System.Drawing.Point(313, 99);
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            this.A2IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2IntervalTextBox.TabIndex = 11;
            this.A2IntervalTextBox.Text = "0";
            this.A2IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A2UpgradeAmount
            // 
            this.A2UpgradeAmount.Location = new System.Drawing.Point(207, 81);
            this.A2UpgradeAmount.Name = "A2UpgradeAmount";
            this.A2UpgradeAmount.Size = new System.Drawing.Size(100, 54);
            this.A2UpgradeAmount.TabIndex = 12;
            this.A2UpgradeAmount.Text = "Ulepsz ilość bota2";
            this.A2UpgradeAmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmount.Click += new System.EventHandler(this.A2UpgradeAmount_Click);
            // 
            // A2UpgradeInterval
            // 
            this.A2UpgradeInterval.Location = new System.Drawing.Point(419, 81);
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.Size = new System.Drawing.Size(97, 54);
            this.A2UpgradeInterval.TabIndex = 13;
            this.A2UpgradeInterval.Text = "Ulepsz częstotliwość bota2";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // MultiplyBotTextBox
            // 
            this.MultiplyBotTextBox.Location = new System.Drawing.Point(207, 294);
            this.MultiplyBotTextBox.Name = "MultiplyBotTextBox";
            this.MultiplyBotTextBox.Size = new System.Drawing.Size(100, 23);
            this.MultiplyBotTextBox.TabIndex = 14;
            this.MultiplyBotTextBox.Text = "1";
            this.MultiplyBotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MultiplyBotButton
            // 
            this.MultiplyBotButton.Location = new System.Drawing.Point(207, 336);
            this.MultiplyBotButton.Name = "MultiplyBotButton";
            this.MultiplyBotButton.Size = new System.Drawing.Size(100, 43);
            this.MultiplyBotButton.TabIndex = 15;
            this.MultiplyBotButton.Text = "Ulepsz mnożnik";
            this.MultiplyBotButton.UseVisualStyleBackColor = true;
            this.MultiplyBotButton.Click += new System.EventHandler(this.MultiplyBotButton_Click);
            // 
            // MultiplyBot
            // 
            this.MultiplyBot.AutoSize = true;
            this.MultiplyBot.Location = new System.Drawing.Point(233, 260);
            this.MultiplyBot.Name = "MultiplyBot";
            this.MultiplyBot.Size = new System.Drawing.Size(53, 15);
            this.MultiplyBot.TabIndex = 16;
            this.MultiplyBot.Text = "Mnożnik";
            // 
            // A3IntervalButton
            // 
            this.A3IntervalButton.Location = new System.Drawing.Point(419, 170);
            this.A3IntervalButton.Name = "A3IntervalButton";
            this.A3IntervalButton.Size = new System.Drawing.Size(97, 58);
            this.A3IntervalButton.TabIndex = 17;
            this.A3IntervalButton.Text = "Ulepsz częstotliwość bota3";
            this.A3IntervalButton.UseVisualStyleBackColor = true;
            this.A3IntervalButton.Click += new System.EventHandler(this.A3IntervalButton_Click);
            // 
            // A3AmountButton
            // 
            this.A3AmountButton.Location = new System.Drawing.Point(207, 170);
            this.A3AmountButton.Name = "A3AmountButton";
            this.A3AmountButton.Size = new System.Drawing.Size(100, 58);
            this.A3AmountButton.TabIndex = 18;
            this.A3AmountButton.Text = "Ulepsz ilość bota3";
            this.A3AmountButton.UseVisualStyleBackColor = true;
            this.A3AmountButton.Click += new System.EventHandler(this.A3AmountButton_Click);
            // 
            // A3Label
            // 
            this.A3Label.AutoSize = true;
            this.A3Label.Location = new System.Drawing.Point(25, 184);
            this.A3Label.Name = "A3Label";
            this.A3Label.Size = new System.Drawing.Size(38, 15);
            this.A3Label.TabIndex = 19;
            this.A3Label.Text = "label3";
            // 
            // A3AmountTextBox
            // 
            this.A3AmountTextBox.Location = new System.Drawing.Point(101, 181);
            this.A3AmountTextBox.Name = "A3AmountTextBox";
            this.A3AmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3AmountTextBox.TabIndex = 20;
            this.A3AmountTextBox.Text = "0";
            this.A3AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A3IntervalTextBox
            // 
            this.A3IntervalTextBox.Location = new System.Drawing.Point(313, 181);
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
            this.A3IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3IntervalTextBox.TabIndex = 21;
            this.A3IntervalTextBox.Text = "0";
            this.A3IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Tumer
            // 
            this.A1Tumer.Tick += new System.EventHandler(this.A1tick);
            // 
            // A2Tamer
            // 
            this.A2Tamer.Tick += new System.EventHandler(this.A2Tick);
            // 
            // A3Tumer
            // 
            this.A3Tumer.Tick += new System.EventHandler(this.A3Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.A3IntervalTextBox);
            this.Controls.Add(this.A3AmountTextBox);
            this.Controls.Add(this.A3Label);
            this.Controls.Add(this.A3AmountButton);
            this.Controls.Add(this.A3IntervalButton);
            this.Controls.Add(this.MultiplyBot);
            this.Controls.Add(this.MultiplyBotButton);
            this.Controls.Add(this.MultiplyBotTextBox);
            this.Controls.Add(this.A2UpgradeInterval);
            this.Controls.Add(this.A2UpgradeAmount);
            this.Controls.Add(this.A2IntervalTextBox);
            this.Controls.Add(this.A2AmountTextbox);
            this.Controls.Add(this.A2Label);
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
        private System.Windows.Forms.Timer A2timer;
        private System.Windows.Forms.Timer A3Timer;
        private Label A2Label;
        private TextBox A2AmountTextbox;
        private TextBox A2IntervalTextBox;
        private Button A2UpgradeAmount;
        private Button A2UpgradeInterval;
        private System.Windows.Forms.Timer timer3;
        private TextBox MultiplyBotTextBox;
        private Button MultiplyBotButton;
        private Label MultiplyBot;
        private Button A3IntervalButton;
        private Button A3AmountButton;
        private Label A3Label;
        private TextBox A3AmountTextBox;
        private TextBox A3IntervalTextBox;
        private System.Windows.Forms.Timer A1Tumer;
        private System.Windows.Forms.Timer A2Tamer;
        private System.Windows.Forms.Timer A3Tumer;
    }
}