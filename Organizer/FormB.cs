using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormC form = new FormC();
            form.ShowDialog();        
        }

        void itemsAddToList()
        {
            for (int i = 0; i < Program.value.Length; i++)
            {
                if (Program.value[i].text == null) continue;
                ListViewItem item = new ListViewItem(new[] { Program.value[i].date, Program.value[i].time, Program.value[i].text });

                switch (Program.value[i].type)
                {
                    case "Memo":
                        item.ImageIndex = 0;
                        break;
                    case "Task":
                        item.ImageIndex = 1;
                        break;
                    case "Meeting":
                        item.ImageIndex = 2;
                        break;
                    default:
                        break;
                }

                listView1.Items.Add(item);
            }
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            if (Program.flagLogin)
            {
                FormA Form = new FormA();
                Form.ShowDialog();
            }

            if (Program.flagExit) Application.Exit();

            itemsAddToList();
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listView1.Items.Clear();

                for (int i = 0; i < Program.value.Length; i++)
                {
                    if (Program.value[i].type == comboBox1.Text)
                    {
                        ListViewItem item = new ListViewItem(new[] { Program.value[i].date, Program.value[i].time, Program.value[i].text });

                        switch (Program.value[i].type)
                        {
                            case "Memo":
                                item.ImageIndex = 0;
                                break;
                            case "Task":
                                item.ImageIndex = 1;
                                break;
                            case "Meeting":
                                item.ImageIndex = 2;
                                break;
                            default:
                                break;
                        }

                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            for (int i = 0; i < Program.value.Length; i++)
            {
                ListViewItem item = new ListViewItem(new[] { Program.value[i].date, Program.value[i].time, Program.value[i].text });

                switch (Program.value[i].type)
                {
                    case "Memo":
                        item.ImageIndex = 0;
                        break;
                    case "Task":
                        item.ImageIndex = 1;
                        break;
                    case "Meeting":
                        item.ImageIndex = 2;
                        break;
                    default:
                        break;
                }

                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listView1.SelectedItems.Count != 0)
            {
                Point po = Cursor.Position;
                contextMenuStrip1.Show(po);
            }
        }

        void removeItem()
        {
            string inf = listView1.SelectedItems[0].Text + "/" + listView1.SelectedItems[0].SubItems[1].Text + "/" + listView1.SelectedItems[0].SubItems[2].Text;

            DialogResult result = MessageBox.Show("Are you sure you want to delete the record " + inf, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                Program.value[listView1.SelectedIndices[0]].date = null;
                Program.value[listView1.SelectedIndices[0]].time = null;
                Program.value[listView1.SelectedIndices[0]].text = null;
                Program.value[listView1.SelectedIndices[0]].type = null;

                for (int i = listView1.SelectedIndices[0] + 1; i < Program.value.Length; i++)
                {
                    if (Program.value[i].text != null)
                    {
                        Program.value[i - 1].date = Program.value[i].date;
                        Program.value[i - 1].time = Program.value[i].time;
                        Program.value[i - 1].text = Program.value[i].text;
                        Program.value[i - 1].type = Program.value[i].type;

                        Program.value[i].date = null;
                        Program.value[i].time = null;
                        Program.value[i].text = null;
                        Program.value[i].type = null;
                    }
                }

                listView1.Items.Clear();
                itemsAddToList();
            }
        }

        void saveList()
        {
            FileStream stream = new FileStream(@"D:\list.txt", FileMode.Create);
            StreamWriter fsswrite = new StreamWriter(stream);

            for (int i = 0; i < Program.value.Length; i++)
            {
                fsswrite.WriteLine(Program.value[i].date);
                fsswrite.WriteLine(Program.value[i].time);
                fsswrite.WriteLine(Program.value[i].text);
                fsswrite.WriteLine(Program.value[i].type);
            }

            fsswrite.Close();
            MessageBox.Show("List saved!");
        }

        void openList()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                StreamReader fssread = new StreamReader(filePath);

                for (int i = 0; i < Program.value.Length; i++)
                {
                    Program.value[i].date = null;
                    Program.value[i].time = null;
                    Program.value[i].text = null;
                    Program.value[i].type = null;
                }

                for (int i = 0; i < Program.value.Length; i++)
                {
                    string s = fssread.ReadLine();
                    if (string.IsNullOrEmpty(s)) break;

                    Program.value[i].date = s;
                    Program.value[i].time = fssread.ReadLine();
                    Program.value[i].text = fssread.ReadLine();
                    Program.value[i].type = fssread.ReadLine();
                }

                fssread.Close();
            }

            listView1.Items.Clear();
            itemsAddToList();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeItem();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.value[listView1.SelectedIndices[0]].date = null;
            Program.value[listView1.SelectedIndices[0]].time = null;
            Program.value[listView1.SelectedIndices[0]].text = null;
            Program.value[listView1.SelectedIndices[0]].type = null;

            FormC form = new FormC();
            form.Show();
            Hide();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedItems.Count != 0)
                removeItem();

            if (e.Control && e.KeyCode == Keys.S)
                saveList();

            if (e.Control && e.KeyCode == Keys.O)
                openList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            bool flag = true;

            for (int i = 0; i < Program.value.Length; i++)
            {
                int maxInd = 0;
                DateTime maxDate = Convert.ToDateTime(Program.value[i].date);
                DateTime date;

                for (int j = i + 1; j < Program.value.Length; j++)
                {
                    if (Program.value[j].date != null)
                    {
                        date = Convert.ToDateTime(Program.value[j].date);

                        if (maxDate.CompareTo(date) > 0)
                        {
                            flag = false;
                            maxDate = date;
                            maxInd = j;
                        }
                    }
                }

                if (flag) break;
                flag = true;

                string tmpDate = Program.value[i].date;
                string tmpTime = Program.value[i].time;
                string tmpText = Program.value[i].text;
                string tmpType = Program.value[i].type;

                Program.value[i].date = Program.value[maxInd].date;
                Program.value[i].time = Program.value[maxInd].time;
                Program.value[i].text = Program.value[maxInd].text;
                Program.value[i].type = Program.value[maxInd].type;

                Program.value[maxInd].date = tmpDate;
                Program.value[maxInd].time = tmpTime;
                Program.value[maxInd].text = tmpText;
                Program.value[maxInd].type = tmpType;
            }

            itemsAddToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormD form = new FormD();
            form.ShowDialog();

            listView1.Items.Clear();

            for (int i = 0; i < Program.value.Length; i++)
            {
                if (Program.value[i].text != null && Program.value[i].time == Program.time)
                {
                    ListViewItem item = new ListViewItem(new[] { Program.value[i].date, Program.value[i].time, Program.value[i].text });

                    switch (Program.value[i].type)
                    {
                        case "Memo":
                            item.ImageIndex = 0;
                            break;
                        case "Task":
                            item.ImageIndex = 1;
                            break;
                        case "Meeting":
                            item.ImageIndex = 2;
                            break;
                        default:
                            break;
                    }

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
