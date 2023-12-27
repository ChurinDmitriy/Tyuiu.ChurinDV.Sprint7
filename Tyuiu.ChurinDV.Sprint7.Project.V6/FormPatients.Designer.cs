
namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    partial class FormPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatients));
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.groupBoxSearch_CDV = new System.Windows.Forms.GroupBox();
            this.buttonChar_CDV = new System.Windows.Forms.Button();
            this.textBoxSearch_CDV = new System.Windows.Forms.TextBox();
            this.labelSearch_CDV = new System.Windows.Forms.Label();
            this.buttonResetSearch_CDV = new System.Windows.Forms.Button();
            this.groupBoxSort_CDV = new System.Windows.Forms.GroupBox();
            this.buttonSortDiagnoz_CDV = new System.Windows.Forms.Button();
            this.buttonSortNumber_CDV = new System.Windows.Forms.Button();
            this.buttonSortOtch_CDV = new System.Windows.Forms.Button();
            this.buttonSortName_CDV = new System.Windows.Forms.Button();
            this.buttonSortFamilia_CDV = new System.Windows.Forms.Button();
            this.groupBoxInstrum_CDV = new System.Windows.Forms.GroupBox();
            this.labelBirthday_CDV = new System.Windows.Forms.Label();
            this.labelDispancer_CDV = new System.Windows.Forms.Label();
            this.labelAmbul_CDV = new System.Windows.Forms.Label();
            this.labelDiagnoz_CDV = new System.Windows.Forms.Label();
            this.labelNumber_CDV = new System.Windows.Forms.Label();
            this.labelOtch_CDV = new System.Windows.Forms.Label();
            this.labelName_CDV = new System.Windows.Forms.Label();
            this.labelFamilia_CDV = new System.Windows.Forms.Label();
            this.textBoxBirthday_CDV = new System.Windows.Forms.TextBox();
            this.textBoxNumber_CDV = new System.Windows.Forms.TextBox();
            this.textBoxOtch_CDV = new System.Windows.Forms.TextBox();
            this.textBoxName_CDV = new System.Windows.Forms.TextBox();
            this.textBoxDispanser_CDV = new System.Windows.Forms.TextBox();
            this.textBoxAmbul_CDV = new System.Windows.Forms.TextBox();
            this.textBoxDiagnoz_CDV = new System.Windows.Forms.TextBox();
            this.textBoxFamilia_CDV = new System.Windows.Forms.TextBox();
            this.buttonClose_CDV = new System.Windows.Forms.Button();
            this.buttonSaveFile_CDV = new System.Windows.Forms.Button();
            this.buttonStat_CDV = new System.Windows.Forms.Button();
            this.buttonReset_CDV = new System.Windows.Forms.Button();
            this.buttonDelete_CDV = new System.Windows.Forms.Button();
            this.buttonAdd_CDV = new System.Windows.Forms.Button();
            this.buttonChange_CDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_CDV = new System.Windows.Forms.Button();
            this.panelFill_CDV = new System.Windows.Forms.Panel();
            this.dataGridViewOutputPatiens_CDV = new System.Windows.Forms.DataGridView();
            this.toolTip_CDV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_CDV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_CDV = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_CDV.SuspendLayout();
            this.groupBoxSearch_CDV.SuspendLayout();
            this.groupBoxSort_CDV.SuspendLayout();
            this.groupBoxInstrum_CDV.SuspendLayout();
            this.panelFill_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputPatiens_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTop_CDV.Controls.Add(this.groupBoxSearch_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxSort_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxInstrum_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(732, 175);
            this.panelTop_CDV.TabIndex = 0;
            // 
            // groupBoxSearch_CDV
            // 
            this.groupBoxSearch_CDV.Controls.Add(this.buttonChar_CDV);
            this.groupBoxSearch_CDV.Controls.Add(this.textBoxSearch_CDV);
            this.groupBoxSearch_CDV.Controls.Add(this.labelSearch_CDV);
            this.groupBoxSearch_CDV.Controls.Add(this.buttonResetSearch_CDV);
            this.groupBoxSearch_CDV.Location = new System.Drawing.Point(548, 3);
            this.groupBoxSearch_CDV.Name = "groupBoxSearch_CDV";
            this.groupBoxSearch_CDV.Size = new System.Drawing.Size(181, 166);
            this.groupBoxSearch_CDV.TabIndex = 0;
            this.groupBoxSearch_CDV.TabStop = false;
            this.groupBoxSearch_CDV.Text = "Поиск и график";
            // 
            // buttonChar_CDV
            // 
            this.buttonChar_CDV.BackColor = System.Drawing.Color.White;
            this.buttonChar_CDV.Enabled = false;
            this.buttonChar_CDV.Location = new System.Drawing.Point(9, 44);
            this.buttonChar_CDV.Name = "buttonChar_CDV";
            this.buttonChar_CDV.Size = new System.Drawing.Size(163, 25);
            this.buttonChar_CDV.TabIndex = 2;
            this.buttonChar_CDV.Text = "График";
            this.buttonChar_CDV.UseVisualStyleBackColor = false;
            this.buttonChar_CDV.Click += new System.EventHandler(this.buttonChar_CDV_Click);
            // 
            // textBoxSearch_CDV
            // 
            this.textBoxSearch_CDV.Enabled = false;
            this.textBoxSearch_CDV.Location = new System.Drawing.Point(6, 106);
            this.textBoxSearch_CDV.Multiline = true;
            this.textBoxSearch_CDV.Name = "textBoxSearch_CDV";
            this.textBoxSearch_CDV.Size = new System.Drawing.Size(171, 25);
            this.textBoxSearch_CDV.TabIndex = 1;
            this.textBoxSearch_CDV.TextChanged += new System.EventHandler(this.textBoxSearch_CDV_TextChanged);
            // 
            // labelSearch_CDV
            // 
            this.labelSearch_CDV.AutoSize = true;
            this.labelSearch_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_CDV.Location = new System.Drawing.Point(6, 84);
            this.labelSearch_CDV.Name = "labelSearch_CDV";
            this.labelSearch_CDV.Size = new System.Drawing.Size(171, 15);
            this.labelSearch_CDV.TabIndex = 0;
            this.labelSearch_CDV.Text = "Введите данные для поиска";
            // 
            // buttonResetSearch_CDV
            // 
            this.buttonResetSearch_CDV.BackColor = System.Drawing.Color.White;
            this.buttonResetSearch_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetSearch_CDV.Enabled = false;
            this.buttonResetSearch_CDV.Location = new System.Drawing.Point(6, 136);
            this.buttonResetSearch_CDV.Name = "buttonResetSearch_CDV";
            this.buttonResetSearch_CDV.Size = new System.Drawing.Size(171, 25);
            this.buttonResetSearch_CDV.TabIndex = 0;
            this.buttonResetSearch_CDV.Text = "Сбросить";
            this.buttonResetSearch_CDV.UseVisualStyleBackColor = false;
            this.buttonResetSearch_CDV.Click += new System.EventHandler(this.buttonResetSearch_CDV_Click);
            // 
            // groupBoxSort_CDV
            // 
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortDiagnoz_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortNumber_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortOtch_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortName_CDV);
            this.groupBoxSort_CDV.Controls.Add(this.buttonSortFamilia_CDV);
            this.groupBoxSort_CDV.Location = new System.Drawing.Point(434, 3);
            this.groupBoxSort_CDV.Name = "groupBoxSort_CDV";
            this.groupBoxSort_CDV.Size = new System.Drawing.Size(114, 166);
            this.groupBoxSort_CDV.TabIndex = 0;
            this.groupBoxSort_CDV.TabStop = false;
            this.groupBoxSort_CDV.Text = "Сортировка по";
            // 
            // buttonSortDiagnoz_CDV
            // 
            this.buttonSortDiagnoz_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortDiagnoz_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortDiagnoz_CDV.Enabled = false;
            this.buttonSortDiagnoz_CDV.Location = new System.Drawing.Point(6, 136);
            this.buttonSortDiagnoz_CDV.Name = "buttonSortDiagnoz_CDV";
            this.buttonSortDiagnoz_CDV.Size = new System.Drawing.Size(102, 25);
            this.buttonSortDiagnoz_CDV.TabIndex = 0;
            this.buttonSortDiagnoz_CDV.Text = "Диагноз";
            this.toolTip_CDV.SetToolTip(this.buttonSortDiagnoz_CDV, "Сортировка по алфавиту по диагнозу");
            this.buttonSortDiagnoz_CDV.UseVisualStyleBackColor = false;
            this.buttonSortDiagnoz_CDV.Click += new System.EventHandler(this.buttonSortNumber_CDV_Click);
            // 
            // buttonSortNumber_CDV
            // 
            this.buttonSortNumber_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortNumber_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortNumber_CDV.Enabled = false;
            this.buttonSortNumber_CDV.Location = new System.Drawing.Point(6, 106);
            this.buttonSortNumber_CDV.Name = "buttonSortNumber_CDV";
            this.buttonSortNumber_CDV.Size = new System.Drawing.Size(102, 25);
            this.buttonSortNumber_CDV.TabIndex = 0;
            this.buttonSortNumber_CDV.Text = "Номер";
            this.toolTip_CDV.SetToolTip(this.buttonSortNumber_CDV, "Сортировка по номеру");
            this.buttonSortNumber_CDV.UseVisualStyleBackColor = false;
            this.buttonSortNumber_CDV.Click += new System.EventHandler(this.buttonSortNumber_CDV_Click);
            // 
            // buttonSortOtch_CDV
            // 
            this.buttonSortOtch_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortOtch_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortOtch_CDV.Enabled = false;
            this.buttonSortOtch_CDV.Location = new System.Drawing.Point(6, 74);
            this.buttonSortOtch_CDV.Name = "buttonSortOtch_CDV";
            this.buttonSortOtch_CDV.Size = new System.Drawing.Size(102, 25);
            this.buttonSortOtch_CDV.TabIndex = 0;
            this.buttonSortOtch_CDV.Text = "Отчество";
            this.toolTip_CDV.SetToolTip(this.buttonSortOtch_CDV, "Сортировка по алфавиту по отчеству");
            this.buttonSortOtch_CDV.UseVisualStyleBackColor = false;
            this.buttonSortOtch_CDV.Click += new System.EventHandler(this.buttonSortOtch_CDV_Click);
            // 
            // buttonSortName_CDV
            // 
            this.buttonSortName_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortName_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortName_CDV.Enabled = false;
            this.buttonSortName_CDV.Location = new System.Drawing.Point(6, 44);
            this.buttonSortName_CDV.Name = "buttonSortName_CDV";
            this.buttonSortName_CDV.Size = new System.Drawing.Size(102, 25);
            this.buttonSortName_CDV.TabIndex = 0;
            this.buttonSortName_CDV.Text = "Имя";
            this.toolTip_CDV.SetToolTip(this.buttonSortName_CDV, "Сортировка по алфавиту по имени");
            this.buttonSortName_CDV.UseVisualStyleBackColor = false;
            this.buttonSortName_CDV.Click += new System.EventHandler(this.buttonSortName_CDV_Click);
            // 
            // buttonSortFamilia_CDV
            // 
            this.buttonSortFamilia_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSortFamilia_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortFamilia_CDV.Enabled = false;
            this.buttonSortFamilia_CDV.Location = new System.Drawing.Point(6, 13);
            this.buttonSortFamilia_CDV.Name = "buttonSortFamilia_CDV";
            this.buttonSortFamilia_CDV.Size = new System.Drawing.Size(102, 25);
            this.buttonSortFamilia_CDV.TabIndex = 0;
            this.buttonSortFamilia_CDV.Text = "Фамилия";
            this.toolTip_CDV.SetToolTip(this.buttonSortFamilia_CDV, "Сортировка по афлавиту по фамилии");
            this.buttonSortFamilia_CDV.UseVisualStyleBackColor = false;
            this.buttonSortFamilia_CDV.Click += new System.EventHandler(this.buttonSortFamilia_CDV_Click);
            // 
            // groupBoxInstrum_CDV
            // 
            this.groupBoxInstrum_CDV.Controls.Add(this.labelBirthday_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelDispancer_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelAmbul_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelDiagnoz_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelNumber_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelOtch_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelName_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.labelFamilia_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxBirthday_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxNumber_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxOtch_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxName_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxDispanser_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxAmbul_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxDiagnoz_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.textBoxFamilia_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonClose_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonSaveFile_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonStat_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonReset_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonDelete_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonAdd_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonChange_CDV);
            this.groupBoxInstrum_CDV.Controls.Add(this.buttonOpenFile_CDV);
            this.groupBoxInstrum_CDV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInstrum_CDV.Name = "groupBoxInstrum_CDV";
            this.groupBoxInstrum_CDV.Size = new System.Drawing.Size(431, 166);
            this.groupBoxInstrum_CDV.TabIndex = 0;
            this.groupBoxInstrum_CDV.TabStop = false;
            this.groupBoxInstrum_CDV.Text = "Инструменты";
            // 
            // labelBirthday_CDV
            // 
            this.labelBirthday_CDV.AutoSize = true;
            this.labelBirthday_CDV.Location = new System.Drawing.Point(235, 124);
            this.labelBirthday_CDV.Name = "labelBirthday_CDV";
            this.labelBirthday_CDV.Size = new System.Drawing.Size(90, 13);
            this.labelBirthday_CDV.TabIndex = 2;
            this.labelBirthday_CDV.Text = "День рождения:";
            // 
            // labelDispancer_CDV
            // 
            this.labelDispancer_CDV.AutoSize = true;
            this.labelDispancer_CDV.Location = new System.Drawing.Point(235, 86);
            this.labelDispancer_CDV.Name = "labelDispancer_CDV";
            this.labelDispancer_CDV.Size = new System.Drawing.Size(123, 13);
            this.labelDispancer_CDV.TabIndex = 2;
            this.labelDispancer_CDV.Text = "Состоит на дисп.учёте:";
            // 
            // labelAmbul_CDV
            // 
            this.labelAmbul_CDV.AutoSize = true;
            this.labelAmbul_CDV.Location = new System.Drawing.Point(235, 47);
            this.labelAmbul_CDV.Name = "labelAmbul_CDV";
            this.labelAmbul_CDV.Size = new System.Drawing.Size(89, 13);
            this.labelAmbul_CDV.TabIndex = 2;
            this.labelAmbul_CDV.Text = "Амбул. лечение:";
            // 
            // labelDiagnoz_CDV
            // 
            this.labelDiagnoz_CDV.AutoSize = true;
            this.labelDiagnoz_CDV.Location = new System.Drawing.Point(235, 10);
            this.labelDiagnoz_CDV.Name = "labelDiagnoz_CDV";
            this.labelDiagnoz_CDV.Size = new System.Drawing.Size(54, 13);
            this.labelDiagnoz_CDV.TabIndex = 2;
            this.labelDiagnoz_CDV.Text = "Диагноз:";
            // 
            // labelNumber_CDV
            // 
            this.labelNumber_CDV.AutoSize = true;
            this.labelNumber_CDV.Location = new System.Drawing.Point(115, 123);
            this.labelNumber_CDV.Name = "labelNumber_CDV";
            this.labelNumber_CDV.Size = new System.Drawing.Size(44, 13);
            this.labelNumber_CDV.TabIndex = 2;
            this.labelNumber_CDV.Text = "Номер:";
            // 
            // labelOtch_CDV
            // 
            this.labelOtch_CDV.AutoSize = true;
            this.labelOtch_CDV.Location = new System.Drawing.Point(115, 85);
            this.labelOtch_CDV.Name = "labelOtch_CDV";
            this.labelOtch_CDV.Size = new System.Drawing.Size(57, 13);
            this.labelOtch_CDV.TabIndex = 2;
            this.labelOtch_CDV.Text = "Отчество:";
            // 
            // labelName_CDV
            // 
            this.labelName_CDV.AutoSize = true;
            this.labelName_CDV.Location = new System.Drawing.Point(115, 47);
            this.labelName_CDV.Name = "labelName_CDV";
            this.labelName_CDV.Size = new System.Drawing.Size(32, 13);
            this.labelName_CDV.TabIndex = 2;
            this.labelName_CDV.Text = "Имя:";
            // 
            // labelFamilia_CDV
            // 
            this.labelFamilia_CDV.AutoSize = true;
            this.labelFamilia_CDV.Location = new System.Drawing.Point(115, 10);
            this.labelFamilia_CDV.Name = "labelFamilia_CDV";
            this.labelFamilia_CDV.Size = new System.Drawing.Size(59, 13);
            this.labelFamilia_CDV.TabIndex = 2;
            this.labelFamilia_CDV.Text = "Фамилия:";
            // 
            // textBoxBirthday_CDV
            // 
            this.textBoxBirthday_CDV.Enabled = false;
            this.textBoxBirthday_CDV.Location = new System.Drawing.Point(238, 140);
            this.textBoxBirthday_CDV.Name = "textBoxBirthday_CDV";
            this.textBoxBirthday_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxBirthday_CDV.TabIndex = 1;
            // 
            // textBoxNumber_CDV
            // 
            this.textBoxNumber_CDV.Enabled = false;
            this.textBoxNumber_CDV.Location = new System.Drawing.Point(118, 139);
            this.textBoxNumber_CDV.Name = "textBoxNumber_CDV";
            this.textBoxNumber_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxNumber_CDV.TabIndex = 1;
            // 
            // textBoxOtch_CDV
            // 
            this.textBoxOtch_CDV.Enabled = false;
            this.textBoxOtch_CDV.Location = new System.Drawing.Point(118, 101);
            this.textBoxOtch_CDV.Name = "textBoxOtch_CDV";
            this.textBoxOtch_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxOtch_CDV.TabIndex = 1;
            // 
            // textBoxName_CDV
            // 
            this.textBoxName_CDV.Enabled = false;
            this.textBoxName_CDV.Location = new System.Drawing.Point(118, 64);
            this.textBoxName_CDV.Name = "textBoxName_CDV";
            this.textBoxName_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxName_CDV.TabIndex = 1;
            // 
            // textBoxDispanser_CDV
            // 
            this.textBoxDispanser_CDV.Enabled = false;
            this.textBoxDispanser_CDV.Location = new System.Drawing.Point(238, 101);
            this.textBoxDispanser_CDV.Name = "textBoxDispanser_CDV";
            this.textBoxDispanser_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxDispanser_CDV.TabIndex = 1;
            // 
            // textBoxAmbul_CDV
            // 
            this.textBoxAmbul_CDV.Enabled = false;
            this.textBoxAmbul_CDV.Location = new System.Drawing.Point(238, 64);
            this.textBoxAmbul_CDV.Name = "textBoxAmbul_CDV";
            this.textBoxAmbul_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxAmbul_CDV.TabIndex = 1;
            // 
            // textBoxDiagnoz_CDV
            // 
            this.textBoxDiagnoz_CDV.Enabled = false;
            this.textBoxDiagnoz_CDV.Location = new System.Drawing.Point(238, 26);
            this.textBoxDiagnoz_CDV.Name = "textBoxDiagnoz_CDV";
            this.textBoxDiagnoz_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxDiagnoz_CDV.TabIndex = 1;
            // 
            // textBoxFamilia_CDV
            // 
            this.textBoxFamilia_CDV.Enabled = false;
            this.textBoxFamilia_CDV.Location = new System.Drawing.Point(118, 26);
            this.textBoxFamilia_CDV.Name = "textBoxFamilia_CDV";
            this.textBoxFamilia_CDV.Size = new System.Drawing.Size(114, 20);
            this.textBoxFamilia_CDV.TabIndex = 1;
            // 
            // buttonClose_CDV
            // 
            this.buttonClose_CDV.BackColor = System.Drawing.Color.White;
            this.buttonClose_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_CDV.Enabled = false;
            this.buttonClose_CDV.Location = new System.Drawing.Point(6, 114);
            this.buttonClose_CDV.Name = "buttonClose_CDV";
            this.buttonClose_CDV.Size = new System.Drawing.Size(106, 45);
            this.buttonClose_CDV.TabIndex = 0;
            this.buttonClose_CDV.Text = "Закрыть базу";
            this.buttonClose_CDV.UseVisualStyleBackColor = false;
            this.buttonClose_CDV.Click += new System.EventHandler(this.buttonClose_CDV_Click);
            // 
            // buttonSaveFile_CDV
            // 
            this.buttonSaveFile_CDV.BackColor = System.Drawing.Color.White;
            this.buttonSaveFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_CDV.Enabled = false;
            this.buttonSaveFile_CDV.Location = new System.Drawing.Point(6, 64);
            this.buttonSaveFile_CDV.Name = "buttonSaveFile_CDV";
            this.buttonSaveFile_CDV.Size = new System.Drawing.Size(106, 45);
            this.buttonSaveFile_CDV.TabIndex = 0;
            this.buttonSaveFile_CDV.Text = "Сохранить базу";
            this.toolTip_CDV.SetToolTip(this.buttonSaveFile_CDV, "Сохраните базу в выбранную папку");
            this.buttonSaveFile_CDV.UseVisualStyleBackColor = false;
            this.buttonSaveFile_CDV.Click += new System.EventHandler(this.buttonSaveFile_CDV_Click);
            // 
            // buttonStat_CDV
            // 
            this.buttonStat_CDV.BackColor = System.Drawing.Color.White;
            this.buttonStat_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStat_CDV.Enabled = false;
            this.buttonStat_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStat_CDV.Location = new System.Drawing.Point(358, 137);
            this.buttonStat_CDV.Name = "buttonStat_CDV";
            this.buttonStat_CDV.Size = new System.Drawing.Size(67, 25);
            this.buttonStat_CDV.TabIndex = 0;
            this.buttonStat_CDV.Text = "Статистика";
            this.toolTip_CDV.SetToolTip(this.buttonStat_CDV, "Количество пациентов");
            this.buttonStat_CDV.UseVisualStyleBackColor = false;
            this.buttonStat_CDV.Click += new System.EventHandler(this.buttonStat_CDV_Click);
            // 
            // buttonReset_CDV
            // 
            this.buttonReset_CDV.BackColor = System.Drawing.Color.White;
            this.buttonReset_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset_CDV.Enabled = false;
            this.buttonReset_CDV.Location = new System.Drawing.Point(358, 106);
            this.buttonReset_CDV.Name = "buttonReset_CDV";
            this.buttonReset_CDV.Size = new System.Drawing.Size(67, 25);
            this.buttonReset_CDV.TabIndex = 0;
            this.buttonReset_CDV.Text = "Сбросить";
            this.toolTip_CDV.SetToolTip(this.buttonReset_CDV, "Сбросить предварительно введённые данные\r\n");
            this.buttonReset_CDV.UseVisualStyleBackColor = false;
            this.buttonReset_CDV.Click += new System.EventHandler(this.buttonReset_CDV_Click);
            // 
            // buttonDelete_CDV
            // 
            this.buttonDelete_CDV.BackColor = System.Drawing.Color.White;
            this.buttonDelete_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete_CDV.Enabled = false;
            this.buttonDelete_CDV.Location = new System.Drawing.Point(358, 75);
            this.buttonDelete_CDV.Name = "buttonDelete_CDV";
            this.buttonDelete_CDV.Size = new System.Drawing.Size(67, 25);
            this.buttonDelete_CDV.TabIndex = 0;
            this.buttonDelete_CDV.Text = "Удалить";
            this.toolTip_CDV.SetToolTip(this.buttonDelete_CDV, "Удалить данные врача из базы");
            this.buttonDelete_CDV.UseVisualStyleBackColor = false;
            this.buttonDelete_CDV.Click += new System.EventHandler(this.buttonDelete_CDV_Click);
            // 
            // buttonAdd_CDV
            // 
            this.buttonAdd_CDV.BackColor = System.Drawing.Color.White;
            this.buttonAdd_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_CDV.Enabled = false;
            this.buttonAdd_CDV.Location = new System.Drawing.Point(358, 13);
            this.buttonAdd_CDV.Name = "buttonAdd_CDV";
            this.buttonAdd_CDV.Size = new System.Drawing.Size(67, 25);
            this.buttonAdd_CDV.TabIndex = 0;
            this.buttonAdd_CDV.Text = "Добавить";
            this.toolTip_CDV.SetToolTip(this.buttonAdd_CDV, "Добавить врача в базу");
            this.buttonAdd_CDV.UseVisualStyleBackColor = false;
            this.buttonAdd_CDV.Click += new System.EventHandler(this.buttonAdd_CDV_Click);
            // 
            // buttonChange_CDV
            // 
            this.buttonChange_CDV.BackColor = System.Drawing.Color.White;
            this.buttonChange_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange_CDV.Enabled = false;
            this.buttonChange_CDV.Location = new System.Drawing.Point(358, 44);
            this.buttonChange_CDV.Name = "buttonChange_CDV";
            this.buttonChange_CDV.Size = new System.Drawing.Size(67, 25);
            this.buttonChange_CDV.TabIndex = 0;
            this.buttonChange_CDV.Text = "Изменить";
            this.toolTip_CDV.SetToolTip(this.buttonChange_CDV, "Изменить данные врача в базе");
            this.buttonChange_CDV.UseVisualStyleBackColor = false;
            this.buttonChange_CDV.Click += new System.EventHandler(this.buttonChange_CDV_Click);
            // 
            // buttonOpenFile_CDV
            // 
            this.buttonOpenFile_CDV.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_CDV.Location = new System.Drawing.Point(6, 13);
            this.buttonOpenFile_CDV.Name = "buttonOpenFile_CDV";
            this.buttonOpenFile_CDV.Size = new System.Drawing.Size(106, 45);
            this.buttonOpenFile_CDV.TabIndex = 0;
            this.buttonOpenFile_CDV.Text = "Открыть базу";
            this.toolTip_CDV.SetToolTip(this.buttonOpenFile_CDV, "Откройте базу для начала\r\nработы с инструментами\r\n");
            this.buttonOpenFile_CDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CDV.Click += new System.EventHandler(this.buttonOpenFile_CDV_Click);
            // 
            // panelFill_CDV
            // 
            this.panelFill_CDV.Controls.Add(this.dataGridViewOutputPatiens_CDV);
            this.panelFill_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CDV.Location = new System.Drawing.Point(0, 175);
            this.panelFill_CDV.Name = "panelFill_CDV";
            this.panelFill_CDV.Size = new System.Drawing.Size(732, 276);
            this.panelFill_CDV.TabIndex = 1;
            // 
            // dataGridViewOutputPatiens_CDV
            // 
            this.dataGridViewOutputPatiens_CDV.AllowUserToAddRows = false;
            this.dataGridViewOutputPatiens_CDV.AllowUserToDeleteRows = false;
            this.dataGridViewOutputPatiens_CDV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOutputPatiens_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputPatiens_CDV.ColumnHeadersVisible = false;
            this.dataGridViewOutputPatiens_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputPatiens_CDV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutputPatiens_CDV.Name = "dataGridViewOutputPatiens_CDV";
            this.dataGridViewOutputPatiens_CDV.RowHeadersVisible = false;
            this.dataGridViewOutputPatiens_CDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutputPatiens_CDV.Size = new System.Drawing.Size(732, 276);
            this.dataGridViewOutputPatiens_CDV.TabIndex = 0;
            this.dataGridViewOutputPatiens_CDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutputPatiens_CDV_CellClick);
            // 
            // toolTip_CDV
            // 
            this.toolTip_CDV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_CDV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_CDV
            // 
            this.openFileDialog_CDV.FileName = "openFileDialog1";
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 451);
            this.Controls.Add(this.panelFill_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(748, 490);
            this.Name = "FormPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База пациентов";
            this.panelTop_CDV.ResumeLayout(false);
            this.groupBoxSearch_CDV.ResumeLayout(false);
            this.groupBoxSearch_CDV.PerformLayout();
            this.groupBoxSort_CDV.ResumeLayout(false);
            this.groupBoxInstrum_CDV.ResumeLayout(false);
            this.groupBoxInstrum_CDV.PerformLayout();
            this.panelFill_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputPatiens_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Panel panelFill_CDV;
        private System.Windows.Forms.DataGridView dataGridViewOutputPatiens_CDV;
        private System.Windows.Forms.GroupBox groupBoxSearch_CDV;
        private System.Windows.Forms.GroupBox groupBoxSort_CDV;
        private System.Windows.Forms.GroupBox groupBoxInstrum_CDV;
        private System.Windows.Forms.Button buttonOpenFile_CDV;
        private System.Windows.Forms.ToolTip toolTip_CDV;
        private System.Windows.Forms.Button buttonSaveFile_CDV;
        private System.Windows.Forms.Button buttonClose_CDV;
        private System.Windows.Forms.TextBox textBoxBirthday_CDV;
        private System.Windows.Forms.TextBox textBoxNumber_CDV;
        private System.Windows.Forms.TextBox textBoxOtch_CDV;
        private System.Windows.Forms.TextBox textBoxName_CDV;
        private System.Windows.Forms.TextBox textBoxFamilia_CDV;
        private System.Windows.Forms.Button buttonChange_CDV;
        private System.Windows.Forms.Button buttonAdd_CDV;
        private System.Windows.Forms.Button buttonDelete_CDV;
        private System.Windows.Forms.Button buttonReset_CDV;
        private System.Windows.Forms.Button buttonStat_CDV;
        private System.Windows.Forms.Button buttonSortName_CDV;
        private System.Windows.Forms.Button buttonSortFamilia_CDV;
        private System.Windows.Forms.TextBox textBoxSearch_CDV;
        private System.Windows.Forms.Label labelSearch_CDV;
        private System.Windows.Forms.Button buttonResetSearch_CDV;
        private System.Windows.Forms.Button buttonSortNumber_CDV;
        private System.Windows.Forms.Button buttonSortOtch_CDV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CDV;
        private System.Windows.Forms.Label labelBirthday_CDV;
        private System.Windows.Forms.Label labelDispancer_CDV;
        private System.Windows.Forms.Label labelAmbul_CDV;
        private System.Windows.Forms.Label labelDiagnoz_CDV;
        private System.Windows.Forms.Label labelNumber_CDV;
        private System.Windows.Forms.Label labelOtch_CDV;
        private System.Windows.Forms.Label labelName_CDV;
        private System.Windows.Forms.Label labelFamilia_CDV;
        private System.Windows.Forms.TextBox textBoxDispanser_CDV;
        private System.Windows.Forms.TextBox textBoxAmbul_CDV;
        private System.Windows.Forms.TextBox textBoxDiagnoz_CDV;
        private System.Windows.Forms.Button buttonSortDiagnoz_CDV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_CDV;
        private System.Windows.Forms.Button buttonChar_CDV;
    }
}