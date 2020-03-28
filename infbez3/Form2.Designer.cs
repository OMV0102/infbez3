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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_simm_entryKeyIV
            // 
            this.label_simm_entryKeyIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_simm_entryKeyIV.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_simm_entryKeyIV.Location = new System.Drawing.Point(141, 9);
            this.label_simm_entryKeyIV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_simm_entryKeyIV.Name = "label_simm_entryKeyIV";
            this.label_simm_entryKeyIV.Size = new System.Drawing.Size(421, 49);
            this.label_simm_entryKeyIV.TabIndex = 79;
            this.label_simm_entryKeyIV.Text = "При шифровании ключ и IV генерируются случайно в целях безопасности (ввод вручную" +
    " недоступен)";
            // 
            // btn_confirm_entry
            // 
            this.btn_confirm_entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm_entry.Location = new System.Drawing.Point(210, 181);
            this.btn_confirm_entry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_confirm_entry.Name = "btn_confirm_entry";
            this.btn_confirm_entry.Size = new System.Drawing.Size(181, 42);
            this.btn_confirm_entry.TabIndex = 80;
            this.btn_confirm_entry.Text = "Подтвердить";
            this.btn_confirm_entry.UseVisualStyleBackColor = true;
            this.btn_confirm_entry.Click += new System.EventHandler(this.btn_confirm_entry_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 29);
            this.textBox1.TabIndex = 81;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 271);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_confirm_entry);
            this.Controls.Add(this.label_simm_entryKeyIV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод ключа (Key) и вектора инициализации (IV)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_simm_entryKeyIV;
        private System.Windows.Forms.Button btn_confirm_entry;
        private System.Windows.Forms.TextBox textBox1;
    }
}