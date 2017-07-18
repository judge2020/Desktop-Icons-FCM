using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.IO;

namespace Desktop_Icons
{
    class Program
    {
        static void Main(string[] args)
        {
            urlShortcutToDesktop("Blue Moon Login", "https://www.bluemoon.com/products/forms_online/login.php");
            urlShortcutToDesktop("FCM University", "https://www.gracehillvision.com/firstcommunities");
            urlShortcutToDesktop("Nexus Payables", "https://payables.nxsap.com/FCM/login.php");
            urlShortcutToDesktop("Notivus", "https://credential.notivus.com/");
            urlShortcutToDesktop("Outlook Web App", "https://webmail.firstcommunities.net/owa");
            urlShortcutToDesktop("PayrollHR", "https://www.firstcommunitieshr.net/hris/");
            urlShortcutToDesktop("Screening Reports, Inc.", "http://www.screeningreports.com/");
            urlShortcutToDesktop("Yardi", "https://www.yardiasp14.com/56437firstcomm/pages/Login.aspx");
        }

        private static void urlShortcutToDesktop(string linkName, string linkUrl)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using(StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=" + linkUrl);
                writer.Flush();
            }
        }
    }
}
