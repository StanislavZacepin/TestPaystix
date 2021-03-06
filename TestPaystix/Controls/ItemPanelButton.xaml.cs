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

namespace TestPaystix.Controls
{
    /// <summary>
    /// Логика взаимодействия для ItemPanelButton.xaml
    /// </summary>
    public partial class ItemPanelButton : UserControl
    {

        #region Свойство зависимости

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(ItemPanelButton),
                new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        } 
        #endregion
        public ItemPanelButton()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Title = "1";
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Title = "2";
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Title = "3";
        }
        private void ButtonText_Click(object sender, RoutedEventArgs e)
        {
            VisibilityStyle.Visibility = Visibility.Visible;
        }
           

        private void DockPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            VisibilityStyle.Visibility = Visibility.Collapsed;
        }

       
    }
}
