using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace kthp_csdlvgt
{ 
    public partial class frmFormChinh : Form
    {
        private SoundPlayer choiNhac;
        public static int count = 0;
        public frmFormChinh()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer("Music.wav");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn1.Text;
        }

        private void txtPhepToan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
                (
                "Bạn chắc chắc muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == "" || txtPhepToan.Text[txtPhepToan.Text.Length - 1] != ')')
                txtPhepToan.Text += btn0.Text;
        }

        private void btnMoNgoac_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text == ""  ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '+' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '*' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '/' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '(' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ' ')
                txtPhepToan.Text += btnMoNgoac.Text;
        }

        private void btnDongNgoac_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnDongNgoac.Text;
            

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnCong.Text;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnTru.Text;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnNhan.Text;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnChia.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                (
                "Bạn chắc chắc muốn reset lại phép toán?",
                "Nhắc nhở",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );
            if (result == DialogResult.Yes)
            {
                txtPhepToan.Text = "";
                lblKetQua.Text = "";
            }
        }

        private void chkAmThanh_CheckedChanged(object sender, EventArgs e)
        { 
                if (chkAmThanh.Checked == true)
                    choiNhac.Play();
                else
                    choiNhac.Stop(); 
        }

        private void frmFormChinh_Load(object sender, EventArgs e)
        {
            chkAmThanh.Checked = true;
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string phepToan = txtPhepToan.Text;
            int mn = 0;
            int dn = 0;
            for (int i = 0; i < phepToan.Length; i++)
            {
                if (phepToan[i] == '(') mn++;
                if (phepToan[i] == ')') dn++;
            }
            Console.WriteLine(mn);
            Console.WriteLine(dn);
            if (mn == dn)
            {
                if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
                txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-' ||
                
                )
                {
                    double a = Tong(bt(phepToan));

                    string s = a.ToString();

                    lblKetQua.Text = s;

                    errorProvider1.Clear();
                    errorProvider2.Clear();

                    lblPhepToanLS.Text += txtPhepToan.Text + "=" + lblKetQua.Text + "\n";
                }
            }
            else if (txtPhepToan.Text == "")
            {
                errorProvider2.Clear();
                errorProvider1.SetError(txtPhepToan, "Phép toán rỗng");
            }

            else
            {
                errorProvider1.Clear();
                errorProvider2.SetError(txtPhepToan, "Phép toán sai");
            }
            
        }
        static int Uutien(char x)
        {
            if (x == '^') return 3;
            else if (x == '*' || x == '/') return 2;
            else if (x == '+' || x == '-') return 1;
            return -1;
        }
        static string[] bt(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string str = "";
            string[] postfix = new string[50];
            while (infix.Length > 0)
            {
                if (char.IsNumber(infix[0]))
                {
                    while (infix.Length > 0 && (char.IsNumber(infix[0]) || infix[0] == '.'))
                    {
                        str += infix[0];
                        infix = infix.Remove(0, 1);
                    }
                    if (str.Length > 0)
                    {
                        postfix[count] = str;
                        count++;
                        str = "";
                    }
                }
                else if (infix[0] == '(')
                {
                    if (infix[1] == '-')
                    {
                        infix = infix.Remove(0, 1);
                        str += infix[0];
                        infix = infix.Remove(0, 1);
                        while (char.IsNumber(infix[0]) || infix[0] == '.')
                        {
                            str += infix[0];
                            infix = infix.Remove(0, 1);
                        }
                        postfix[count] = str;
                        count++;
                        str = "";
                        infix = infix.Remove(0, 1);
                    }
                    else
                    {
                        stack.Push('(');
                        infix = infix.Remove(0, 1);
                    }
                }
                else if (infix[0] == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix[count] = Convert.ToString(stack.Pop());
                        count++;
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.Write("Lỗi");
                    }
                    else
                    {
                        stack.Pop();
                        infix = infix.Remove(0, 1);
                    }
                }
                else
                {
                    while (stack.Count > 0 && Uutien(infix[0]) <= Uutien(stack.Peek()))
                    {
                        postfix[count] = Convert.ToString(stack.Pop());
                        count++;
                    }
                    stack.Push(infix[0]);
                    infix = infix.Remove(0, 1);
                }
            }
            while (stack.Count > 0)
            {
                postfix[count] = Convert.ToString(stack.Pop());
                count++;
            }
            return postfix;
        }
        static double Tong(string[] x)
        {
            double tong = 0;
            Stack<double> stack = new Stack<double>();
            double a, b;
            foreach (string i in x)
            {
                if (i != null)
                {
                    if (i == "+" || i == "-" || i == "*" || i == "/" || i == "^")
                    {
                        a = stack.Pop();
                        b = stack.Pop();
                        if (i == "+")
                            stack.Push((a + b));
                        else if (i == "-")
                            stack.Push((b - a));
                        else if (i == "*")
                            stack.Push((a * b));
                        else if (i == "/")
                            stack.Push((b / a));
                        else if (i == "^")
                            stack.Push(Math.Pow(b, a));
                    }
                    else
                    {
                        stack.Push(Convert.ToDouble(i));
                    }
                }
            }
            while (stack.Count > 0)
                tong += stack.Pop();
            return tong;
        }
        private void lblKetQua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDauPhay_Click(object sender, EventArgs e)
        {
            if (txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '0' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '1' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '2' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '3' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '4' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '5' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '6' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '7' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '8' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '9' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == ')' ||
            txtPhepToan.Text[txtPhepToan.Text.Length - 1] == '-')
                txtPhepToan.Text += btnDauPhay.Text;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPhepToanLS_Click(object sender, EventArgs e)
        {

        }

        private void txtPhepToan_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
