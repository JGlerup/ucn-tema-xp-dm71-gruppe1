using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIBooking : UserControl
    {
        private ServiceReference1.IService1 service;
        public GUIBooking()
        {
            service = new ServiceReference1.Service1Client();
            InitializeComponent();
            populateCmbShow();
            
        }

        private void populateCmbShow()
        {
            
            try
            {
                cmbForestilling.DataSource = service.FindAllShows(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
            }
        }

        private void GUIBooking_Enter(object sender, EventArgs e)
        {
            populateCmbShow();
        }

        private void populateCmbCinema()
        {
            Show s = (Show) cmbForestilling.SelectedItem;
            cmbCinema.DataSource = s.Cinemas;

        }

        private void cmbTickets_SelectedValueChanged(object sender, EventArgs e)
        {
            populateCmbCinema();
        }

        private void cmbForestilling_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

