using System.Text;

namespace Student_Managent_Addlication
{
    public partial class Form1 : Form
    {
        private string? strData;
        private string major;
        private object oGPACal;
        private object textBoxAllData;

        public int Columns { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void oPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (+.CSV) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    //Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                    //addDataToGridView(student);
                    //Too: Add Student object to DataGridView
                }
                //TODO : calculate max, min, gpax
            }

        }
        private void addDataToGridView(string id, string name, string Major)
        {
            //this.dataGridView1.Rows.Add(new string[] { id, name, major });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string data = this.dataGridView1.Rows[0].Cells[0].Value.ToString();

            String filepath = String.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (+.CSV) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {

                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < Columns; j++)
                        {
                            if (this.dataGridView1.Rows[i].Cells[j].Value != null)
                                strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //ToDo: Save data from dataGridView1 to variadle
                        }
                    }

                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String filepath = String.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (+.CSV) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {

                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < Columns; j++)
                        {
                            if (this.dataGridView1.Rows[i].Cells[j].Value != null)
                                strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //ToDo: Save data from dataGridView1 to variadle
                        }
                    }

                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);


                }
            }
        

            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            textBoxMaxGPA.Text = oGPACal.getMax().ToString();

            textBoxMinGPA.Text = oGPACal.getMin().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty;
            textBoxAllData.Text = oGPACal.getAlldata();
            //TODO add data to data gridvidview
            //TODO : calculate max, min, gpax
        }
    }
}