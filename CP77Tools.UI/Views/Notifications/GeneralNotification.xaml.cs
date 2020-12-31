﻿using ControlzEx.Theming;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace CP77Tools.UI.Views.Notifications
{
    /// <summary>
    /// Interaction logic for GeneralNotification.xaml
    /// </summary>
    public partial class GeneralNotification : MetroWindow
    {
        public GeneralNotification(string title, string message)
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, SUI.sui.generaldata.ThemeFinder());


            this.Title = title;
            this.TextOption.Text = message;

        }
    }
}