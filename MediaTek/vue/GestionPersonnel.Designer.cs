namespace MediaTek.vue
{
    partial class GestionPersonnel
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblGauche = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblDroit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.DPickDebut = new System.Windows.Forms.DateTimePicker();
            this.DPickFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNom.Location = new System.Drawing.Point(54, 117);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 32);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(60, 159);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 31);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(287, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(278, 31);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrenom.Location = new System.Drawing.Point(281, 117);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(100, 32);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(505, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(54, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse mail";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblService.Location = new System.Drawing.Point(281, 306);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(92, 32);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(60, 347);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 31);
            this.txtTel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(54, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Téléphone";
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(287, 347);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(278, 33);
            this.cboServices.TabIndex = 15;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprimer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(60, 720);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(505, 68);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.DimGray;
            this.btnModifier.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(320, 635);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(245, 68);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.BackColor = System.Drawing.Color.Indigo;
            this.lblGauche.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGauche.ForeColor = System.Drawing.Color.White;
            this.lblGauche.Location = new System.Drawing.Point(169, 25);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(293, 37);
            this.lblGauche.TabIndex = 20;
            this.lblGauche.Text = "FICHE DU PERSONNEL";
            this.lblGauche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.White;
            this.btnSwitch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.ForeColor = System.Drawing.Color.Indigo;
            this.btnSwitch.Location = new System.Drawing.Point(60, 805);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(505, 68);
            this.btnSwitch.TabIndex = 21;
            this.btnSwitch.Text = "VOIR LES ABSENCES  →";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblDroit
            // 
            this.lblDroit.AutoSize = true;
            this.lblDroit.BackColor = System.Drawing.Color.Indigo;
            this.lblDroit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroit.ForeColor = System.Drawing.Color.White;
            this.lblDroit.Location = new System.Drawing.Point(436, 25);
            this.lblDroit.Name = "lblDroit";
            this.lblDroit.Size = new System.Drawing.Size(310, 37);
            this.lblDroit.TabIndex = 22;
            this.lblDroit.Text = "LISTE DES PERSONNELS";
            this.lblDroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.lblGauche);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 86);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.lblDroit);
            this.panel3.Location = new System.Drawing.Point(630, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 86);
            this.panel3.TabIndex = 25;
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPersonnels.Location = new System.Drawing.Point(630, 117);
            this.dgvPersonnels.MultiSelect = false;
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 82;
            this.dgvPersonnels.RowTemplate.Height = 33;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(1178, 757);
            this.dgvPersonnels.TabIndex = 26;
            this.dgvPersonnels.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnels_CellEnter);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Indigo;
            this.btnAjouter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(60, 635);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(245, 68);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVider.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.Gray;
            this.btnVider.Location = new System.Drawing.Point(473, 412);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(92, 45);
            this.btnVider.TabIndex = 27;
            this.btnVider.Text = "VIDER";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::MediaTek.Properties.Resources.refresh_pp;
            this.picRefresh.Location = new System.Drawing.Point(407, 412);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(60, 45);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 29;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // cboMotifs
            // 
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(60, 441);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(505, 33);
            this.cboMotifs.TabIndex = 54;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMotif.Location = new System.Drawing.Point(54, 399);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(74, 32);
            this.lblMotif.TabIndex = 53;
            this.lblMotif.Text = "Motif";
            // 
            // DPickDebut
            // 
            this.DPickDebut.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickDebut.Font = new System.Drawing.Font("Yu Gothic UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickDebut.Location = new System.Drawing.Point(60, 253);
            this.DPickDebut.MaxDate = new System.DateTime(2120, 1, 1, 0, 0, 0, 0);
            this.DPickDebut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DPickDebut.Name = "DPickDebut";
            this.DPickDebut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DPickDebut.Size = new System.Drawing.Size(505, 35);
            this.DPickDebut.TabIndex = 52;
            // 
            // DPickFin
            // 
            this.DPickFin.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickFin.Font = new System.Drawing.Font("Yu Gothic UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickFin.Location = new System.Drawing.Point(60, 347);
            this.DPickFin.MaxDate = new System.DateTime(2120, 1, 1, 0, 0, 0, 0);
            this.DPickFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DPickFin.Name = "DPickFin";
            this.DPickFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DPickFin.Size = new System.Drawing.Size(505, 35);
            this.DPickFin.TabIndex = 51;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDateFin.Location = new System.Drawing.Point(54, 305);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(138, 32);
            this.lblDateFin.TabIndex = 50;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDateDebut.Location = new System.Drawing.Point(54, 211);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(172, 32);
            this.lblDateDebut.TabIndex = 49;
            this.lblDateDebut.Text = "Date de début";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAbsences.Location = new System.Drawing.Point(630, 117);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 82;
            this.dgvAbsences.RowTemplate.Height = 33;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(1178, 757);
            this.dgvAbsences.TabIndex = 55;
            this.dgvAbsences.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsences_CellEnter);
            // 
            // GestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1810, 929);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.cboMotifs);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.DPickDebut);
            this.Controls.Add(this.DPickFin);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionPersonnel";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 25, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblDroit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.DateTimePicker DPickDebut;
        private System.Windows.Forms.DateTimePicker DPickFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}