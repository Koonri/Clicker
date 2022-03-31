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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Clicker.Properties.Resources.money_button1;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upgradebutton
            // 
            this.upgradebutton.BackColor = System.Drawing.Color.Transparent;
            this.upgradebutton.BackgroundImage = global::Clicker.Properties.Resources.upgradebutton;
            resources.ApplyResources(this.upgradebutton, "upgradebutton");
            this.upgradebutton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.upgradebutton.Name = "upgradebutton";
            this.upgradebutton.UseVisualStyleBackColor = false;
            this.upgradebutton.Click += new System.EventHandler(this.upgradebutton_Click);
            // 
            // buttonleveltextbox
            // 
            resources.ApplyResources(this.buttonleveltextbox, "buttonleveltextbox");
            this.buttonleveltextbox.Name = "buttonleveltextbox";
            // 
            // A1UpgradeAmount
            // 
            resources.ApplyResources(this.A1UpgradeAmount, "A1UpgradeAmount");
            this.A1UpgradeAmount.Name = "A1UpgradeAmount";
            this.A1UpgradeAmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmount.Click += new System.EventHandler(this.button2_Click);
            // 
            // A1AmountTextbox
            // 
            resources.ApplyResources(this.A1AmountTextbox, "A1AmountTextbox");
            this.A1AmountTextbox.Name = "A1AmountTextbox";
            // 
            // A1UpgradeInterval
            // 
            resources.ApplyResources(this.A1UpgradeInterval, "A1UpgradeInterval");
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            resources.ApplyResources(this.A1Label, "A1Label");
            this.A1Label.Name = "A1Label";
            // 
            // A1IntervalTextBox
            // 
            resources.ApplyResources(this.A1IntervalTextBox, "A1IntervalTextBox");
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            // 
            // A2Label
            // 
            resources.ApplyResources(this.A2Label, "A2Label");
            this.A2Label.Name = "A2Label";
            // 
            // A2AmountTextbox
            // 
            resources.ApplyResources(this.A2AmountTextbox, "A2AmountTextbox");
            this.A2AmountTextbox.Name = "A2AmountTextbox";
            // 
            // A2IntervalTextBox
            // 
            resources.ApplyResources(this.A2IntervalTextBox, "A2IntervalTextBox");
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            // 
            // A2UpgradeAmount
            // 
            resources.ApplyResources(this.A2UpgradeAmount, "A2UpgradeAmount");
            this.A2UpgradeAmount.Name = "A2UpgradeAmount";
            this.A2UpgradeAmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmount.Click += new System.EventHandler(this.A2UpgradeAmount_Click);
            // 
            // A2UpgradeInterval
            // 
            resources.ApplyResources(this.A2UpgradeInterval, "A2UpgradeInterval");
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // MultiplyBotTextBox
            // 
            resources.ApplyResources(this.MultiplyBotTextBox, "MultiplyBotTextBox");
            this.MultiplyBotTextBox.Name = "MultiplyBotTextBox";
            // 
            // MultiplyBotButton
            // 
            resources.ApplyResources(this.MultiplyBotButton, "MultiplyBotButton");
            this.MultiplyBotButton.Name = "MultiplyBotButton";
            this.MultiplyBotButton.UseVisualStyleBackColor = true;
            this.MultiplyBotButton.Click += new System.EventHandler(this.MultiplyBotButton_Click);
            // 
            // MultiplyBot
            // 
            resources.ApplyResources(this.MultiplyBot, "MultiplyBot");
            this.MultiplyBot.Name = "MultiplyBot";
            // 
            // A3IntervalButton
            // 
            resources.ApplyResources(this.A3IntervalButton, "A3IntervalButton");
            this.A3IntervalButton.Name = "A3IntervalButton";
            this.A3IntervalButton.UseVisualStyleBackColor = true;
            this.A3IntervalButton.Click += new System.EventHandler(this.A3IntervalButton_Click);
            // 
            // A3AmountButton
            // 
            resources.ApplyResources(this.A3AmountButton, "A3AmountButton");
            this.A3AmountButton.Name = "A3AmountButton";
            this.A3AmountButton.UseVisualStyleBackColor = true;
            this.A3AmountButton.Click += new System.EventHandler(this.A3AmountButton_Click);
            // 
            // A3Label
            // 
            resources.ApplyResources(this.A3Label, "A3Label");
            this.A3Label.Name = "A3Label";
            // 
            // A3AmountTextBox
            // 
            resources.ApplyResources(this.A3AmountTextBox, "A3AmountTextBox");
            this.A3AmountTextBox.Name = "A3AmountTextBox";
            // 
            // A3IntervalTextBox
            // 
            resources.ApplyResources(this.A3IntervalTextBox, "A3IntervalTextBox");
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Clicker.Properties.Resources.realbot;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Clicker.Properties.Resources.realbot;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Clicker.Properties.Resources.realbot;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Clicker.Properties.Resources.realbot;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clicker.Properties.Resources.factoryimage;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
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
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}