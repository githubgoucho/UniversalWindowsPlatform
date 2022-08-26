
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SerialTemplate;

namespace SerialTemplate
{
    /// <summary>
    /// This class is intended to host any functionality that will be shared among different
    /// scenario/pages such as common error messages.
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Prints an error message stating that device is not connected
        /// </summary>
        public static void NotifyDeviceNotConnected()
        {
            MainPage.Current.NotifyUser("Device is not connected, please select a plugged in device to try the scenario again", NotifyType.ErrorMessage);
        }
    }
}
