﻿namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class FormDivision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDivision));
            this.DGV_Division = new System.Windows.Forms.DataGridView();
            this.CMS_Division = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Division = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Deconnexion = new System.Windows.Forms.Button();
            this.BTN_QUITTER = new System.Windows.Forms.Button();
            this.BTN_AfficheMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Division)).BeginInit();
            this.CMS_Division.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Division
            // 
            this.DGV_Division.AllowUserToAddRows = false;
            this.DGV_Division.AllowUserToDeleteRows = false;
            this.DGV_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Division.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Division.ContextMenuStrip = this.CMS_Division;
            this.DGV_Division.Location = new System.Drawing.Point(12, 44);
            this.DGV_Division.MultiSelect = false;
            this.DGV_Division.Name = "DGV_Division";
            this.DGV_Division.ReadOnly = true;
            this.DGV_Division.RowHeadersVisible = false;
            this.DGV_Division.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Division.Size = new System.Drawing.Size(245, 126);
            this.DGV_Division.TabIndex = 0;
            this.DGV_Division.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Division_CellMouseDoubleClick);
            // 
            // CMS_Division
            // 
            this.CMS_Division.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.CMS_Division.Name = "CMS_Division";
            this.CMS_Division.Size = new System.Drawing.Size(168, 76);
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.voirToolStripMenuItem.ShowShortcutKeys = false;
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.voirToolStripMenuItem.Text = "&Voir";
            this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.ShowShortcutKeys = false;
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Division});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Division
            // 
            this.TSMI_Division.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.TSMI_Division.Name = "TSMI_Division";
            this.TSMI_Division.Size = new System.Drawing.Size(54, 20);
            this.TSMI_Division.Text = "Fichier";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(301, 44);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 2;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modifier.Location = new System.Drawing.Point(301, 98);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 3;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete.Location = new System.Drawing.Point(301, 147);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Deconnexion
            // 
            this.BTN_Deconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Deconnexion.Location = new System.Drawing.Point(182, 194);
            this.BTN_Deconnexion.Name = "BTN_Deconnexion";
            this.BTN_Deconnexion.Size = new System.Drawing.Size(96, 23);
            this.BTN_Deconnexion.TabIndex = 5;
            this.BTN_Deconnexion.Text = "Déconnexion";
            this.BTN_Deconnexion.UseVisualStyleBackColor = true;
            this.BTN_Deconnexion.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // BTN_QUITTER
            // 
            this.BTN_QUITTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_QUITTER.Location = new System.Drawing.Point(284, 194);
            this.BTN_QUITTER.Name = "BTN_QUITTER";
            this.BTN_QUITTER.Size = new System.Drawing.Size(96, 23);
            this.BTN_QUITTER.TabIndex = 5;
            this.BTN_QUITTER.Text = "Quitter";
            this.BTN_QUITTER.UseVisualStyleBackColor = true;
            this.BTN_QUITTER.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BTN_AfficheMatch
            // 
            this.BTN_AfficheMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_AfficheMatch.Location = new System.Drawing.Point(13, 193);
            this.BTN_AfficheMatch.Name = "BTN_AfficheMatch";
            this.BTN_AfficheMatch.Size = new System.Drawing.Size(112, 23);
            this.BTN_AfficheMatch.TabIndex = 6;
            this.BTN_AfficheMatch.Text = "Afficheur De Match";
            this.BTN_AfficheMatch.UseVisualStyleBackColor = true;
            this.BTN_AfficheMatch.Click += new System.EventHandler(this.BTN_AfficheMatch_Click);
            // 
            // FormDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 229);
            this.Controls.Add(this.BTN_AfficheMatch);
            this.Controls.Add(this.BTN_QUITTER);
            this.Controls.Add(this.BTN_Deconnexion);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Division);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(408, 267);
            this.Name = "FormDivision";
            this.Text = "FormDivision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDivision_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDivision_FormClosed);
            this.Load += new System.EventHandler(this.FormDivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Division)).EndInit();
            this.CMS_Division.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Division;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Deconnexion;
        private System.Windows.Forms.ContextMenuStrip CMS_Division;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.DataGridView DGV_Division;
        private System.Windows.Forms.Button BTN_QUITTER;
        private System.Windows.Forms.Button BTN_AfficheMatch;
    }
}