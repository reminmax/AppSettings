// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Wrapper class for saving and restoring application settings using Xamarin.Essentials Preferences.
//   For more info check https://docs.microsoft.com/en-us/xamarin/essentials/preferences
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AppSettings.Helpers
{
    using System;

    using Xamarin.Essentials;

    /// <summary>
    /// Wrapper class for saving and restoring application settings using Xamarin.Essentials Preferences
    /// </summary>
    public static class ApplicationSettings
    {
        /// <summary>
        /// Gets or sets user name
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// When value is null.
        /// </exception>
        public static string UserName
        {
            get
            {
                if (Preferences.ContainsKey("UserName"))
                {
                    return Preferences.Get("UserName", string.Empty);
                }
                else
                {
                    return string.Empty;
                }
            }

            // Short syntax
            //get => Preferences.ContainsKey("UserName") ? Preferences.Get("UserName", string.Empty) : string.Empty;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                
                Preferences.Set("UserName", value);
            }
        }

        /// <summary>
        /// Gets or sets value indicating whether backup is enabled
        /// </summary>
        public static bool IsBackupEnabled
        {
            get => Preferences.ContainsKey("IsBackupEnabled") && Preferences.Get("IsBackupEnabled", false);

            set => Preferences.Set("IsBackupEnabled", value);
        }

        /// <summary>
        /// Gets or sets the last successful authorization date.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// When value is null.
        /// </exception>
        public static DateTime LastSuccessfulAuthorizationDate
        {
            get => Preferences.ContainsKey("LastSuccessfulAuthorizationDate") ? Preferences.Get("LastSuccessfulAuthorizationDate", DateTime.MinValue) : DateTime.MinValue;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                Preferences.Set("LastSuccessfulAuthorizationDate", value);
            }
        }

        /// <summary>
        /// Gets or sets how many days left till birthday.
        /// </summary>
        public static int DaysLeftTillBirthday
        {
            get => Preferences.ContainsKey("DaysLeftTillBirthday") ? Preferences.Get("DaysLeftTillBirthday", 0) : 0;
            
            set => Preferences.Set("DaysLeftTillBirthday", value);
        }
    }
}
