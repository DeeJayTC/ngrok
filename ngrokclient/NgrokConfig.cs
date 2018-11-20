using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngrokclient
{

    public class NgrokConfig
    {
        private IConfigurationRoot Config { get; set; }
        public NgrokConfig(IConfigurationRoot pConfig)
        {
            Config = pConfig;
        }


        public string Token
        {
            get { return Config["authtoken"]; }
            set { Config["authtoken"] = value; }
        }
    }
}
