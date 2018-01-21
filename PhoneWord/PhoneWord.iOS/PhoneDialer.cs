using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PhoneWord.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace PhoneWord.iOS
{
    class PhoneDialer:IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}