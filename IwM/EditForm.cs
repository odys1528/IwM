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
        private BindingSource bindingSource1 = new BindingSource();

        public EditForm(Patient patient, List<Observation> bundle)
        {
            InitializeComponent();
            this.patient = patient;
            this.data = bundle;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string column = dataGridView1.Columns[e.ColumnIndex].Name.ToString();
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            Console.WriteLine(id.ToString());
            Console.WriteLine(column.ToString());
            Console.WriteLine(value);
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            string patientName = patient.Id + " " + patient.Name[0].Given.FirstOrDefault() + " " + patient.Name.First().Family;
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
                var performer="";
                try
                {
                    performer = obs.Performer.FirstOrDefault().Display;
                }
                catch (System.NullReferenceException) {}
                var effective = obs.Effective;
                var status = obs.Status;
                var interpretation = obs.Interpretation;
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
