using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace lab_3
{
    public partial class MainForm : Form
    {
        private Loader CarLoader;
        private string LastModelName;
        private string LastModelType;

        private string CURRENT_MODEL;
        private string CURRENT_TYPE;
        private Thread CarThread;
        private string FileName = @"C:\Users\Алёна\source\repos\lab-3\CarBrands.xml";
        private string FirstTableFileHash = "";
        public MainForm()
        {
            InitializeComponent();
            carBrandDataGridView.DataMember = "Car";
            carListDataGridView.ColumnCount = 3;
            CarLoader = new Loader();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save your DB in current XML file
            SaveXMLFileDialog.Filter = "XML-File | *.xml";

            if (SaveXMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = SaveXMLFileDialog.FileName;
                DataSet ds = (DataSet)carBrandDataGridView.DataSource;
                ds.WriteXml(path);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load DB from current XML file
            OpenXMLFileDialog.Filter = "XML-File | *.xml";

            if (OpenXMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = OpenXMLFileDialog.FileName;
                DataSet ds = new DataSet();
                ds.ReadXml(path);
                carBrandDataGridView.DataSource = ds;
                carBrandDataGridView.DataMember = "Car";
                FileName = path;
            }
        }

        private string checkFileHash()
        {
            // Check DB file hash
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(FileName))
                {
                    byte[] tmpNewHash = md5.ComputeHash(stream);
                    return Convert.ToBase64String(tmpNewHash);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the File Menu
            if (MessageBox.Show("Are you really want to close the program?", "Close program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CreateCarColums()
        {
            // Create colums for table with generated cars
            carListDataGridView.Columns[0].HeaderText = "Registration number";
            carListDataGridView.Columns[1].HeaderText = "Media name";
            carListDataGridView.Columns[2].HeaderText = "Airbag amount";
        }

        private void CreateTrackColums()
        {
            // Create colums for table with generated tracks
            carListDataGridView.Columns[0].HeaderText = "Registration number";
            carListDataGridView.Columns[1].HeaderText = "Wheels amount";
            carListDataGridView.Columns[2].HeaderText = "Body volume";
        }

        private void loadAll(string ModelName, string Type)
        {
            // Add data to a new table with generated cars / tracks
            if (ModelName == LastModelName && Type == LastModelType) return;
            carListDataGridView.Rows.Clear();
            switch (Type)
            {
                case "car":
                    CreateCarColums();
                    foreach (CarForLoadModel car in CarLoader.CarCache[ModelName])
                    {
                        carListDataGridView.Rows.Add(car.RegistrationNumber, car.MediaName, car.AirbagAmount);
                        int rowIndex = carListDataGridView.Rows.Count - 2;
                        carListDataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(car.redRowColor, car.greenRowColor, car.blueRowColor);
                    }
                    break;
                case "track":
                    CreateTrackColums();
                    foreach (TrackForLoadModel track in CarLoader.TrackCache[ModelName])
                    {
                        carListDataGridView.Rows.Add(track.RegistrationNumber, track.WheelsAmount, track.BodyVolume);
                        int rowIndex = carListDataGridView.Rows.Count - 2;
                        carListDataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(track.redRowColor, track.greenRowColor, track.blueRowColor);
                    }
                    break;
            }
            LastModelName = ModelName;
            LastModelType = Type;
            LoaderProgressBar.Visible = false;
            carListDataGridView.Visible = true;
        }

        private void carBrandDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Change color for rows in car brand table (by type: car / track)
            foreach (DataGridViewRow row in carBrandDataGridView.Rows)
            {
                var Type = row.Cells["Type"].Value;
                if (Type != null)
                {
                    switch (Type.ToString())
                    {
                        case "car":
                            row.DefaultCellStyle.BackColor = Color.Pink;
                            row.Tag = "car";
                            break;
                        case "track":
                            row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            row.Tag = "track";
                            break;
                    }
                }
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // Load a new table with generated cars / tracks
            if (carBrandDataGridView.SelectedCells.Count > 0)
            {
                int index = carBrandDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = carBrandDataGridView.Rows[index];

                var Type = row.Cells["Type"].Value;
                var ModelName = row.Cells["Brand"].Value;

                if (Type != null && ModelName != null && (Type.ToString() != "" && ModelName.ToString() != "") && (CURRENT_MODEL == null && CURRENT_TYPE == null ||
                    CURRENT_MODEL != ModelName.ToString() || CURRENT_TYPE != Type.ToString()))
                {
                    int Progress = CarLoader.getProgress();
                    var ModelNameString = ModelName.ToString();
                    var TypeString = Type.ToString();

                    if (Progress == 100 && CarThread != null)
                    {
                        LoaderProgressBar.Value = Progress;
                        if (CarLoader.CarCache.ContainsKey(ModelNameString) || 
                            CarLoader.TrackCache.ContainsKey(ModelNameString)) {
                            
                            CURRENT_MODEL = ModelNameString;
                            CURRENT_TYPE = TypeString;

                            loadAll(ModelNameString, TypeString);

                            CarThread = null;
                            LoaderProgressBar.Visible = false;
                            CarLoader.Progress = 0;
                        }
                    }
                    else if (Progress == 0 && CarThread == null)
                    {
                        carListDataGridView.Visible = false;
                        LoaderProgressBar.Visible = true;
                        if (Type.ToString() == "car")
                        {
                            CarThread = new Thread(() => CarLoader.Load(CarType.CAR, ModelNameString));
                        }
                        else
                        {
                            CarThread = new Thread(() => CarLoader.Load(CarType.TRACK, ModelNameString));
                        }
                        CarThread.Start();
                    }
                    else
                    {
                        LoaderProgressBar.Visible = true;
                        LoaderProgressBar.Value = Progress;
                    }
                }
                else
                {
                    CarThread = null;
                    LoaderProgressBar.Visible = false;
                    CarLoader.Progress = 0;
                }
            }
        }

        private void FirstTimer_Tick(object sender, EventArgs e)
        {
            // Check if DB changed
            string hash = checkFileHash();

            DataSet ds = (DataSet)carBrandDataGridView.DataSource;
            if (hash == FirstTableFileHash && ds != null)
            {
                ds.WriteXml(FileName);
                FirstTableFileHash = checkFileHash();
                return;
            }

            hash = checkFileHash();
            // Load DB if it changed
            if (FirstTableFileHash != hash)
            {
                ds = new DataSet();
                ds.ReadXml(FileName);
                if (ds != null)
                {
                    carBrandDataGridView.DataSource = ds;
                    carBrandDataGridView.DataMember = "Car";
                    FirstTableFileHash = hash;
                }
            }
        }
    }
}
