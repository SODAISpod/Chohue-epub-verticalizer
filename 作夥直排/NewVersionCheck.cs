using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using Microsoft.Toolkit.Uwp.Notifications;
namespace ChoHoe
{
    public class NewVersionCheck
    {
     

       public async Task<bool> HasnewAsync()
        {
            
            var client = new GitHubClient(new ProductHeaderValue("Chehue"));
            var release = await client.Repository.Release.GetAll("SODAIS69", "Chohue-EpubVerticalizationer");
            var latest = release[0];

            if (CompareVersion(latest.TagName)) //
            {
                string info = "✨ 更新內容:" + Environment.NewLine +Environment.NewLine + latest.Body+Environment.NewLine+ Environment.NewLine + "請問要前往下載嗎?";

                string title = $"🍄 發現新版本: {latest.TagName} !";
                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //ChoHoe.Properties.Resources.AboutBoxBanner
                new ToastContentBuilder()
                .AddArgument("action", "open")
                .AddArgument("version", latest.TagName)
                .AddText($"🍄 發現新的版本！{latest.TagName} 已發布！")
                .AddText($"{latest.Name}；請問要前往下載嗎？")

                .AddHeroImage(new Uri("https://picsum.photos/360/202?image=883"))


                .AddButton(new ToastButton()
                    .SetContent("開啟")
                    .AddArgument("action", "open")
                    .SetBackgroundActivation())
                 .AddButton(new ToastButton()
                    .SetContent("關閉")
                    .AddArgument("action", "close")
                    .SetBackgroundActivation())
                  .AddButton(new ToastButton()
                    .SetContent("略過這個版本")
                    .AddArgument("action", "ignoreThisOne")
                    .SetBackgroundActivation())

                .Show();






                //result = MessageBox.Show(info, title, buttons,MessageBoxIcon.Information);

                //if (result == System.Windows.Forms.DialogResult.Yes)//
                //{
                //    System.Diagnostics.Process.Start("http://kiicho.cc/Chohue?utm_source=Chehue&utm_medium=InApp&utm_campaign=UpdateNotification");
                    
                //}
                return true;
            }
            return false;





            //using (WebClient wc = new WebClient())
            //{
            //    System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
              
            ////    var json = wc.DownloadString(url);
            //}
            
        }
        private bool CompareVersion(string latestVersion)
        {
            Version thisversion = Assembly.GetEntryAssembly().GetName().Version;
            Version newVersion =new Version(latestVersion);
            string ignore = ChoHoe.Properties.Settings.Default.IgnoreVersion;
            
            if (thisversion.CompareTo(newVersion)<=0)
            {
                if (ignore != "")
                {
                    Version ignoredVersion = new Version(ignore);
                    if(ignoredVersion.CompareTo(newVersion)<0) 
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }

            
                


        }

    }
}
