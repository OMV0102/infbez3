namespace infbez3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_simm_entryKeyIV = new System.Windows.Forms.Label();
            this.btn_confirm_entry = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_iv = new System.Windows.Forms.TextBox();
            this.checkBox_keyShow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_simm_entryKeyIV
            // 
            this.label_simm_entryKeyIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_simm_entryKeyIV.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_simm_entryKeyIV.Location = new System.Drawing.Point(141, 9);
            this.label_simm_entryKeyIV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_simm_entryKeyIV.Name = "label_simm_entryKeyIV";
            this.label_simm_entryKeyIV.Size = new System.Drawing.Size(422, 49);
            this.label_simm_entryKeyIV.TabIndex = 79;
            this.label_simm_entryKeyIV.Text = "При шифровании вектор инициализации IV целесообразно генерировать случайно в целя" +
    "х безопасности";
            // 
            // btn_confirm_entry
            // 
            this.btn_confirm_entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm_entry.Location = new System.Drawing.Point(266, 199);
            this.btn_confirm_entry.Margin = new System.Windows.Forms.Padding(6);
            this.btn_confirm_entry.Name = "btn_confirm_entry";
            this.btn_confirm_entry.Size = new System.Drawing.Size(181, 42);
            this.btn_confirm_entry.TabIndex = 80;
            this.btn_confirm_entry.Text = "Подтвердить";
            this.btn_confirm_entry.UseVisualStyleBackColor = true;
            this.btn_confirm_entry.Click += new System.EventHandler(this.btn_confirm_entry_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(124, 75);
            this.txt_key.MaxLength = 32;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(333, 29);
            this.txt_key.TabIndex = 81;
            this.txt_key.Text = "12345678901234567890123456789000";
            // 
            // txt_iv
            // 
            this.txt_iv.Location = new System.Drawing.Point(52, 154);
            this.txt_iv.MaxLength = 16;
            this.txt_iv.Name = "txt_iv";
            this.txt_iv.Size = new System.Drawing.Size(170, 29);
            this.txt_iv.TabIndex = 82;
            this.txt_iv.Text = "1234567890123456";
            // 
            // checkBox_keyShow
            // 
            this.checkBox_keyShow.AutoSize = true;
            this.checkBox_keyShow.Checked = true;
            this.checkBox_keyShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_keyShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_keyShow.Location = new System.Drawing.Point(405, 75);
            this.checkBox_keyShow.Name = "checkBox_keyShow";
            this.checkBox_keyShow.Size = new System.Drawing.Size(136, 28);
            this.checkBox_keyShow.TabIndex = 83;
            this.checkBox_keyShow.Text = "Ключ виден";
            this.checkBox_keyShow.UseVisualStyleBackColor = true;
            this.checkBox_keyShow.CheckedChanged += new System.EventHandler(this.checkBox_keyShow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ключ:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_keyShow);
            this.Controls.Add(this.txt_iv);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.btn_confirm_entry);
            this.Controls.Add(this.label_simm_entryKeyIV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ШИФРОВАНИЕ: Ввод ключа (Key) и вектора инициализации (IV)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_simm_entryKeyIV;
        private System.Windows.Forms.Button btn_confirm_entry;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_iv;
        private System.Windows.Forms.CheckBox checkBox_keyShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}