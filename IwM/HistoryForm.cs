﻿using Hl7.Fhir.Model;
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
        List<Observation> observations;
        List<Medication> medications;
        List<MedicationStatement> medicationStatements;
        BindingSource bs;

        public HistoryForm(Patient patient, Bundle bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
            bs = new BindingSource();
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

        private void fillGridWithData(int mode)
        {
            bs.Clear();
            if (mode == 0 || mode == 1)
                foreach (var o in observations)
                {
                    //bs.Add(o);
                    TableRecord tr = new TableRecord("Observation","2018-06-07","nana");
                    bs.Add(tr);
                }

            if (mode == 0 || mode == 2)
                foreach (var m in medications)
                {
                    //bs.Add(m);
                    TableRecord tr = new TableRecord("Medication", "2018-06-07", "nana");
                    bs.Add(tr);
                }

            if (mode == 0 || mode == 3)
                foreach (var ms in medicationStatements)
                {
                    //bs.Add(ms);
                    TableRecord tr = new TableRecord("Medication Statement", "2018-06-07", "nana");
                    bs.Add(tr);
                }
            historyDataGridView.DataSource = bs;
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
    }
}
