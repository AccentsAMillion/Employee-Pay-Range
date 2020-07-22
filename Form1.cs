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


namespace Wk2EmployeePayRage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile()
        {
            OpenFileDialog openfd = new OpenFileDialog();

        }

        //Save Button
             private void button2Save_Click(object sender, EventArgs e)
        {
            string employeeCollection ="";
            employeeCollection += textBox1Name.Text + "%";
            employeeCollection += textBox2EmpNo.Text + "%";
            employeeCollection += textBox3PayRate.Text + "%";
            employeeCollection += textBox4Hours.Text;
            saveFile(employeeCollection);           
        }

        private void  saveFile(string record)
        {
            SaveFileDialog savefd = new SaveFileDialog();
            var filePath = savefd.ShowDialog();

            StreamWriter sw = new StreamWriter(savefd.FileName);
            sw.WriteLine(record);
            sw.Flush();
            sw.Close();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            string loadEmployeeOutput;

            loadEmployeeOutput = textBox1Name.Text +
                "\n" + textBox2EmpNo.Text +
                "\n" + textBox3PayRate.Text +
                "\n" + textBox4Hours.Text;

            MessageBox.Show(loadEmployeeOutput, "Employee Data");
        }

        public void label6_Click(object sender, EventArgs e)
        {
            int totalPay;

            totalPay = textBox3PayRate + textBox4Hours;

            Message.Equals(totalPay);
        }
    }
}
