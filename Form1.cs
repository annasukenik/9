using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _9.FolderModel;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2AddData form2 = new Form2AddData();
            form2.Show();
            Hide();
        }

        private void Form1Show_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            studentDataGridView.DataSource = model.Student.ToList();
        }
    }
}
