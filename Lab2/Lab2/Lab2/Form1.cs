using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1(string response)
        {
            InitializeComponent();
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(response);
            foreach (var s in students)
                listBox1.Items.Add(s.studentId + ":\t" + s.studentName);

        }
    }
}
