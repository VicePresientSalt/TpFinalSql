﻿namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Equipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Equipe));
            this.DGV_Equipes = new System.Windows.Forms.DataGridView();
            this.CMS_Equipe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.Flash_Classement = new FlashButton.FlashButton();
            this.FB_Top5 = new FlashButton.FlashButton();
            this.PB_Equipes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            this.CMS_Equipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.AllowUserToAddRows = false;
            this.DGV_Equipes.AllowUserToDeleteRows = false;
            this.DGV_Equipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.ContextMenuStrip = this.CMS_Equipe;
            this.DGV_Equipes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipes.MultiSelect = false;
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.ReadOnly = true;
            this.DGV_Equipes.RowHeadersVisible = false;
            this.DGV_Equipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Equipes.Size = new System.Drawing.Size(451, 253);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Equipes_CellMouseDoubleClick);
            this.DGV_Equipes.SelectionChanged += new System.EventHandler(this.DGV_Equipes_SelectionChanged);
            // 
            // CMS_Equipe
            // 
            this.CMS_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.sToolStripMenuItem});
            this.CMS_Equipe.Name = "CMS_Equipe";
            this.CMS_Equipe.Size = new System.Drawing.Size(154, 76);
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.voirToolStripMenuItem.ShowShortcutKeys = false;
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.voirToolStripMenuItem.Text = "&Voir";
            this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.ShowShortcutKeys = false;
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.sToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sToolStripMenuItem.Text = "Supprimer";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Ajouter.Location = new System.Drawing.Point(494, 154);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Modifier.Location = new System.Drawing.Point(494, 183);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Delete.Location = new System.Drawing.Point(494, 212);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(509, 337);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 4;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // Flash_Classement
            // 
            this.Flash_Classement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Flash_Classement.BackgroundImage = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo_Podium_Default;
            this.Flash_Classement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Flash_Classement.ImageClick = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo_Podium_Click;
            this.Flash_Classement.ImageDisable = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo_Podium_Wesly;
            this.Flash_Classement.ImageNeutral = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo_Podium_Default;
            this.Flash_Classement.ImageOver = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo_Podium_Over;
            this.Flash_Classement.Location = new System.Drawing.Point(279, 304);
            this.Flash_Classement.Name = "Flash_Classement";
            this.Flash_Classement.Size = new System.Drawing.Size(52, 57);
            this.Flash_Classement.TabIndex = 6;
            this.Flash_Classement.Click += new System.EventHandler(this.Flash_Classement_Click);
            // 
            // FB_Top5
            // 
            this.FB_Top5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Top5.BackgroundImage = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources._5star;
            this.FB_Top5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Top5.ImageClick = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources._5star_Click;
            this.FB_Top5.ImageDisable = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources._5star_WESLEY;
            this.FB_Top5.ImageNeutral = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources._5star;
            this.FB_Top5.ImageOver = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources._5star_Over;
            this.FB_Top5.Location = new System.Drawing.Point(119, 304);
            this.FB_Top5.Name = "FB_Top5";
            this.FB_Top5.Size = new System.Drawing.Size(62, 56);
            this.FB_Top5.TabIndex = 5;
            this.FB_Top5.Click += new System.EventHandler(this.FB_Top5_Click);
            // 
            // PB_Equipes
            // 
            this.PB_Equipes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Equipes.Location = new System.Drawing.Point(469, 12);
            this.PB_Equipes.Name = "PB_Equipes";
            this.PB_Equipes.Size = new System.Drawing.Size(117, 114);
            this.PB_Equipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Equipes.TabIndex = 4;
            this.PB_Equipes.TabStop = false;
            // 
            // Form_Equipe
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 372);
            this.Controls.Add(this.Flash_Classement);
            this.Controls.Add(this.FB_Top5);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.PB_Equipes);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Equipes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(612, 411);
            this.Name = "Form_Equipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Équipes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipe_FormClosing);
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            this.CMS_Equipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.PictureBox PB_Equipes;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.ContextMenuStrip CMS_Equipe;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private FlashButton.FlashButton FB_Top5;
        private FlashButton.FlashButton Flash_Classement;
    }
}