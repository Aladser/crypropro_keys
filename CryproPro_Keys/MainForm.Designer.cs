namespace CryproPro_Keys
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.version_Label = new System.Windows.Forms.Label();
            this.key_Label = new System.Windows.Forms.Label();
            this.version_Field = new System.Windows.Forms.Label();
            this.key_Field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // version_Label
            // 
            this.version_Label.BackColor = System.Drawing.SystemColors.Control;
            this.version_Label.Location = new System.Drawing.Point(12, 9);
            this.version_Label.Name = "version_Label";
            this.version_Label.Size = new System.Drawing.Size(61, 23);
            this.version_Label.TabIndex = 0;
            this.version_Label.Text = "Версия:";
            this.version_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // key_Label
            // 
            this.key_Label.BackColor = System.Drawing.SystemColors.Control;
            this.key_Label.Location = new System.Drawing.Point(12, 47);
            this.key_Label.Name = "key_Label";
            this.key_Label.Size = new System.Drawing.Size(61, 23);
            this.key_Label.TabIndex = 1;
            this.key_Label.Text = "Ключ:";
            this.key_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version_Field
            // 
            this.version_Field.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.version_Field.Location = new System.Drawing.Point(79, 9);
            this.version_Field.Name = "version_Field";
            this.version_Field.Size = new System.Drawing.Size(230, 23);
            this.version_Field.TabIndex = 2;
            this.version_Field.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key_Field
            // 
            this.key_Field.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.key_Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key_Field.Location = new System.Drawing.Point(82, 50);
            this.key_Field.Multiline = true;
            this.key_Field.Name = "key_Field";
            this.key_Field.ReadOnly = true;
            this.key_Field.Size = new System.Drawing.Size(227, 20);
            this.key_Field.TabIndex = 4;
            this.key_Field.TabStop = false;
            this.key_Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 92);
            this.Controls.Add(this.key_Field);
            this.Controls.Add(this.version_Field);
            this.Controls.Add(this.key_Label);
            this.Controls.Add(this.version_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Ключ КриптоПро";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version_Label;
        private System.Windows.Forms.Label key_Label;
        private System.Windows.Forms.Label version_Field;
        private System.Windows.Forms.TextBox key_Field;
    }
}

