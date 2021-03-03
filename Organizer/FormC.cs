using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormC : Form
    {
        public FormC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Enter all parameters");
            }

            else
            {
                for (int i = 0; i < Program.value.Length; i++)
                {
                    if (Program.value[i].text == null)
                    {
                        Program.value[i].date = monthCalendar1.SelectionStart.ToShortDateString();
                        Program.value[i].time = dateTimePicker1.Value.ToShortTimeString();
                        Program.value[i].text = textBox1.Text;
                        Program.value[i].type = comboBox1.Text;

                        break;
                    }
                }

                Close();                
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionStart < monthCalendar1.TodayDate) MessageBox.Show("The selected date is less than the current date!");
            else monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void FormC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            FormB form = new FormB();
            form.Show();
        }
    }
}
