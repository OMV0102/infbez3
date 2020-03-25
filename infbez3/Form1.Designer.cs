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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Hesh = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Hesh_out = new System.Windows.Forms.Label();
            this.txt_byte_in_num = new System.Windows.Forms.Label();
            this.txt_hesh_file_in = new System.Windows.Forms.Label();
            this.btn_Hesh_save = new System.Windows.Forms.Button();
            this.btn_Hesh_get = new System.Windows.Forms.Button();
            this.btn_copy_Hesh = new System.Windows.Forms.Button();
            this.btn_clear_Hesh_byte_in = new System.Windows.Forms.Button();
            this.checkBox_autoHesh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_choice_filein = new System.Windows.Forms.Button();
            this.comboBox_HeshAlg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_SimAlg = new System.Windows.Forms.TabPage();
            this.tab_AsimAlg = new System.Windows.Forms.TabPage();
            this.tab_eds = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_Hesh.SuspendLayout();
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
            this.tab_Hesh.Controls.Add(this.label3);
            this.tab_Hesh.Controls.Add(this.txt_Hesh_out);
            this.tab_Hesh.Controls.Add(this.txt_byte_in_num);
            this.tab_Hesh.Controls.Add(this.txt_hesh_file_in);
            this.tab_Hesh.Controls.Add(this.btn_Hesh_save);
            this.tab_Hesh.Controls.Add(this.btn_Hesh_get);
            this.tab_Hesh.Controls.Add(this.btn_copy_Hesh);
            this.tab_Hesh.Controls.Add(this.btn_clear_Hesh_byte_in);
            this.tab_Hesh.Controls.Add(this.checkBox_autoHesh);
            this.tab_Hesh.Controls.Add(this.label2);
            this.tab_Hesh.Controls.Add(this.btn_choice_filein);
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
            // txt_hesh_file_in
            // 
            this.txt_hesh_file_in.BackColor = System.Drawing.Color.White;
            this.txt_hesh_file_in.Location = new System.Drawing.Point(18, 83);
            this.txt_hesh_file_in.Name = "txt_hesh_file_in";
            this.txt_hesh_file_in.Size = new System.Drawing.Size(592, 30);
            this.txt_hesh_file_in.TabIndex = 51;
            this.txt_hesh_file_in.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btn_choice_filein
            // 
            this.btn_choice_filein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choice_filein.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choice_filein.Location = new System.Drawing.Point(616, 83);
            this.btn_choice_filein.Name = "btn_choice_filein";
            this.btn_choice_filein.Size = new System.Drawing.Size(205, 33);
            this.btn_choice_filein.TabIndex = 41;
            this.btn_choice_filein.TabStop = false;
            this.btn_choice_filein.Tag = "";
            this.btn_choice_filein.Text = "Прочитать из файла";
            this.btn_choice_filein.UseVisualStyleBackColor = true;
            this.btn_choice_filein.Click += new System.EventHandler(this.btn_choice_filein_Click);
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
            this.tab_SimAlg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_SimAlg.Location = new System.Drawing.Point(4, 33);
            this.tab_SimAlg.Margin = new System.Windows.Forms.Padding(4);
            this.tab_SimAlg.Name = "tab_SimAlg";
            this.tab_SimAlg.Padding = new System.Windows.Forms.Padding(4);
            this.tab_SimAlg.Size = new System.Drawing.Size(840, 429);
            this.tab_SimAlg.TabIndex = 1;
            this.tab_SimAlg.Text = "Симметричные алгоритмы";
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
            this.tab_eds.Text = "ЭЦП";
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
        private System.Windows.Forms.Button btn_choice_filein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_autoHesh;
        private System.Windows.Forms.Button btn_clear_Hesh_byte_in;
        private System.Windows.Forms.Button btn_copy_Hesh;
        private System.Windows.Forms.Button btn_Hesh_get;
        private System.Windows.Forms.Button btn_Hesh_save;
        private System.Windows.Forms.Label txt_hesh_file_in;
        private System.Windows.Forms.Label txt_Hesh_out;
        private System.Windows.Forms.Label txt_byte_in_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

