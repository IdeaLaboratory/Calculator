﻿using System;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for ExtendedKeys.xaml
    /// </summary>
    public partial class ExtendedKeys : UserControl
    {
        public ExtendedKeys()
        {
            InitializeComponent();
        }

        private void DecClicked(object sender, RoutedEventArgs e)
        {
            ViewModel.CommandFactory.GetNumberModeCommand.Execute((sender as RadioButton).Content);
        }
    }
}