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

namespace Jalinga_Paint.UseControl
{
    /// <summary>
    /// Логика взаимодействия для RadialMenu.xaml
    /// </summary>
    public partial class RadialMenu : UserControl
    {
        public RadialMenu()
        {
            InitializeComponent();
        }

        private void MenuOn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try 
            {
                DragMove();
            } 
            catch(Exception ex) 
            {

            } 
             
        }

        private void DragMove()
        {
            throw new NotImplementedException();
        }
    }
}
