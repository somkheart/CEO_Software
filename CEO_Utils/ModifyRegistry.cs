﻿
using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace CEO_Utils
{

    public class CEORegistry
    {
        private bool showError = false;
        public bool ShowError
        {
            get { return showError; }
            set { showError = value; }
        }
       // private string subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();
        private string subKey = "SOFTWARE\\CEO-SOFTWARE";
        public string SubKey
        {
            get { return subKey; }
            set { subKey = value; }
        }
        private RegistryKey baseRegistryKey = Registry.CurrentUser;
        public RegistryKey BaseRegistryKey
        {
            get { return baseRegistryKey; }
            set { baseRegistryKey = value; }
        }
        public string Read(string KeyName)
        {
            RegistryKey rk = baseRegistryKey;
            RegistryKey sk1 = rk.OpenSubKey(subKey);
            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (string)sk1.GetValue(KeyName.ToUpper());
                }
                catch (Exception e)
                {
                    ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }
        }
        public bool Write(string KeyName, object Value)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                sk1.SetValue(KeyName.ToUpper(), Value);
                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }
        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        public bool DeleteSubKeyTree()
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists, I delete it
                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }
        public int SubKeyCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Retriving subkeys of " + subKey);
                return 0;
            }
        }

        public int ValueCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + subKey);
                return 0;
            }
        }

        private void ShowErrorMessage(Exception e, string Title)
        {
            if (showError == true)
                MessageBox.Show(e.Message,
                                Title
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
        }
    }
}
