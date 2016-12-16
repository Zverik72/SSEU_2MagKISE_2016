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
            //вывод списка семестров
            comboBoxSemestr.Items.Clear(); //очистка списка
            //перебираем курсы с 1 до того, на котором учится студент
            for (int k = 1; k <= student1.kurs; k++)
            {
                int s1 = 2 * k - 1; //номер осеннего семестра на курсе k
                int s2 = 2 * k; //номер весеннего семестра на курсе k
                                //добавляем в список
                comboBoxSemestr.Items.Add(s1 + " семестр");
                comboBoxSemestr.Items.Add(s2 + " семестр");
            };
            //выбираем выделенный семестр - первый (отчет с 0)
            comboBoxSemestr.SelectedIndex = 0;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //сохранить бюджет/коммерческое
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz1_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 0] = (byte)numericUpDownEkz1.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz2_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 1] = (byte)numericUpDownEkz2.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz3_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 2] = (byte)numericUpDownEkz3.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz4_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 3] = (byte)numericUpDownEkz4.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz15_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 4] = (byte)numericUpDownEkz15.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void comboBoxSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownEkz1.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 0];
            numericUpDownEkz2.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 1];
            numericUpDownEkz3.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 2];
            numericUpDownEkz4.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 3];
            numericUpDownEkz15.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 4];
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 0] == 0)
            {
                checkBoxEkz1.Checked = false; //снять флажок
            }
            else //иначе - экзамен был
            {
                checkBoxEkz1.Checked = true; //установить флажок
                                             //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 0] == 1)
                {
                    checkBoxEkz1neyavka.Checked = true; //установить флажок
                }
                else
                {
                    checkBoxEkz1neyavka.Checked = false; //снять флажок
                                                         //вывести оценку
                    numericUpDownEkz1.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 0];
                };

            }
        }

        private void groupBoxOzenki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxEkz1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //оценку можно вводить
                numericUpDownEkz1.Enabled = true;
                //можно поставить неявку
                checkBoxEkz1neyavka.Enabled = true;
            }
            else //иначе - экзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz1.Minimum = 0;
                numericUpDownEkz1.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz1.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz1neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //оценку можно вводить
                numericUpDownEkz2.Enabled = true;
                //можно поставить неявку
                checkBoxEkz2neyavka.Enabled = true;
            }
            else //иначе - экзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz2.Minimum = 0;
                numericUpDownEkz2.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz2.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz2neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz3.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //оценку можно вводить
                numericUpDownEkz3.Enabled = true;
                //можно поставить неявку
                checkBoxEkz3neyavka.Enabled = true;
            }
            else //иначе - экзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz3.Minimum = 0;
                numericUpDownEkz3.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz3.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz3neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz4.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //оценку можно вводить
                numericUpDownEkz4.Enabled = true;
                //можно поставить неявку
                checkBoxEkz4neyavka.Enabled = true;
            }
            else //иначе - экзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz4.Minimum = 0;
                numericUpDownEkz4.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz4.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz4neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz5.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz15.Minimum = 2;
                numericUpDownEkz15.Value = 4;
                //оценку можно вводить
                numericUpDownEkz15.Enabled = true;
                //можно поставить неявку
                checkBoxEkz5neyavka.Enabled = true;
            }
            else //иначе - экзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz15.Minimum = 0;
                numericUpDownEkz15.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz15.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz5neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz1neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz1.Minimum = 1;
                numericUpDownEkz1.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz1.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //оценку нельзя вводить
                numericUpDownEkz1.Enabled = true;
            };
        }

        private void checkBoxEkz2neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz2.Minimum = 1;
                numericUpDownEkz2.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz2.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //оценку нельзя вводить
                numericUpDownEkz2.Enabled = true;
            };
        }

        private void checkBoxEkz3neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz3neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz3.Minimum = 1;
                numericUpDownEkz3.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz3.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //оценку нельзя вводить
                numericUpDownEkz3.Enabled = true;
            };
        }

        private void checkBoxEkz4neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz4neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz4.Minimum = 1;
                numericUpDownEkz4.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz4.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //оценку нельзя вводить
                numericUpDownEkz4.Enabled = true;
            };
        }

        private void checkBoxEkz5neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz5neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz15.Minimum = 1;
                numericUpDownEkz15.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz15.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz15.Minimum = 2;
                numericUpDownEkz15.Value = 4;
                //оценку нельзя вводить
                numericUpDownEkz15.Enabled = true;
            };
        }
    }
}
