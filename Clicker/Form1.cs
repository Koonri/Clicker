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
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlevel = 1;
            A1Amount = 10;
            A1Interval = 0;
            A1AmountTextbox.Text = A1Amount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (uint)Math.Pow(10, buttonlevel - 1);
            label1.Text = "Kasa: $" + Cash.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void upgradebutton_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)Math.Pow(10, buttonlevel);
            if (Cash >= upgradecost)
            {
                buttonlevel++;
                buttonleveltextbox.Text = buttonlevel.ToString();
                Cash -= upgradecost;
                label1.Text = "Kasa : $" + Cash.ToString();
                string nextupgradecost = "($" + Math.Pow(10, buttonlevel).ToString() + ")";
                upgradebutton.Text = "Upgrade\n" + nextupgradecost;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A1Amount += 10;
            A1AmountTextbox.Text = A1Amount.ToString();
        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            uint upgradecost = (uint)A1Interval * 100;
            if (Cash >= upgradecost)
            {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1timer.Interval = (60 / A1Interval) * 100;
                if (!A1timer.Enabled)
                    A1timer.Enabled = true;
                Cash -= upgradecost;
            }
        }   

        private void A1tick(object sender, EventArgs e)
        {
            Cash += (uint)A1Amount;
        }
    }
}