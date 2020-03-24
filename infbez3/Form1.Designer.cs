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
            this.tab_SimAlg = new System.Windows.Forms.TabPage();
            this.tab_AsimAlg = new System.Windows.Forms.TabPage();
            this.tab_eds = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Hesh);
            this.tabControl1.Controls.Add(this.tab_SimAlg);
            this.tabControl1.Controls.Add(this.tab_AsimAlg);
            this.tabControl1.Controls.Add(this.tab_eds);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 553);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tab_Hesh
            // 
            this.tab_Hesh.AutoScroll = true;
            this.tab_Hesh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_Hesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_Hesh.Location = new System.Drawing.Point(4, 33);
            this.tab_Hesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Hesh.Name = "tab_Hesh";
            this.tab_Hesh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Hesh.Size = new System.Drawing.Size(840, 516);
            this.tab_Hesh.TabIndex = 0;
            this.tab_Hesh.Text = "Хэширование";
            this.tab_Hesh.UseVisualStyleBackColor = true;
            // 
            // tab_SimAlg
            // 
            this.tab_SimAlg.AutoScroll = true;
            this.tab_SimAlg.Location = new System.Drawing.Point(4, 33);
            this.tab_SimAlg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_SimAlg.Name = "tab_SimAlg";
            this.tab_SimAlg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_SimAlg.Size = new System.Drawing.Size(838, 517);
            this.tab_SimAlg.TabIndex = 1;
            this.tab_SimAlg.Text = "Симметричные алгоритмы";
            this.tab_SimAlg.UseVisualStyleBackColor = true;
            // 
            // tab_AsimAlg
            // 
            this.tab_AsimAlg.AutoScroll = true;
            this.tab_AsimAlg.Location = new System.Drawing.Point(4, 33);
            this.tab_AsimAlg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_AsimAlg.Name = "tab_AsimAlg";
            this.tab_AsimAlg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_AsimAlg.Size = new System.Drawing.Size(840, 516);
            this.tab_AsimAlg.TabIndex = 2;
            this.tab_AsimAlg.Text = "Асимметричные алгоритмы";
            this.tab_AsimAlg.UseVisualStyleBackColor = true;
            // 
            // tab_eds
            // 
            this.tab_eds.AutoScroll = true;
            this.tab_eds.Location = new System.Drawing.Point(4, 33);
            this.tab_eds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_eds.Name = "tab_eds";
            this.tab_eds.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_eds.Size = new System.Drawing.Size(838, 517);
            this.tab_eds.TabIndex = 3;
            this.tab_eds.Text = "ЭЦП";
            this.tab_eds.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 553);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Hesh;
        private System.Windows.Forms.TabPage tab_SimAlg;
        private System.Windows.Forms.TabPage tab_AsimAlg;
        private System.Windows.Forms.TabPage tab_eds;
    }
}

