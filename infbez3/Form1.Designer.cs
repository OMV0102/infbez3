namespace infbez3
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Hesh = new System.Windows.Forms.TabPage();
            this.txt_hesh_file_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Hesh_out = new System.Windows.Forms.Label();
            this.txt_byte_in_num = new System.Windows.Forms.Label();
            this.btn_Hesh_save = new System.Windows.Forms.Button();
            this.btn_Hesh_get = new System.Windows.Forms.Button();
            this.btn_copy_Hesh = new System.Windows.Forms.Button();
            this.btn_clear_Hesh_byte_in = new System.Windows.Forms.Button();
            this.checkBox_autoHesh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_choice_fileinHesh = new System.Windows.Forms.Button();
            this.comboBox_HeshAlg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_SimAlg = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_simm_file_in = new System.Windows.Forms.TextBox();
            this.comboBox_SimmAlg = new System.Windows.Forms.ComboBox();
            this.radioBtn_SimmAlg2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_SimmAlg1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_SimmEncrypt = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tab_AsimAlg = new System.Windows.Forms.TabPage();
            this.tab_eds = new System.Windows.Forms.TabPage();
            this.toolTip_hesh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_simm = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Hesh.SuspendLayout();
            this.tab_SimAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Hesh);
            this.tabControl1.Controls.Add(this.tab_SimAlg);
            this.tabControl1.Controls.Add(this.tab_AsimAlg);
            this.tabControl1.Controls.Add(this.tab_eds);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 466);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tab_Hesh
            // 
            this.tab_Hesh.AutoScroll = true;
            this.tab_Hesh.BackColor = System.Drawing.Color.LightGray;
            this.tab_Hesh.Controls.Add(this.txt_hesh_file_in);
            this.tab_Hesh.Controls.Add(this.label3);
            this.tab_Hesh.Controls.Add(this.txt_Hesh_out);
            this.tab_Hesh.Controls.Add(this.txt_byte_in_num);
            this.tab_Hesh.Controls.Add(this.btn_Hesh_save);
            this.tab_Hesh.Controls.Add(this.btn_Hesh_get);
            this.tab_Hesh.Controls.Add(this.btn_copy_Hesh);
            this.tab_Hesh.Controls.Add(this.btn_clear_Hesh_byte_in);
            this.tab_Hesh.Controls.Add(this.checkBox_autoHesh);
            this.tab_Hesh.Controls.Add(this.label2);
            this.tab_Hesh.Controls.Add(this.btn_choice_fileinHesh);
            this.tab_Hesh.Controls.Add(this.comboBox_HeshAlg);
            this.tab_Hesh.Controls.Add(this.label1);
            this.tab_Hesh.Controls.Add(this.label4);
            this.tab_Hesh.Controls.Add(this.label5);
            this.tab_Hesh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_Hesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_Hesh.Location = new System.Drawing.Point(4, 33);
            this.tab_Hesh.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Hesh.Name = "tab_Hesh";
            this.tab_Hesh.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Hesh.Size = new System.Drawing.Size(833, 429);
            this.tab_Hesh.TabIndex = 0;
            this.tab_Hesh.Text = "Хэширование";
            // 
            // txt_hesh_file_in
            // 
            this.txt_hesh_file_in.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_hesh_file_in.Location = new System.Drawing.Point(22, 85);
            this.txt_hesh_file_in.Name = "txt_hesh_file_in";
            this.txt_hesh_file_in.ReadOnly = true;
            this.txt_hesh_file_in.Size = new System.Drawing.Size(588, 29);
            this.txt_hesh_file_in.TabIndex = 99;
            this.txt_hesh_file_in.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 31);
            this.label3.TabIndex = 54;
            this.label3.Text = "Исходное сообщение";
            // 
            // txt_Hesh_out
            // 
            this.txt_Hesh_out.BackColor = System.Drawing.Color.White;
            this.txt_Hesh_out.Location = new System.Drawing.Point(52, 314);
            this.txt_Hesh_out.Name = "txt_Hesh_out";
            this.txt_Hesh_out.Size = new System.Drawing.Size(647, 48);
            this.txt_Hesh_out.TabIndex = 53;
            this.txt_Hesh_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_byte_in_num
            // 
            this.txt_byte_in_num.BackColor = System.Drawing.Color.White;
            this.txt_byte_in_num.Location = new System.Drawing.Point(294, 134);
            this.txt_byte_in_num.Name = "txt_byte_in_num";
            this.txt_byte_in_num.Size = new System.Drawing.Size(170, 30);
            this.txt_byte_in_num.TabIndex = 52;
            this.txt_byte_in_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Hesh_save
            // 
            this.btn_Hesh_save.BackColor = System.Drawing.Color.White;
            this.btn_Hesh_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hesh_save.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Hesh_save.Location = new System.Drawing.Point(581, 369);
            this.btn_Hesh_save.Name = "btn_Hesh_save";
            this.btn_Hesh_save.Size = new System.Drawing.Size(231, 38);
            this.btn_Hesh_save.TabIndex = 50;
            this.btn_Hesh_save.TabStop = false;
            this.btn_Hesh_save.Tag = "";
            this.btn_Hesh_save.Text = "Сохранить хэш в файл";
            this.btn_Hesh_save.UseVisualStyleBackColor = false;
            this.btn_Hesh_save.Click += new System.EventHandler(this.btn_Hesh_save_Click);
            // 
            // btn_Hesh_get
            // 
            this.btn_Hesh_get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hesh_get.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hesh_get.Location = new System.Drawing.Point(298, 235);
            this.btn_Hesh_get.Name = "btn_Hesh_get";
            this.btn_Hesh_get.Size = new System.Drawing.Size(240, 63);
            this.btn_Hesh_get.TabIndex = 49;
            this.btn_Hesh_get.TabStop = false;
            this.btn_Hesh_get.Tag = "";
            this.btn_Hesh_get.Text = "⇓  Хэшировать  ⇓";
            this.btn_Hesh_get.UseVisualStyleBackColor = true;
            this.btn_Hesh_get.Click += new System.EventHandler(this.btn_Hesh_get_Click);
            // 
            // btn_copy_Hesh
            // 
            this.btn_copy_Hesh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_copy_Hesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy_Hesh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_copy_Hesh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_copy_Hesh.Location = new System.Drawing.Point(700, 313);
            this.btn_copy_Hesh.Name = "btn_copy_Hesh";
            this.btn_copy_Hesh.Size = new System.Drawing.Size(112, 50);
            this.btn_copy_Hesh.TabIndex = 47;
            this.btn_copy_Hesh.TabStop = false;
            this.btn_copy_Hesh.Tag = "";
            this.btn_copy_Hesh.Text = "Скопировать в буффер";
            this.btn_copy_Hesh.UseVisualStyleBackColor = false;
            this.btn_copy_Hesh.Click += new System.EventHandler(this.btn_copy_Hesh_Click);
            // 
            // btn_clear_Hesh_byte_in
            // 
            this.btn_clear_Hesh_byte_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_Hesh_byte_in.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear_Hesh_byte_in.Location = new System.Drawing.Point(504, 131);
            this.btn_clear_Hesh_byte_in.Name = "btn_clear_Hesh_byte_in";
            this.btn_clear_Hesh_byte_in.Size = new System.Drawing.Size(106, 35);
            this.btn_clear_Hesh_byte_in.TabIndex = 46;
            this.btn_clear_Hesh_byte_in.TabStop = false;
            this.btn_clear_Hesh_byte_in.Tag = "";
            this.btn_clear_Hesh_byte_in.Text = "Очистить";
            this.btn_clear_Hesh_byte_in.UseVisualStyleBackColor = true;
            this.btn_clear_Hesh_byte_in.Click += new System.EventHandler(this.btn_clear_Hesh_byte_in_Click);
            // 
            // checkBox_autoHesh
            // 
            this.checkBox_autoHesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_autoHesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_autoHesh.Location = new System.Drawing.Point(565, 241);
            this.checkBox_autoHesh.Name = "checkBox_autoHesh";
            this.checkBox_autoHesh.Size = new System.Drawing.Size(256, 57);
            this.checkBox_autoHesh.TabIndex = 45;
            this.checkBox_autoHesh.TabStop = false;
            this.checkBox_autoHesh.Text = "Авто-хэширование после выбора алгоритма";
            this.checkBox_autoHesh.UseVisualStyleBackColor = true;
            this.checkBox_autoHesh.CheckedChanged += new System.EventHandler(this.checkBox_autoHesh_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Количество считанных байт:";
            // 
            // btn_choice_fileinHesh
            // 
            this.btn_choice_fileinHesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choice_fileinHesh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choice_fileinHesh.Location = new System.Drawing.Point(616, 83);
            this.btn_choice_fileinHesh.Name = "btn_choice_fileinHesh";
            this.btn_choice_fileinHesh.Size = new System.Drawing.Size(205, 33);
            this.btn_choice_fileinHesh.TabIndex = 41;
            this.btn_choice_fileinHesh.TabStop = false;
            this.btn_choice_fileinHesh.Tag = "";
            this.btn_choice_fileinHesh.Text = "Прочитать из файла";
            this.btn_choice_fileinHesh.UseVisualStyleBackColor = true;
            this.btn_choice_fileinHesh.Click += new System.EventHandler(this.btn_choice_fileinHesh_Click);
            // 
            // comboBox_HeshAlg
            // 
            this.comboBox_HeshAlg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_HeshAlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_HeshAlg.DisplayMember = "0";
            this.comboBox_HeshAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HeshAlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_HeshAlg.FormattingEnabled = true;
            this.comboBox_HeshAlg.Items.AddRange(new object[] {
            "MD5",
            "RIPEMD160",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBox_HeshAlg.Location = new System.Drawing.Point(56, 266);
            this.comboBox_HeshAlg.MaxDropDownItems = 10;
            this.comboBox_HeshAlg.Name = "comboBox_HeshAlg";
            this.comboBox_HeshAlg.Size = new System.Drawing.Size(211, 32);
            this.comboBox_HeshAlg.TabIndex = 0;
            this.comboBox_HeshAlg.TabStop = false;
            this.comboBox_HeshAlg.SelectedIndexChanged += new System.EventHandler(this.comboBox_HeshAlg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Алгоритм хэширования:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(815, 200);
            this.label4.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(815, 210);
            this.label5.TabIndex = 56;
            // 
            // tab_SimAlg
            // 
            this.tab_SimAlg.AutoScroll = true;
            this.tab_SimAlg.BackColor = System.Drawing.Color.LightGray;
            this.tab_SimAlg.Controls.Add(this.label13);
            this.tab_SimAlg.Controls.Add(this.label8);
            this.tab_SimAlg.Controls.Add(this.txt_simm_file_in);
            this.tab_SimAlg.Controls.Add(this.comboBox_SimmAlg);
            this.tab_SimAlg.Controls.Add(this.radioBtn_SimmAlg2);
            this.tab_SimAlg.Controls.Add(this.radioBtn_SimmAlg1);
            this.tab_SimAlg.Controls.Add(this.label11);
            this.tab_SimAlg.Controls.Add(this.button3);
            this.tab_SimAlg.Controls.Add(this.btn_SimmEncrypt);
            this.tab_SimAlg.Controls.Add(this.button5);
            this.tab_SimAlg.Controls.Add(this.checkBox1);
            this.tab_SimAlg.Controls.Add(this.label6);
            this.tab_SimAlg.Controls.Add(this.label7);
            this.tab_SimAlg.Controls.Add(this.button1);
            this.tab_SimAlg.Controls.Add(this.label9);
            this.tab_SimAlg.Controls.Add(this.button2);
            this.tab_SimAlg.Controls.Add(this.label10);
            this.tab_SimAlg.Controls.Add(this.label12);
            this.tab_SimAlg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_SimAlg.Location = new System.Drawing.Point(4, 33);
            this.tab_SimAlg.Margin = new System.Windows.Forms.Padding(4);
            this.tab_SimAlg.Name = "tab_SimAlg";
            this.tab_SimAlg.Padding = new System.Windows.Forms.Padding(4);
            this.tab_SimAlg.Size = new System.Drawing.Size(833, 429);
            this.tab_SimAlg.TabIndex = 1;
            this.tab_SimAlg.Text = "Симметричные алгоритмы";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(-4, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(841, 2);
            this.label8.TabIndex = 73;
            // 
            // txt_simm_file_in
            // 
            this.txt_simm_file_in.Location = new System.Drawing.Point(44, 107);
            this.txt_simm_file_in.Name = "txt_simm_file_in";
            this.txt_simm_file_in.ReadOnly = true;
            this.txt_simm_file_in.Size = new System.Drawing.Size(100, 29);
            this.txt_simm_file_in.TabIndex = 72;
            // 
            // comboBox_SimmAlg
            // 
            this.comboBox_SimmAlg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_SimmAlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_SimmAlg.DisplayMember = "0";
            this.comboBox_SimmAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SimmAlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SimmAlg.FormattingEnabled = true;
            this.comboBox_SimmAlg.Items.AddRange(new object[] {
            "AES",
            "3DES"});
            this.comboBox_SimmAlg.Location = new System.Drawing.Point(117, 13);
            this.comboBox_SimmAlg.MaxDropDownItems = 10;
            this.comboBox_SimmAlg.Name = "comboBox_SimmAlg";
            this.comboBox_SimmAlg.Size = new System.Drawing.Size(211, 32);
            this.comboBox_SimmAlg.TabIndex = 63;
            this.comboBox_SimmAlg.TabStop = false;
            // 
            // radioBtn_SimmAlg2
            // 
            this.radioBtn_SimmAlg2.AutoSize = true;
            this.radioBtn_SimmAlg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_SimmAlg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_SimmAlg2.Location = new System.Drawing.Point(640, 13);
            this.radioBtn_SimmAlg2.Name = "radioBtn_SimmAlg2";
            this.radioBtn_SimmAlg2.Size = new System.Drawing.Size(182, 29);
            this.radioBtn_SimmAlg2.TabIndex = 71;
            this.radioBtn_SimmAlg2.Text = "Расшифровка";
            this.radioBtn_SimmAlg2.UseVisualStyleBackColor = true;
            this.radioBtn_SimmAlg2.CheckedChanged += new System.EventHandler(this.radioBtn_SimmAlg2_CheckedChanged);
            // 
            // radioBtn_SimmAlg1
            // 
            this.radioBtn_SimmAlg1.AutoSize = true;
            this.radioBtn_SimmAlg1.Checked = true;
            this.radioBtn_SimmAlg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_SimmAlg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_SimmAlg1.Location = new System.Drawing.Point(464, 13);
            this.radioBtn_SimmAlg1.Name = "radioBtn_SimmAlg1";
            this.radioBtn_SimmAlg1.Size = new System.Drawing.Size(170, 29);
            this.radioBtn_SimmAlg1.TabIndex = 70;
            this.radioBtn_SimmAlg1.TabStop = true;
            this.radioBtn_SimmAlg1.Text = "Шифрование";
            this.radioBtn_SimmAlg1.UseVisualStyleBackColor = true;
            this.radioBtn_SimmAlg1.CheckedChanged += new System.EventHandler(this.radioBtn_SimmAlg1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(52, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(647, 48);
            this.label11.TabIndex = 69;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(581, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 38);
            this.button3.TabIndex = 68;
            this.button3.TabStop = false;
            this.button3.Tag = "";
            this.button3.Text = "Сохранить хэш в файл";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_SimmEncrypt
            // 
            this.btn_SimmEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SimmEncrypt.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SimmEncrypt.Location = new System.Drawing.Point(298, 239);
            this.btn_SimmEncrypt.Name = "btn_SimmEncrypt";
            this.btn_SimmEncrypt.Size = new System.Drawing.Size(240, 63);
            this.btn_SimmEncrypt.TabIndex = 67;
            this.btn_SimmEncrypt.TabStop = false;
            this.btn_SimmEncrypt.Tag = "";
            this.btn_SimmEncrypt.Text = "⇓  Шифровать  ⇓";
            this.btn_SimmEncrypt.UseVisualStyleBackColor = true;
            this.btn_SimmEncrypt.Click += new System.EventHandler(this.btn_SimmEncrypt_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(700, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 50);
            this.button5.TabIndex = 66;
            this.button5.TabStop = false;
            this.button5.Tag = "";
            this.button5.Text = "Скопировать в буффер";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(565, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(256, 57);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Авто-шифрование после выбора алгоритма";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 24);
            this.label12.TabIndex = 64;
            this.label12.Text = "Алгоритм:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Входные данные";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 30);
            this.label7.TabIndex = 60;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(505, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 58;
            this.button1.TabStop = false;
            this.button1.Tag = "";
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "Количество считанных байт:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(617, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 33);
            this.button2.TabIndex = 56;
            this.button2.TabStop = false;
            this.button2.Tag = "";
            this.button2.Text = "Прочитать из файла";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tab_AsimAlg
            // 
            this.tab_AsimAlg.AutoScroll = true;
            this.tab_AsimAlg.BackColor = System.Drawing.Color.LightGray;
            this.tab_AsimAlg.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_AsimAlg.Location = new System.Drawing.Point(4, 33);
            this.tab_AsimAlg.Margin = new System.Windows.Forms.Padding(4);
            this.tab_AsimAlg.Name = "tab_AsimAlg";
            this.tab_AsimAlg.Padding = new System.Windows.Forms.Padding(4);
            this.tab_AsimAlg.Size = new System.Drawing.Size(833, 429);
            this.tab_AsimAlg.TabIndex = 2;
            this.tab_AsimAlg.Text = "Асимметричные алгоритмы (RSA)";
            // 
            // tab_eds
            // 
            this.tab_eds.AutoScroll = true;
            this.tab_eds.BackColor = System.Drawing.Color.LightGray;
            this.tab_eds.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_eds.Location = new System.Drawing.Point(4, 33);
            this.tab_eds.Margin = new System.Windows.Forms.Padding(4);
            this.tab_eds.Name = "tab_eds";
            this.tab_eds.Padding = new System.Windows.Forms.Padding(4);
            this.tab_eds.Size = new System.Drawing.Size(833, 429);
            this.tab_eds.TabIndex = 3;
            this.tab_eds.Text = "ЭЦП (DSA)";
            // 
            // toolTip_hesh
            // 
            this.toolTip_hesh.ShowAlways = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 74;
            this.label10.Text = "Режим:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(560, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 25);
            this.label13.TabIndex = 75;
            this.label13.Text = "Обработанные данные";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(841, 466);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Hesh.ResumeLayout(false);
            this.tab_Hesh.PerformLayout();
            this.tab_SimAlg.ResumeLayout(false);
            this.tab_SimAlg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Hesh;
        private System.Windows.Forms.TabPage tab_SimAlg;
        private System.Windows.Forms.TabPage tab_AsimAlg;
        private System.Windows.Forms.TabPage tab_eds;
        private System.Windows.Forms.ComboBox comboBox_HeshAlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_choice_fileinHesh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_autoHesh;
        private System.Windows.Forms.Button btn_clear_Hesh_byte_in;
        private System.Windows.Forms.Button btn_copy_Hesh;
        private System.Windows.Forms.Button btn_Hesh_get;
        private System.Windows.Forms.Button btn_Hesh_save;
        private System.Windows.Forms.Label txt_Hesh_out;
        private System.Windows.Forms.Label txt_byte_in_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_SimmEncrypt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_SimmAlg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip_hesh;
        private System.Windows.Forms.RadioButton radioBtn_SimmAlg1;
        private System.Windows.Forms.RadioButton radioBtn_SimmAlg2;
        private System.Windows.Forms.TextBox txt_hesh_file_in;
        private System.Windows.Forms.TextBox txt_simm_file_in;
        private System.Windows.Forms.ToolTip toolTip_simm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}

