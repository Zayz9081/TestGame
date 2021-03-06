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
using TestGame.Structures;
using TestGame.Objects;

namespace TestGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GOSquare Square1 = new GOSquare(45, new Coords(40, 80), "Vasya");
            Rectangle Sq1Rct = Square1.SquareRect;

            MainCanvas.Children.Add(Sq1Rct);
            Canvas.SetLeft(Sq1Rct, Square1.crd.x);
            Canvas.SetBottom(Sq1Rct, Square1.crd.y);
        }
    }
}
