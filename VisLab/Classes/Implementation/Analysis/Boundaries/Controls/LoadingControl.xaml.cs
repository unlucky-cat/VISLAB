﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisLab.Controls
{
    /// <summary>
    /// Interaction logic for LoadingControl.xaml
    /// </summary>
    public partial class LoadingControl : UserControl
    {
        public string Message
        {
            get { return tbkMessage.Text; }
            set { tbkMessage.Text = value; }
        }

        public LoadingControl(string message)
        {
            InitializeComponent();

            tbkMessage.Text = message;
        }

        public LoadingControl() : this(string.Empty) { }
    }
}
