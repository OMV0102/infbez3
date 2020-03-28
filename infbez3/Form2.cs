using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Collections;
using System.Text;
using System.Drawing;

namespace infbez3
{
    public partial class Form2 : Form
    {
        public Form2(string Alg)
        {
            InitializeComponent();
            AlgName = Alg;
        }

        public static AesCng aescng;
        public static TripleDESCng tripledes;
        public static string AlgName;
        public Button form1_btn_simm_entryKeyIV;


        // при загрузке формы для ввода ключа и IV
        private void Form2_Load(object sender, EventArgs e)
        {
            aescng = new AesCng();
            tripledes = new TripleDESCng();
            if (AlgName == "AES")
            {
                txt_key.MaxLength = 64;
                txt_iv.MaxLength = 32;
            }

            if (AlgName == "3DES")
            {
                txt_key.MaxLength = 48;
                txt_iv.MaxLength = 16;
            }
        }

        private void btn_confirm_entry_Click(object sender, EventArgs e)
        {
            //Form form = this.Owner; // получили объект родительской формы
            //Form_main form = this.Owner; // получили объект родительской формы
            if(txt_key.Text.Length == txt_key.MaxLength)
            {
                if (txt_iv.Text.Length == txt_iv.MaxLength)
                {
                    global.Simm_byte_key = alg.StringHEXToByteArray(txt_key.Text); // Запомнили ключ
                    global.Simm_byte_iv = alg.StringHEXToByteArray(txt_iv.Text); // Запомнили IV

                    form1_btn_simm_entryKeyIV.Text = "Ввести ключ и IV (введен)";
                    form1_btn_simm_entryKeyIV.ForeColor = Color.FromKnownColor(KnownColor.Green);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Число символов в IV должно быть " + txt_iv.MaxLength.ToString() + "!\nОтредактируйте IV или сгенерируйте случайно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Число символов в ключе должно быть " + txt_key.MaxLength.ToString() + "!\nОтредактируйте ключ или сгенерируйте случайно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            
            //this.Close();
        }

        // Генерировать ключ
        private void btn_generate_key_Click(object sender, EventArgs e)
        {
            if(AlgName == "AES")
            {
                aescng.GenerateKey();
                this.txt_key.Text = alg.ByteArrayTOStringHEX(aescng.Key);
            }

            if (AlgName == "3DES")
            {
                tripledes.GenerateKey();
                this.txt_key.Text = alg.ByteArrayTOStringHEX(tripledes.Key);
            }
        }

        // Генерировать вектор инициализации IV
        private void btn_generate_iv_Click(object sender, EventArgs e)
        {
            if (AlgName == "AES")
            {
                aescng.GenerateIV();
                this.txt_iv.Text = alg.ByteArrayTOStringHEX(aescng.IV);
            }

            if (AlgName == "3DES")
            {
                tripledes.GenerateIV();
                this.txt_iv.Text = alg.ByteArrayTOStringHEX(tripledes.IV);
            }
        }

        // Ввод символа в поле ключа (только 16-ричные символы)
        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 70) || (e.KeyChar >= 97 && e.KeyChar <= 102) || e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Ввод символа в поле iv (только 16-ричные символы)
        private void txt_iv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 70) || (e.KeyChar >= 97 && e.KeyChar <= 102) || e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
