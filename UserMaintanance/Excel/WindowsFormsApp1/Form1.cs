using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using  Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        RealEstateEntities context = new RealEstateEntities();
        List<Flat> lakasok;
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;
            CreateExcel();
            CreateTable();

        }
        public void LoadData()
        {
            lakasok = context.Flat.ToList();
        }
        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {


                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

        }
        private void CreateTable();
        {

        }
        
        

        
    }
}
