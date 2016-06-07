using Hawk.View.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Xceed.Wpf.Toolkit;

namespace Hawk.View.Themes
{
    public partial class Geral : ResourceDictionary
    {
        private void maskedTextBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                MaskedTextBox maskedTextBox = sender as MaskedTextBox;

                if (string.IsNullOrEmpty(maskedTextBox.Value as string))
                {
                    maskedTextBox.SelectionStart = 0;
                }
            }
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            var comboBox = (sender as ComboBox);

            if (e.Key == Key.Delete && comboBox.IsEnabled)
            {
                comboBox.SelectedIndex = -1;
            }
        }

    }
}
