using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagelocation
{
    public partial class Form2 : Form
    {
        public byte highThreshold;
        public byte lowThreshold;

        public Form2()
        {
            InitializeComponent();
        }

        private void tbrLowThreshold_Scroll(object sender, EventArgs e)
        {
            lblValueLowThresh.Text = tbrLowThreshold.Value.ToString();
        }

        private void tbrHighThreshold_Scroll(object sender, EventArgs e)
        {
            lblValueHighThresh.Text = tbrHighThreshold.Value.ToString();
        }

        private void btnOKThreshold_Click(object sender, EventArgs e)
        {
            lowThreshold = Convert.ToByte(tbrLowThreshold.Value);
            highThreshold = Convert.ToByte(tbrHighThreshold.Value);
            this.Close();
        }
    }
}
