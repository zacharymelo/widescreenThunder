using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace widescreenThunder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //This does not sync with our students.xml that exists already
            DataTable studentTable = new DataTable();
            studentTable.TableName = "Student";

            DataColumn studentsName = new DataColumn();
            DataColumn studentsHours = new DataColumn();
            DataColumn studentsID = new DataColumn();

            studentTable.Columns.Add(studentsName);
            studentTable.Columns.Add(studentsHours);
            studentTable.Columns.Add(studentsID);

            studentTable.Rows.Add("Ryan", "13", "01");
            studentTable.Rows.Add("Ryan", "13", "02");
            studentTable.Rows.Add("Ryan", "13", "03");

            DataSet studentsDatabase = new DataSet();
            studentsDatabase.DataSetName = "Students";
            studentsDatabase.Tables.Add(studentTable);

            studentsDatabase.WriteXml("students2.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
