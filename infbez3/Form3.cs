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
    public partial class Form3 : Form
    {
        public Form3(string Alg)
        {
            InitializeComponent();
            AlgName = Alg;
        }

        public static string AlgName;
        public Button form1_btn_Asim_entryKey;
        byte[] key;


        // при ЗАГРУЗКЕ ФОРМЫ для ввода ключа Ассим шифрование
        private void Form3_Load(object sender, EventArgs e)
        {
            key = new byte[0];

            // если раннее были введенны ключи то вывести их на форму
            if (global.Simm_KeyIV_isEntry)
            {
                this.txt_key_file.Text = global.Asim_file_key;
                this.key = global.Asim_byte_key;
            }

            // Инструкция сверху формы
            this.label_simm_entryKeyIV.Text = "> Ключом могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина ключа должна быть обязательно равна " + txt_key_file.MaxLength + " знакам!\n\n";
            this.label_simm_entryKeyIV.Text += "> В векторе могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина должна быть обязательно равна "+ txt_keyPrivate.MaxLength + " знакам!\n";
            

            if (global.Simm_EncryptOrDecrypt) // если загрузили для ШИФРОВАНИЯ
            {
                this.Text = "ШИФРОВАНИЕ: Ввод ключа (Public/Private Key)";
                // показать кнопки случайно генерации
                this.btn_generate_key.Visible = true;
            }
            else  // если загрузили для РАСШИФРОВКИ
            {
                this.Text = "РАСШИФРОВКА: Ввод секретного ключа (Private Key)";
                this.btn_generate_key.Visible = false;
            }
        }

        // кнопка ПОДТВЕРДИТЬ
        private void btn_confirm_entry_Click(object sender, EventArgs e)
        {
            if(txt_key_file.Text.Length > 0 && (this.key != null || this.key.Length > 0))
            {

                global.Asim_byte_key = this.key; // Запомнили ключ
                global.Asim_file_key = this.txt_key_file.Text; // Запомнили путь к ключу
                global.Simm_KeyIV_isEntry = true;

                form1_btn_Asim_entryKey.Text = "Изменить ключ (введенно)"; // Изменили название кнопки на основной форме
                form1_btn_Asim_entryKey.ForeColor = Color.FromKnownColor(KnownColor.Green); // Цвет изменили

                this.Close();

            }
            else
            {
                MessageBox.Show("Число символов в ключе должно быть " + txt_key_file.MaxLength.ToString() + "!\nОтредактируйте ключ или сгенерируйте случайно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        // Генерировать ключ
        private void btn_generate_key_Click(object sender, EventArgs e)
        {
            byte[] keyPrivate = new byte[0];
            byte[] keyPublic = new byte[0];

            if(AlgName == "RSA")
            {
                RSACryptoServiceProvider rsacrypto = new RSACryptoServiceProvider(global.Asim_size_key_bit);
                keyPrivate = rsacrypto.ExportCspBlob(true); // запомнили приватный ключ
                keyPublic = rsacrypto.ExportCspBlob(false); // запомнили публичный ключ
            }

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Выберите место и введите название файла (БЕЗ РАСШИРЕНИЯ) для сохранения сгенерированных ключей ...";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Filter = "Files(*.public)|*.public"; // Сохранять только c расширением public
                sfd.AddExtension = false;  //НЕ Добавлять расширение к имени если не указали

                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                    // сохраняем байты в файл
                    System.IO.File.WriteAllBytes(filename+ ".public", keyPublic);
                    System.IO.File.WriteAllBytes(filename+ ".private", keyPrivate);


                    this.Enabled = false;
                    string message = "Ключи сохранены.Публичный ключ записан в файл:\n" +
                        filename + ".public\n" +
                        "Приватный ключ записан в файл:\n" + 
                        filename + ".private\n" +
                        "\nВвести сгенерированный (публичный) ключ сейчас для шифрования?";
                    res = MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    this.Enabled = true;
                    
                    if(res == DialogResult.Yes) // Если ответ да (ввести ключ)
                    {
                        this.key = keyPublic;
                        this.txt_key_file.Text = filename + filename + ".public";
                    }
                }
                sfd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // кнопка ЗАГРУЗИТЬ ключ
        private void btn_loadKeyIV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(global.Asim_EncryptOrDecrypt == true) // Если шифруем
            {
                ofd.Title = "ШИФРОВАНИЕ: Выбрать файл c ключом ..."; // Заголовок окна
                ofd.InitialDirectory = Application.StartupPath; // Папка проекта
                ofd.Filter = "Files(*.public)|*.public|Files(*.private|*.private"; // расширения public/private
            }
            else
            {
                ofd.Title = "РАСШИФРОВКА: Выбрать файл c секретным ключом ..."; // Заголовок окна
                ofd.InitialDirectory = Application.StartupPath; // Папка проекта
                ofd.Filter = "Files(*.private|*.private"; // расширения public/private
            }
            if (ofd.ShowDialog() == DialogResult.OK) // Если выбрали файл
            {
                // читаем байты из файла
                if (ofd.FileName.Length > 0) // Если путь не нулевой
                {
                    if (File.Exists(ofd.FileName) == true) // Если указанный файл существует
                    {
                        byte[] tempKey = new byte[0];
                        tempKey = File.ReadAllBytes(ofd.FileName);
                        if(tempKey == null || tempKey.Length < global.Asim_size_key_byte)
                        {
                            MessageBox.Show("Ошибка считывания ключа!\n", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Выводим в форму считанные данные
                        this.txt_key_file.Text = ofd.FileName;
                        this.key = tempKey;
                    }
                    else
                    {
                        MessageBox.Show("Файла {" + ofd.FileName + "} не существует!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    this.Enabled = false;
                    MessageBox.Show("Указан неверный путь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    return;
                }
            }
            ofd.Dispose();
        }
    }
}
