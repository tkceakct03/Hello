using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanNguyen_2180606793
{
    public partial class FrmNguyenVanNguyen : Form
    {
        public FrmNguyenVanNguyen()
        {
            InitializeComponent();
        }

        private bool checkData()
        {

            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(txtM.Text)) return false;
            return true;
        }
        private bool prime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n);i++)
            {
                if( n % i == 0) return false;
            }
            return true;
        }
        private int CountPrime(int n, int m)
        {
            int count = 0;
            for(int i = n ; i <= m; i++)
            {
                if (prime(i))
                {
                    count++;
                }
            }
            return count;
        }
        private bool SoChinhPhuong(int n)
        {
            return (int)Math.Sqrt(n) *(int)Math.Sqrt(n) == n;
        }
        private int CountSCP(int n, int m)
        {
            int count = 0;
            for(int i = n; i <= m; i++)
            {
                if (SoChinhPhuong(i)) count++;
            }
            return count;
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                int n = Int32.Parse(txtN.Text);
                int m = Int32.Parse(txtM.Text);
                if (rdbTong.Checked)
                {
                    double result = (m - n + 1) * (n + m) / 2;
                    txtKetQua.Text = result.ToString();
                }
                if(rdbTich.Checked)
                {
                    double result = 1;
                    for(int i =  n; i <= m; i++)
                    {
                        result *= i;
                    }
                    txtKetQua.Text = result.ToString();
                }
                if(rdbChan.Checked)
                {
                    InSoChan(n, m);
                }
                if (rdbChiaHet2va3.Checked)
                {
                    SoChiaHetcho2and3(n, m);
                }
                if (rdbLietkeSnt.Checked)
                {
                    string result = "";
                    bool flag = true;
                    for(int i = n; i <= m; i++)
                    {
                        if (prime(i))
                        {
                            if (!flag) result += ";";
                            result += i;
                            flag = false;
                        }
                    }
                    txtKetQua.Text = result;
                }
                if(rdbLietkeSCP.Checked)
                {
                    string result = "";
                    bool flag = true;
                    for(int i = n; i <= m; i++)
                    {
                        if(SoChinhPhuong(i))
                        {
                            if (!flag) result += ";";
                            result += i;
                            flag = false;
                        }
                        txtKetQua.Text = result;
                    }
                }
                if(rdbDemSNT.Checked)
                {
                    txtKetQua.Text = CountPrime(n, m).ToString();
                }
                if(rdbDemSCP.Checked)
                {
                    txtKetQua.Text = CountSCP(n,m).ToString(); 
                }
            }
        }
        private void InSoChan(int n , int m)
        {
            //5 10 5 6 7 8 9 10
            int begin = n;
            int end = m;
            if (begin % 2 != 0) begin ++;
            if (end % 2 != 0) end--;
            string result = "";
            for (int i = begin; i <= end; i+=2)
            {
                if( i % 2 == 0)
                {
                    result += i + " ";
                    if(i != end ) { result += ";"; }
                }
            }
            txtKetQua.Text = result;
        }
        // 2 3 6 12 ,18
        private void SoChiaHetcho2and3(int n, int m)
        {
            // m = 18  
            string result = "";
            int begin = n;
            int end = m;
            while(end >= begin)
            {
                if (end % 2 == 0 && end % 3 == 0) break;
                end--;
            }
            bool isFirst = true;
            if (begin < 6) begin = 6;
            for(int i = begin; i <= end  ; i+=6)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    if (!isFirst) result += ";";
                    result += i;
                    // 6  
                    isFirst = false;
                }
            }
            txtKetQua.Text= result;
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Khong duoc nhap ki tu chu cai");
            }
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Khong duoc nhap ki tu chu cai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Text = txtM.Text = txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
