namespace GG_Calculation
{
    public partial class Form1 : Form
    {

        double collect1 = 0.00;
        double collect2 = 0.00;
        double result = 0.00;
        string operation = "";


        //R  = D1
        //H = D2


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "0";
            else
                Dispaly1.Text += "0";
           
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "")
                Dispaly1.Text = "1";
            else
                Dispaly1.Text += "1";
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {

            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "2";
            else
                Dispaly1.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "3";
            else
                Dispaly1.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "4";
            else
                Dispaly1.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "5";
            else
                Dispaly1.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
            {
                Dispaly1.Text = "6";
                Dispaly2.Clear();
            }
            else
                Dispaly1.Text += "6";
                Dispaly2.Clear();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
            {
                Dispaly1.Text = "7";
                Dispaly2.Clear();
            }
            else
                Dispaly1.Text += "7";
                Dispaly2.Clear();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "8";
            else
                Dispaly1.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Dispaly2.Clear();
            if (Dispaly1.Text == "0")
                Dispaly1.Text = "9";
            else
                Dispaly1.Text += "9";
        }

        //บวก
        private void plus_Click(object sender, EventArgs e)
        {
            collect1 = double.Parse(Dispaly1.Text);
            Dispaly1.Text = "0";
            operation = "+";
            Dispaly2.Clear();
        }

        //ลบ
        private void button8_Click(object sender, EventArgs e)
        {
            collect1 = double.Parse(Dispaly1.Text);
            Dispaly1.Text = "0";
            operation = "-";
            Dispaly2.Clear();
        }

        //คูณ
        private void button15_Click(object sender, EventArgs e)
        {
            collect1 = double.Parse(Dispaly1.Text);
            Dispaly1.Text = "0";
            operation = "*";
            Dispaly2.Clear();
        }

        //จุด
        private void button11_Click(object sender, EventArgs e)
        {
            if (!Dispaly1.Text.Contains("."))
            {
                Dispaly1.Text += ".";
                Dispaly2.Clear();
            };
        }

        //หาร
        private void button16_Click(object sender, EventArgs e)
        {
            collect2 = double.Parse(Dispaly1.Text);
            Dispaly1.Text = "0";
            operation = "/";
            Dispaly2.Clear();
        }

        //ตั้งหมด
        private void button17_Click(object sender, EventArgs e)
        {
            Dispaly1.Clear();
            if (Dispaly1.Text == String.Empty)
            {
                Dispaly2.Text = "";
                Dispaly1.Text = "0";
            }
        }

        //ลบที่ละหนึ่ง
        private void button18_Click(object sender, EventArgs e)
        {
            if (Dispaly1.Text.Length > 0)
            {
                Dispaly1.Text = Dispaly1.Text.Remove(Dispaly1.Text.Length - 1, 1);
            }
        }

        //เท่ากับ
        private void button13_Click(object sender, EventArgs e)
        {
            collect2 = double.Parse(this.Dispaly1.Text);
            if (operation == "+")
            {
                result = collect1 + collect2;
                Dispaly1.Text = result.ToString("#,###.#####");
                Dispaly2.Text = ($"{collect1.ToString("#,###.#####")}{operation}{collect2.ToString("#,###.#####")} = \n");
            }
            else if (operation == "-")
            {
                result = collect1 - collect2;
                Dispaly1.Text = result.ToString("#,###.#####");
                Dispaly2.Text = ($"{collect1.ToString("#,###.#####")}{operation}{collect2.ToString("#,###.#####")} = \n");
            }
            else if (operation == "*")
            {
                result = collect1 * collect2;
                Dispaly1.Text = result.ToString("#,###.#####");
                Dispaly2.Text = ($"{collect1.ToString("#,###.#####")}{operation}{collect2.ToString("#,###.#####")} = \n");
            }
            else
                result = collect1 / collect2;
            Dispaly1.Text = result.ToString("#,###.#####");
            Dispaly2.Text = ($"{collect1.ToString("#,###.#####")}{operation}{collect2.ToString("#,###.#####")} = \n");

            result = double.Parse(this.Dispaly1.Text);
            operation = String.Empty;
        }

    }
}