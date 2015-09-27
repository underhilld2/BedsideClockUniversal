
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BedsideClockUniversal.ViewModels
{
   public class ViewModelLocator
   {
      public ViewModelLocator()
      {
         ServiceLocator.SetLocatorProvider( () => SimpleIoc.Default );



         SimpleIoc.Default.Register<MainViewModel>();
      }

      public MainViewModel MainViewModel
      {
         get
         {
            return SimpleIoc.Default.GetInstance<MainViewModel>();
         }
      }
   }

}
