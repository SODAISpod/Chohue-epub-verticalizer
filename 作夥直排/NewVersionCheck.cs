using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChoHoe
{
    class NewVersionCheck
    {
        Uri url = new Uri("http://api.github.com/repos/SODAIS69/Chohue-EpubVerticalizationer/releases/latest");

       public bool Hasnew()
        {
            using (WebClient wc = new WebClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
              
            //    var json = wc.DownloadString(url);
            }
            return true;
        }

    }
}
