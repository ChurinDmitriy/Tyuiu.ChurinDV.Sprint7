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

namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    public partial class FormDoctors : Form
    {
        int izm = 0;
        int index;

        public FormDoctors()
        {
            InitializeComponent();

            openFileDialogData_CDV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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
                openFileDialogData_CDV.ShowDialog();
                openFilePath = openFileDialogData_CDV.FileName;

                string[,] arrayData = new string[rows, columns];
                arrayData = LoadFromFileData(openFilePath);

                dataGridViewOutputData_CDV.ColumnCount = columns;
                dataGridViewOutputData_CDV.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOutputData_CDV.Columns[i].Width = 243;
                    dataGridViewOutputData_CDV.Columns[i].Width = 243;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutputData_CDV.Rows[r].Cells[c].Value = arrayData[r, c];
                    }
                }
                buttonAdd_CDV.Enabled = true;
                buttonChange_CDV.Enabled = true;
                buttonDelete_CDV.Enabled = true;
                buttonReset_CDV.Enabled = true;
                textBoxFIO_CDV.Enabled = true;
                textBoxSpec_CDV.Enabled = true;
                textBoxStage_CDV.Enabled = true;
                buttonSortFIO_CDV.Enabled = true;
                buttonSortStage_CDV.Enabled = true;
                buttonSortSpec_CDV.Enabled = true;
                radioButtonSpecFilter_CDV.Enabled = true;
                radioButtonStageFilter_CDV.Enabled = true;
                comboBoxSpecFilter_CDV.Enabled = true;
                comboBoxStageFilter_CDV.Enabled = true;
                textBoxSearch_CDV.Enabled = true;
                buttonStat_CDV.Enabled = true;
                buttonSaveFile_CDV.Enabled = true;
                buttonResetData_CDV.Enabled = true;
                buttonResetSearch_CDV.Enabled = true;
            }
            catch
            {

            }
        }

        private void buttonAdd_CDV_Click(object sender, EventArgs e)
        {
            string FIO = textBoxFIO_CDV.Text;
            string spec = textBoxSpec_CDV.Text;
            string stage = textBoxStage_CDV.Text;

            dataGridViewOutputData_CDV.Rows.Add(FIO, spec, stage);
            textBoxFIO_CDV.Text = "";
            textBoxSpec_CDV.Text = "";
            textBoxStage_CDV.Text = "";
            dataGridViewOutputData_CDV.CurrentCell = dataGridViewOutputData_CDV.Rows[dataGridViewOutputData_CDV.Rows.Count - 1].Cells[0];

            izm++;
        }

        private void buttonChange_CDV_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewOutputData_CDV.Rows[index];
            newdata.Cells[0].Value = textBoxFIO_CDV.Text;
            newdata.Cells[1].Value = textBoxSpec_CDV.Text;
            newdata.Cells[2].Value = textBoxStage_CDV.Text;

            izm++;
        }

        private void dataGridViewOutputData_CDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewOutputData_CDV.Rows[index];
            textBoxFIO_CDV.Text = row.Cells[0].Value.ToString();
            textBoxSpec_CDV.Text = row.Cells[1].Value.ToString();
            textBoxStage_CDV.Text = row.Cells[2].Value.ToString();
        }

        private void buttonDelete_CDV_Click(object sender, EventArgs e)
        {
            int count = dataGridViewOutputData_CDV.SelectedRows.Count;
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                while (count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewOutputData_CDV.SelectedRows)
                    {
                        dataGridViewOutputData_CDV.Rows.Remove(row);
                        count--;
                    }
                }
            }

            izm++;
        }

        private void buttonReset_CDV_Click(object sender, EventArgs e)
        {
            textBoxFIO_CDV.Text = String.Empty;
            textBoxSpec_CDV.Text = String.Empty;
            textBoxStage_CDV.Text = String.Empty;
        }

        private void SortByAlphabet(int columnIndex)
        {
            try
            {
                DataGridViewColumn column = dataGridViewOutputData_CDV.Columns[columnIndex];

                if (dataGridViewOutputData_CDV.SortOrder == SortOrder.Ascending)
                {
                    dataGridViewOutputData_CDV.Sort(column, ListSortDirection.Descending);
                }
                else
                {
                    dataGridViewOutputData_CDV.Sort(column, ListSortDirection.Ascending);
                }
            }
            catch
            {
                MessageBox.Show("Откройте базу для начала сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortByNumbers(int columnIndex)
        {
            try
            {
                DataGridViewColumn column = dataGridViewOutputData_CDV.Columns[columnIndex];

                if (dataGridViewOutputData_CDV.SortOrder == SortOrder.Ascending)
                {
                    dataGridViewOutputData_CDV.Sort(column, ListSortDirection.Descending);
                }
                else
                {
                    dataGridViewOutputData_CDV.Sort(column, ListSortDirection.Ascending);
                }
            }
            catch
            {
                MessageBox.Show("Откройте базу для начала сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortFIO_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 0;
                SortByAlphabet(columnIndex);
            }
            catch
            {
                MessageBox.Show("Откройте базу для начала сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpec_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 1;
                SortByAlphabet(columnIndex);
            }
            catch
            {
                MessageBox.Show("Откройте базу для начала сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortStage_CDV_Click_1(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 2;
                SortByNumbers(columnIndex);
            }
            catch
            {
                MessageBox.Show("Откройте базу для начала сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetData_CDV_Click(object sender, EventArgs e)
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
                    dataGridViewOutputData_CDV.Rows.Clear();
                    dataGridViewOutputData_CDV.Columns.Clear();

                    izm = 0;

                    buttonAdd_CDV.Enabled = false;
                    buttonChange_CDV.Enabled = false;
                    buttonDelete_CDV.Enabled = false;
                    buttonReset_CDV.Enabled = false;
                    textBoxFIO_CDV.Enabled = false;
                    textBoxSpec_CDV.Enabled = false;
                    textBoxStage_CDV.Enabled = false;
                    buttonSortFIO_CDV.Enabled = false;
                    buttonSortStage_CDV.Enabled = false;
                    buttonSortSpec_CDV.Enabled = false;
                    radioButtonSpecFilter_CDV.Enabled = false;
                    radioButtonStageFilter_CDV.Enabled = false;
                    comboBoxSpecFilter_CDV.Enabled = false;
                    comboBoxStageFilter_CDV.Enabled = false;
                    textBoxSearch_CDV.Enabled = false;
                    buttonStat_CDV.Enabled = false;
                    buttonSaveFile_CDV.Enabled = false;
                    buttonResetData_CDV.Enabled = false;
                    buttonResetSearch_CDV.Enabled = false;

                }
                if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                dataGridViewOutputData_CDV.Rows.Clear();
                dataGridViewOutputData_CDV.Columns.Clear();

                izm = 0;

                buttonAdd_CDV.Enabled = false;
                buttonChange_CDV.Enabled = false;
                buttonDelete_CDV.Enabled = false;
                buttonReset_CDV.Enabled = false;
                textBoxFIO_CDV.Enabled = false;
                textBoxSpec_CDV.Enabled = false;
                textBoxStage_CDV.Enabled = false;
                buttonSortFIO_CDV.Enabled = false;
                buttonSortStage_CDV.Enabled = false;
                buttonSortSpec_CDV.Enabled = false;
                radioButtonSpecFilter_CDV.Enabled = false;
                radioButtonStageFilter_CDV.Enabled = false;
                comboBoxSpecFilter_CDV.Enabled = false;
                comboBoxStageFilter_CDV.Enabled = false;
                textBoxSearch_CDV.Enabled = false;
                buttonStat_CDV.Enabled = false;
                buttonSaveFile_CDV.Enabled = false;
                buttonResetData_CDV.Enabled = false;
                buttonResetSearch_CDV.Enabled = false;
            }
        }
        private void SaveFile()
        {
            try
            {
                saveFileDialogData_CDV.FileName = ".csv";
                saveFileDialogData_CDV.InitialDirectory = @":L";
                if (saveFileDialogData_CDV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogData_CDV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOutputData_CDV.RowCount;
                    int columns = dataGridViewOutputData_CDV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOutputData_CDV.Rows[i].Cells[j].Value);

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

        private void radioButtonSpecFilter_CDV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 1;
            List<string> items = new List<string>();

            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            comboBoxSpecFilter_CDV.Items.Clear();
            comboBoxSpecFilter_CDV.Items.AddRange(items.ToArray());

            comboBoxSpecFilter_CDV.Enabled = true;

            comboBoxStageFilter_CDV.Enabled = false;

            comboBoxSpecFilter_CDV.Text = "";
            comboBoxSpecFilter_CDV.Text = "";
        }

        private void radioButtonStageFilter_CDV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 2;
            List<string> items = new List<string>();

            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            comboBoxStageFilter_CDV.Items.Clear();
            comboBoxStageFilter_CDV.Items.AddRange(items.ToArray());

            comboBoxStageFilter_CDV.Enabled = true;

            comboBoxSpecFilter_CDV.Enabled = false;

            comboBoxStageFilter_CDV.Text = "";
            comboBoxStageFilter_CDV.Text = "";
        }

        private void comboBoxSpecFilter_CDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxSpecFilter_CDV.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                row.Visible = true;
            }

            foreach (DataGridViewColumn column in dataGridViewOutputData_CDV.Columns)
            {
                int columnIndex = 1;
                foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBoxStageFilter_CDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxStageFilter_CDV.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                row.Visible = true;
            }

            foreach (DataGridViewColumn column in dataGridViewOutputData_CDV.Columns)
            {
                int columnIndex = 2;
                foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void buttonSearch_CDV_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonResetSearch_CDV_Click(object sender, EventArgs e)
        {
            textBoxSearch_CDV.Clear();

            string searchText = textBoxSearch_CDV.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                if (row.IsNewRow) continue;
                bool found = false;
                for (int i = 0; i < dataGridViewOutputData_CDV.Columns.Count; i++)
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


            comboBoxSpecFilter_CDV.Items.Clear();
            comboBoxStageFilter_CDV.Items.Clear();

            comboBoxSpecFilter_CDV.Text = "";
            comboBoxStageFilter_CDV.Text = "";

            radioButtonSpecFilter_CDV.Checked = false;
            radioButtonStageFilter_CDV.Checked = false;


            comboBoxSpecFilter_CDV.SelectedIndex = -1;
            comboBoxStageFilter_CDV.SelectedIndex = -1;


            comboBoxSpecFilter_CDV.Enabled = false;
            comboBoxStageFilter_CDV.Enabled = false;
        }

        private void textBoxSearch_CDV_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearch_CDV.Text))
            {
                string searchText = textBoxSearch_CDV.Text.ToLower();
                foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
                {
                    if (row.IsNewRow) continue;
                    bool found = false;
                    for (int i = 0; i < dataGridViewOutputData_CDV.Columns.Count; i++)
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

        private void buttonStat_CDV_Click(object sender, EventArgs e)
        {
            int count = 0;
            int maxstage = 0;
            int minstage = 100;
            int summa = 0;
            foreach (DataGridViewRow row in dataGridViewOutputData_CDV.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        count++;
                        if (Convert.ToInt32(row.Cells[2].Value) > maxstage)
                        {
                            maxstage = Convert.ToInt32(row.Cells[2].Value);
                        }
                        if (Convert.ToInt32(row.Cells[2].Value) < minstage)
                        {
                            minstage = Convert.ToInt32(row.Cells[2].Value);
                        }
                        summa += Convert.ToInt32(row.Cells[2].Value);
                    }                
                }
            }
            int sred = summa / count;
            MessageBox.Show($"Количество сотрудников: {count} \nМинимальный стаж: {minstage} \nМаксимальный стаж: {maxstage} \nСредний стаж: {sred}", "Статистика");
        }

        private void panelTop_CDV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
