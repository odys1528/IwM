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
using DevExpress.XtraCharts;

namespace IwM
{
    public partial class ChartForm : Form
    {
        List<Observation> observations;
        Dictionary<DateTime, double> seriesData;
        string dataName;

        public ChartForm(string patient, string dataName, List<Observation> observations)
        {
            InitializeComponent();
            this.observations = observations;
            titleLabel.Text = "Karta Pacjenta: " + patient;
            this.dataName = dataName;
            subtitleLabel.Text = "Dane: " + dataName;
            this.seriesData = new Dictionary<DateTime, double>();
        }

        private void getDataFromBundle()
        {
            foreach(var o in observations)
            {
                if(dataName == o.Code.Text)
                {
                    DateTime date = DateTime.Parse(o.Effective.ToString());
                    double value = valueFromObservation(o);
                    if(!seriesData.Keys.Contains(date)) seriesData.Add(date, value);
                }
                
            }
        }

        private double valueFromObservation(Observation o)
        {
            var a = FhirSerializer.SerializeResourceToXml(o);
            string b = XDocument.Parse(a).ToString();
            b = b.Substring(b.IndexOf("<value value=") + 14, 10);
            b = b.Substring(0, b.IndexOf('"'));
            b = b.Replace(".", ",");
            if (b.IndexOf(",") < 0) b = b + ",0";
            return double.Parse(b);
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            getDataFromBundle();
            fillSeriesWithData(DateTime.Parse("1900/01/01"), DateTime.Parse("3000/01/01"));
        }

        private void fillSeriesWithData(DateTime start, DateTime end)
        {
            Series series = new Series(dataName, ViewType.Line);
            series.ArgumentScaleType = ScaleType.DateTime;
            (chartControl.Diagram as XYDiagram).AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second;

            foreach(var obs in seriesData)
            {
                if(obs.Key >= start && obs.Key <= end)
                {
                    series.Points.Add(new SeriesPoint(obs.Key.ToString(), obs.Value));
                }
            }

            chartControl.Series.Clear();
            chartControl.Series.Add(series);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            fillSeriesWithData(fromDateTimePicker.Value, toDateTimePicker.Value);
        }
    }
}
