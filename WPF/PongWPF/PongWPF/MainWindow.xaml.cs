using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PongWPF
{
    enum Direction { UpRight, DownRight, DownLeft, UpLeft};

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool againstPC;
        private int hitDelayCnt;
        private const int MinY = 5;
        private const int MaxY = 300;
        private const int MaxX = 795;
        private const int MinX = 5;
        private const int tile_Speed = 20;
        private const int ball_speed = 3;
        private Direction ball_direction;

        private int winner; // 1 - left, - right

        private DispatcherTimer mainTimer;



        Random rnd = new Random();

        public MainWindow()
        {
            
            InitializeComponent();
            // Timer Tick
            mainTimer = new DispatcherTimer();
            mainTimer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            mainTimer.Tick += new EventHandler(mainTimer_Tick);

            ball_direction =  (Direction)rnd.Next(4);

            this.hitDelayCnt = 0;
        }
        
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            MoveBall();
            if (againstPC)
                MoveLeftTilePC();
            CheckBallBorders();
            CheckTileHit();
            if (CheckWin())
            {
                mainTimer.Stop();
                ball.Visibility = Visibility.Hidden;
                partition.Visibility = Visibility.Hidden;
                WinLabel.Content = "Player " + winner + " Won!";
                WinLabel.Visibility = Visibility.Visible;

            }
            hitDelayCnt++;
                
        }

        private bool CheckWin()
        {
            if (ball.Margin.Left < left_Tile.Margin.Left)
            {
                winner = 2; // right player won
                return true;
            }

            if (ball.Margin.Left > right_Tile.Margin.Left + right_Tile.Width)
            {
                winner = 1; // left player won
                return true;
            }

            return false;
        }

        private void CheckTileHit()
        {
            double tileTop = left_Tile.Margin.Top;
            double tileBottom = left_Tile.Margin.Top + left_Tile.Height;
            double tileX = left_Tile.Margin.Left + left_Tile.Width;
            double ballTop = ball.Margin.Top;
            double ballBottom = ball.Margin.Top + ball.Height;
            double ballX = ball.Margin.Left;

            // Check Left Tile hit
            if (ballTop > tileTop && ballBottom < tileBottom && ballX < tileX+1)
            {
                ChangeBallDirection();
                return;
            }

            // Check right Tile hit
            tileTop = right_Tile.Margin.Top;
            tileBottom = right_Tile.Margin.Top + right_Tile.Height;
            tileX = right_Tile.Margin.Left;

            if (ballTop > tileTop && ballBottom < tileBottom && ballX > tileX - 25)
            {
                ChangeBallDirection();
            }
        }

        private void MoveBall()
        {
            if (ball_direction == Direction.UpRight)
                ball.Margin = new Thickness(ball.Margin.Left + ball_speed, ball.Margin.Top - ball_speed, 0, 0);

            else if (ball_direction == Direction.DownRight)
                ball.Margin = new Thickness(ball.Margin.Left + ball_speed, ball.Margin.Top + ball_speed, 0, 0);

            else if (ball_direction == Direction.DownLeft)
                ball.Margin = new Thickness(ball.Margin.Left - ball_speed, ball.Margin.Top + ball_speed, 0, 0);

            else if (ball_direction == Direction.UpLeft)
                ball.Margin = new Thickness(ball.Margin.Left - ball_speed, ball.Margin.Top - ball_speed, 0, 0);
        }



        private void CheckBallBorders()
        {
            if (BallReachedBorder() && hitDelayCnt > 20)
            {
                ChangeBallDirection();
                hitDelayCnt = 0;
            }
        }

        private void ChangeBallDirection()
        {
            ball_direction = (Direction)((int)(ball_direction + 1) % 4);
        }

        private bool BallReachedBorder()
        {
            return ball.Margin.Top > 390 || ball.Margin.Top < 10;
        }

        private void MoveRightTile(System.Windows.Input.KeyEventArgs e)
        {
            // Right Tile Movement
            if (e.Key == Key.Up && right_Tile.Margin.Top > MinY)
                right_Tile.Margin = new Thickness(right_Tile.Margin.Left, right_Tile.Margin.Top - tile_Speed, 0, 0);

            else if (e.Key == Key.Down && right_Tile.Margin.Top < MaxY)
                right_Tile.Margin = new Thickness(right_Tile.Margin.Left, right_Tile.Margin.Top + tile_Speed, 0, 0);
        }

        private void MoveLeftTileUser(System.Windows.Input.KeyEventArgs e)
        {
            // Left Tile Movement
            if (e.Key == Key.W && left_Tile.Margin.Top > MinY)
                left_Tile.Margin = new Thickness(left_Tile.Margin.Left, left_Tile.Margin.Top - tile_Speed, 0, 0);

            else if (e.Key == Key.S && left_Tile.Margin.Top < MaxY)
                left_Tile.Margin = new Thickness(left_Tile.Margin.Left, left_Tile.Margin.Top + tile_Speed, 0, 0);
        }

        private void MoveLeftTilePC()
        {

            // Move left Tile accordingly to the ball Y position

            double ballTop = ball.Margin.Top;
            double ballBottom = ball.Margin.Top + ball.Height;

            double tileTop = left_Tile.Margin.Top;
            double tileBottom = left_Tile.Margin.Top + left_Tile.Height;

            if (ballTop < tileTop && ((int)ball_direction == 3 || (int)ball_direction == 2))
                left_Tile.Margin = new Thickness(left_Tile.Margin.Left, left_Tile.Margin.Top - tile_Speed, 0, 0);

            else if (ballBottom > tileBottom && ((int)ball_direction == 3 || (int)ball_direction == 2))
                left_Tile.Margin = new Thickness(left_Tile.Margin.Left, left_Tile.Margin.Top + tile_Speed, 0, 0);
        }

        private void PlayerInput(object sender, System.Windows.Input.KeyEventArgs e)
        {
            MoveRightTile(e); // Check right tile movement

            if (!againstPC) // Only if not against PC
                MoveLeftTileUser(e); // Check left tile movement

            // Start Game
            if (e.Key == Key.Enter)
            {
                mainTimer.Start();
                slider.Visibility = Visibility.Hidden;
                friendPick.Visibility = Visibility.Hidden;
                PCpick.Visibility = Visibility.Hidden;
                startLabel.Visibility = Visibility.Hidden;
                partition.Visibility = Visibility.Visible;

            }

            // End Game & exit window
            else if (e.Key == Key.Escape)
            {
                mainTimer.Stop();
                window.Close();
            }

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Check if player wants to play against PC ("AI") or Friend (W, S)
            
            if (slider.Value > 2.5) // Against a friend
            {
                againstPC = false;
                //friendPick.FontWeight(FontWeights.Bold);
                //PCpick.FontWeight = FontWeights.Normal;

            }
            
            else if (slider.Value < 2.5) // Against PC
            {
                againstPC = true;
                PCpick.FontWeight = FontWeights.Bold;
                friendPick.FontWeight = FontWeights.Normal;
            }

        }
    }
}
