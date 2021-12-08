using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCB_Status_Manager.Modal
{
    public class Settings : ApplicationSettingsBase
    {
        [ApplicationScopedSetting()]
        [DefaultSettingValue(null)]
        public string IpAddress
        {
            get
            {
                return this["IpAddress"].ToString();
            }
            set
            {
                this["IpAddress"] = value.ToString();
            }
        }

        [ApplicationScopedSetting()]
        [DefaultSettingValue(null)]
        public string Host
        {
            get
            {
                return this["Host"].ToString();
            }
            set
            {
                this["Host"] = value.ToString();
            }
        }

    }
}
