
namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.toolTip_CDV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogInfo_CDV = new System.Windows.Forms.OpenFileDialog();
            this.buttonPatients_CDV = new System.Windows.Forms.Button();
            this.buttonDoctors_CDV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CDV.Image")));
            this.buttonHelp_CDV.Location = new System.Drawing.Point(822, 12);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(50, 50);
            this.buttonHelp_CDV.TabIndex = 0;
            this.toolTip_CDV.SetToolTip(this.buttonHelp_CDV, "Сведение о программе");
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // toolTip_CDV
            // 
            this.toolTip_CDV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_CDV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogInfo_CDV
            // 
            this.openFileDialogInfo_CDV.FileName = "openFileDialog1";
            // 
            // buttonPatients_CDV
            // 
            this.buttonPatients_CDV.BackColor = System.Drawing.Color.White;
            this.buttonPatients_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatients_CDV.Location = new System.Drawing.Point(320, 180);
            this.buttonPatients_CDV.Name = "buttonPatients_CDV";
            this.buttonPatients_CDV.Size = new System.Drawing.Size(220, 70);
            this.buttonPatients_CDV.TabIndex = 1;
            this.buttonPatients_CDV.Text = "База пациентов";
            this.buttonPatients_CDV.UseVisualStyleBackColor = false;
            this.buttonPatients_CDV.Click += new System.EventHandler(this.buttonPatients_CDV_Click);
            // 
            // buttonDoctors_CDV
            // 
            this.buttonDoctors_CDV.BackColor = System.Drawing.Color.White;
            this.buttonDoctors_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoctors_CDV.Location = new System.Drawing.Point(320, 256);
            this.buttonDoctors_CDV.Name = "buttonDoctors_CDV";
            this.buttonDoctors_CDV.Size = new System.Drawing.Size(220, 70);
            this.buttonDoctors_CDV.TabIndex = 2;
            this.buttonDoctors_CDV.Text = "База врачей";
            this.buttonDoctors_CDV.UseVisualStyleBackColor = false;
            this.buttonDoctors_CDV.Click += new System.EventHandler(this.buttonDoctors_CDV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonDoctors_CDV);
            this.Controls.Add(this.buttonPatients_CDV);
            this.Controls.Add(this.buttonHelp_CDV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_CDV;
        private System.Windows.Forms.ToolTip toolTip_CDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogInfo_CDV;
        private System.Windows.Forms.Button buttonPatients_CDV;
        private System.Windows.Forms.Button buttonDoctors_CDV;
    }
}

