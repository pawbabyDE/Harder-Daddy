namespace KLIKAJJJ
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash 
        {
            set
            {
                cash = value;
                label1.Text = "Cash: $" + value.ToString();
            }
            get
            {
                return cash;
            }
        }
        int buttonLevel;
        int A1Ammount;
        int A1Interval;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            A1Ammount = 10;
            A1Interval = 0;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel - 1);
            label1.Text = "Kasa: $" + cash.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (Cash >= upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                Cash -= upgradeCost;
                label1.Text = "Kasa: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }

        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if(Cash >= upgradeCost)
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                A1Timer.Enabled = true;
            Cash -= upgradeCost;
            label1.Text = "Kasa: $" + cash.ToString();

        }

        private void A1Tick(object sender, EventArgs e)
        {
            Cash += A1Ammount;
            label1.Text = "Kasa: $" + cash.ToString();

        }

        private void A1UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A1Ammount+=10;
            A1AmmountTextBox.Text = A1Ammount.ToString();
        }
    }
}
           
        
        
