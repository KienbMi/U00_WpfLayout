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

namespace U00_WpfLayout.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnStackPanel.Click += BtnStackPanel_Click;
            btnDock.Click += BtnDock_Click;
            btnGrid.Click += BtnGrid_Click;
            btnGridSplitter.Click += BtnGridSplitter_Click;
        }

        private void BtnGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            GridSplitter gridSplitter = new GridSplitter();
            gridSplitter.ShowDialog();
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.ShowDialog();
        }

        private void BtnDock_Click(object sender, RoutedEventArgs e)
        {
            DockWindow dockWindow = new DockWindow();
            dockWindow.ShowDialog();
        }

        private void BtnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.ShowDialog();
        }
    }
}
