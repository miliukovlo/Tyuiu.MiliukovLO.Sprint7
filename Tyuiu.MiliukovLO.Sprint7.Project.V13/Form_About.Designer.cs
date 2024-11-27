namespace Tyuiu.MiliukovLO.Sprint7.Project.V13
{
    partial class Form_About
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
            panelAbout_MLO = new Panel();
            textBoxAbout = new TextBox();
            buttonAbout_Close_MLO = new Button();
            panelAbout_MLO.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbout_MLO
            // 
            panelAbout_MLO.BackColor = SystemColors.ActiveBorder;
            panelAbout_MLO.Controls.Add(buttonAbout_Close_MLO);
            panelAbout_MLO.Controls.Add(textBoxAbout);
            panelAbout_MLO.Dock = DockStyle.Fill;
            panelAbout_MLO.Location = new Point(0, 0);
            panelAbout_MLO.Name = "panelAbout_MLO";
            panelAbout_MLO.Size = new Size(433, 116);
            panelAbout_MLO.TabIndex = 0;
            // 
            // textBoxAbout
            // 
            textBoxAbout.BackColor = SystemColors.ActiveBorder;
            textBoxAbout.BorderStyle = BorderStyle.None;
            textBoxAbout.Dock = DockStyle.Fill;
            textBoxAbout.Enabled = false;
            textBoxAbout.Location = new Point(0, 0);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(433, 116);
            textBoxAbout.TabIndex = 2;
            textBoxAbout.Text = "Выполнил: Милюков Леонид Олегович,\r\n Группа: ИИПб-24-2,\r\n Спрнт: 7 Финальный проект Вариант 13,\r\n Институт: ВШЦТ,  \r\nГод: 2024";
            textBoxAbout.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAbout_Close_MLO
            // 
            buttonAbout_Close_MLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAbout_Close_MLO.Location = new Point(346, 81);
            buttonAbout_Close_MLO.Name = "buttonAbout_Close_MLO";
            buttonAbout_Close_MLO.Size = new Size(75, 23);
            buttonAbout_Close_MLO.TabIndex = 1;
            buttonAbout_Close_MLO.Text = "Закрыть";
            buttonAbout_Close_MLO.UseVisualStyleBackColor = true;
            buttonAbout_Close_MLO.Click += buttonAbout_Close_MLO_Click;
            // 
            // Form_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 116);
            Controls.Add(panelAbout_MLO);
            MinimumSize = new Size(449, 155);
            Name = "Form_About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            TopMost = true;
            panelAbout_MLO.ResumeLayout(false);
            panelAbout_MLO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbout_MLO;
        private Button buttonAbout_Close_MLO;
        private TextBox textBoxAbout;
    }
}