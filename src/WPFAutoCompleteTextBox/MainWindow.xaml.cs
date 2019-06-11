//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace WPFAutoCompleteTextBox
{
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

    /// <summary>
    /// Interaction logic for Main Window
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Default Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            try
            {
                // Initialization.
                this.InitializeComponent();

                // Loaded.
                this.Loaded += this.MainWindow_Loaded;
            }
            catch (Exception ex)
            {
                // Info.
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }

        #endregion

        #region Page Loaded event method.

        /// <summary>
        /// Page Loaded event method
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Navigating.
                this.mainFrame.Navigate(new Uri("/Views/Pages/HomePage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }

        #endregion
    }
}
