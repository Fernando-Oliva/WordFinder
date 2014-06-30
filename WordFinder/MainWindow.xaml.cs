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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

using WordFinder.Core;

namespace WordFinder
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReferenceWord.Text))
            {
                OpenFileDialog loadFile = new OpenFileDialog();

                loadFile.ShowDialog();

                txbWordData.Text = string.Format("Ocurrences Number: {0}", Core.WordFinder.Search(loadFile.FileName, txtReferenceWord.Text));
            }
            else
            {
                MessageBox.Show("Insert a word to search");
            }
        }
    }
}
