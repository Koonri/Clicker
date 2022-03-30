namespace Clicker
{
    public partial class Form1 : Form
    {

        private uint cash;
        public uint Cash
        {
            set
            {
                cash = value;
                label1.Text = value.ToString();
            }
            get
            {
                return cash;
            }
        }

        int buttonlevel;
        int A1Amount;
        int A1Interval; //iloœæ cykli na / min
        int A2Amount;
        int A2Interval;
        double Multiply;
        int A3Amount;
        int A3Interval;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlevel = 1;
            A1Amount = 10;
            A1Interval = 0;
            A1AmountTextbox.Text = A1Amount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
            A2Amount = 100;
            A2Interval = 0;
            A2AmountTextbox.Text = A2Amount.ToString();
            A2IntervalTextBox.Text = A2Interval.ToString();
            Multiply = 1;
            A3Amount = 1000;
            A3Interval = 0;
            A3AmountTextBox.Text = A3Amount.ToString();
            A3IntervalTextBox.Text = A3Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (uint)Math.Pow(10, buttonlevel - 1);
            label1.Text = "Kasa: $" + cash.ToString();

        }






        private void upgradebutton_Click(object sender, EventArgs e)
        {
            int upgradecost = (int)Math.Pow(10, buttonlevel);
            if (cash >= upgradecost)
            {
                buttonlevel++;
                buttonleveltextbox.Text = buttonlevel.ToString();
                Cash -= (uint)upgradecost;
                label1.Text = "Kasa : $" + cash.ToString();
                string nextupgradecost = "($" + Math.Pow(10, buttonlevel).ToString() + ")";
                upgradebutton.Text = "Upgrade\n" + nextupgradecost;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A1Amount * 2;
            if (Cash >= upgradecost)
            {
                A1Amount += 10;

                A1AmountTextbox.Text = A1Amount.ToString();
                Cash -= upgradecost;
            }
        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A1Interval * 100;
            if (Cash >= upgradecost)
            {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Tumer.Interval = (int)Math.Ceiling((double)((60 / A1Interval) * 100 + float.Epsilon));
                if (!A1Tumer.Enabled)
                    A1Tumer.Enabled = true;
                Cash -= upgradecost;
            }
        }

        private void A1tick(object sender, EventArgs e)
        {
            Cash += (uint)(A1Amount * Multiply);
        }

        private void A2UpgradeAmount_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A2Amount * 5;
            if (Cash >= upgradecost)
            {
                A2Amount += 100;
                A2AmountTextbox.Text = A2Amount.ToString();
                Cash -= upgradecost;
            }
        }

        private void A2Tick(object sender, EventArgs e)
        {
            Cash += (uint)(A1Amount * Multiply);
        }

        private void A2UpgradeInterval_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A2Interval * 3000;
            if (Cash >= upgradecost)
            {
                A2Interval++;
                A2IntervalTextBox.Text = A2Interval.ToString();
                A2Tamer.Interval = (int)Math.Ceiling((double)((60 / A2Interval) * 100 + float.Epsilon));
                if (!A2Tamer.Enabled)
                    A2Tamer.Enabled = true;
                Cash -= upgradecost;
            }
        }

        private void MultiplyBotButton_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)Multiply * 98;
            if (Cash >= upgradecost)
            {
                Multiply = Multiply * 1.105;
                MultiplyBotTextBox.Text = Multiply.ToString();
                Cash -= upgradecost;

            }

        }

        private void A3AmountButton_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A3Amount * 5;
            if (Cash >= upgradecost)
            {
                A3Amount += 100;
                A3AmountTextBox.Text = A3Amount.ToString();
                Cash -= upgradecost;
            }
        }

        private void A3IntervalButton_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A3Interval * 30000;
            if (Cash >= upgradecost)
            {
                A3Interval++;
                A3IntervalTextBox.Text = A3Interval.ToString();
                A3Tumer.Interval = (int)Math.Ceiling((double)((60 / A3Interval) * 100 + float.Epsilon));
                if (!A3Tumer.Enabled)
                    A3Tumer.Enabled = true;
                Cash -= upgradecost;
            }
        }

        private void A3Timer_Tick(object sender, EventArgs e)
        {
            Cash += (uint)(A3Amount * Multiply);
        }

        private void A2Tumer(object sender, EventArgs e)
        {

        }
    }
}