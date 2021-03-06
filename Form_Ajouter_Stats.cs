﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Ajouter_Stats : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public string equipeHome = null;
        public string equipeVisiteur = null;

        public Form_Ajouter_Stats()
        {
            InitializeComponent();
        }

        public string numJoueurs
        {
            get
            {
                return CB_NumJoueurs.Text;
            }
            set
            {
                CB_NumJoueurs.Text = value;
            }
        }
        public string numMatch
        {
            get
            {
                return TB_NumMatch.Text;
            }
            set
            {
                TB_NumMatch.Text = value;
            }
        }
        public string nbButs
        {
            get
            {
                return TB_NbButs.Text;
            }
            set
            {
                TB_NbButs.Text = value;
            }
        }
        public string nbPasses
        {
            get
            {
                return TB_NbPasses.Text;
            }
            set
            {
                TB_NbPasses.Text = value;
            }
        }
        public string tempsPunition
        {
            get
            {
                return TB_TempsPunition.Text;
            }
            set
            {
                TB_TempsPunition.Text = value;
            }
        }

        private void Form_Ajouter_Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Ajouter_Stats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_Ajouter_Stats_Load(object sender, EventArgs e)
        {
            try
            {
                OracleCommand oraSelect = conn.CreateCommand();
                oraSelect.CommandText = "SELECT NumeroJoueurs FROM Joueurs where EquipeJoueur = :equipeHome or EquipeJoueur = :equipeVisiteur";
                OracleParameter OraParaEquipeHome = new OracleParameter(":equipeHome", OracleDbType.Varchar2, 40);
                OracleParameter OraParaEquipeVisiteur = new OracleParameter(":equipeVisiteur", OracleDbType.Varchar2, 40);
                OraParaEquipeHome.Value = equipeHome;
                OraParaEquipeVisiteur.Value = equipeVisiteur;
                oraSelect.Parameters.Add(OraParaEquipeHome);
                oraSelect.Parameters.Add(OraParaEquipeVisiteur);

                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumJoueurs.Items.Add(oraReader.GetInt32(0));
                    }
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());  
            }
        }
    }
}
