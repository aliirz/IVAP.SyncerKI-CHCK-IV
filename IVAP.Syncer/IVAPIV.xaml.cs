using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CsvHelper;
using System.IO;

namespace IVAP.Syncer
{
    /// <summary>
    /// Interaction logic for IVAPIV.xaml
    /// </summary>
    public partial class IVAPIV : Window
    {

        private MainWindow _mainWindow;

        public IVAPIV(MainWindow mainWindow)
        {

            _mainWindow = mainWindow;
            InitializeComponent();
        }



        public IVAPIV()
        {
            InitializeComponent();
        }

        private void upload_btn_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".csv";
            //dlg.Filter = "CSV Files (*.csv)";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                questionaireTextBox.Text = filename;
            }
        }

        private void sync_btn_Click(object sender, RoutedEventArgs e)
        {
            var syncedList = new List<SyncedIV>();
            try
            {
                var reader = new CsvReader(new StreamReader(questionaireTextBox.Text));
                var unsynced = reader.GetRecords<UnsyncedIV>().ToList();
                Syncrhonizerer s = new Syncrhonizerer();

                var synced = s.SyncIVAPIVSurvey(unsynced.ToList());
                using (var csv = new CsvWriter(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SynceIVAP4Data.csv")))
                {
                    csv.WriteRecords(synced);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _mainWindow.Show();
        }
    }
}
