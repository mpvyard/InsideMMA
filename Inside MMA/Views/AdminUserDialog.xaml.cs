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
using System.Windows.Shapes;

namespace Inside_MMA.Views
{
    /// <summary>
    /// Логика взаимодействия для AdminUserDialog.xaml
    /// </summary>
    public partial class AdminUserDialog
    {
        public AdminUserDialog()
        {
            InitializeComponent();
        }

        public bool Confirmed;
        private void Confirm(object sender, RoutedEventArgs e)
        {
            Confirmed = true;
            Close();
        }
    }
}
