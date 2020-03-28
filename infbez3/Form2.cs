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
    }
}
