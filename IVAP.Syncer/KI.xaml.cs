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
    /// Interaction logic for KI.xaml
    /// </summary>
    public partial class KI : Window
    {
        public KI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".csv";
            //dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                KITextBox.Text = filename;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var syncedList = new List<SyncedKI>();
            try
            {
                var reader = new CsvReader(new StreamReader(KITextBox.Text));
                var unsynced = reader.GetRecords<UnscyncedKI>().ToList();
                Syncrhonizerer s = new Syncrhonizerer();

                var synced = s.SyncKeyInformantFile(unsynced.ToList());
                using (var csv = new CsvWriter(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SyncedKIList.csv")))
                {
                    csv.WriteRecords(synced);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
