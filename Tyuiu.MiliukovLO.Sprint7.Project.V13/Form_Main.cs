using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;
using Tyuiu.MiliukovLO.Sprint7.Project.V13.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.MiliukovLO.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new();
        public FormMain()
        {
            InitializeComponent();
            dataGridViewOutput.ColumnHeaderMouseClick += dataGridViewOutput_ColumnHeaderMouseClick;
        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            List<Country> countries = ds.GetCountries();
            dataGridViewInput.AutoGenerateColumns = true;
            dataGridViewInput.DataSource = countries;
            dataGridViewOutput.AutoGenerateColumns = true;
            dataGridViewOutput.DataSource = countries;

            chartOfPopulation_MLO.Series.Clear();
            chartCountryArea_MLO.Series.Clear();

            foreach (var country in countries)
            {
                var seriesPopulation = chartOfPopulation_MLO.Series.Add(country.CountryName);
                seriesPopulation.Points.AddXY(country.CountryName, country.Population);
                var seriesArea = chartCountryArea_MLO.Series.Add(country.CountryName);
                seriesArea.Points.AddXY(country.CountryName, country.Area);
            }

            chartOfPopulation_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartOfPopulation_MLO.ChartAreas[0].AxisY.Title = "Население";
            chartCountryArea_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartCountryArea_MLO.ChartAreas[0].AxisY.Title = "Площадь";
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            List<Country> countries = ds.SearchCountry(textBoxName.Text);
            dataGridViewOutput.AutoGenerateColumns = true;
            dataGridViewOutput.DataSource = countries;
            chartOfPopulation_MLO.Series.Clear();

            chartOfPopulation_MLO.Series.Clear();
            chartCountryArea_MLO.Series.Clear();

            foreach (var country in countries)
            {
                var seriesPopulation = chartOfPopulation_MLO.Series.Add(country.CountryName);
                seriesPopulation.Points.AddXY(country.CountryName, country.Population);
                var seriesArea = chartCountryArea_MLO.Series.Add(country.CountryName);
                seriesArea.Points.AddXY(country.CountryName, country.Area);
            }

            chartOfPopulation_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartOfPopulation_MLO.ChartAreas[0].AxisY.Title = "Население";
            chartCountryArea_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartCountryArea_MLO.ChartAreas[0].AxisY.Title = "Площадь";
        }

        private void dataGridViewOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOutput_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            List<Country> countries = ds.SortCountry(columnIndex);
            dataGridViewOutput.DataSource = countries;
            chartOfPopulation_MLO.Series.Clear();
            chartCountryArea_MLO.Series.Clear();

            foreach (var country in countries)
            {
                var seriesPopulation = chartOfPopulation_MLO.Series.Add(country.CountryName);
                seriesPopulation.Points.AddXY(country.CountryName, country.Population);
                var seriesArea = chartCountryArea_MLO.Series.Add(country.CountryName);
                seriesArea.Points.AddXY(country.CountryName, country.Area);
            }

            chartOfPopulation_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartOfPopulation_MLO.ChartAreas[0].AxisY.Title = "Население";
            chartCountryArea_MLO.ChartAreas[0].AxisX.Title = "Страны";
            chartCountryArea_MLO.ChartAreas[0].AxisY.Title = "Площадь";

        }

        private DataGridView GetDataGridViewOutput()
        {
            return dataGridViewOutput;
        }

        private void buttonSave_MLO_Click(object sender, EventArgs e)
        {
            saveFileDialog_MLO.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog_MLO.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog_MLO.FileName;

                StringBuilder csvContent = new();

                for (int i = 0; i < dataGridViewOutput.Columns.Count; i++)
                {
                    csvContent.Append(dataGridViewOutput.Columns[i].HeaderText);
                    if (i < dataGridViewOutput.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();

                foreach (DataGridViewRow row in dataGridViewOutput.Rows)
                {
                    for (int i = 0; i < dataGridViewOutput.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString());
                        if (i < dataGridViewOutput.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }

                File.WriteAllText(filename, csvContent.ToString());
                MessageBox.Show("Файл сохранен");
            }
        }
        private void buttonAbout_MLO_Click(object sender, EventArgs e)
        {
            Form_About about = new Form_About();
            about.ShowDialog();
        }
        private void buttonHelp_MLO_Click(object sender, EventArgs e)
        {
            Form_Help help = new Form_Help();
            help.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
