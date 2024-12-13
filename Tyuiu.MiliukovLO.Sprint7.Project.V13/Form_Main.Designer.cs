namespace Tyuiu.MiliukovLO.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelHeader_MLO = new Panel();
            groupBoxHeaderHelp_MLO = new GroupBox();
            buttonAbout_MLO = new Button();
            buttonHelp_MLO = new Button();
            buttonSave_MLO = new Button();
            toolTip_MLO = new ToolTip(components);
            chartOfPopulation_MLO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            countryBindingSource = new BindingSource(components);
            panel1 = new Panel();
            chartCountryArea_MLO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Sort = new Button();
            groupBoxSearch_MLO = new GroupBox();
            textBoxName = new TextBox();
            countryBindingSource1 = new BindingSource(components);
            panelData = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridViewInput = new DataGridView();
            countryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capitalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            developedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewOutput = new DataGridView();
            countryNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            capitalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            areaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            developedDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            populationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBoxOutput = new GroupBox();
            groupBoxInput = new GroupBox();
            colorDialog1 = new ColorDialog();
            saveFileDialog_MLO = new SaveFileDialog();
            panelHeader_MLO.SuspendLayout();
            groupBoxHeaderHelp_MLO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOfPopulation_MLO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCountryArea_MLO).BeginInit();
            groupBoxSearch_MLO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource1).BeginInit();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // panelHeader_MLO
            // 
            panelHeader_MLO.BackColor = SystemColors.ControlLight;
            panelHeader_MLO.Controls.Add(groupBoxHeaderHelp_MLO);
            panelHeader_MLO.Controls.Add(buttonSave_MLO);
            panelHeader_MLO.Dock = DockStyle.Top;
            panelHeader_MLO.Location = new Point(0, 0);
            panelHeader_MLO.Name = "panelHeader_MLO";
            panelHeader_MLO.Size = new Size(1619, 73);
            panelHeader_MLO.TabIndex = 0;
            // 
            // groupBoxHeaderHelp_MLO
            // 
            groupBoxHeaderHelp_MLO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxHeaderHelp_MLO.BackColor = SystemColors.ScrollBar;
            groupBoxHeaderHelp_MLO.Controls.Add(buttonAbout_MLO);
            groupBoxHeaderHelp_MLO.Controls.Add(buttonHelp_MLO);
            groupBoxHeaderHelp_MLO.Location = new Point(1328, 12);
            groupBoxHeaderHelp_MLO.Name = "groupBoxHeaderHelp_MLO";
            groupBoxHeaderHelp_MLO.Size = new Size(279, 47);
            groupBoxHeaderHelp_MLO.TabIndex = 1;
            groupBoxHeaderHelp_MLO.TabStop = false;
            // 
            // buttonAbout_MLO
            // 
            buttonAbout_MLO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAbout_MLO.Location = new Point(6, 13);
            buttonAbout_MLO.Name = "buttonAbout_MLO";
            buttonAbout_MLO.Size = new Size(114, 23);
            buttonAbout_MLO.TabIndex = 1;
            buttonAbout_MLO.Text = "О программе";
            toolTip_MLO.SetToolTip(buttonAbout_MLO, "Нажмите, чтобы получить информацию о программе.");
            buttonAbout_MLO.UseVisualStyleBackColor = true;
            buttonAbout_MLO.Click += buttonAbout_MLO_Click;
            // 
            // buttonHelp_MLO
            // 
            buttonHelp_MLO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MLO.Location = new Point(198, 13);
            buttonHelp_MLO.Name = "buttonHelp_MLO";
            buttonHelp_MLO.Size = new Size(75, 23);
            buttonHelp_MLO.TabIndex = 0;
            buttonHelp_MLO.Text = "Помощь";
            toolTip_MLO.SetToolTip(buttonHelp_MLO, "Нажмите, для получения справки о том, как работать с данной программой.");
            buttonHelp_MLO.UseVisualStyleBackColor = true;
            buttonHelp_MLO.Click += buttonHelp_MLO_Click;
            // 
            // buttonSave_MLO
            // 
            buttonSave_MLO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_MLO.Location = new Point(1197, 25);
            buttonSave_MLO.Name = "buttonSave_MLO";
            buttonSave_MLO.Size = new Size(75, 23);
            buttonSave_MLO.TabIndex = 2;
            buttonSave_MLO.Text = "Сохранить";
            toolTip_MLO.SetToolTip(buttonSave_MLO, "Нажмите, чтобы сохранить результат выполнения программы!\r\n");
            buttonSave_MLO.UseVisualStyleBackColor = true;
            buttonSave_MLO.Click += buttonSave_MLO_Click;
            // 
            // chartOfPopulation_MLO
            // 
            chartOfPopulation_MLO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            chartOfPopulation_MLO.ChartAreas.Add(chartArea1);
            chartOfPopulation_MLO.DataSource = countryBindingSource;
            legend1.Name = "Legend1";
            chartOfPopulation_MLO.Legends.Add(legend1);
            chartOfPopulation_MLO.Location = new Point(492, 0);
            chartOfPopulation_MLO.Name = "chartOfPopulation_MLO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOfPopulation_MLO.Series.Add(series1);
            chartOfPopulation_MLO.Size = new Size(489, 216);
            chartOfPopulation_MLO.TabIndex = 2;
            chartOfPopulation_MLO.Text = "Популяция";
            title1.Name = "Title1";
            title1.Text = "Популяция стран";
            chartOfPopulation_MLO.Titles.Add(title1);
            toolTip_MLO.SetToolTip(chartOfPopulation_MLO, "Диаграмма популяции стран.\r\n");
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Lib.Country);
            // 
            // panel1
            // 
            panel1.Controls.Add(chartCountryArea_MLO);
            panel1.Controls.Add(chartOfPopulation_MLO);
            panel1.Controls.Add(Sort);
            panel1.Controls.Add(groupBoxSearch_MLO);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1619, 235);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // chartCountryArea_MLO
            // 
            chartCountryArea_MLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            chartCountryArea_MLO.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartCountryArea_MLO.Legends.Add(legend2);
            chartCountryArea_MLO.Location = new Point(1072, 0);
            chartCountryArea_MLO.Name = "chartCountryArea_MLO";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartCountryArea_MLO.Series.Add(series2);
            chartCountryArea_MLO.Size = new Size(472, 216);
            chartCountryArea_MLO.TabIndex = 3;
            chartCountryArea_MLO.Text = "chartCountryArea_MLO";
            title2.Name = "Title1";
            title2.Text = "Площадь стран";
            chartCountryArea_MLO.Titles.Add(title2);
            // 
            // Sort
            // 
            Sort.Location = new Point(386, 28);
            Sort.Name = "Sort";
            Sort.Size = new Size(75, 23);
            Sort.TabIndex = 1;
            Sort.Text = "Найти";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += Sort_Click;
            // 
            // groupBoxSearch_MLO
            // 
            groupBoxSearch_MLO.BackColor = SystemColors.ScrollBar;
            groupBoxSearch_MLO.Controls.Add(textBoxName);
            groupBoxSearch_MLO.Location = new Point(3, 6);
            groupBoxSearch_MLO.Name = "groupBoxSearch_MLO";
            groupBoxSearch_MLO.Size = new Size(292, 65);
            groupBoxSearch_MLO.TabIndex = 0;
            groupBoxSearch_MLO.TabStop = false;
            groupBoxSearch_MLO.Text = "Поиск";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(9, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название страны";
            textBoxName.Size = new Size(261, 23);
            textBoxName.TabIndex = 0;
            // 
            // countryBindingSource1
            // 
            countryBindingSource1.DataSource = typeof(Lib.Country);
            // 
            // panelData
            // 
            panelData.BackColor = SystemColors.ScrollBar;
            panelData.Controls.Add(splitContainer1);
            panelData.Controls.Add(groupBoxOutput);
            panelData.Controls.Add(groupBoxInput);
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(0, 308);
            panelData.Name = "panelData";
            panelData.Size = new Size(1619, 565);
            panelData.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewInput);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewOutput);
            splitContainer1.Size = new Size(1619, 565);
            splitContainer1.SplitterDistance = 816;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.AutoGenerateColumns = false;
            dataGridViewInput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInput.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Columns.AddRange(new DataGridViewColumn[] { countryNameDataGridViewTextBoxColumn, capitalDataGridViewTextBoxColumn, areaDataGridViewTextBoxColumn, developedDataGridViewCheckBoxColumn, populationDataGridViewTextBoxColumn, nationDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn });
            dataGridViewInput.DataSource = countryBindingSource;
            dataGridViewInput.Dock = DockStyle.Fill;
            dataGridViewInput.Location = new Point(0, 0);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.Size = new Size(816, 565);
            dataGridViewInput.TabIndex = 0;
            dataGridViewInput.CellContentClick += dataGridViewInput_CellContentClick;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            countryNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            capitalDataGridViewTextBoxColumn.Width = 69;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            areaDataGridViewTextBoxColumn.HeaderText = "Area";
            areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            areaDataGridViewTextBoxColumn.Width = 56;
            // 
            // developedDataGridViewCheckBoxColumn
            // 
            developedDataGridViewCheckBoxColumn.DataPropertyName = "Developed";
            developedDataGridViewCheckBoxColumn.HeaderText = "Developed";
            developedDataGridViewCheckBoxColumn.Name = "developedDataGridViewCheckBoxColumn";
            developedDataGridViewCheckBoxColumn.Width = 69;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            populationDataGridViewTextBoxColumn.Width = 90;
            // 
            // nationDataGridViewTextBoxColumn
            // 
            nationDataGridViewTextBoxColumn.DataPropertyName = "Nation";
            nationDataGridViewTextBoxColumn.HeaderText = "Nation";
            nationDataGridViewTextBoxColumn.Name = "nationDataGridViewTextBoxColumn";
            nationDataGridViewTextBoxColumn.Width = 68;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Note";
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.Width = 58;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.AutoGenerateColumns = false;
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { countryNameDataGridViewTextBoxColumn1, capitalDataGridViewTextBoxColumn1, areaDataGridViewTextBoxColumn1, developedDataGridViewCheckBoxColumn1, populationDataGridViewTextBoxColumn1, nationDataGridViewTextBoxColumn1, noteDataGridViewTextBoxColumn1 });
            dataGridViewOutput.DataSource = countryBindingSource1;
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(0, 0);
            dataGridViewOutput.Margin = new Padding(10);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.Size = new Size(799, 565);
            dataGridViewOutput.TabIndex = 1;
            dataGridViewOutput.CellContentClick += dataGridViewOutput_CellContentClick;
            // 
            // countryNameDataGridViewTextBoxColumn1
            // 
            countryNameDataGridViewTextBoxColumn1.DataPropertyName = "CountryName";
            countryNameDataGridViewTextBoxColumn1.HeaderText = "CountryName";
            countryNameDataGridViewTextBoxColumn1.Name = "countryNameDataGridViewTextBoxColumn1";
            // 
            // capitalDataGridViewTextBoxColumn1
            // 
            capitalDataGridViewTextBoxColumn1.DataPropertyName = "Capital";
            capitalDataGridViewTextBoxColumn1.HeaderText = "Capital";
            capitalDataGridViewTextBoxColumn1.Name = "capitalDataGridViewTextBoxColumn1";
            // 
            // areaDataGridViewTextBoxColumn1
            // 
            areaDataGridViewTextBoxColumn1.DataPropertyName = "Area";
            areaDataGridViewTextBoxColumn1.HeaderText = "Area";
            areaDataGridViewTextBoxColumn1.Name = "areaDataGridViewTextBoxColumn1";
            // 
            // developedDataGridViewCheckBoxColumn1
            // 
            developedDataGridViewCheckBoxColumn1.DataPropertyName = "Developed";
            developedDataGridViewCheckBoxColumn1.HeaderText = "Developed";
            developedDataGridViewCheckBoxColumn1.Name = "developedDataGridViewCheckBoxColumn1";
            // 
            // populationDataGridViewTextBoxColumn1
            // 
            populationDataGridViewTextBoxColumn1.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn1.HeaderText = "Population";
            populationDataGridViewTextBoxColumn1.Name = "populationDataGridViewTextBoxColumn1";
            // 
            // nationDataGridViewTextBoxColumn1
            // 
            nationDataGridViewTextBoxColumn1.DataPropertyName = "Nation";
            nationDataGridViewTextBoxColumn1.HeaderText = "Nation";
            nationDataGridViewTextBoxColumn1.Name = "nationDataGridViewTextBoxColumn1";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn1.HeaderText = "Note";
            noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput.Location = new Point(515, 276);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(1201, 565);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInput.Location = new Point(101, 276);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(1220, 565);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Данные";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1619, 873);
            Controls.Add(panelData);
            Controls.Add(panel1);
            Controls.Add(panelHeader_MLO);
            MinimumSize = new Size(1635, 912);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Милюков Леонид ИИПб-24-2 | Спринт 7 | Проект";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelHeader_MLO.ResumeLayout(false);
            groupBoxHeaderHelp_MLO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartOfPopulation_MLO).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCountryArea_MLO).EndInit();
            groupBoxSearch_MLO.ResumeLayout(false);
            groupBoxSearch_MLO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource1).EndInit();
            panelData.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader_MLO;
        private Button buttonHelp_MLO;
        private Button buttonAbout_MLO;
        private Button buttonSave_MLO;
        private ToolTip toolTip_MLO;
        private GroupBox groupBoxHeaderHelp_MLO;
        private Panel panel1;
        private GroupBox groupBoxSearch_MLO;
        private TextBox textBoxName;
        private Panel panelData;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOutput;
        private DataGridView dataGridViewInput;
        private ColorDialog colorDialog1;
        private SplitContainer splitContainer1;
        private Button Sort;
        private DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn developedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private BindingSource countryBindingSource;
        private DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn developedDataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private BindingSource countryBindingSource1;
        private SaveFileDialog saveFileDialog_MLO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOfPopulation_MLO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountryArea_MLO;
    }
}
