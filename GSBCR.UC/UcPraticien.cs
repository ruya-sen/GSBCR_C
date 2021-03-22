using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UcPraticien : UserControl
    {
        private PRATICIEN lePraticien = null;
        public PRATICIEN LePraticien
        {
            get { return lePraticien; }
            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPraticien_actualiser();
                }
            }
        }
        
        private void ucPraticien_actualiser()
        {
            txtNum.Text = lePraticien.PRA_NUM.ToString();
            txtNom.Text = lePraticien.PRA_NOM;
            txtPrenom.Text = lePraticien.PRA_PRENOM;
            txtAdresse.Text = lePraticien.PRA_ADRESSE;
            txtCp.Text = lePraticien.PRA_CP;
            txtVille.Text = lePraticien.PRA_VILLE;
            txtCoeff.Text = lePraticien.PRA_COEFNOTORIETE.ToString();
            txtCode.Text = lePraticien.TYP_CODE;
        }
        public UcPraticien()
        {
            InitializeComponent();
        }
    }
}
