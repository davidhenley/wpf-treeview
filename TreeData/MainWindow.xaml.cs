using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Get all logical drives on computer
            var drives = Directory.GetLogicalDrives();

            foreach (var drive in drives)
            {
                // Create tree item for each drive with a Header and Tag
                var item = new TreeViewItem
                {
                    Header = drive,
                    Tag = drive
                };

                // Add dummy data to item
                item.Items.Add(null);

                // Add the item to the Tree View
                FolderView.Items.Add(item);
            }
        }
    }
}
