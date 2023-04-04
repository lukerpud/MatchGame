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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🍕","🍕",
                "❤️","❤️",
                "🎃","🎃",
                "🤩","🤩",
                "☠️","☠️",
                "🍭","🍭",
                "🍔","🍔",
                "😎","😎",
            };
            Random random = new Random();

            foreach (TextBlock testBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int i = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[i];
                testBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(i);
            }
        }
    }
}
