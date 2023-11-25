using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class PCSitStatusForm : Form
    {
        string selectedSitNo;
        string selectedSitPower;
        string selectedSitMalfunction;
        public PCSitStatusForm(SitManagementForm sitManagermentForm)
        {
           
            InitializeComponent();
            selectedSitNo = sitManagermentForm.SitIDArray[sitManagermentForm.SelectedSitNoIndex];
            selectedSitPower = sitManagermentForm.SitPowerArray[sitManagermentForm.SelectedSitNoIndex];
            selectedSitMalfunction = sitManagermentForm.SitMalfunctionArray[sitManagermentForm.SelectedSitNoIndex];
            txtSelectedSitNo.Text = selectedSitNo;
            txtSitPower.Text = selectedSitPower;
            txtSitMalfunction.Text = selectedSitMalfunction;
        }


    }
}
