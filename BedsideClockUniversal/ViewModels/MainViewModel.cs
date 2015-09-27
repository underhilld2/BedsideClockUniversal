using System;
using Windows.UI.Xaml;
using GalaSoft.MvvmLight;

namespace BedsideClockUniversal.ViewModels
{
   public class MainViewModel : ViewModelBase
   {

      public MainViewModel()
      {
         _timer.Interval = TimeSpan.FromSeconds( 1 );
         _timer.Tick += _timer_Tick;
         _timer.Start();
      }

      DispatcherTimer _timer = new DispatcherTimer();
      private string _backgroundImage = "ms-appx:///Assets/20131128_033722000_iOS.jpg";
      private string _currentTime = "Test me";


      public string BackgroundImage
      {
         get
         {
            return _backgroundImage;
         }
         set
         {
            _backgroundImage = value;
            RaisePropertyChanged();
         }
      }
      public string CurrentTime
      {
         get
         {
            return _currentTime;
         }
         set
         {
            _currentTime = value;
            RaisePropertyChanged();
         }
      }


      private void _timer_Tick( object sender, object e )
      {
         CurrentTime = DateTime.Now.ToString();
      }

   }
}
