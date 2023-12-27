
namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInfo_CDV = new System.Windows.Forms.GroupBox();
            this.groupBoxDeveloper_CDV = new System.Windows.Forms.GroupBox();
            this.labelInfo_CDV = new System.Windows.Forms.Label();
            this.labelDeveloper_CDV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInfo_CDV.SuspendLayout();
            this.groupBoxDeveloper_CDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 219);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInfo_CDV
            // 
            this.groupBoxInfo_CDV.Controls.Add(this.labelInfo_CDV);
            this.groupBoxInfo_CDV.Location = new System.Drawing.Point(207, 12);
            this.groupBoxInfo_CDV.Name = "groupBoxInfo_CDV";
            this.groupBoxInfo_CDV.Size = new System.Drawing.Size(292, 95);
            this.groupBoxInfo_CDV.TabIndex = 1;
            this.groupBoxInfo_CDV.TabStop = false;
            this.groupBoxInfo_CDV.Text = "О программе:";
            // 
            // groupBoxDeveloper_CDV
            // 
            this.groupBoxDeveloper_CDV.Controls.Add(this.labelDeveloper_CDV);
            this.groupBoxDeveloper_CDV.Location = new System.Drawing.Point(207, 113);
            this.groupBoxDeveloper_CDV.Name = "groupBoxDeveloper_CDV";
            this.groupBoxDeveloper_CDV.Size = new System.Drawing.Size(292, 128);
            this.groupBoxDeveloper_CDV.TabIndex = 2;
            this.groupBoxDeveloper_CDV.TabStop = false;
            this.groupBoxDeveloper_CDV.Text = "Разработчик:";
            // 
            // labelInfo_CDV
            // 
            this.labelInfo_CDV.AutoSize = true;
            this.labelInfo_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_CDV.Location = new System.Drawing.Point(6, 16);
            this.labelInfo_CDV.Name = "labelInfo_CDV";
            this.labelInfo_CDV.Size = new System.Drawing.Size(285, 72);
            this.labelInfo_CDV.TabIndex = 0;
            this.labelInfo_CDV.Text = "Программа создана в рамках изучения\r\nязыка программирования C#.\r\nВ программе реал" +
    "изована база данных\r\nполиклиники и взаимодействие с ней.";
            // 
            // labelDeveloper_CDV
            // 
            this.labelDeveloper_CDV.AutoSize = true;
            this.labelDeveloper_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeveloper_CDV.Location = new System.Drawing.Point(6, 16);
            this.labelDeveloper_CDV.Name = "labelDeveloper_CDV";
            this.labelDeveloper_CDV.Size = new System.Drawing.Size(297, 105);
            this.labelDeveloper_CDV.TabIndex = 0;
            this.labelDeveloper_CDV.Text = "Чурин Д.В.\r\nгруппа ИСТНб-23-1\r\n\r\nТюменский индустриальный университет (c) 2023\r\nВ" +
    "ысшая школа цифровых технологий (c) 2023\r\n\r\nВнутрнее имя: Tyuiu.ChurinDV.Sprint7" +
    ".Project.V6\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 242);
            this.Controls.Add(this.groupBoxDeveloper_CDV);
            this.Controls.Add(this.groupBoxInfo_CDV);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInfo_CDV.ResumeLayout(false);
            this.groupBoxInfo_CDV.PerformLayout();
            this.groupBoxDeveloper_CDV.ResumeLayout(false);
            this.groupBoxDeveloper_CDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInfo_CDV;
        private System.Windows.Forms.Label labelInfo_CDV;
        private System.Windows.Forms.GroupBox groupBoxDeveloper_CDV;
        private System.Windows.Forms.Label labelDeveloper_CDV;
    }
}