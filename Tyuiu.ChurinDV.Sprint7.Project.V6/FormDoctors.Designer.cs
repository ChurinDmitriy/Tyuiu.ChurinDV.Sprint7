
namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    partial class FormDoctors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctors));
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.labelStageData_CDV = new System.Windows.Forms.Label();
            this.labelSpecData_CDV = new System.Windows.Forms.Label();
            this.labelFIOData_CDV = new System.Windows.Forms.Label();
            this.groupBoxSerachFilter_CDV = new System.Windows.Forms.GroupBox();
            this.labelSearch_CDV = new System.Windows.Forms.Label();
            this.buttonResetSearch_CDV = new System.Windows.Forms.Button();
            this.textBoxSearch_CDV = new System.Windows.Forms.TextBox();
            this.comboBoxStageFilter_CDV = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecFilter_CDV = new System.Windows.Forms.ComboBox();
            this.radioButtonStageFilter_CDV = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecFilter_CDV = new System.Windows.Forms.RadioButton();
            this.groupBoxSort_CDV = new System.Windows.Forms.GroupBox();
            this.buttonSortStage_CDV = new System.Windows.Forms.Button();
            this.buttonSortSpec_CDV = new System.Windows.Forms.Button();
            this.buttonSortFIO_CDV = new System.Windows.Forms.Button();
            this.groupBoxInstrums_CDV = new System.Windows.Forms.GroupBox();
            this.buttonStat_CDV = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.buttonResetData_CDV = new System.Windows.Forms.Button();
            this.buttonSaveFile_CDV = new System.Windows.Forms.Button();
            this.buttonReset_CDV = new System.Windows.Forms.Button();
            this.buttonDelete_CDV = new System.Windows.Forms.Button();
            this.buttonChange_CDV = new System.Windows.Forms.Button();
            this.buttonAdd_CDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_CDV = new System.Windows.Forms.Button();
            this.labelStage_CDV = new System.Windows.Forms.Label();
            this.labelSpec_CDV = new System.Windows.Forms.Label();
            this.labelFIO_CDV = new System.Windows.Forms.Label();
            this.textBoxFIO_CDV = new System.Windows.Forms.TextBox();
            this.textBoxStage_CDV = new System.Windows.Forms.TextBox();
            this.textBoxSpec_CDV = new System.Windows.Forms.TextBox();
            this.panelFill_CDV = new System.Windows.Forms.Panel();
            this.dataGridViewOutputData_CDV = new System.Windows.Forms.DataGridView();
            this.openFileDialogData_CDV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogData_CDV = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_CDV = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_CDV.SuspendLayout();
            this.groupBoxSerachFilter_CDV.SuspendLayout();
            this.groupBoxSort_CDV.SuspendLayout();
            this.groupBoxInstrums_CDV.SuspendLayout();
            this.panelFill_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTop_CDV.Controls.Add(this.labelStageData_CDV);
            this.panelTop_CDV.Controls.Add(this.labelSpecData_CDV);
            this.panelTop_CDV.Controls.Add(this.labelFIOData_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxSerachFilter_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxSort_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxInstrums_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(732, 175);
            this.panelTop_CDV.TabIndex = 0;
            this.panelTop_CDV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_CDV_Paint);
            // 
            // labelStageData_CDV
            // 
            this.labelStageData_CDV.AutoSize = true;
            this.labelStageData_CDV.Location = new System.Drawing.Point(402, 159);
            this.labelStageData_CDV.Name = "labelStageData_CDV";
            this.labelStageData_CDV.Size = new System.Drawing.Size(36, 13);
            this.labelStageData_CDV.TabIndex = 6;
            this.labelStageData_CDV.Text = "Стаж:";
            // 
            // labelSpecData_CDV
            // 
            this.labelSpecData_CDV.AutoSize = true;
            this.labelSpecData_CDV.Location = new System.Drawing.Point(198, 159);
            this.labelSpecData_CDV.Name = "labelSpecData_CDV";
            this.labelSpecData_CDV.Size = new System.Drawing.Size(89, 13);
            this.labelSpecData_CDV.TabIndex = 6;
            this.labelSpecData_CDV.Text = "Специализация:";
            // 
            // labelFIOData_CDV
            // 
            this.labelFIOData_CDV.AutoSize = true;
            this.labelFIOData_CDV.Location = new System.Drawing.Point(0, 160);
            this.labelFIOData_CDV.Name = "labelFIOData_CDV";
            this.labelFIOData_CDV.Size = new System.Drawing.Size(37, 13);
            this.labelFIOData_CDV.TabIndex = 6;
            this.labelFIOData_CDV.Text = "ФИО:";
            // 
            // groupBoxSerachFilter_CDV
            // 
            this.groupBoxSerachFilter_CDV.Controls.Add(this.labelSearch_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.buttonResetSearch_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.textBoxSearch_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.comboBoxStageFilter_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.comboBoxSpecFilter_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.radioButtonStageFilter_CDV);
            this.groupBoxSerachFilter_CDV.Controls.Add(this.radioButtonSpecFilter_CDV);
            this.groupBoxSerachFilter_CDV.Location = new System.Drawing.Point(480, 3);
            this.groupBoxSerachFilter_CDV.Name = "groupBoxSerachFilter_CDV";
            this.groupBoxSerachFilter_CDV.Size = new System.Drawing.Size(244, 154);
            this.groupBoxSerachFilter_CDV.TabIndex = 5;
            this.groupBoxSerachFilter_CDV.TabStop = false;
            this.groupBoxSerachFilter_CDV.Text = "Поиск и фильтр";
            // 
            // labelSearch_CDV
            // 
            this.labelSearch_CDV.AutoSize = true;
            this.labelSearch_CDV.Location = new System.Drawing.Point(3, 61);
            this.labelSearch_CDV.Name = "labelSearch_CDV";
            this.labelSearch_CDV.Size = new System.Drawing.Size(150, 13);
            this.labelSearch_CDV.TabIndex = 4;
            this.labelSearch_CDV.Text = "Введите данные для поиска";
            // 
            // buttonResetSearch_CDV
            // 
            this.buttonResetSearch_CDV.BackColor = System.Drawing.Color.White;
            this.buttonResetSearch_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetSearch_CDV.Enabled = false;
            this.buttonResetSearch_CDV.Location = new System.Drawing.Point(6, 107);
            this.buttonResetSearch_CDV.Name = "buttonResetSearch_CDV";
            this.buttonResetSearch_CDV.Size = new System.Drawing.Size(231, 40);
            this.buttonResetSearch_CDV.TabIndex = 3;
            this.buttonResetSearch_CDV.Text = "Сброс";
            this.toolTip_CDV.SetToolTip(this.buttonResetSearch_CDV, "Сброс фильтров и поиска");
            this.buttonResetSearch_CDV.UseVisualStyleBackColor = false;
            this.buttonResetSearch_CDV.Click += new System.EventHandler(this.buttonResetSearch_CDV_Click);
            // 
            // textBoxSearch_CDV
            // 
            this.textBoxSearch_CDV.Enabled = false;
            this.textBoxSearch_CDV.Location = new System.Drawing.Point(6, 77);
            this.textBoxSearch_CDV.Multiline = true;
            this.textBoxSearch_CDV.Name = "textBoxSearch_CDV";
            this.textBoxSearch_CDV.Size = new System.Drawing.Size(231, 24);
            this.textBoxSearch_CDV.TabIndex = 2;
            this.textBoxSearch_CDV.TextChanged += new System.EventHandler(this.textBoxSearch_CDV_TextChanged);
            // 
            // comboBoxStageFilter_CDV
            // 
            this.comboBoxStageFilter_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStageFilter_CDV.Enabled = false;
            this.comboBoxStageFilter_CDV.FormattingEnabled = true;
            this.comboBoxStageFilter_CDV.Location = new System.Drawing.Point(116, 37);
            this.comboBoxStageFilter_CDV.Name = "comboBoxStageFilter_CDV";
            this.comboBoxStageFilter_CDV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStageFilter_CDV.TabIndex = 1;
            this.toolTip_CDV.SetToolTip(this.comboBoxStageFilter_CDV, "Какой должен быть стаж врача?");
            this.comboBoxStageFilter_CDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxStageFilter_CDV_SelectedIndexChanged);
            // 
            // comboBoxSpecFilter_CDV
            // 
            this.comboBoxSpecFilter_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSpecFilter_CDV.Enabled = false;
            this.comboBoxSpecFilter_CDV.FormattingEnabled = true;
            this.comboBoxSpecFilter_CDV.Location = new System.Drawing.Point(116, 13);
            this.comboBoxSpecFilter_CDV.Name = "comboBoxSpecFilter_CDV";
            this.comboBoxSpecFilter_CDV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecFilter_CDV.TabIndex = 1;
            this.toolTip_CDV.SetToolTip(this.comboBoxSpecFilter_CDV, "По какой специальности вы\r\nхотите отфильтровать данные?");
            this.comboBoxSpecFilter_CDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecFilter_CDV_SelectedIndexChanged);
            // 
            // radioButtonStageFilter_CDV
            // 
            this.radioButtonStageFilter_CDV.AutoSize = true;
            this.radioButtonStageFilter_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonStageFilter_CDV.Enabled = false;
            this.radioButtonStageFilter_CDV.Location = new System.Drawing.Point(6, 36);
            this.radioButtonStageFilter_CDV.Name = "radioButtonStageFilter_CDV";
            this.radioButtonStageFilter_CDV.Size = new System.Drawing.Size(51, 17);
            this.radioButtonStageFilter_CDV.TabIndex = 0;
            this.radioButtonStageFilter_CDV.TabStop = true;
            this.radioButtonStageFilter_CDV.Text = "Стаж";
            this.radioButtonStageFilter_CDV.UseVisualStyleBackColor = true;
            this.radioButtonStageFilter_CDV.CheckedChanged += new System.EventHandler(this.radioButtonStageFilter_CDV_CheckedChanged);
            // 
            // radioButtonSpecFilter_CDV
            // 
            this.radioButtonSpecFilter_CDV.AutoSize = true;
            this.radioButtonSpecFilter_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSpecFilter_CDV.Enabled = false;
            this.radioButtonSpecFilter_CDV.Location = new System.Drawing.Point(6, 15);
            this.radioButtonSpecFilter_CDV.Name = "radioButtonSpecFilter_CDV";
            this.radioButtonSpecFilter_CDV.Size = new System.Drawing.Size(104, 17);
            this.radioButtonSpecFilter_CDV.TabIndex = 0;
            this.radioButtonSpecFilter_CDV.TabStop = true;
            this.radioButtonSpecFilter_CDV.Text = "Специализация";
            this.radioButtonSpecFilter_CDV.UseVisualStyleBackColor = true;
            this.radioButtonSpecFilter_CDV.CheckedChanged += new System.EventHandler(this.radioButtonSpecFilter_CDV_CheckedChanged);
            // 
            // groupBoxSort_CDV
            // 
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortStage_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortSpec_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortFIO_CDV);
            this.groupBoxSort_CDV.Location = new System.Drawing.Point(358, 3);
            this.groupBoxSort_CDV.Name = "groupBoxSort_CDV";
            this.groupBoxSort_CDV.Size = new System.Drawing.Size(116, 154);
            this.groupBoxSort_CDV.TabIndex = 4;
            this.groupBoxSort_CDV.TabStop = false;
            this.groupBoxSort_CDV.Text = "Сортировка по";
            // 
            // buttonSortStage_CDV
            // 
            this.buttonSortStage_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortStage_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortStage_CDV.Enabled = false;
            this.buttonSortStage_CDV.Location = new System.Drawing.Point(5, 107);
            this.buttonSortStage_CDV.Name = "buttonSortStage_CDV";
            this.buttonSortStage_CDV.Size = new System.Drawing.Size(105, 40);
            this.buttonSortStage_CDV.TabIndex = 1;
            this.buttonSortStage_CDV.Text = "Стаж";
            this.toolTip_CDV.SetToolTip(this.buttonSortStage_CDV, "Сортировка по стажу");
            this.buttonSortStage_CDV.UseVisualStyleBackColor = false;
            this.buttonSortStage_CDV.Click += new System.EventHandler(this.buttonSortStage_CDV_Click_1);
            // 
            // buttonSortSpec_CDV
            // 
            this.buttonSortSpec_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortSpec_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortSpec_CDV.Enabled = false;
            this.buttonSortSpec_CDV.Location = new System.Drawing.Point(6, 61);
            this.buttonSortSpec_CDV.Name = "buttonSortSpec_CDV";
            this.buttonSortSpec_CDV.Size = new System.Drawing.Size(105, 40);
            this.buttonSortSpec_CDV.TabIndex = 1;
            this.buttonSortSpec_CDV.Text = "Специализация";
            this.toolTip_CDV.SetToolTip(this.buttonSortSpec_CDV, "Сортировка по алфавиту специализации");
            this.buttonSortSpec_CDV.UseVisualStyleBackColor = false;
            this.buttonSortSpec_CDV.Click += new System.EventHandler(this.buttonSpec_CDV_Click);
            // 
            // buttonSortFIO_CDV
            // 
            this.buttonSortFIO_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortFIO_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortFIO_CDV.Enabled = false;
            this.buttonSortFIO_CDV.Location = new System.Drawing.Point(6, 15);
            this.buttonSortFIO_CDV.Name = "buttonSortFIO_CDV";
            this.buttonSortFIO_CDV.Size = new System.Drawing.Size(105, 40);
            this.buttonSortFIO_CDV.TabIndex = 0;
            this.buttonSortFIO_CDV.Text = "ФИО";
            this.toolTip_CDV.SetToolTip(this.buttonSortFIO_CDV, "Сортировка данных по алфавиту ФИО");
            this.buttonSortFIO_CDV.UseVisualStyleBackColor = false;
            this.buttonSortFIO_CDV.Click += new System.EventHandler(this.buttonSortFIO_CDV_Click);
            // 
            // groupBoxInstrums_CDV
            // 
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonStat_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.label);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonResetData_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonSaveFile_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonReset_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonDelete_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonChange_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonAdd_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.buttonOpenFile_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.labelStage_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.labelSpec_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.labelFIO_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.textBoxFIO_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.textBoxStage_CDV);
            this.groupBoxInstrums_CDV.Controls.Add(this.textBoxSpec_CDV);
            this.groupBoxInstrums_CDV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInstrums_CDV.Name = "groupBoxInstrums_CDV";
            this.groupBoxInstrums_CDV.Size = new System.Drawing.Size(348, 154);
            this.groupBoxInstrums_CDV.TabIndex = 3;
            this.groupBoxInstrums_CDV.TabStop = false;
            this.groupBoxInstrums_CDV.Text = "Инструменты";
            // 
            // buttonStat_CDV
            // 
            this.buttonStat_CDV.BackColor = System.Drawing.Color.White;
            this.buttonStat_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStat_CDV.Enabled = false;
            this.buttonStat_CDV.Location = new System.Drawing.Point(267, 125);
            this.buttonStat_CDV.Name = "buttonStat_CDV";
            this.buttonStat_CDV.Size = new System.Drawing.Size(75, 22);
            this.buttonStat_CDV.TabIndex = 5;
            this.buttonStat_CDV.Text = "Статистика";
            this.toolTip_CDV.SetToolTip(this.buttonStat_CDV, "Количество; Минимальный,\r\nмаксимальный и средний стаж врача\r\n");
            this.buttonStat_CDV.UseVisualStyleBackColor = false;
            this.buttonStat_CDV.Click += new System.EventHandler(this.buttonStat_CDV_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(195, 156);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 13);
            this.label.TabIndex = 6;
            this.label.Text = "ФИО:";
            // 
            // buttonResetData_CDV
            // 
            this.buttonResetData_CDV.BackColor = System.Drawing.Color.White;
            this.buttonResetData_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetData_CDV.Enabled = false;
            this.buttonResetData_CDV.Location = new System.Drawing.Point(6, 109);
            this.buttonResetData_CDV.Name = "buttonResetData_CDV";
            this.buttonResetData_CDV.Size = new System.Drawing.Size(100, 40);
            this.buttonResetData_CDV.TabIndex = 4;
            this.buttonResetData_CDV.Text = "Сбросить базу";
            this.buttonResetData_CDV.UseVisualStyleBackColor = false;
            this.buttonResetData_CDV.Click += new System.EventHandler(this.buttonResetData_CDV_Click);
            // 
            // buttonSaveFile_CDV
            // 
            this.buttonSaveFile_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSaveFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_CDV.Enabled = false;
            this.buttonSaveFile_CDV.Location = new System.Drawing.Point(6, 63);
            this.buttonSaveFile_CDV.Name = "buttonSaveFile_CDV";
            this.buttonSaveFile_CDV.Size = new System.Drawing.Size(100, 40);
            this.buttonSaveFile_CDV.TabIndex = 3;
            this.buttonSaveFile_CDV.Text = "Сохранить базу";
            this.toolTip_CDV.SetToolTip(this.buttonSaveFile_CDV, "Сохраните базу в выбранную папку");
            this.buttonSaveFile_CDV.UseVisualStyleBackColor = false;
            this.buttonSaveFile_CDV.Click += new System.EventHandler(this.buttonSaveFile_CDV_Click);
            // 
            // buttonReset_CDV
            // 
            this.buttonReset_CDV.BackColor = System.Drawing.Color.White;
            this.buttonReset_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset_CDV.Enabled = false;
            this.buttonReset_CDV.Location = new System.Drawing.Point(267, 97);
            this.buttonReset_CDV.Name = "buttonReset_CDV";
            this.buttonReset_CDV.Size = new System.Drawing.Size(75, 22);
            this.buttonReset_CDV.TabIndex = 3;
            this.buttonReset_CDV.Text = "Сбросить";
            this.toolTip_CDV.SetToolTip(this.buttonReset_CDV, "Сбросить предварительно введённые данные");
            this.buttonReset_CDV.UseVisualStyleBackColor = false;
            this.buttonReset_CDV.Click += new System.EventHandler(this.buttonReset_CDV_Click);
            // 
            // buttonDelete_CDV
            // 
            this.buttonDelete_CDV.BackColor = System.Drawing.Color.White;
            this.buttonDelete_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete_CDV.Enabled = false;
            this.buttonDelete_CDV.Location = new System.Drawing.Point(267, 69);
            this.buttonDelete_CDV.Name = "buttonDelete_CDV";
            this.buttonDelete_CDV.Size = new System.Drawing.Size(75, 22);
            this.buttonDelete_CDV.TabIndex = 3;
            this.buttonDelete_CDV.Text = "Удалить";
            this.toolTip_CDV.SetToolTip(this.buttonDelete_CDV, "Удалить данные врача из базы");
            this.buttonDelete_CDV.UseVisualStyleBackColor = false;
            this.buttonDelete_CDV.Click += new System.EventHandler(this.buttonDelete_CDV_Click);
            // 
            // buttonChange_CDV
            // 
            this.buttonChange_CDV.BackColor = System.Drawing.Color.White;
            this.buttonChange_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange_CDV.Enabled = false;
            this.buttonChange_CDV.Location = new System.Drawing.Point(267, 41);
            this.buttonChange_CDV.Name = "buttonChange_CDV";
            this.buttonChange_CDV.Size = new System.Drawing.Size(75, 22);
            this.buttonChange_CDV.TabIndex = 3;
            this.buttonChange_CDV.Text = "Изменить";
            this.toolTip_CDV.SetToolTip(this.buttonChange_CDV, "Изменить данные врача в базе");
            this.buttonChange_CDV.UseVisualStyleBackColor = false;
            this.buttonChange_CDV.Click += new System.EventHandler(this.buttonChange_CDV_Click);
            // 
            // buttonAdd_CDV
            // 
            this.buttonAdd_CDV.BackColor = System.Drawing.Color.White;
            this.buttonAdd_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_CDV.Enabled = false;
            this.buttonAdd_CDV.Location = new System.Drawing.Point(267, 13);
            this.buttonAdd_CDV.Name = "buttonAdd_CDV";
            this.buttonAdd_CDV.Size = new System.Drawing.Size(75, 22);
            this.buttonAdd_CDV.TabIndex = 3;
            this.buttonAdd_CDV.Text = "Добавить";
            this.toolTip_CDV.SetToolTip(this.buttonAdd_CDV, "Добавить врача в базу");
            this.buttonAdd_CDV.UseVisualStyleBackColor = false;
            this.buttonAdd_CDV.Click += new System.EventHandler(this.buttonAdd_CDV_Click);
            // 
            // buttonOpenFile_CDV
            // 
            this.buttonOpenFile_CDV.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_CDV.Location = new System.Drawing.Point(6, 18);
            this.buttonOpenFile_CDV.Name = "buttonOpenFile_CDV";
            this.buttonOpenFile_CDV.Size = new System.Drawing.Size(100, 40);
            this.buttonOpenFile_CDV.TabIndex = 0;
            this.buttonOpenFile_CDV.Text = "Открыть базу";
            this.toolTip_CDV.SetToolTip(this.buttonOpenFile_CDV, "Откройте базу для начала\r\nработы с инструментами");
            this.buttonOpenFile_CDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CDV.Click += new System.EventHandler(this.buttonOpenFile_CDV_Click);
            // 
            // labelStage_CDV
            // 
            this.labelStage_CDV.AutoSize = true;
            this.labelStage_CDV.Location = new System.Drawing.Point(109, 109);
            this.labelStage_CDV.Name = "labelStage_CDV";
            this.labelStage_CDV.Size = new System.Drawing.Size(33, 13);
            this.labelStage_CDV.TabIndex = 2;
            this.labelStage_CDV.Text = "Стаж";
            // 
            // labelSpec_CDV
            // 
            this.labelSpec_CDV.AutoSize = true;
            this.labelSpec_CDV.Location = new System.Drawing.Point(109, 63);
            this.labelSpec_CDV.Name = "labelSpec_CDV";
            this.labelSpec_CDV.Size = new System.Drawing.Size(86, 13);
            this.labelSpec_CDV.TabIndex = 2;
            this.labelSpec_CDV.Text = "Специализация";
            // 
            // labelFIO_CDV
            // 
            this.labelFIO_CDV.AutoSize = true;
            this.labelFIO_CDV.Location = new System.Drawing.Point(109, 17);
            this.labelFIO_CDV.Name = "labelFIO_CDV";
            this.labelFIO_CDV.Size = new System.Drawing.Size(34, 13);
            this.labelFIO_CDV.TabIndex = 2;
            this.labelFIO_CDV.Text = "ФИО";
            // 
            // textBoxFIO_CDV
            // 
            this.textBoxFIO_CDV.Enabled = false;
            this.textBoxFIO_CDV.Location = new System.Drawing.Point(112, 35);
            this.textBoxFIO_CDV.Name = "textBoxFIO_CDV";
            this.textBoxFIO_CDV.Size = new System.Drawing.Size(149, 20);
            this.textBoxFIO_CDV.TabIndex = 1;
            this.toolTip_CDV.SetToolTip(this.textBoxFIO_CDV, "Введите ФИО врача");
            // 
            // textBoxStage_CDV
            // 
            this.textBoxStage_CDV.Enabled = false;
            this.textBoxStage_CDV.Location = new System.Drawing.Point(112, 126);
            this.textBoxStage_CDV.Name = "textBoxStage_CDV";
            this.textBoxStage_CDV.Size = new System.Drawing.Size(149, 20);
            this.textBoxStage_CDV.TabIndex = 1;
            this.toolTip_CDV.SetToolTip(this.textBoxStage_CDV, "Введите стаж работы врача");
            // 
            // textBoxSpec_CDV
            // 
            this.textBoxSpec_CDV.Enabled = false;
            this.textBoxSpec_CDV.Location = new System.Drawing.Point(112, 81);
            this.textBoxSpec_CDV.Name = "textBoxSpec_CDV";
            this.textBoxSpec_CDV.Size = new System.Drawing.Size(149, 20);
            this.textBoxSpec_CDV.TabIndex = 1;
            this.toolTip_CDV.SetToolTip(this.textBoxSpec_CDV, "Введите специальность врача");
            // 
            // panelFill_CDV
            // 
            this.panelFill_CDV.Controls.Add(this.dataGridViewOutputData_CDV);
            this.panelFill_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CDV.Location = new System.Drawing.Point(0, 175);
            this.panelFill_CDV.Name = "panelFill_CDV";
            this.panelFill_CDV.Size = new System.Drawing.Size(732, 276);
            this.panelFill_CDV.TabIndex = 1;
            // 
            // dataGridViewOutputData_CDV
            // 
            this.dataGridViewOutputData_CDV.AllowUserToAddRows = false;
            this.dataGridViewOutputData_CDV.AllowUserToDeleteRows = false;
            this.dataGridViewOutputData_CDV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOutputData_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputData_CDV.ColumnHeadersVisible = false;
            this.dataGridViewOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputData_CDV.GridColor = System.Drawing.Color.White;
            this.dataGridViewOutputData_CDV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutputData_CDV.MinimumSize = new System.Drawing.Size(800, 300);
            this.dataGridViewOutputData_CDV.Name = "dataGridViewOutputData_CDV";
            this.dataGridViewOutputData_CDV.RowHeadersVisible = false;
            this.dataGridViewOutputData_CDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutputData_CDV.Size = new System.Drawing.Size(800, 300);
            this.dataGridViewOutputData_CDV.TabIndex = 0;
            this.dataGridViewOutputData_CDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutputData_CDV_CellClick);
            // 
            // openFileDialogData_CDV
            // 
            this.openFileDialogData_CDV.FileName = "openFileDialog1";
            // 
            // toolTip_CDV
            // 
            this.toolTip_CDV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_CDV.ToolTipTitle = "Подсказка";
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 451);
            this.Controls.Add(this.panelFill_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 490);
            this.Name = "FormDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База врачей";
            this.panelTop_CDV.ResumeLayout(false);
            this.panelTop_CDV.PerformLayout();
            this.groupBoxSerachFilter_CDV.ResumeLayout(false);
            this.groupBoxSerachFilter_CDV.PerformLayout();
            this.groupBoxSort_CDV.ResumeLayout(false);
            this.groupBoxInstrums_CDV.ResumeLayout(false);
            this.groupBoxInstrums_CDV.PerformLayout();
            this.panelFill_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Panel panelFill_CDV;
        private System.Windows.Forms.DataGridView dataGridViewOutputData_CDV;
        private System.Windows.Forms.Button buttonOpenFile_CDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogData_CDV;
        private System.Windows.Forms.GroupBox groupBoxSerachFilter_CDV;
        private System.Windows.Forms.Button buttonResetSearch_CDV;
        private System.Windows.Forms.TextBox textBoxSearch_CDV;
        private System.Windows.Forms.ComboBox comboBoxStageFilter_CDV;
        private System.Windows.Forms.ComboBox comboBoxSpecFilter_CDV;
        private System.Windows.Forms.RadioButton radioButtonStageFilter_CDV;
        private System.Windows.Forms.RadioButton radioButtonSpecFilter_CDV;
        private System.Windows.Forms.GroupBox groupBoxSort_CDV;
        private System.Windows.Forms.Button buttonSortStage_CDV;
        private System.Windows.Forms.Button buttonSortSpec_CDV;
        private System.Windows.Forms.Button buttonSortFIO_CDV;
        private System.Windows.Forms.GroupBox groupBoxInstrums_CDV;
        private System.Windows.Forms.Button buttonSaveFile_CDV;
        private System.Windows.Forms.Button buttonReset_CDV;
        private System.Windows.Forms.Button buttonDelete_CDV;
        private System.Windows.Forms.Button buttonChange_CDV;
        private System.Windows.Forms.Button buttonAdd_CDV;
        private System.Windows.Forms.Label labelStage_CDV;
        private System.Windows.Forms.Label labelSpec_CDV;
        private System.Windows.Forms.Label labelFIO_CDV;
        private System.Windows.Forms.TextBox textBoxFIO_CDV;
        private System.Windows.Forms.TextBox textBoxStage_CDV;
        private System.Windows.Forms.TextBox textBoxSpec_CDV;
        private System.Windows.Forms.Button buttonResetData_CDV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData_CDV;
        private System.Windows.Forms.Button buttonStat_CDV;
        private System.Windows.Forms.Label labelSearch_CDV;
        private System.Windows.Forms.Label labelFIOData_CDV;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelStageData_CDV;
        private System.Windows.Forms.Label labelSpecData_CDV;
        private System.Windows.Forms.ToolTip toolTip_CDV;
    }
}