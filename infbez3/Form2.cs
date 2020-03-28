using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infbez3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // при загрузке формы для воода ключа и IV
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_entry_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 
        private void checkBox_keyShow_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox_keyShow.Checked == true)
            {
                this.checkBox_keyShow.Text = "Ключ виден";
                this.txt_key.PasswordChar = '\0';
            }
            else
            {
                this.checkBox_keyShow.Text = "Ключ скрыт";
                this.txt_key.PasswordChar = '*';
            }
        }
    }
}
