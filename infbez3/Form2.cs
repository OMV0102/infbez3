﻿using System;
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


        // при ЗАГРУЗКЕ ФОРМЫ для ввода ключа и IV
        private void Form2_Load(object sender, EventArgs e)
        {
            // Выделили память и установили длину ключей и IV
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

            // Инструкция сверху формы
            this.label_simm_entryKeyIV.Text = "> Ключом могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина ключа должна быть обязательно равна " + txt_key.MaxLength + " знакам!\n\n";
            this.label_simm_entryKeyIV.Text += "> В векторе могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина должна быть обязательно равна "+ txt_iv.MaxLength + " знакам!\n\n";
            this.label_simm_entryKeyIV.Text += "> Стрелки - случайное заполнение.";

            // Подсказка у кнопки загрузки ключа
            this.toolTip_LoadKeyIV.ToolTipTitle = this.btn_loadKeyIV.Text;
            this.toolTip_LoadKeyIV.ToolTipIcon = ToolTipIcon.Info;
            this.toolTip_LoadKeyIV.SetToolTip(this.btn_loadKeyIV, "В файле должно быть две строки в 16-ричном виде.\n1-ая строка: Ключ длинной 64 знака.\n2-ая строка: Вектор(IV) длиной 32 знакак.");

            if (global.Simm_EncryptOrDecrypt) // если загрузили для ШИФРОВАНИЯ
            {
                this.Text = "ШИФРОВАНИЕ: Ввод ключа (Key) и вектора инициализации (IV)";
            }
            else  // если загрузили для РАСШИФРОВКИ
            {
                this.Text = "РАСШИФРОВКА: Ввод ключа (Key) и вектора инициализации (IV)";
            }
        }

        // кнопка ПОДТВЕРДИТЬ
        private void btn_confirm_entry_Click(object sender, EventArgs e)
        {
            if(txt_key.Text.Length == txt_key.MaxLength)
            {
                if (txt_iv.Text.Length == txt_iv.MaxLength)
                {
                    global.Simm_byte_key = alg.StringHEXToByteArray(txt_key.Text); // Запомнили ключ
                    global.Simm_byte_iv = alg.StringHEXToByteArray(txt_iv.Text); // Запомнили IV
                    global.Simm_KeyIV_isEntry = true;

                    form1_btn_simm_entryKeyIV.Text = "Изменить ключ и IV (введенно)"; // Изменили название кнопки на основной форме
                    form1_btn_simm_entryKeyIV.ForeColor = Color.FromKnownColor(KnownColor.Green); // Цвет изменили

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

        // кнопка ЗАГРУЗИТЬ ключ и IV из файла
        private void btn_loadKeyIV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбрать файл ..."; // Заголовок окна
            ofd.InitialDirectory = Application.StartupPath; // Папка проекта

            if (ofd.ShowDialog() == DialogResult.OK) // Если выбрали файл
            {
                // читаем байты из файла
                if (ofd.FileName.Length > 0) // Если путь не нулевой
                {
                    if (File.Exists(ofd.FileName) == true) // Если указанный файл существует
                    {
                        string temp1 = "";
                        string temp2 = "";
                        using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8))
                        {
                            temp1 = sr.ReadLine();
                            temp2 = sr.ReadLine();
                            if(temp1 == null || temp2 == null || temp1.Length != txt_key.MaxLength || temp2.Length != txt_iv.MaxLength)
                            {
                                MessageBox.Show("Ошибка считывания данных!\nПосмотрите подсказку при наведении на кнопку загрузки.", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Выводим в форму считанные данные
                            this.txt_key.Text = temp1;
                            this.txt_iv.Text = temp2;

                        }
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
        }

        // При закрытии формы
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освободили память от aes и 3des
            aescng.Dispose();
            tripledes.Dispose();
        }
    }
}
