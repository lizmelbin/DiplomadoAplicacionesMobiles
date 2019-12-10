using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dominos.Configuration
{
    public class AppContants
    {

        public static string AppId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-1699316743089525~2393864905";
                    default:
                        return "ca-app-pub-1699316743089525~2393864905";
                }
            }
        }
        public static string BannerId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-1699316743089525~2393864905";
                    default:
                        return "ca-app-pub-1699316743089525~2393864905";
                }
            }
        }
    }
}
