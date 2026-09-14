namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        private double num1;
        private double num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
            
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(TextBoxInput1.Text);
            num2 = Convert.ToDouble(TextBoxInput2.Text);
          
            if (cbOperator.SelectedItem.Equals("+"))
            {
                cal.CalculateEvent += cal.GetSum;
                var total = cal.Calculate(num1, num2);
                lblDisplayTotal.Text = total.ToString();
            }
            else if (cbOperator.SelectedItem.Equals("-"))
            {
                cal.CalculateEvent += cal.GetDifference;
                var total = cal.Calculate(num1, num2);
                lblDisplayTotal.Text = total.ToString();
            }
            else if (cbOperator.SelectedItem.Equals("*"))
            {
                cal.CalculateEvent += cal.GetProduct;
                var total = cal.Calculate(num1, num2);
                lblDisplayTotal.Text = total.ToString();
            }
            else if (cbOperator.SelectedItem.Equals("/"))
            {
                cal.CalculateEvent += cal.GetQuotient;
                var total = cal.Calculate(num1, num2);
                lblDisplayTotal.Text = total.ToString();
            }


        }
    }
}
