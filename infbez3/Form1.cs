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
            this.comboBox_HeshAlg.SelectedIndex = 0; // выбираем по умолчанию первый алгоритм хэширования
            //======================================
            this.comboBox_SimmAlg.SelectedIndex = 0; // выбираем по умолчанию первый алгоритм Симм. шифрования
            this.radioBtn_SimmAlg1.Checked = true; ; // режим шифрования при запуске Симм. шифрования
            this.btn_simm_clear_Click(null, null); // жмем кнопку очистить для Симм. шифрования
            //======================================
            this.comboBox_AsimAlg.SelectedIndex = 0; // выбираем по умолчанию первый алгоритм Асимм. шифрования
            this.radioBtn_AsimAlg1.Checked = true; ; // режим шифрования при запуске Асимм. шифрования
            this.btn_Asim_clear_Click(null, null); // жмем кнопку очистить для Асимм. шифрования
            //======================================
            this.radioBtn_eds1.Checked = true; // при запуске режим подписания документа ЭЦП
            this.btn_eds_clear_Click(null, null); // Очистить всё на ЭЦП при запуске
        }

        //=====================================================================

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
                        // Считали байты из файла
                        global.Hesh_byte_in = File.ReadAllBytes(ofd.FileName);
                        this.txt_hesh_byte_in_num.Text = global.Hesh_byte_in.Length.ToString(); // Вывели кол-во считанный байт
                        this.txt_hesh_file_in.Text = ofd.FileName; // вывели путь в textbox
                        this.toolTip_hesh_file.SetToolTip(this.txt_hesh_file_in, this.txt_hesh_file_in.Text);

                        // если автохэширование вкл
                        if (this.checkBox_autoHesh.Checked == true)
                        {
                            // кнопка хэшировать
                            this.btn_Hesh_get_Click(null, null);
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

        // кнопка ОЧИСТИТЬ у ХЭШИРОВАНИЯ
        private void btn_clear_Hesh_byte_in_Click(object sender, EventArgs e)
        {
            // очистили данные в  входном массиве байт в хешэ
            if (global.Hesh_byte_in != null)
                Array.Clear(global.Hesh_byte_in, 0, global.Hesh_byte_in.Length);
            else
                global.Hesh_byte_in = new byte[0]; // выделили память под входной массив байт у хэширования
            // Кол-во считанных байт для хэширование 0
            this.txt_hesh_byte_in_num.Text = (0).ToString();
            // Очистили входной файл
            this.txt_hesh_file_in.Text = "";
            this.toolTip_hesh_file.SetToolTip(this.txt_hesh_file_in, this.txt_hesh_file_in.Text);
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
                MessageBox.Show("Хеш записан в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = true;
            }
            sfd.Dispose();
        }
        
        //=============================================================
        
        // кнопка ШИФРОВАТЬ/РАСшифровать Симметрично
        private void btn_SimmEncrypt_Click(object sender, EventArgs e)
        {
            if (this.txt_simm_byte_in_num.Text != "0") // Если входные данные не пусты
            {
                if(global.Simm_KeyIV_isEntry == true)// Если введен ключ и вектор
                {
                    try
                    {
                        // вызываем функцию шифрования и получаем байты шифра
                        global.Simm_byte_out = alg.SimmAlg(global.Simm_byte_in, global.Simm_byte_key, global.Simm_byte_iv, comboBox_SimmAlg.SelectedItem.ToString(), global.Simm_EncryptOrDecrypt);

                        // Вывести выходные байты 
                        if (global.Simm_EncryptOrDecrypt == true) // Если шифруем
                        {
                            // вывели байты на форму виде 16-ричной строки
                            this.txt_simm_text_out.Text = alg.ByteArrayTOStringHEX(global.Simm_byte_out);
                        }
                        else // Если расшифровываем
                        {
                            // вывели байты на форму виде строки с кодировкой UTF8
                            this.txt_simm_text_out.Text = Encoding.UTF8.GetString(global.Simm_byte_out).Replace("\0", "0");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    this.Enabled = false;
                    MessageBox.Show("Сначала укажите ключ и IV!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    return;
                }
            }
            else
            {
                this.Enabled = false;
                MessageBox.Show("Сначала укажите входные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                return;
            }
        }

        // кнопка режим Симметричного Шифрования
        private void radioBtn_SimmAlg1_CheckedChanged(object sender, EventArgs e)
        {
            global.Simm_EncryptOrDecrypt = true;
            this.btn_SimmEncrypt.Text = "🡻 Шифровать 🡻";
            this.label_simm_caption1.Text = "Входные данные";
            this.label_simm_caption2.Text = "Зашифрованные данные";
            this.label_simm_onText_out.Text = "Примерный вид зашифрованных данных:";
            this.label_simm_underText_out.Text = "(В файл шифр сохраниться в виде бинарных данных,\n но с таким же расширением, что и входной файл)";
            this.btn_simm_saveData.Text = "Сохранить шифр в файл";
            this.btn_choice_fileinSimm.Text = "Выбрать файл с данными";
            btn_simm_clear_Click(null, null); // Очистить всё при переключении
        }

        // кнопка режим Симметричной Расшифровки
        private void radioBtn_SimmAlg2_CheckedChanged(object sender, EventArgs e)
        {
            global.Simm_EncryptOrDecrypt = false;
            this.btn_SimmEncrypt.Text = "🡻 Расшифровать 🡻";
            this.label_simm_caption1.Text = "Зашифрованные данные";
            this.label_simm_caption2.Text = "Расшифрованные данные"; 
            this.label_simm_onText_out.Text = "Расшифрованные данные:";
            this.label_simm_underText_out.Text = "(В файл данные сохраняться в виде байт, но при открытие\n файл будет отображаться корректно так как будет сохранен\n с таким же расширеним, что и шифрованный файл)";
            this.btn_simm_saveData.Text = "Сохранить данные в файл";
            this.btn_choice_fileinSimm.Text = "Выбрать файл с шифром";
            btn_simm_clear_Click(null, null); // Очистить всё при переключении
        }

        // кнопка ПРОЧИТАТЬ ИЗ ФАЙЛА при СИММ. Шифровании
        private void btn_choice_fileinSimm_Click(object sender, EventArgs e)
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
                        // очистили ВЫходные байты
                        global.Simm_byte_out = new byte[0];
                        // Считали байты из файла
                        global.Simm_byte_in = File.ReadAllBytes(ofd.FileName);
                        this.txt_simm_byte_in_num.Text = global.Simm_byte_in.Length.ToString(); // Вывели кол-во считанных байт
                        this.txt_simm_file_in.Text = ofd.FileName; // вывели путь к файлу в textbox
                        this.toolTip_simm_file.SetToolTip(this.txt_simm_file_in, this.txt_simm_file_in.Text); // текст подсказки запомнили
                        this.txt_simm_text_in.Text = Encoding.UTF8.GetString(global.Simm_byte_in).Replace('\0', '0'); // вывели на форму считанное в кодировке UTF8
                        global.Simm_file_extension = ofd.SafeFileName.Substring(ofd.SafeFileName.LastIndexOf('.'));  // Запомнили расширение считанного файла
                    }
                    else
                    {
                        this.Enabled = false;
                        MessageBox.Show("Файла {" + ofd.FileName + "} не существует!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Enabled = true;
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

        // кнопка Ввод ключа и IV
        private void btn_simm_entryKeyIV_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(comboBox_SimmAlg.SelectedItem.ToString());
            form.Owner = this;
            form.form1_btn_simm_entryKeyIV = this.btn_simm_entryKeyIV; // передали ссылку на управление кнопкой
            form.ShowDialog(this);
        }

        // если меняем алгоритм СИММетричного ШИФРОВАНИЯ
        private void comboBox_SimmAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            //========очистка ключа======
            // меняем кнопку ввод ключа на обычную
            this.btn_simm_entryKeyIV.Text = "Ввести ключ и IV (отсутствуют)";
            this.btn_simm_entryKeyIV.ForeColor = Color.FromKnownColor(KnownColor.Black);
            // очищаем ключ и вектор
            global.Simm_byte_key = new byte[0];
            global.Simm_byte_iv = new byte[0];
            // флаг меняем что не введенны
            global.Simm_KeyIV_isEntry = false;
            //===================================
        }

        // кнопка ОЧИСТИТЬ у СИММетричного ШИФРОВАНИЯ
        private void btn_simm_clear_Click(object sender, EventArgs e)
        {
            //========очистка ключа======
            // меняем кнопку ввод ключа на обычную
            this.btn_simm_entryKeyIV.Text = "Ввести ключ и IV (отсутствуют)";
            this.btn_simm_entryKeyIV.ForeColor = Color.FromKnownColor(KnownColor.Black);
            // очищаем ключ и вектор
            global.Simm_byte_key = new byte[0];
            global.Simm_byte_iv = new byte[0];
            // флаг меняем что не введенны
            global.Simm_KeyIV_isEntry = false;
            //===================================
            // входные данные стираем
            global.Simm_byte_in = new byte[0];
            this.txt_simm_text_in.Text = "";
            this.txt_simm_file_in.Text = "";
            this.txt_simm_byte_in_num.Text = "0";
            // ВЫходные данные стираем
            global.Simm_byte_out = new byte[0];
            this.txt_simm_text_out.Text = "";
            // очистили расширение входного файла
            global.Simm_file_extension = "";
        }

        // Сохранить ключ IV в файл у СИММ шифрования
        private void btn_simm_saveKeyIV_Click(object sender, EventArgs e)
        {
            try
            {
                //Если ключ или IV  пусты 
                if (global.Simm_byte_key.Length == 0 || global.Simm_byte_iv.Length == 0)
                {
                    this.Enabled = false;
                    MessageBox.Show("Ключ или IV пусты!\nСначала введите ключ и IV.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Выберите папку и введите название файла (БЕЗ расширения) ...";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Filter = "Text files(*.txt)|*.txt"; // Сохранять только как текстовые файлы
                sfd.AddExtension = true;  //Добавить расширение к имени если не указали
                
                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                    // массив с двумя строками с ключом и IV
                    string[] KeyAndIV = new string[2]
                    {
                        alg.ByteArrayTOStringHEX(global.Simm_byte_key),
                        alg.ByteArrayTOStringHEX(global.Simm_byte_iv)
                    };
                    // сохраняем байты в файл
                    File.WriteAllLines(filename, KeyAndIV, Encoding.UTF8);

                    this.Enabled = false;
                    MessageBox.Show("Ключ и IV записаны в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                }
                sfd.Dispose();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Сохранить шифр/текст в файл у СИММ шифрования
        private void btn_simm_saveData_Click(object sender, EventArgs e)
        {
            try
            {
                //Если выходные байты пусты 
                if (global.Simm_byte_out.Length == 0)
                {
                    this.Enabled = false;
                    if (global.Simm_EncryptOrDecrypt == true)
                        MessageBox.Show("Сначала зашифруйте данные!\nЗатем можете сохранить полученный шифр.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Сначала расшифруйте шифр!\nЗатем можете сохранить полученные данные.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Enabled = true;
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Выберите папку и введите название файла (БЕЗ расширения) ...";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Filter = "Files(*" + global.Simm_file_extension + ")|*" + global.Simm_file_extension; // Сохранять только c расширением как и у входного файла
                sfd.AddExtension = true;  //Добавить расширение к имени если не указали

                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                    // сохраняем байты в файл
                    System.IO.File.WriteAllBytes(filename, global.Simm_byte_out);

                    this.Enabled = false;
                    if (global.Simm_EncryptOrDecrypt == true)
                        MessageBox.Show("Шифр записан в файл ЗАПИСАН в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Расшифрованное сообщение записано в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                }
                sfd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //===========================================================================

        // кнопка ШИФРОВАТЬ/РАСшифровать Асимметрично
        private void btn_AsimEncrypt_Click(object sender, EventArgs e)
        {
            if (this.txt_Asim_byte_in_num.Text != "0")  // Если входные данные не пусты
            {
                if (global.Asim_Keys_isEntry == true)  // Если введен ключ и вектор
                {
                    try
                    {
                        // шифруем/расшифровываем
                        global.Asim_byte_out = alg.AsimAlg(global.Asim_byte_in, global.Asim_byte_key, this.comboBox_AsimAlg.SelectedItem.ToString(), global.Asim_EncryptOrDecrypt);

                        // Вывести выходные байты 
                        if (global.Asim_EncryptOrDecrypt == true) // Если шифруем
                        {
                            // вывели байты на форму виде 16-ричной строки
                            this.txt_Asim_text_out.Text = alg.ByteArrayTOStringHEX(global.Asim_byte_out);
                        }
                        else // Если расшифровываем
                        {
                            // вывели байты на форму виде строки с кодировкой UTF8
                            this.txt_Asim_text_out.Text = Encoding.UTF8.GetString(global.Asim_byte_out).Replace("\0", "0");
                        }
                    }
                    catch (Exception error)
                    {
                        this.Enabled = false;
                        MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Enabled = true;
                        return;
                    }
                }
                else
                {
                    this.Enabled = false;
                    MessageBox.Show("Сначала укажите ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    return;
                }
            }
            else
            {
                this.Enabled = false;
                MessageBox.Show("Сначала укажите входные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                return;
            }
        }

        // кнопка режим Асимметричного Шифрования
        private void radioBtn_AsimAlg1_CheckedChanged(object sender, EventArgs e)
        {
            global.Asim_EncryptOrDecrypt = true;
            this.btn_AsimEncrypt.Text = "🡻 Шифровать 🡻";
            this.label_Asim_caption1.Text = "Входные данные";
            this.label_Asim_caption2.Text = "Зашифрованные данные";
            this.label_Asim_onText_out.Text = "Примерный вид зашифрованных данных:";
            this.label_Asim_underText_out.Text = "(В файл шифр сохраниться в виде бинарных данных,\n но с таким же расширением, что и входной файл)";
            this.btn_Asim_saveData.Text = "Сохранить шифр в файл";
            this.btn_choice_fileinAsim.Text = "Выбрать файл с данными";
            btn_Asim_clear_Click(null, null); // Очистить всё при переключении
        }

        // кнопка режим Асимметричной Расшифровки
        private void radioBtn_AsimAlg2_CheckedChanged(object sender, EventArgs e)
        {
            global.Asim_EncryptOrDecrypt = false;
            this.btn_AsimEncrypt.Text = "🡻 Расшифровать 🡻";
            this.label_Asim_caption1.Text = "Зашифрованные данные";
            this.label_Asim_caption2.Text = "Расшифрованные данные";
            this.label_Asim_onText_out.Text = "Расшифрованные данные:";
            this.label_Asim_underText_out.Text = "(В файл данные сохраняться в виде байт, но при открытие\n файл будет отображаться корректно так как будет сохранен\n с таким же расширеним, что и шифрованный файл)";
            this.btn_Asim_saveData.Text = "Сохранить данные в файл";
            this.btn_choice_fileinAsim.Text = "Выбрать файл с шифром";
            btn_Asim_clear_Click(null, null); // Очистить всё при переключении
        }

        // кнопка ПРОЧИТАТЬ ИЗ ФАЙЛА при Асимм. Шифровании
        private void btn_choice_fileinAsim_Click(object sender, EventArgs e)
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
                        // очистили ВЫходные байты
                        global.Asim_byte_out = new byte[0];
                        // Считали байты из файла
                        global.Asim_byte_in = File.ReadAllBytes(ofd.FileName);
                        this.txt_Asim_byte_in_num.Text = global.Asim_byte_in.Length.ToString(); // Вывели кол-во считанных байт
                        this.txt_Asim_file_in.Text = ofd.FileName; // вывели путь к файлу в textbox
                        this.toolTip_Asim_file.SetToolTip(this.txt_Asim_file_in, this.txt_Asim_file_in.Text); // текст подсказки запомнили
                        this.txt_Asim_text_in.Text = Encoding.UTF8.GetString(global.Asim_byte_in).Replace('\0', '0'); // вывели на форму считанное в кодировке UTF8
                        global.Asim_file_extension = ofd.SafeFileName.Substring(ofd.SafeFileName.LastIndexOf('.'));  // Запомнили расширение считанного файла
                    }
                    else
                    {
                        this.Enabled = false;
                        MessageBox.Show("Файла {" + ofd.FileName + "} не существует!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Enabled = true;
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

        // кнопка ВВОД КЛЮЧЕЙ
        private void btn_Asim_entryKey_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(comboBox_AsimAlg.SelectedItem.ToString());
            form.Owner = this;
            form.form1_btn_Asim_entryKey = this.btn_Asim_entryKey; // передали ссылку на управление кнопкой
            this.Enabled = false;
            form.ShowDialog(this);
            this.Enabled = true;
        }

        // если меняем алгоритм Асим ШИФРОВАНИЯ 
        // так как всего один алгоритма (RSA) по факту не используется *для будущих фич*
        private void comboBox_AsimAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            //========очистка ключа======
            // меняем кнопку ввод ключа на обычную
            this.btn_Asim_entryKey.Text = "Ввести ключ (отсутствует)";
            this.btn_Asim_entryKey.ForeColor = Color.FromKnownColor(KnownColor.Black);
            // очищаем ключ и вектор
            global.Asim_byte_key = new byte[0];
            global.Asim_file_key = "";
            // флаг меняем что не введенны
            global.Asim_Keys_isEntry = false;
            //===================================
        }

        // кнопка ОЧИСТИТЬ у Асимметричного ШИФРОВАНИЯ
        private void btn_Asim_clear_Click(object sender, EventArgs e)
        {
            //========очистка ключа======
            // меняем кнопку ввод ключа на обычную
            this.btn_Asim_entryKey.Text = "Ввести ключ (отсутствует)";
            this.btn_Asim_entryKey.ForeColor = Color.FromKnownColor(KnownColor.Black);
            // очищаем ключ и его файл
            global.Asim_byte_key = new byte[0];
            global.Asim_file_key = "";
            // флаг меняем что не введенны
            global.Asim_Keys_isEntry = false;
            //===================================
            // входные данные стираем
            global.Asim_byte_in = new byte[0];
            this.txt_Asim_text_in.Text = "";
            this.txt_Asim_file_in.Text = "";
            this.txt_Asim_byte_in_num.Text = "0";
            // ВЫходные данные стираем
            global.Asim_byte_out = new byte[0];
            this.txt_Asim_text_out.Text = "";
            // очистили расширение входного файла
            global.Asim_file_extension = "";
        }

        // Сохранить шифр/текст в файл у Асимм шифрования
        private void btn_Asim_saveData_Click(object sender, EventArgs e)
        {
            try
            {
                //Если выходные байты пусты 
                if (global.Asim_byte_out.Length == 0)
                {
                    this.Enabled = false;
                    if (global.Asim_EncryptOrDecrypt == true)
                        MessageBox.Show("Сначала зашифруйте данные!\nЗатем можете сохранить полученный шифр.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Сначала расшифруйте шифр!\nЗатем можете сохранить полученные данные.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Enabled = true;
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Выберите папку и введите название файла (БЕЗ расширения) ...";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Filter = "Files(*" + global.Asim_file_extension + ")|*" + global.Asim_file_extension; // Сохранять только c расширением как и у входного файла
                sfd.AddExtension = true;  //Добавить расширение к имени если не указали

                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                    // сохраняем байты в файл
                    System.IO.File.WriteAllBytes(filename, global.Asim_byte_out);

                    this.Enabled = false;
                    if (global.Asim_EncryptOrDecrypt == true)
                        MessageBox.Show("Шифр записан в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Расшифрованное сообщение записано в файл:\n" + filename, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                }
                sfd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //===========================================================================

        // работает ЛОЛ
        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rs = new RSACryptoServiceProvider(global.eds_size_key_bit);
            byte[] pbKey = rs.ExportCspBlob(false);
            byte[] prKey = rs.ExportCspBlob(true);
            //byte[] inmes = new byte[4] { 97, 98, 99, 100 };
            byte[] inmes = new byte[0];
            byte[] outmes = new byte[0];
            bool res = false;

            rs.ImportCspBlob(prKey);
            outmes = rs.SignData(inmes, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1);


            rs.ImportCspBlob(pbKey);
            res = rs.VerifyData(inmes, outmes, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1);
        }

        // кнопка ПОДПИСАТЬ/ПРОВЕРИТЬ у ЭЦП
        private void btn_edsDO_Click(object sender, EventArgs e)
        {
            this.button1_Click(null, null);
        }

        // смена режима: создания ЭЦП
        private void radioBtn_eds1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // смена режима: проверки ЭЦП
        private void radioButton_eds2_CheckedChanged(object sender, EventArgs e)
        {

        }

        // кнопка ОЧИСТИТЬ у ЭЦП
        private void btn_eds_clear_Click(object sender, EventArgs e)
        {
            //========очистка ключа======
            // меняем кнопку ввод ключа на обычную
            this.btn_eds_entryKey.Text = "Ввести ключ (отсутствует)";
            this.btn_eds_entryKey.ForeColor = Color.FromKnownColor(KnownColor.Black);
            // очищаем ключ и его файл
            global.eds_byte_key = new byte[0];
            global.eds_file_key = "";
            // флаг меняем что не введенны
            global.eds_Keys_isEntry = false;
            //===================================
            // Подпись не получена false
            global.eds_data_isSign = false;
            // входные данные стираем
            global.eds_byte_message = new byte[0];
            this.txt_eds_file_in.Text = "";
            // ВЫходные данные стираем
            global.eds_byte_sign = new byte[0];
            global.eds_data_isSign = false;
            global.eds_data_isCheck = false;
            this.txt_Asim_text_out.Text = "";
            // очистили расширение входного файла
            global.Asim_file_extension = "";
        }

        // ввод ключа ЭЦП
        private void btn_eds_entryKey_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Owner = this;
            form.form1_btn_eds_entryKey = this.btn_eds_entryKey; // передали ссылку на управление кнопкой
            this.Enabled = false;
            form.ShowDialog(this);
            this.Enabled = true;
        }
    }
    
}
