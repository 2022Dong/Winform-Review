using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Review
{
    public partial class Registration : Form
    {
        DataTable dt = new DataTable();
        string name;
        string designation;
        int salary;
        string gender;
        string review;

        string name1;


        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            designation = txtDesignation.Text;
            salary = int.Parse(txtSalary.Text);


            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (chkGood.Checked)
            {
                review = "Good";
            }
            else
            {
                review = "Very Good";
            }
            display();
            empty();

         //   lblDisplay.Text = name + " " + designation + " " + salary + " " + gender + " " + review;
         //MessageBox.Show(" Your name is : " + name + " Your designation is : " + designation + " Your salary is : " + salary);
        }

        // make a method for dt
        public void display()
        {
            dt.Columns.Add(" Name ");
            dt.Columns.Add(" Designation ");
            dt.Columns.Add(" Salary ");
            dt.Columns.Add(" Gender ");
            dt.Columns.Add(" Review ");

            DataRow dr = dt.NewRow(); // make an object - DataRow
            dr[0] = name;
            dr[1] = designation;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = review;

            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt; // initialise
        }

        // Empty textBoxs.
        public void empty()
        {
            txtName.Text = "";
            txtDesignation.Text = "";
            txtSalary.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.Add(" C# Programming");
            cmbCourse.Items.Add(" C++ Programming");
            cmbCourse.Items.Add(" C Programming");
            cmbCourse.Items.Add(" Java Programming");
            cmbCourse.Items.Add(" PHP Programming");
        }

        // cmb -> properties -> double click SelectedIndexChanged
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            name1 = cmbCourse.SelectedItem.ToString();            
        }

        private void btnCmb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name1);
        }
    }
}
