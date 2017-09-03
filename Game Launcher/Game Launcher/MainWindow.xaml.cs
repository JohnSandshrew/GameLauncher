using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using MaterialDesignColors;

namespace Game_Launcher {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            //until we add StayOpen glag to Drawer this helps with scrollbar
            var dependencyObject = Mouse.Captured as DependencyObject;
            while (dependencyObject != null) {
                if (dependencyObject is ScrollBar) return;
                dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
            }
            MenuToggleButton.IsChecked = false;
        }

        string displayType; 

        private void GridButton_OnClick(object sender, RoutedEventArgs e) {
            string displayType = "grid";
            return; //Just a return so the buttons dont error all over your face
        }
        private void PosterButton_OnClick(object sender, RoutedEventArgs e) {
            string displayType = "poster";
            return; //Just a return so the buttons dont error all over your face
        }
        private void BannerButton_OnClick(object sender, RoutedEventArgs e) {
            string displayType = "banner";
            return; //Just a return so the buttons dont error all over your face
        }
        private void ListButton_OnClick(object sender, RoutedEventArgs e) {
            string displayType = "list";
            return; //Just a return so the buttons dont error all over your face
        }
        private void SettingsButton_OnClick(object sender, RoutedEventArgs e) {
            //code needed to bring up a settings form or something idk
            return; //Just a return so the buttons dont error all over your face
        }
    }
    }
