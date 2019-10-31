using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace ChoHoe
{
    class NewVersionCheck
    {
        Uri url = new Uri("http://api.github.com/repos/SODAIS69/Chohue-EpubVerticalizationer/releases/latest");

       public async Task<bool> HasnewAsync()
        {
            
            var client = new GitHubClient(new ProductHeaderValue("Chehue"));
            var release = await client.Repository.Release.GetAll("SODAIS69", "Chohue-EpubVerticalizationer");
            var latest = release[0];

            if (compareVersion(latest.TagName)) //
            {
                string info = "✨更新內容:" + Environment.NewLine +Environment.NewLine + latest.Body+Environment.NewLine+ Environment.NewLine + "請問要前往下載嗎?";
                string title = $"🆕 發現新版本:{latest.TagName}!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(info, title, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)//
                {
                    System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/?utm_source=Chehue&utm_medium=PopNotify");
                }

            }
            



            Console.WriteLine(latest.TagName);

            //using (WebClient wc = new WebClient())
            //{
            //    System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
              
            ////    var json = wc.DownloadString(url);
            //}
            return true;
        }
        private bool compareVersion(string latestVersion)
        {
            Version thisversion = Assembly.GetEntryAssembly().GetName().Version;
            Version newVersion =new Version(latestVersion);
            int a = thisversion.CompareTo(newVersion);
            if (thisversion.CompareTo(newVersion)<=0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
                


        }

    }
}
