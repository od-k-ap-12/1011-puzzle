using System;
using System.Collections.Generic;
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

namespace _1011_puzzle
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
        Image ImageToDrop = null;
        private void imgSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageToDrop = sender as Image;
            DataObject data = new DataObject(typeof(ImageSource), ImageToDrop.Source);
            DragDrop.DoDragDrop(ImageToDrop, data, DragDropEffects.All);
        }

        private void imgTarget_Drop(object sender, DragEventArgs e)
        {
            Image Image = sender as Image;
            ImageSource ReplaceTarget = e.Data.GetData(typeof(ImageSource)) as ImageSource;
            ImageToDrop.Source = Image.Source;
            Image.Source = ReplaceTarget;
        }
    }
}
