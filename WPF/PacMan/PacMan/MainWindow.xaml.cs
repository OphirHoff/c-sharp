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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PacMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int sec = 0;


        private Pacman pacman = new Pacman();

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeDirection(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
                this.pacman.SetDirection(Direction.Right);
            else if (e.Key == Key.Left)
                pacman.SetDirection(Direction.Left);
            else if (e.Key == Key.Up)
                pacman.SetDirection(Direction.Up);
            if (e.Key == Key.Down)
                pacman.SetDirection(Direction.Down);
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            
            DispatcherTimer mainTimer = new DispatcherTimer();
            mainTimer.Interval = new TimeSpan(0, 0, 0, 1, 500);
            mainTimer.Tick += new EventHandler(mainTimer_Tick);
            mainTimer.Start();

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {

            Move();
            TimerLabel.Content = "Timer: " + sec.ToString();
        }

        private void Move()
        {
            if (pacman.GetDirection() == Direction.Right)
            {
                Canvas.SetTop(pacmanPic, pacman.GetX()+1);
                pacman.Move();
            }
        }
    }
}
