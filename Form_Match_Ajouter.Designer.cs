﻿namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Match_Ajouter
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_DateRencontre = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NumeroMatch = new System.Windows.Forms.TextBox();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TB_ScoreHome = new System.Windows.Forms.TextBox();
            this.TB_ScoreVisiteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Visiteur = new System.Windows.Forms.ComboBox();
            this.CB_HOME = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(32, 288);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 14;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero du Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Équipe Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Équipe Visiteur";
            // 
            // DTP_DateRencontre
            // 
            this.DTP_DateRencontre.Location = new System.Drawing.Point(114, 144);
            this.DTP_DateRencontre.Name = "DTP_DateRencontre";
            this.DTP_DateRencontre.Size = new System.Drawing.Size(132, 20);
            this.DTP_DateRencontre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Rencontre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lieu";
            // 
            // TB_NumeroMatch
            // 
            this.TB_NumeroMatch.Enabled = false;
            this.TB_NumeroMatch.Location = new System.Drawing.Point(114, 29);
            this.TB_NumeroMatch.Name = "TB_NumeroMatch";
            this.TB_NumeroMatch.Size = new System.Drawing.Size(132, 20);
            this.TB_NumeroMatch.TabIndex = 1;
            // 
            // TB_Lieu
            // 
            this.TB_Lieu.Location = new System.Drawing.Point(114, 179);
            this.TB_Lieu.MaxLength = 40;
            this.TB_Lieu.Name = "TB_Lieu";
            this.TB_Lieu.Size = new System.Drawing.Size(132, 20);
            this.TB_Lieu.TabIndex = 9;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(162, 288);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // TB_ScoreHome
            // 
            this.TB_ScoreHome.Location = new System.Drawing.Point(114, 218);
            this.TB_ScoreHome.MaxLength = 40;
            this.TB_ScoreHome.Name = "TB_ScoreHome";
            this.TB_ScoreHome.Size = new System.Drawing.Size(132, 20);
            this.TB_ScoreHome.TabIndex = 11;
            this.TB_ScoreHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ScoreHome_KeyPress);
            // 
            // TB_ScoreVisiteur
            // 
            this.TB_ScoreVisiteur.Location = new System.Drawing.Point(114, 256);
            this.TB_ScoreVisiteur.MaxLength = 40;
            this.TB_ScoreVisiteur.Name = "TB_ScoreVisiteur";
            this.TB_ScoreVisiteur.Size = new System.Drawing.Size(132, 20);
            this.TB_ScoreVisiteur.TabIndex = 13;
            this.TB_ScoreVisiteur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ScoreHome_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Score Home";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Score Visiteur";
            // 
            // CB_Visiteur
            // 
            this.CB_Visiteur.FormattingEnabled = true;
            this.CB_Visiteur.Location = new System.Drawing.Point(114, 106);
            this.CB_Visiteur.Name = "CB_Visiteur";
            this.CB_Visiteur.Size = new System.Drawing.Size(132, 21);
            this.CB_Visiteur.TabIndex = 5;
            // 
            // CB_HOME
            // 
            this.CB_HOME.FormattingEnabled = true;
            this.CB_HOME.Location = new System.Drawing.Point(114, 63);
            this.CB_HOME.Name = "CB_HOME";
            this.CB_HOME.Size = new System.Drawing.Size(132, 21);
            this.CB_HOME.TabIndex = 3;
            // 
            // Form_Match_Ajouter
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(261, 323);
            this.Controls.Add(this.CB_HOME);
            this.Controls.Add(this.CB_Visiteur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_ScoreVisiteur);
            this.Controls.Add(this.TB_ScoreHome);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.TB_Lieu);
            this.Controls.Add(this.TB_NumeroMatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTP_DateRencontre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Match_Ajouter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Match_Ajouter_FormClosed);
            this.Load += new System.EventHandler(this.Form_Match_Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_DateRencontre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NumeroMatch;
        private System.Windows.Forms.TextBox TB_Lieu;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_ScoreHome;
        private System.Windows.Forms.TextBox TB_ScoreVisiteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Visiteur;
        private System.Windows.Forms.ComboBox CB_HOME;
    }
}