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
using Hl7.Fhir.Rest;

namespace IwM
{
    public partial class EditForm : Form
    {
        private Patient patient;
        private List<Observation> data;
        private BindingSource bindingSource1 = new BindingSource();
        private FhirOperations db;
        // redundant
        public static string FhirClientEndPoint = "http://localhost:8080/baseDstu3/";
        private FhirClient _client;

        public EditForm(Patient patient, List<Observation> bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
            //redundant
            _client = new FhirClient(FhirClientEndPoint);
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string column = dataGridView1.Columns[e.ColumnIndex].Name.ToString();
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            switch (e.ColumnIndex) {
                case 1:
                    FhirDateTime dt = new FhirDateTime(value);
                    data[e.RowIndex].Effective = dt;
                    _client.Update<Observation>(data[e.RowIndex]);
                    
                    //db.updateEffective(dt,ob);
                    break;
                case 2:
                    Code c = new Code(value);
                    Hl7.Fhir.Model.ObservationStatus os = new Hl7.Fhir.Model.ObservationStatus();
                   // data[e.RowIndex].Status = c;
                    break;

                case 3:
                    CodeableConcept cc = new CodeableConcept();
                    cc.Text = value;
                    data[e.RowIndex].Interpretation = cc;
                    _client.Update<Observation>(data[e.RowIndex]);
                    break;
                         

            }
            Console.WriteLine(value);
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            string patientName = /*patient.Id + " " + */patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
            titleLabel.Text = "Edycja danych pacjenta: " + patientName;
            DataTable _myDataTable = new DataTable();

            _myDataTable.Columns.Add("Id");
            _myDataTable.Columns[0].ReadOnly = true;
            _myDataTable.Columns.Add("Effective");
            _myDataTable.Columns.Add("Status");
            _myDataTable.Columns.Add("Interpretation");
            foreach (var obs in data)
            {
                DataRow row = _myDataTable.NewRow();
                
                var effective = obs.Effective;
                var status = obs.Status;

                var interpretation = "";
                try
                {
                    interpretation = obs.Interpretation.Text;
                }
                catch (System.NullReferenceException) { }
                var performer = "";
                try
                {
                    performer = obs.Performer.FirstOrDefault().Display;
                }
                catch (System.NullReferenceException) { }
                row[0] = obs.Id;
                row[1] = effective;
                row[2] = status;
                row[3] = interpretation;
                _myDataTable.Rows.Add(row);
            }
            bindingSource1.DataSource = _myDataTable;
            dataGridView1.DataSource = bindingSource1;

        }

    }
}

public class a
{
    string one;
    int two;
    public a(string o, int t)
    {
        this.one = o;
        this.two = t;
    }
}
