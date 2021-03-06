﻿using mobSocial.Core.Config;
using mobSocial.Data.Enum;

namespace mobSocial.Data.Entity.Settings
{
    public class UserSettings: ISettingGroup
    {
        /// <summary>
        /// Default registration mode for users
        /// </summary>
        public RegistrationMode UserRegistrationDefaultMode { get; set; }

        /// <summary>
        /// Specifies if user names are enabled for site
        /// </summary>
        public bool AreUserNamesEnabled { get; set; }
    }
}