using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void chartControl1_BoundDataChanged(object sender, EventArgs e)
        {
            ChartControl cc = sender as ChartControl;
            foreach (Series s in cc.Series)
            {
                if (Convert.ToInt32(s.Name) > 5)
                    s.Visible = false;

            }
        }
    }
}