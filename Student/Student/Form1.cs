using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class FormStudent : Form
    {
        Student student1 = new Student(); // объект класса Студент

        public FormStudent()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; // сохранить текст 
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text; //сохранить № студбилета
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void textGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = textBoxGruppa.Text; //сохранить группу
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value; //сохранить курс
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //сохранить бюджет/коммерческое
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }
    }
}
