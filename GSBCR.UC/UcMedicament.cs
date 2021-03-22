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
    public partial class UcMedicament : UserControl
    {
        private MEDICAMENT leMedicament = null;
        public MEDICAMENT LeMedicament
        {
            get { return leMedicament; }
            set
            {
                leMedicament = value;
                if (leMedicament != null)
                {
                    ucMedicament_actualiser();
                }
            }
        }
        private void ucMedicament_actualiser()
        {
            txtDepot.Text = leMedicament.MED_DEPOTLEGAL;
            txtNom.Text = leMedicament.MED_NOMCOMMERCIAL;
            txtFam1.Text = leMedicament.FAM_CODE;
            txtFam2.Text = leMedicament.LaFamille.FAM_LIBELLE;
            txtCompo.Text = leMedicament.MED_COMPOSITION;
            txtContre.Text = leMedicament.MED_CONTREINDIC;
            txtEffets.Text = leMedicament.MED_EFFETS;
            txtPrix.Text = leMedicament.MED_PRIXECHANTILLON.ToString();
        }

        public UcMedicament()
        {
            InitializeComponent();
        }


    }
}
