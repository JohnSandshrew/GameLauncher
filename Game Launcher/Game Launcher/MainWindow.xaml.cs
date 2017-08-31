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

        private void GridButton_OnClick(object sender, RoutedEventArgs e) {
            return; //Just a return so the buttons dont error all over your face
        }
        private void PosterButton_OnClick(object sender, RoutedEventArgs e) {
            return; //Just a return so the buttons dont error all over your face
        }
        private void BannerButton_OnClick(object sender, RoutedEventArgs e) {
            return; //Just a return so the buttons dont error all over your face
        }
        private void ListButton_OnClick(object sender, RoutedEventArgs e) {
            return; //Just a return so the buttons dont error all over your face
        }
        private void SettingsButton_OnClick(object sender, RoutedEventArgs e) {
            return; //Just a return so the buttons dont error all over your face
        }
    }
    }
