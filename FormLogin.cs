﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Login : Form
    {
        private OracleConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string Dsource = "(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
               + "(HOST=205.237.244.251)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id=" + TB_Username.Text + " ; Password =" + TB_Password.Text;
                conn = new OracleConnection();
                conn.ConnectionString = ChaineConnexion;

                conn.Open();

                 if(conn.State.ToString() == "Open")
                 {
                     Cursor = Cursors.Default;
                     FormDivision fd = new FormDivision();
                     fd.conn = conn;

                     this.Hide();
                     fd.callBackForm = this;
                     fd.Show();

                 }

            }
            catch(OracleException ex)
            {
                if (ex.Number == 1017)
                {
                    Cursor = Cursors.Default;
                    LB_Username.ForeColor = Color.Red;
                    LB_MDP.ForeColor = Color.Red;
                    TB_Password.Clear();
                    TB_Password.Focus();
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Connect_Click(sender, e);
            }
        }
    }
}