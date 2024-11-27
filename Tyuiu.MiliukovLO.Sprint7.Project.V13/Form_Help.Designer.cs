namespace Tyuiu.MiliukovLO.Sprint7.Project.V13
{
    partial class Form_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Help));
            panelHelp = new Panel();
            buttonHelo_Close = new Button();
            textBoxHelp = new TextBox();
            panelHelp.SuspendLayout();
            SuspendLayout();
            // 
            // panelHelp
            // 
            panelHelp.BackColor = SystemColors.ActiveBorder;
            panelHelp.Controls.Add(buttonHelo_Close);
            panelHelp.Controls.Add(textBoxHelp);
            panelHelp.Dock = DockStyle.Fill;
            panelHelp.Location = new Point(0, 0);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(519, 365);
            panelHelp.TabIndex = 0;
            // 
            // buttonHelo_Close
            // 
            buttonHelo_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonHelo_Close.Location = new Point(419, 320);
            buttonHelo_Close.Name = "buttonHelo_Close";
            buttonHelo_Close.Size = new Size(75, 23);
            buttonHelo_Close.TabIndex = 2;
            buttonHelo_Close.Text = "Закрыть";
            buttonHelo_Close.UseVisualStyleBackColor = true;
            buttonHelo_Close.Click += buttonHelo_Close_Click;
            // 
            // textBoxHelp
            // 
            textBoxHelp.BackColor = SystemColors.ActiveBorder;
            textBoxHelp.BorderStyle = BorderStyle.None;
            textBoxHelp.Dock = DockStyle.Fill;
            textBoxHelp.Enabled = false;
            textBoxHelp.Location = new Point(0, 0);
            textBoxHelp.MinimumSize = new Size(519, 365);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.ReadOnly = true;
            textBoxHelp.Size = new Size(519, 365);
            textBoxHelp.TabIndex = 1;
            textBoxHelp.Text = resources.GetString("textBoxHelp.Text");
            textBoxHelp.TextAlign = HorizontalAlignment.Center;
            // 
            // Form_Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 365);
            Controls.Add(panelHelp);
            Name = "Form_Help";
            Text = "Помощь";
            TopMost = true;
            panelHelp.ResumeLayout(false);
            panelHelp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHelp;
        private TextBox textBoxHelp;
        private Button buttonHelo_Close;
    }
}