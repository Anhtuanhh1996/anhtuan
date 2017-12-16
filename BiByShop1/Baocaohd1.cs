﻿using BiByShop1.reports;
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
    public partial class Baocaohd1 : Form
    {
        public Baocaohd1()
        {
            InitializeComponent();
        }
        public void ShowReport(string reportFileName, string reportTitle, DateTime Ngaytao,string Nguoilap)
        {
            CRPBaocaohd rpt = new CRPBaocaohd();
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

            crParameterDiscreteValue.Value = Ngaytao.ToString("dd/MM/yyyy");
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@Ngay"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            

            ParameterFieldDefinitions crParameterFieldDefinitions1;
            ParameterFieldDefinition crParameterFieldDefinition1;
            ParameterValues crParameterValues1 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();

            crParameterDiscreteValue1.Value = Nguoilap;
            crParameterFieldDefinitions1 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition1 = crParameterFieldDefinitions1["nguoilap"];
            crParameterValues1 = crParameterFieldDefinition1.CurrentValues;

            crParameterValues1.Clear();
            crParameterValues1.Add(crParameterDiscreteValue1);
            crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);
            if (!string.IsNullOrEmpty(reportTitle))
            {
                rpt.SummaryInfo.ReportTitle = reportTitle;

            }
            CRVBaocaohd.ReportSource = rpt;
            #endregion
            
            
        }
    }
}
