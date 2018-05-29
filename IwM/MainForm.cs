﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.FhirPath;

namespace IwM
{
    public partial class MainForm : Form
    {
        FhirOperations db;

        public MainForm()
        {
            InitializeComponent();
            db = new FhirOperations();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void namesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }

        private void validateNameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                namesComboBox.Text = "";
                List<Patient> patients = db.patientsByName(nameTextBox.Text);
                namesComboBox.Items.Clear();

                foreach (var l in patients)
                {
                    namesComboBox.Items.Add(l.Id + " " + l.Name[0].Given.FirstOrDefault() + " " + l.Name.First().Family);
                }

                namesComboBox.SelectedIndex = 0;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Enabled = true;
            toDateTimePicker.Enabled = true;
            filterButton.Enabled = true;
            addButton.Enabled = true;
            chartButton.Enabled = true;
            anotherButton.Enabled = true;
        }
    }
}
