namespace Caculator
{
    public partial class Form1 : Form
    {
        double so1 = 0;
        string phepTinh = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            phepTinh = "+";
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            phepTinh = "-";
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            phepTinh = "*";
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            phepTinh = "/";
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double so2 = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            if (phepTinh == "+")
            {
                ketQua = so1 + so2;
            }
            else if (phepTinh == "-")
            {
                ketQua = so1 - so2;
            }
            else if (phepTinh == "*")
            {
                ketQua = so1 * so2;
            }
            else if (phepTinh == "/")
            {
                ketQua = so1 / so2;
            }

            txtDisplay.Text = ketQua.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            so1 = 0;
            phepTinh = "";
        }
    }
}
