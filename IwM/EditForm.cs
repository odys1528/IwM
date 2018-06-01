using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;

namespace IwM
{
    public partial class EditForm : Form
    {
        private Patient patient;
        private Bundle data;

        public EditForm(Patient patient, Bundle bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
            titleLabel.Text = "Edycja danych pacjenta: " + patientName;
        }

    }
}
