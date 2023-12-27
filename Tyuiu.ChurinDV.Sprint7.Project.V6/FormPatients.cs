using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    public partial class FormPatients : Form
    {
        int izm = 0;
        int index;

        public FormPatients()
        {
            InitializeComponent();
            openFileDialog_CDV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayData = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayData[r, c] = line_r[c];
                }
            }
            return arrayData;
        }

        private void buttonOpenFile_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_CDV.ShowDialog();
                openFilePath = openFileDialog_CDV.FileName;

                string[,] arrayData = new string[rows, columns];
                arrayData = LoadFromFileData(openFilePath);

                dataGridViewOutputPatiens_CDV.ColumnCount = columns;
                dataGridViewOutputPatiens_CDV.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOutputPatiens_CDV.Columns[i].Width = 91;
                    dataGridViewOutputPatiens_CDV.Columns[i].Width = 91;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutputPatiens_CDV.Rows[r].Cells[c].Value = arrayData[r, c];
                    }
                }
                buttonAdd_CDV.Enabled = true;
                buttonChange_CDV.Enabled = true;
                buttonDelete_CDV.Enabled = true;
                buttonReset_CDV.Enabled = true;
                textBoxBirthday_CDV.Enabled = true;
                textBoxFamilia_CDV.Enabled = true;
                textBoxName_CDV.Enabled = true;
                textBoxNumber_CDV.Enabled = true;
                textBoxOtch_CDV.Enabled = true;
                textBoxDiagnoz_CDV.Enabled = true;
                textBoxDispanser_CDV.Enabled = true;
                textBoxAmbul_CDV.Enabled = true;
                buttonClose_CDV.Enabled = true;
                textBoxSearch_CDV.Enabled = true;
                buttonStat_CDV.Enabled = true;
                buttonSaveFile_CDV.Enabled = true;
                buttonResetSearch_CDV.Enabled = true;
                buttonSortFamilia_CDV.Enabled = true;
                buttonSortName_CDV.Enabled = true;
                buttonSortNumber_CDV.Enabled = true;
                buttonSortOtch_CDV.Enabled = true;
                buttonSortDiagnoz_CDV.Enabled = true;
                buttonChar_CDV.Enabled = true;
                
            }
            catch
            {
                MessageBox.Show("Выберете файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_CDV_Click(object sender, EventArgs e)
        {
            string familia = textBoxFamilia_CDV.Text;
            string name = textBoxName_CDV.Text;
            string otch = textBoxOtch_CDV.Text;
            string number = textBoxNumber_CDV.Text;
            string birthday = textBoxBirthday_CDV.Text;
            string diagnoz = textBoxDiagnoz_CDV.Text;
            string ambul = textBoxAmbul_CDV.Text;
            string dispanser = textBoxDispanser_CDV.Text;

            dataGridViewOutputPatiens_CDV.Rows.Add(familia, name, otch, number, diagnoz, ambul, dispanser, birthday);
            textBoxFamilia_CDV.Text = "";
            textBoxName_CDV.Text = "";
            textBoxOtch_CDV.Text = "";
            textBoxNumber_CDV.Text = "";
            textBoxBirthday_CDV.Text = "";
            textBoxDiagnoz_CDV.Text = "";
            textBoxAmbul_CDV.Text = "";
            textBoxDispanser_CDV.Text = "";
            dataGridViewOutputPatiens_CDV.CurrentCell = dataGridViewOutputPatiens_CDV.Rows[dataGridViewOutputPatiens_CDV.Rows.Count - 1].Cells[0];

            izm++;
        }

        private void buttonChange_CDV_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewOutputPatiens_CDV.Rows[index];
            newdata.Cells[0].Value = textBoxFamilia_CDV.Text;
            newdata.Cells[1].Value = textBoxName_CDV.Text;
            newdata.Cells[2].Value = textBoxOtch_CDV.Text;
            newdata.Cells[3].Value = textBoxNumber_CDV.Text;
            newdata.Cells[4].Value = textBoxDiagnoz_CDV.Text;
            newdata.Cells[5].Value = textBoxAmbul_CDV.Text;
            newdata.Cells[6].Value = textBoxDispanser_CDV.Text;
            newdata.Cells[7].Value = textBoxBirthday_CDV.Text;

            izm++;
        }

        private void dataGridViewOutputPatiens_CDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewOutputPatiens_CDV.Rows[index];
            textBoxFamilia_CDV.Text = row.Cells[0].Value.ToString();
            textBoxName_CDV.Text = row.Cells[1].Value.ToString();
            textBoxOtch_CDV.Text = row.Cells[2].Value.ToString();
            textBoxNumber_CDV.Text = row.Cells[3].Value.ToString();
            textBoxDiagnoz_CDV.Text = row.Cells[4].Value.ToString();
            textBoxAmbul_CDV.Text = row.Cells[5].Value.ToString();
            textBoxDispanser_CDV.Text = row.Cells[6].Value.ToString();
            textBoxBirthday_CDV.Text = row.Cells[7].Value.ToString();
        }

        private void buttonDelete_CDV_Click(object sender, EventArgs e)
        {
            int count = dataGridViewOutputPatiens_CDV.SelectedRows.Count;
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                while (count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewOutputPatiens_CDV.SelectedRows)
                    {
                        dataGridViewOutputPatiens_CDV.Rows.Remove(row);
                        count--;
                    }
                }
            }

            izm++;
        }

        private void buttonReset_CDV_Click(object sender, EventArgs e)
        {
            textBoxFamilia_CDV.Text = String.Empty;
            textBoxName_CDV.Text = String.Empty;
            textBoxOtch_CDV.Text = String.Empty;
            textBoxNumber_CDV.Text = String.Empty;
            textBoxDiagnoz_CDV.Text = String.Empty;
            textBoxAmbul_CDV.Text = String.Empty;
            textBoxDispanser_CDV.Text = String.Empty;
            textBoxBirthday_CDV.Text = String.Empty;
        }

        private void SortByAlphabet(int columnIndex)
        {
            DataGridViewColumn column = dataGridViewOutputPatiens_CDV.Columns[columnIndex];

            if (dataGridViewOutputPatiens_CDV.SortOrder == SortOrder.Ascending)
            {
                dataGridViewOutputPatiens_CDV.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                dataGridViewOutputPatiens_CDV.Sort(column, ListSortDirection.Ascending);
            }
        }

        private void buttonSortFamilia_CDV_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortName_CDV_Click(object sender, EventArgs e)
        {
            int columnIndex = 1;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortOtch_CDV_Click(object sender, EventArgs e)
        {
            int columnIndex = 2;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortNumber_CDV_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridViewOutputPatiens_CDV.Columns[3];

            if (dataGridViewOutputPatiens_CDV.SortOrder == SortOrder.Ascending)
            {
                dataGridViewOutputPatiens_CDV.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                this.dataGridViewOutputPatiens_CDV.Sort(this.dataGridViewOutputPatiens_CDV.Columns[3], ListSortDirection.Ascending);
            }
        }

        private void buttonSortData_CDV_Click(object sender, EventArgs e)
        {
            this.dataGridViewOutputPatiens_CDV.Sort(this.dataGridViewOutputPatiens_CDV.Columns[7], ListSortDirection.Ascending);
        }

        private void buttonStat_CDV_Click(object sender, EventArgs e)
        {
            int count = 0;
            int countambul = 0;
            int countdispan = 0;
            int summaage = 0;
            int stariy = 0;
            int molodoy = 0;
            foreach (DataGridViewRow row in dataGridViewOutputPatiens_CDV.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        count++;
                        if (row.Cells[5].Value.ToString() == "да")
                        {
                            countambul++;
                        }
                        if (row.Cells[6].Value.ToString() == "да")
                        {
                            countdispan++;
                        }
                    }
                    List<int> years = new List<int>(row.Cells[7].Value.ToString().Split('.').Select(x => Convert.ToInt32(x)));
                    for (int i = 2; i <= years.Count(); i+=3)
                    {
                        DateTime currentDate = DateTime.Today;
                        int age = currentDate.Year - years[i];
                        if (age > 30)
                        {
                            stariy++;
                        }
                        else
                        {
                            molodoy++;
                        }
                        summaage += age;
                    }
                }
            }
            int sredage = summaage / count;
            MessageBox.Show($"Количество пациентов: {count}\nКоличетсво пациентов с амбулаторным лечением: {countambul}\nКоличество пациентов состоящих на диспансерном учёте: {countdispan}" +
                $"\nКоличество пациентов старше 30 лет: {stariy}\nКоличество пациентов, чей возраст 30 лет или младше: {molodoy}\nСредний возраст пациентов: {sredage}", "Статистика");
        }


        private void SaveFile()
        {
            try
            {
                saveFileDialog_CDV.FileName = ".csv";
                saveFileDialog_CDV.InitialDirectory = @":L";
                if (saveFileDialog_CDV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_CDV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOutputPatiens_CDV.RowCount;
                    int columns = dataGridViewOutputPatiens_CDV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOutputPatiens_CDV.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    izm = 0;
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_CDV_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void buttonClose_CDV_Click(object sender, EventArgs e)
        {
            if (izm != 0)
            {
                DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                if (result == DialogResult.No)
                {
                    dataGridViewOutputPatiens_CDV.Rows.Clear();
                    dataGridViewOutputPatiens_CDV.Columns.Clear();

                    izm = 0;

                    buttonAdd_CDV.Enabled = false;
                    buttonChange_CDV.Enabled = false;
                    buttonDelete_CDV.Enabled = false;
                    buttonReset_CDV.Enabled = false;
                    textBoxBirthday_CDV.Enabled = false;
                    textBoxFamilia_CDV.Enabled = false;
                    textBoxName_CDV.Enabled = false;
                    textBoxNumber_CDV.Enabled = false;
                    textBoxOtch_CDV.Enabled = false;
                    textBoxDiagnoz_CDV.Enabled = false;
                    textBoxDispanser_CDV.Enabled = false;
                    textBoxAmbul_CDV.Enabled = false;
                    buttonClose_CDV.Enabled = false;
                    textBoxSearch_CDV.Enabled = false;
                    buttonStat_CDV.Enabled = false;
                    buttonSaveFile_CDV.Enabled = false;
                    buttonResetSearch_CDV.Enabled = false;
                    buttonSortFamilia_CDV.Enabled = false;
                    buttonSortName_CDV.Enabled = false;
                    buttonSortNumber_CDV.Enabled = false;
                    buttonSortOtch_CDV.Enabled = false;
                    buttonSortDiagnoz_CDV.Enabled = false;
                    buttonChar_CDV.Enabled = false;

                }
                if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                dataGridViewOutputPatiens_CDV.Rows.Clear();
                dataGridViewOutputPatiens_CDV.Columns.Clear();

                izm = 0;

                buttonAdd_CDV.Enabled = false;
                buttonChange_CDV.Enabled = false;
                buttonDelete_CDV.Enabled = false;
                buttonReset_CDV.Enabled = false;
                textBoxBirthday_CDV.Enabled = false;
                textBoxFamilia_CDV.Enabled = false;
                textBoxName_CDV.Enabled = false;
                textBoxNumber_CDV.Enabled = false;
                textBoxOtch_CDV.Enabled = false;
                textBoxDiagnoz_CDV.Enabled = false;
                textBoxDispanser_CDV.Enabled = false;
                textBoxAmbul_CDV.Enabled = false;
                buttonClose_CDV.Enabled = false;
                textBoxSearch_CDV.Enabled = false;
                buttonStat_CDV.Enabled = false;
                buttonSaveFile_CDV.Enabled = false;
                buttonResetSearch_CDV.Enabled = false;
                buttonSortFamilia_CDV.Enabled = false;
                buttonSortName_CDV.Enabled = false;
                buttonSortNumber_CDV.Enabled = false;
                buttonSortOtch_CDV.Enabled = false;
                buttonSortDiagnoz_CDV.Enabled = false;
                buttonChar_CDV.Enabled = false;
            }
        }

        private void textBoxSearch_CDV_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearch_CDV.Text))
            {
                string searchText = textBoxSearch_CDV.Text.ToLower();
                foreach (DataGridViewRow row in dataGridViewOutputPatiens_CDV.Rows)
                {
                    if (row.IsNewRow) continue;
                    bool found = false;
                    for (int i = 0; i < dataGridViewOutputPatiens_CDV.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToLower().Contains(searchText))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
                buttonResetSearch_CDV.Enabled = true;
            }
        }

        private void buttonResetSearch_CDV_Click(object sender, EventArgs e)
        {
            textBoxSearch_CDV.Clear();

            string searchText = textBoxSearch_CDV.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewOutputPatiens_CDV.Rows)
            {
                if (row.IsNewRow) continue;
                bool found = false;
                for (int i = 0; i < dataGridViewOutputPatiens_CDV.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString().ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    row.Visible = true;
                else
                    row.Visible = false;
            }
            textBoxSearch_CDV.Clear();
            buttonResetSearch_CDV.Enabled = false;
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate.AddYears(-age)) age--;
            return age;
        }

        private void buttonChar_CDV_Click(object sender, EventArgs e)
        {
            FormChart chartForm = new FormChart();

            List<int> agecount = new List<int>();
            List<int> vseages = new List<int>();
            List<int> sortages = new List<int>();
            foreach (DataGridViewRow row in dataGridViewOutputPatiens_CDV.Rows)
            {
                List<int> dati = new List<int>(row.Cells[7].Value.ToString().Split('.').Select(x => Convert.ToInt32(x)));
                for (int i = 2; i <= dati.Count(); i += 3)
                {
                    DateTime currentDate = DateTime.Today;
                    int age = currentDate.Year - dati[i];
                    vseages.Add(age);
                    if (sortages.Contains(age) == false)
                    {
                        sortages.Add(age);
                    }    
                }
            }
            foreach (int age in sortages)
            {
                List<int> vseages2 = vseages;
                agecount.Add(age);
                int countage = 0;
                for (int i = 0; i <= vseages.Count(); i++)
                {
                    if (vseages.Contains(age))
                    {
                        vseages2.Remove(age);
                        countage++;
                    }
                }
                agecount.Add(countage);
            }
            chartForm.UpdateChart(agecount);
            chartForm.Show();
        }
    }
}
