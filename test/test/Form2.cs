using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        private Form1 form1; 

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            form1 = parentForm;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id, lastname, firstname, middle, course, year;

            id = idTxt.Text;
            firstname = firstTxt.Text;
            lastname = lastsTxt.Text;
            middle = miTxt.Text;
            course = courseTxt.GetItemText(courseTxt.SelectedItem);
            year = yearTxt.GetItemText(yearTxt.SelectedItem);

            form1.dgvClassList.Rows.Add(id, lastname, firstname, middle, course, year);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTxt.Text = "";
            firstTxt.Text = "";
            lastsTxt.Text = "";
            miTxt.Text = "";
            courseTxt.SelectedIndex = -1;
            yearTxt.SelectedIndex = -1;
        }
    }
}
