using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class LMS : Form
    {
        private static readonly List<Student> studentList = new List<Student>();
        
        public LMS()
        {
            InitializeComponent();
        }

        private void LMS_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            LoadColumns();
        }

        public void PopulateGrid()
        {
            dataGridView1.Rows.Add(1, "John Smith", 3.7);
            dataGridView1.Rows.Add(2, "Chris Jones", 2.5);
            studentList.Add(new Student(1, "John Smith", 3.7M));
            studentList.Add(new Student(2, "Chris Jones", 2.5M));
        }

        private void LoadColumns()
        {
            dataGridView1.Rows.Clear();
            foreach (var entry in studentList)
            {
                dataGridView1.Rows.Add(entry.StudentID, entry.StudentName, entry.GPA);
            }
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox_StudentID.Text, textBox_Name.Text, textBox_GPA.Text);
            studentList.Add(new Student(Convert.ToInt32(textBox_StudentID.Text), textBox_Name.Text,Convert.ToDecimal(textBox_GPA.Text)));
            textBox_StudentID.Clear();
            textBox_Name.Clear();
            textBox_GPA.Clear();

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var input = MessageBox.Show("Are you sure you want to remove data?", "Data removed", MessageBoxButtons.YesNo);
            
            if (input == DialogResult.Yes)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                studentList.RemoveAt(row);
            }
            LoadColumns();
            
        }

        
       

    }
}
