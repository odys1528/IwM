using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IwM
{
    public partial class HistoryForm : Form
    {
        private Patient patient;
        private Bundle data;
        List<Observation> observations;
        List<Medication> medications;
        List<MedicationStatement> medicationStatements;
        BindingSource bs;
        HashSet<string> types;

        public HistoryForm(Patient patient, Bundle bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
            bs = new BindingSource();
            types = new HashSet<string>();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
            titleLabel.Text = "Karta pacjenta: " + patientName;

            dataTypeComboBox.Items.Add("wszystkie");
            dataTypeComboBox.Items.Add("Observation");
            dataTypeComboBox.Items.Add("Medication");
            dataTypeComboBox.Items.Add("Medication Statement");
            dataTypeComboBox.SelectedIndex = 0;

            getPatientData();
            fillGridWithData(0);
        }

        private void dataTypeButton_Click(object sender, EventArgs e)
        {
            fillGridWithData(dataTypeComboBox.SelectedIndex);
            if (dataTypeComboBox.SelectedIndex > 0)
            {
                chartTypeComboBox.Enabled = true;
                chartButton.Enabled = true;
            }
            else
            {
                chartTypeComboBox.Enabled = false;
                chartButton.Enabled = false;
            }
        }

        private void getPatientData()
        {
            Patient p = patient;
            observations = new List<Observation>();
            medications = new List<Medication>();
            medicationStatements = new List<MedicationStatement>();

            Hl7.Fhir.Model.Bundle ReturnedBundle = data;
            foreach (var Entry in ReturnedBundle.Entry)
            {
                if (Entry.Resource is Patient)
                {
                    p = (Patient)Entry.Resource;
                }
                if (Entry.Resource is Observation)
                    observations.Add((Observation)Entry.Resource);
                if (Entry.Resource is Medication)
                    medications.Add((Medication)Entry.Resource);
                if (Entry.Resource is MedicationStatement)
                    medicationStatements.Add((MedicationStatement)Entry.Resource);

                //Console.WriteLine(string.Format("{0}/{1}", Entry.Resource.TypeName, Entry.Resource.Id));
            }
            //Console.WriteLine(string.Format("{0} {1}", p.Name.First().Given.FirstOrDefault(), p.Name.First().Family));
            //Period a = medicationStatements[0].Effective as Period;
            //Console.WriteLine(string.Format("{0}", a.Start));
        }

        private void updateChartTypes()
        {
            chartTypeComboBox.Items.Clear();
            foreach (var t in types)
            {
                chartTypeComboBox.Items.Add(t);
            }
        }

        private void fillGridWithData(int mode)
        {
            bs.Clear();
            types.Clear();
            if (mode == 0 || mode == 1)
                foreach (var o in observations)
                {
                    TableRecord tr = new TableRecord("Observation",o.Effective.ToString(), o.Code.Text);
                    bs.Add(tr);
                    types.Add(o.Code.Text);
                }

            if (mode == 0 || mode == 2)
                foreach (var m in medications)
                {
                    TableRecord tr = new TableRecord("Medication", "brak", m.Ingredient.ToString());
                    bs.Add(tr);
                    types.Add(m.Ingredient.ToString());
                }

            if (mode == 0 || mode == 3)
                foreach (var ms in medicationStatements)
                {
                    TableRecord tr = new TableRecord("Medication Statement", ms.Effective.ToString(), ms.BasedOn.ToString());
                    bs.Add(tr);
                    types.Add(ms.BasedOn.ToString());
                }
            historyDataGridView.DataSource = bs;
            updateChartTypes();
        }

        private class TableRecord
        {
            public string type { get; set; }
            public string date { get; set; }
            public string desc { get; set; }

            public TableRecord(string type, string date, string desc)
            {
                this.type = type;
                this.date = date;
                this.desc = desc;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if(dataTypeComboBox.SelectedIndex != 2)
            {
                BindingSource filter = new BindingSource();
                DateTime start = fromDateTimePicker.Value;
                DateTime end = toDateTimePicker.Value;

                historyDataGridView.DataSource = bs;

                foreach (DataGridViewRow row in historyDataGridView.Rows)
                {
                    DateTime x = DateTime.Parse(row.Cells["date"].Value.ToString());
                    if (x >= start && x <= end)
                    {
                        filter.Add(new TableRecord(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()));
                    }
                }

                historyDataGridView.DataSource = filter;
            }
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            if (dataTypeComboBox.SelectedIndex == 1)
            {
                string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
                ChartForm form = new ChartForm(patientName, chartTypeComboBox.SelectedItem.ToString(), observations);
                form.ShowDialog();
            }
        }
    }
}
