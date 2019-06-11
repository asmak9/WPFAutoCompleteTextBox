//-----------------------------------------------------------------------
// <copyright file="HomeBusinessLogic.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace WPFAutoCompleteTextBox.Model.BusinessLogic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using WPFAutoCompleteTextBox.Helper_Code.Objects;

    /// <summary>
    /// Home business logic class.
    /// </summary>
    public class HomeBusinessLogic
    {
        #region Country list loading method

        /// <summary>
        /// Country list loading method.
        /// </summary>
        /// <returns>Returns - List of countries</returns>
        public static List<string> LoadCountryList()
        {
            // Initialization
            List<string> lst = new List<string>();
            string line = string.Empty;

            try
            {
                // Initialization
                string srcFilePath = "Content/files/country_list.txt";
                string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string fullPath = Path.Combine(rootPath, srcFilePath);
                string filePath = new Uri(fullPath).LocalPath;

                StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));

                // Read file.
                while ((line = sr.ReadLine()) != null)
                {
                    // Initialization.
                    CountryObj obj = new CountryObj();
                    string[] info = line.Split(':');

                    // Setting.
                    obj.CountryCode = info[0].ToString();
                    obj.CountryName = info[1].ToString();

                    // Adding.
                    lst.Add(obj.CountryName);
                }

                // Closing.
                sr.Dispose();
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lst;
        }

        #endregion
    }
}
