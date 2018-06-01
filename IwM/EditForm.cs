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
        private List<Observation> data;

        public EditForm(Patient patient, List<Observation> bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
            titleLabel.Text = "Edycja danych pacjenta: " + patientName;

            foreach (var obs in data)
            {
                var performer="";
                try
                {
                    performer = obs.Performer.FirstOrDefault().Display;
                }
                catch (System.NullReferenceException) {}
                var effective = obs.Effective;
                var status = obs.Status;
                var interpretation = obs.Interpretation;
            }
        }

    }
}
