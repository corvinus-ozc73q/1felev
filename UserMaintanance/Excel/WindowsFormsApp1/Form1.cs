using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> lakasok;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;

          
        }
        public void LoadData()
        {
            lakasok = context.Flat.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
