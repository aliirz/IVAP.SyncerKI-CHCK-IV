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
    /// Interaction logic for VC.xaml
    /// </summary>
    public partial class VC : Window
    {
        private MainWindow _mainWindow;


        public VC(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        public VC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
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
                vcTextBox.Text = filename;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var syncedList = new List<SyncedVC>();
            try
            {
                var reader = new CsvReader(new StreamReader(vcTextBox.Text));
                var unsynced = reader.GetRecords<UnsyncedVC>().ToList();
                Syncrhonizerer s = new Syncrhonizerer();

                var synced = s.SyncVerificationChecklist(unsynced.ToList());
                using (var csv = new CsvWriter(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SyncedVCList.csv")))
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
