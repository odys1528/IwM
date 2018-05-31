using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwM
{
    public partial class HistoryForm : Form
    {
        private Patient patient;
        private Bundle data;

        public HistoryForm(Patient patient, Bundle bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
            titleLabel.Text = "Karta pacjenta: " + patientName;
        }
    }
}
