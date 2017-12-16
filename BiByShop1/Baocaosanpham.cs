using BiByShop1.reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BiByShop1
{
    public partial class Baocaosanpham : Form
    {
        public Baocaosanpham()
        {
            InitializeComponent();
        }

        private void Baocaosanpham_Load(object sender, EventArgs e)
        {

        }
        public void ShowReport(string reportFileName, string reportTitle, string nguoilap)
        {
            CRPSanpham rpt = new CRPSanpham();
            #region
            rpt.Load(string.Format("{0}\\Reports\\{1}", Application.StartupPath, reportFileName));
            TableLogOnInfo tli = new TableLogOnInfo();
            tli.ConnectionInfo.ServerName = "WINDOWS-S8RLUFM\\SQLEXPRESS";
            tli.ConnectionInfo.DatabaseName = "BibyShop";
            tli.ConnectionInfo.IntegratedSecurity = true;
            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tli);
            }
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = nguoilap;
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["nguoilap"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            
            #endregion
            if (!string.IsNullOrEmpty(reportTitle))
            {
                rpt.SummaryInfo.ReportTitle = reportTitle;
            }
            CRVSanpham.ReportSource = rpt;
        }
    }
}
