//-----------------------------------------------------------------------
// <copyright file="HomePage.xaml.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace WPFAutoCompleteTextBox.Views.Pages
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
    using WPFAutoCompleteTextBox.Model.BusinessLogic;

    /// <summary>
    /// Interaction logic for Home Page
    /// </summary>
    public partial class HomePage : Page
    {
        #region Default Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage" /> class.
        /// </summary>
        public HomePage()
        {
            try
            {
                // Initialization.
                this.InitializeComponent();

                // Loaded.
                this.Loaded += this.HomePage_Loaded;
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
        private void HomePage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Auto suggestion list.
                this.autoSuggestionUseControl.AutoSuggestionList = HomeBusinessLogic.LoadCountryList();
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
