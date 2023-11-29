using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace ListBoxMVVM
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBoxPerson.Focus();
        }
    }
}
