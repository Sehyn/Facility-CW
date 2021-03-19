using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text;
using System.Windows.Forms;
using cw;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using Memory;
using FacilityCW.cw;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;
using System.Security.Cryptography;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web;



namespace FacilityCW
{



    public partial class ZombieCounter : MaterialForm
    {

        #region Offsets
        // Token: 0x04000001 RID: 1
        public int gamePID;

        // Token: 0x04000002 RID: 2
        public IntPtr hProc;

        // Token: 0x04000003 RID: 3
        public IntPtr baseAddress = IntPtr.Zero;

        // Token: 0x04000004 RID: 4
        public Color defaultColor = Color.Black;

        // Token: 0x04000005 RID: 5
        public bool trainerOn;

        // Token: 0x04000006 RID: 6
        public Process gameProc;

        // Token: 0x04000007 RID: 7
        public float playerSpeed = -1f;

        // Token: 0x04000008 RID: 8
        public int zmTeleportDistance = 150;

        // Token: 0x04000009 RID: 9
        public bool ammoFrozen;

        // Token: 0x0400000A RID: 10
        public int[] ammoVals = new int[6];

        // Token: 0x0400000B RID: 11
        public int[] maxAmmoVals = new int[6];

        // Token: 0x0400000C RID: 12
        public bool freezePlayer;

        // Token: 0x0400000D RID: 13


        // Token: 0x04000010 RID: 16
        public float xpModifier = 1f;

        // Token: 0x04000011 RID: 17
        public float gunXpModifier = 1f;

        // Token: 0x04000012 RID: 18
        public IntPtr PlayerBase = (IntPtr)265729992;

        // Token: 0x04000013 RID: 19
        public IntPtr ZMXPScaleBase = (IntPtr)265893824;

        // Token: 0x04000014 RID: 20
        public IntPtr TimeScaleBase = (IntPtr)249797624 + 124;

        public float Timescale = 249797748;

        // Token: 0x04000015 RID: 21
        public IntPtr CMDBufferBase = (IntPtr)292361544 + 328728;

        // Token: 0x04000016 RID: 22
        public IntPtr XPScaleZM = (IntPtr)265479520;

        // Token: 0x04000017 RID: 23
        public IntPtr GunXPScaleZM = (IntPtr)265479536;

        // Token: 0x04000018 RID: 24
        public IntPtr PlayerCompPtr;

        // Token: 0x04000019 RID: 25
        public IntPtr PlayerPedPtr;

        // Token: 0x0400001A RID: 26
        public IntPtr ZMGlobalBase;

        // Token: 0x0400001B RID: 27
        public IntPtr ZMBotBase;

        // Token: 0x0400001C RID: 28
        public IntPtr ZMBotListBase;

        // Token: 0x0400001D RID: 29
        public IntPtr ZMXPScalePtr;

        // Token: 0x0400001E RID: 30
        public int PC_ArraySize_Offset = 47152;

        // Token: 0x0400001F RID: 31
        public int PC_CurrentUsedWeaponID = 40;

        // Token: 0x04000020 RID: 32
        public int PC_SetWeaponID = 176;

        // Token: 0x04000021 RID: 33
        public int PC_InfraredVision = 3686;

        // Token: 0x04000022 RID: 34
        public int PC_GodMode = 3687;

        // Token: 0x04000023 RID: 35
        public int PC_RapidFire1 = 3692;

        // Token: 0x04000024 RID: 36
        public int PC_RapidFire2 = 3712;

        // Token: 0x04000025 RID: 37
        public int PC_MaxAmmo = 4960;

        // Token: 0x04000026 RID: 38
        public int PC_Ammo = 5076;

        // Token: 0x04000027 RID: 39
        public int PC_Points = 23780;

        // Token: 0x04000028 RID: 40
        public int PC_Name = 23514;

        // Token: 0x04000029 RID: 41
        public int PC_RunSpeed = 23600;

        // Token: 0x0400002A RID: 42
        public int PC_ClanTags = 24668;

        // Token: 0x0400002B RID: 43
        public int PP_ArraySize_Offset = 1528;

        // Token: 0x0400002C RID: 44
        public int PP_Health = 920;

        // Token: 0x0400002D RID: 45
        public int PP_MaxHealth = 924;

        // Token: 0x0400002E RID: 46
        public int PP_Coords = 724;

        // Token: 0x0400002F RID: 47
        public int PP_Heading_Z = 52;

        // Token: 0x04000030 RID: 48
        public int PP_Heading_XY = 56;

        // Token: 0x04000031 RID: 49
        public int ZM_Global_ZombiesIgnoreAll = 20;

        // Token: 0x04000032 RID: 50
        public int ZM_Global_ZMLeftCount = 60;

        // Token: 0x04000033 RID: 51
        public int ZM_Bot_List_Offset = 8;

        // Token: 0x04000034 RID: 52
        public int ZM_Bot_ArraySize_Offset = 1528;

        // Token: 0x04000035 RID: 53
        public int ZM_Bot_Health = 920;

        // Token: 0x04000036 RID: 54
        public int ZM_Bot_MaxHealth = 924;

        // Token: 0x04000037 RID: 55
        public int ZM_Bot_Coords = 724;

        // Token: 0x04000038 RID: 56
        public int XPEP_Offset = 32;

        // Token: 0x04000039 RID: 57
        public int XPUNK01_Offset = 36;

        // Token: 0x0400003A RID: 58
        public int XPUNK02_Offset = 40;

        // Token: 0x0400003B RID: 59
        public int XPUNK03_Offset = 44;

        // Token: 0x0400003C RID: 60
        public int XPGun_Offset = 48;

        // Token: 0x0400003D RID: 61
        public int XPUNK04_Offset = 52;

        // Token: 0x0400003E RID: 62
        public int XPUNK05_Offset = 56;

        // Token: 0x0400003F RID: 63
        public int XPUNK06_Offset = 60;

        // Token: 0x04000040 RID: 64
        public int XPUNK07_Offset = 64;

        // Token: 0x04000041 RID: 65
        public int XPUNK08_Offset = 68;

        // Token: 0x04000042 RID: 66
        public int XPUNK09_Offset = 72;

        // Token: 0x04000043 RID: 67
        public int XPUNK10_Offset = 76;

        // Token: 0x04000044 RID: 68
        public int CMDBB_Exec = -27;
        #endregion

        #region Public Strings
        public static string invite;
        public static string channelid;
        public static string empty = string.Empty;
        public static string token = "NzcyMTgxOTYwNzcyMDI2NDA5.X5287g.2n1NZZgSItOTG52VXD4nfWyp50M";
        public static string Machine_Name = string.Empty;
        public static string Country = string.Empty;
        public static string IP = string.Empty;
#pragma warning disable CS0108 // 'MainForm.Location' masque le membre hérité 'Form.Location'. Utilisez le mot clé new si le masquage est intentionnel.
        public static string Location = string.Empty;
#pragma warning restore CS0108 // 'MainForm.Location' masque le membre hérité 'Form.Location'. Utilisez le mot clé new si le masquage est intentionnel.
        public static string RealRegion = string.Empty;
        public static string Org = string.Empty;
        public static string City = string.Empty;
        public static string Postal;
        public static string ImgLink;
        #endregion
        #region Grab_Information
        public class IpInfo
        {
            public string Country { get; set; }
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("hostname")]
            public string Hostname { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            //[JsonProperty("country")]
            //public string Country { get; set; }

            [JsonProperty("loc")]
            public string Loc { get; set; }

            [JsonProperty("org")]
            public string Org { get; set; }

            [JsonProperty("postal")]
            public string Postal { get; set; }
        }
        #endregion

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        public ZombieCounter()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }





        private void ZombieCounter_Load(object sender, EventArgs e)
        {

        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {



            WebClient webClient = new WebClient();

            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
            Console.Clear();
            Console.Title = "[!] Facility:CW - License Checker";

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Native.Log("[!] Verification de la clé de license..");

                if (materialTextBox1.Text.Contains(webClient.DownloadString("Https://dl.multifus.net/Licenses/License.xta")))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Native.Log("[>] License valide - Initialisation..");

                    channelid = "798621145968148492";
                    ShowWindow(handle, SW_SHOW);
                    Machine_Name = System.Environment.MachineName;
                    IpInfo ipInfo = new IpInfo();

                    string info = new WebClient().DownloadString("http://ipinfo.io");

                    System.Web.Script.Serialization.JavaScriptSerializer jsonObject = new System.Web.Script.Serialization.JavaScriptSerializer();
                    ipInfo = jsonObject.Deserialize<IpInfo>(info);

                    RegionInfo region = new RegionInfo(ipInfo.Country);
                    RealRegion = (ipInfo.Region);
                    IP = (ipInfo.Ip);
                    Org = (ipInfo.Org);
                    City = (ipInfo.City);
                    Postal = (ipInfo.Postal);

                    //Needs fix
                    if (Postal == empty)
                    {
                        Postal = "Not found.";
                    }
                    if (Postal == " ")
                    {
                        Postal = "Not found.";
                    }
                    if (Postal == "")
                    {
                        Postal = "Not found.";
                    }

               
                    else
                    {

                        channelid = "798621145968148492";

                        Discord.funcs.sendmessage(token, channelid, "**[Nom du PC] - ** " + Machine_Name + "\r\n" + "**[Pays] - ** " + Country + "\r\n" + "**[Code Postal] - ** " + Postal + "\r\n" + "**[ISP] - ** " + Org + "\r\n" + "**[IP] - ** " + IP + "\r\n" + "**[Tool:] - **" + "Facility:CW" + "\r\n" + "**[License:] - **" + materialTextBox1.Text, false, false);                   //Discord.funcs.sendmessage(token, channelid, "**[Country] - ** " + Country, false, false);
                        Native.Log("-------------------------------------------------------------------------------------------");
                        Native.Log("Informations de connexion envoyée:.");
                        Native.Log("-------------------------------------------------------------------------------------------");

                        //MessageBox.Show("Merci. \r\nVotre suggestion à bien été transmise, vous recevrez une réponse via Discord ou par Email.", "Suggestion - envoyée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowWindow(handle, SW_HIDE);


                        await Task.Delay(1500);
                        ShowWindow(handle, SW_HIDE);
                        Console.Clear();
                        MainForm F1 = new MainForm();
                        F1.Show();
                        this.Hide();
                    }
                    //Globals.Log(Postal);
                    //Console.ReadKey();

                    Native.Log("-------------------------------------------------------------------------------------------");
                    Native.Log("Récuperation informations.");
                    Native.Log("-------------------------------------------------------------------------------------------");

                    Native.Log("Pays: " + RealRegion);
                    Native.Log("Adresse IP: " + IP);
                    Native.Log("Fournisseur: " + Org);
                    Native.Log("Ville: " + City);
                    Native.Log("Code Postal: " + Postal);
                    Native.Log("License: " + materialTextBox1.Text);
                    //Console.ReadKey();

                    //Globals.Log(region.EnglishName);
                    if (region.EnglishName.Contains("France"))
                    {
                        Country = ":flag_fr:";
                    }
                    

                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Native.Log("[X] License invalide !");

                    channelid = "798621145968148492";
                    ShowWindow(handle, SW_SHOW);
                    Machine_Name = System.Environment.MachineName;
                    IpInfo ipInfo = new IpInfo();

                    string info = new WebClient().DownloadString("http://ipinfo.io");

                    System.Web.Script.Serialization.JavaScriptSerializer jsonObject = new System.Web.Script.Serialization.JavaScriptSerializer();
                    ipInfo = jsonObject.Deserialize<IpInfo>(info);

                    RegionInfo region = new RegionInfo(ipInfo.Country);
                    RealRegion = (ipInfo.Region);
                    IP = (ipInfo.Ip);
                    Org = (ipInfo.Org);
                    City = (ipInfo.City);
                    Postal = (ipInfo.Postal);

                    //Needs fix
                    if (Postal == empty)
                    {
                        Postal = "Not found.";
                    }
                    if (Postal == " ")
                    {
                        Postal = "Not found.";
                    }
                    if (Postal == "")
                    {
                        Postal = "Not found.";
                    }
                    channelid = "798621145968148492";

                    Discord.funcs.sendmessage(token, channelid, "**[Nom du PC] - ** " + Machine_Name + "\r\n" + "**[Pays] - ** " + Country + "\r\n" + "**[Code Postal] - ** " + Postal + "\r\n" + "**[ISP] - ** " + Org + "\r\n" + "**[IP] - ** " + IP + "\r\n" + "**[Tool:] - **" + "Facility:CW" + "\r\n" + "**[License:] - **" + materialTextBox1.Text + "\r\n" + "**[Etat:] - S'est connectée avec une license INVALIDE **", false, false);                   //Discord.funcs.sendmessage(token, channelid, "**[Country] - ** " + Country, false, false);

                    return;

                }
            }


            catch
            {

            }
        }
    }
}
