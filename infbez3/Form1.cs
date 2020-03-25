using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;

namespace infbez3
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        // при ЗАГРУЗКЕ ФОРМЫ
        private void Form_main_Load(object sender, EventArgs e)
        {
            this.checkBox_autoHesh.Checked = false; // автохэширование выкл по дефолту
            this.btn_clear_Hesh_byte_in_Click(null, null); // очистили входные поля (кнопка очистить)
            this.comboBox_HeshAlg.SelectedIndex = 0; // 
        }

        // ВЫБОР метода хэширования
        private void comboBox_HeshAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox_autoHesh.Checked == true)
            {
                this.btn_Hesh_get_Click(null, null); // клик кнопки хэшировать
            }
            
        }

        // кнопка ПРОЧИТАТЬ ИЗ ФАЙЛА при ХЭШИРОВАНИИ
        private void btn_choice_fileinHesh_Click(object sender, EventArgs e)
        {

        }

        // кнопка ОЧИСТИТЬ у ХЭШИРОВАНИЯ
        private void btn_clear_Hesh_byte_in_Click(object sender, EventArgs e)
        {
            // очистили данные в  входном массиве байт в хешэ
            if (global.Hesh_byte_in != null)
                Array.Clear(global.Hesh_byte_in, 0, global.Hesh_byte_in.Length);
            else
                global.Hesh_byte_in = new byte[0]; // выделили память под входной массив байт у хэширования
            // Кол-во считанных байт для хэширование 0
            this.txt_byte_in_num.Text = (0).ToString();
            // Очистили хеш на форме
            this.txt_Hesh_out.Text = "";

        }

        // кнопка КОПИРОВАТЬ ХЭШ в буффер windows
        private void btn_copy_Hesh_Click(object sender, EventArgs e)
        {
            if (this.txt_Hesh_out.Text.Length > 0)
                Clipboard.SetText(txt_Hesh_out.Text);
        }

        // кнопка ХЭШИРОВАТЬ
        private void btn_Hesh_get_Click(object sender, EventArgs e)
        {
            string selectedAlgHesh = comboBox_HeshAlg.SelectedItem.ToString();
            this.txt_Hesh_out.Text = alg.HeshAlg(global.Hesh_byte_in, selectedAlgHesh);

        }

        // кнопка СОХРАНИТЬ ХЭШ
        private void btn_Hesh_save_Click(object sender, EventArgs e)
        {
            //Если поле с хэш-функцией пустое
            if (this.txt_Hesh_out.Text.Length < 1)
            {
                this.Enabled = false;
                MessageBox.Show("Поле с хеш-функцией пустое!\nСначала получите хеш.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Text files(*.txt)|*.txt"; // Сохранять только как текстовые файлы
            sfd.AddExtension = true;  //Добавить расширение к имени если не указали

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = sfd.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, txt_Hesh_out.Text);

                this.Enabled = false;
                MessageBox.Show("Хеш записан в файл:\n" + filename, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = true;
                this.btn_SimmEncrypt_Click(null, null);
            }
        }

        // кнопка ШИФРОВАТЬ Симметрично
        private void btn_SimmEncrypt_Click(object sender, EventArgs e)
        {
            AesExample.example();
           
        }
    }
}
