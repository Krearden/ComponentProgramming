using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;


namespace ClockWidget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Неизменяемая система исчисления.
        const double NumberSystem = 60;

        // Количество градусов на единицу системы исчисления.
        // Базовый угол для минут и секунд.
        const double baseAngleNumberSystem = 360 / NumberSystem;

        // Базовый угол для часов.
        const double baseAngleHour = 30;

        public MainWindow()
        {

            InitializeComponent();

            StartClock();

            ShowMarksClockFace();

        }

        #region Вычисление текущего времени
        private void Timer_Tick(object sender, EventArgs e)
        {
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            // Вычисленные углы для стрелок
            double angleSecond = baseAngleNumberSystem * sec;
            double angleMinute = (min * baseAngleNumberSystem) + (angleSecond / 60.0);
            double angleHour = (hour - 12) * baseAngleHour + angleMinute / 12;

            // Обновление угла вращения стрелок
            SecondArrow.RenderTransform = new RotateTransform { Angle = angleSecond };
            MinuteArrow.RenderTransform = new RotateTransform { Angle = angleMinute };
            HourArrow.RenderTransform = new RotateTransform { Angle = angleHour };

            // Показываем форму после первого события Timer_Tick
            this.Show();
        }


        #endregion

        #region Система перемещения окна

        bool move = false;
        Point constPosition;

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            // Зафиксируем неизменяемую позицию.
            constPosition = e.GetPosition(this);

            // Разрешаем движение.
            move = true;

            // Чтобы мышь не теряла окно, даже если окно скрывается под тормост окнами.
            this.CaptureMouse();

        }



        private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (move == true)
            {
                // Вычисляем разницу между бывшим и текущим положением курсора от края окна.
                double deltaX = e.GetPosition(this).X - constPosition.X;
                double deltaY = e.GetPosition(this).Y - constPosition.Y;


                // Положение окна тут же корректируем на вычисленную величину(разницу).
                this.Left += deltaX;
                this.Top += deltaY;
            }

        }



        private void Window_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            // Запрещаем движение и отпускаем мышь.
            move = false;
            this.ReleaseMouseCapture();

        }

        #endregion



        #region Дополнительные методы

        // Запуск часов.
        void StartClock()
        {
            // Скрываем форму пока не заработали часы.
            // После первого события Timer_Tick,
            // когда стрелки скорректируют своё положение,
            // сделаем форму видимой.
            this.Hide();

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        // Показываем или скрываем метки циферблата
        void ShowMarksClockFace(bool show = true)
        {
            MinuteMarks();

            HourMarks();
        }


        // Минутная маркировка циферблата
        void MinuteMarks()
        {
            for (int i = 0; i < 60; i++)
            {
                if (i * 6 % 30 != 0)
                {
                    var mark = new Border
                    {
                        RenderTransformOrigin = new Point(0.5, 0.5),
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = 2
                    };

                    var markVisual = new Border
                    {
                        Background = Brushes.Brown,
                        HorizontalAlignment = HorizontalAlignment.Right,
                        Width = 10
                    };

                    mark.Child = markVisual;
                    mark.RenderTransform = new RotateTransform(i * 6);

                    ClockFace.Children.Add(mark);
                }
            }
        }


        // Часовая маркировка циферблата
        void HourMarks()
        {
            for (int i = 0; i < 12; i++)
            {
                var mark = new Border
                {
                    Height = 12,
                    RenderTransformOrigin = new Point(0.5, 0.5),
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Center
                };

                var markVisual = new Border
                {
                    Width = 8,
                    Background = Brushes.Black,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    BorderBrush = Brushes.Black
                };

                mark.Child = markVisual;

                if (i * 30 % 360 != 0) // Часовые метки через 30 градусов.
                {
                    mark.RenderTransform = new RotateTransform(i * 30);
                    ClockFace.Children.Add(mark);
                }
            }
        }

        #endregion

    }
}
