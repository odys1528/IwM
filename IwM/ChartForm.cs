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
    public partial class ChartForm : Form
    {
        BindingSource bs;

        public ChartForm(string patient, string data, BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;
            titleLabel.Text = "Karta Pacjenta: " + patient;
            subtitleLabel.Text = "Dane: " + data;
        }
    }
}
