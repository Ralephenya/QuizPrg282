using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace W2D1_Git_execrise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            BindingSource binding = new BindingSource();
            string filepath = @"information.txt";
            string line;



            using (StreamReader reader = new StreamReader(filepath))
            {
                while ((line = reader.ReadLine())!= null)
                {
                    info.Add(line);
                }
            }

            binding.DataSource = info;

            listBox1.DataSource = binding;

        }
    }
}
