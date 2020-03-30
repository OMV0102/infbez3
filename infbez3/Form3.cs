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
    public partial class Form3 : Form
    {
        public Form3(string Alg)
        {
            InitializeComponent();
            AlgName = Alg;
        }

        public static RSACryptoServiceProvider rsacrypto;
        public static string AlgName;
        public Button form1_btn_Asim_entryKey;


        // при ЗАГРУЗКЕ ФОРМЫ для ввода ключа и IV
        private void Form3_Load(object sender, EventArgs e)
        {
            // Выделили память и установили длину ключей и IV
            // в зависимости от алгоритма
            rsacrypto = new RSACryptoServiceProvider(global.Asim_size_key);
            
            if (AlgName == "RSA")
            {
                this.txt_keyPublic.MaxLength = 64;
                this.txt_keyPrivate.MaxLength = 32;

            }

            // если раннее были введенны ключи то вывести их на форму
            if (global.Simm_KeyIV_isEntry)
            {
                this.txt_keyPublic.Text = alg.ByteArrayTOStringHEX(global.Simm_byte_key);
                this.txt_keyPrivate.Text = alg.ByteArrayTOStringHEX(global.Simm_byte_iv);
            }

            // Подсказка у кнопки загрузки ключа
            this.toolTip_LoadKeyIV.ToolTipTitle = this.btn_loadKeyIV.Text;
            this.toolTip_LoadKeyIV.ToolTipIcon = ToolTipIcon.Info;
            this.toolTip_LoadKeyIV.SetToolTip(this.btn_loadKeyIV, "В файле должно быть две строки в 16-ричном виде.\n1-ая строка: Ключ длинной 64 знака.\n2-ая строка: Вектор(IV) длиной 32 знакак.");

            // Инструкция сверху формы
            this.label_simm_entryKeyIV.Text = "> Ключом могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина ключа должна быть обязательно равна " + txt_keyPublic.MaxLength + " знакам!\n\n";
            this.label_simm_entryKeyIV.Text += "> В векторе могут быть только 16-ричные цифры (0-9, A-F).\n";
            this.label_simm_entryKeyIV.Text += "> Длина должна быть обязательно равна "+ txt_keyPrivate.MaxLength + " знакам!\n";
            

            if (global.Simm_EncryptOrDecrypt) // если загрузили для ШИФРОВАНИЯ
            {
                this.Text = "ШИФРОВАНИЕ: Ввод ключа (Key) и вектора инициализации (IV)";
                // показать кнопки случайно генерации
                this.btn_generate_key.Visible = true;
                this.label_simm_entryKeyIV.Text += "\n> Стрелки - случайное заполнение ключа и вектора (IV).";
            }
            else  // если загрузили для РАСШИФРОВКИ
            {
                this.Text = "РАСШИФРОВКА: Ввод ключа (Key) и вектора инициализации (IV)";
                this.btn_generate_key.Visible = false;
            }
        }

        // кнопка ПОДТВЕРДИТЬ
        private void btn_confirm_entry_Click(object sender, EventArgs e)
        {
            if(txt_keyPublic.Text.Length == txt_keyPublic.MaxLength)
            {
                if (txt_keyPrivate.Text.Length == txt_keyPrivate.MaxLength)
                {
                    global.Simm_byte_key = alg.StringHEXToByteArray(txt_keyPublic.Text); // Запомнили ключ
                    global.Simm_byte_iv = alg.StringHEXToByteArray(txt_keyPrivate.Text); // Запомнили IV
                    global.Simm_KeyIV_isEntry = true;

                    form1_btn_Asim_entryKey.Text = "Изменить ключ и IV (введенно)"; // Изменили название кнопки на основной форме
                    form1_btn_Asim_entryKey.ForeColor = Color.FromKnownColor(KnownColor.Green); // Цвет изменили

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Число символов в IV должно быть " + txt_keyPrivate.MaxLength.ToString() + "!\nОтредактируйте IV или сгенерируйте случайно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Число символов в ключе должно быть " + txt_keyPublic.MaxLength.ToString() + "!\nОтредактируйте ключ или сгенерируйте случайно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        // Генерировать ключ
        private void btn_generate_key_Click(object sender, EventArgs e)
        {
            if(AlgName == "AES")
            {
                aescng.GenerateKey();
                this.txt_keyPublic.Text = alg.ByteArrayTOStringHEX(aescng.Key);
            }

            if (AlgName == "3DES")
            {
                tripledes.GenerateKey();
                this.txt_keyPublic.Text = alg.ByteArrayTOStringHEX(tripledes.Key);
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
                            if(temp1 == null || temp2 == null || temp1.Length != txt_keyPublic.MaxLength || temp2.Length != txt_keyPrivate.MaxLength)
                            {
                                MessageBox.Show("Ошибка считывания данных!\nПосмотрите подсказку при наведении на кнопку загрузки.", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Выводим в форму считанные данные
                            this.txt_keyPublic.Text = temp1;
                            this.txt_keyPrivate.Text = temp2;

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
            ofd.Dispose();
        }

        // При закрытии формы
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освободили память от aes и 3des
            aescng.Dispose();
            tripledes.Dispose();
        }
    }
}
