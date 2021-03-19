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

namespace FacilityCW
{
    public partial class MainForm : MaterialForm
    {
		Mem m = new Mem();
		private readonly MaterialSkinManager materialSkinManager;

		


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

		public int MaxAmmoP2 = 46872;

		// Token: 0x04000009 RID: 9
		public bool ammoFrozen;

		// Token: 0x0400000A RID: 10
		public int[] ammoVals = new int[6];

		// Token: 0x0400000B RID: 11
		public int[] maxAmmoVals = new int[6];

		// Token: 0x0400000C RID: 12
		public bool freezePlayer;

		// Token: 0x0400000D RID: 13
		public Vector3 frozenPlayerPos = Vector3.Zero;


		// Token: 0x0400000E RID: 14
		public Vector3 lastKnownPlayerPos = Vector3.Zero;

		// Token: 0x0400000F RID: 15
		public Vector3 updatedPlayerPos = Vector3.Zero;

		// Token: 0x04000010 RID: 16
		public float xpModifier = 1f;

		// Token: 0x04000011 RID: 17
		public float gunXpModifier = 1f;


		// Token: 0x04000012 RID: 18
		public IntPtr PlayerBase = (IntPtr)265734088;

		// Token: 0x04000013 RID: 19
		public IntPtr ZMXPScaleBase = (IntPtr)265897920;

		// Token: 0x04000014 RID: 20
		public IntPtr TimeScaleBase = (IntPtr)249801720 + 124;

		public float Timescale = 249801720;

		// Token: 0x04000015 RID: 21
		public IntPtr CMDBufferBase = (IntPtr)292365656 + 328728;

		// Token: 0x04000016 RID: 22
		public IntPtr XPScaleZM = (IntPtr)265897920;

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
		public int PP_ArraySize_Points = 23780;


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

		public int XPEP_RealAdd_Offset = 40; // 0x28 Add it really! Use 0x20 for the InGame Visibility. So Combine 0x20 and 0x28 with same Values.

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

		int savedpost;

		public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey700, Primary.Grey100, Accent.Red400, TextShade.WHITE);

            // Add dummy data to the listview
            seedListView();
          
        }

        public void ConsoleOut(string str)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action<string>(this.ConsoleOut), new object[]
                {
                    str
                });
                return;
            }
            DateTime now = DateTime.Now;
            this.textBox1.AppendText(now.ToString("HH:mm:ss - ") + str + Environment.NewLine);
        }
        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            updateColor();
        }

        private int colorSchemeIndex;

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
                colorSchemeIndex = 0;
            updateColor();
        }

        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }

        private void MaterialButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
        }

       
        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder("Batch operation report:\n\n");
            var random = new Random();
            var result = 0;

            for (int i = 0; i < 200; i++)
            {
                result = random.Next(1000);

                if (result < 950)
                {
                    builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                }
                else
                {
                    builder.AppendFormat(" - Task {0}: Operation failed! A very very very very very very very very very very very very serious error has occured during this sub-operation. The errorcode is: {1}).\n", i, result);
                }
            }

            var batchOperationResults = builder.ToString();
            var mresult = MaterialMessageBox.Show(batchOperationResults, "Batch Operation");
        }

        private void AutoFollowChk_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
			for (; ; )
			{
				try
				{
					if (this.trainerOn)
					{
						Process[] processesByName = Process.GetProcessesByName("BlackOpsColdWar");
						if (processesByName.Length < 1)
						{
							//ConsoleOut("Game is not running");
						}
						else
						{
							this.gameProc = processesByName[0];
							this.gamePID = this.gameProc.Id;
							if (this.gamePID > 0)
							{
								//ConsoleOut("Game is running! Process ID: " + this.gamePID.ToString());
								this.hProc = cwapi.OpenProcess(cwapi.ProcessAccessFlags.All, false, this.gameProc.Id);
								if (this.baseAddress != cwapi.GetModuleBaseAddress(this.gameProc, "BlackOpsColdWar.exe"))
								{
									this.baseAddress = cwapi.GetModuleBaseAddress(this.gameProc, "BlackOpsColdWar.exe");
								}
								if (this.PlayerCompPtr != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()), new int[1]))
								{
									this.PlayerCompPtr = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()), new int[1]);
								}
								if (this.PlayerPedPtr != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 8L), new int[1]))
								{
									this.PlayerPedPtr = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 8L), new int[1]);
								}
								if (this.ZMGlobalBase != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 96L), new int[1]))
								{
									this.ZMGlobalBase = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 96L), new int[1]);
								}
								if (this.ZMBotBase != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 104L), new int[1]))
								{
									this.ZMBotBase = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()) + 104, new int[1]);
								}
								if (this.ZMBotBase != (IntPtr)0 && this.ZMBotBase != (IntPtr)104 && this.ZMBotListBase != cwapi.FindDMAAddy(this.hProc, this.ZMBotBase + this.ZM_Bot_List_Offset, new int[1]))
								{
									this.ZMBotListBase = cwapi.FindDMAAddy(this.hProc, this.ZMBotBase + this.ZM_Bot_List_Offset, new int[1]);
								}
								byte[] array = new byte[12];
								IntPtr intPtr;
								cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Coords, array, 12L, out intPtr);
								float num = BitConverter.ToSingle(array, 0);
								float num2 = BitConverter.ToSingle(array, 4);
								float num3 = BitConverter.ToSingle(array, 8);


								this.updatedPlayerPos = new Vector3((float)Math.Round((double)num, 4), (float)Math.Round((double)num2, 4), (float)Math.Round((double)num3, 4));
								if (this.freezePlayer)
								{
									if (this.frozenPlayerPos == Vector3.Zero)
									{
										this.frozenPlayerPos = ((this.lastKnownPlayerPos == Vector3.Zero) ? this.updatedPlayerPos : this.lastKnownPlayerPos);
									}
									this.UpdatePlayerPosition(this.frozenPlayerPos);
								}
								bool flag = false;
								if (this.ZNumerics.Value != (decimal)this.lastKnownPlayerPos.X)
								{
									this.lastKnownPlayerPos.X = (float)this.ZNumerics.Value;
									flag = true;
								}
								else
								{
									this.ZNumerics.Value = (decimal)this.updatedPlayerPos.X;
								}
								if (this.YNumerics.Value != (decimal)this.lastKnownPlayerPos.Y)
								{
									this.lastKnownPlayerPos.Y = (float)this.YNumerics.Value;
									flag = true;
								}
								else
								{
									this.YNumerics.Value = (decimal)this.updatedPlayerPos.Y;
								}
								if (this.ZNumerics.Value != (decimal)this.lastKnownPlayerPos.Z)
								{
									this.lastKnownPlayerPos.Z = (float)this.ZNumerics.Value;
									flag = true;
								}
								else
								{
									this.ZNumerics.Value = (decimal)this.updatedPlayerPos.Z;
								}
								if (flag)
								{
									this.UpdatePlayerPosition(this.lastKnownPlayerPos);
								}


								if (this.AmmoChk.Checked)
								{
									for (int i = 1; i < 6; i++)
									{
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + this.PC_Ammo + i * 4, 20, 4L, out intPtr);
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + MaxAmmoP2 + this.PC_Ammo + i * 4, 20, 4L, out intPtr);

									}
								}

							if(TimescaleChk.Checked)
                                {
                                    m.WriteMemory("BlackOpsColdWar.exe+0xEE3AC74", "float", "5");

                                }
								else
                                {
                                    m.WriteMemory("BlackOpsColdWar.exe+0xEE3AC74", "float", "1");

                                }

								if (this.GodModeChk.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + this.PC_GodMode, 160, 1L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + PP_ArraySize_Offset + this.PC_GodMode , 160, 1L, out intPtr);

								}
								else
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + this.PC_GodMode, 32, 1L, out intPtr);
								}
								if (this.InstaKillChk.Checked)
								{
									for (int j = 0; j < 90; j++)
									{
										cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + this.ZM_Bot_ArraySize_Offset * j + this.ZM_Bot_Health, 1, 4L, out intPtr);
										cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + this.ZM_Bot_ArraySize_Offset * j + this.ZM_Bot_MaxHealth, 1, 4L, out intPtr);
									}
								}
								if(TpZombieToLocChk.Checked)
                                {
									IntPtr Ayy;
									byte[] array3 = new byte[4];
									byte[] array4 = new byte[4];
									cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_XY, array3, 4L, out Ayy);
									cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_Z, array4, 4L, out Ayy);
									double num4 = -this.ConvertToRadians((double)BitConverter.ToSingle(array4, 0));
									double num5 = this.ConvertToRadians((double)BitConverter.ToSingle(array3, 0));
									float x = Convert.ToSingle(Math.Cos(num5) * Math.Cos(num4));
									float y = Convert.ToSingle(Math.Sin(num5) * Math.Cos(num4));
									float z = Convert.ToSingle(Math.Sin(num4));
									Vector3 vector =  new Vector3(371.769f, -27.4684f, 67.3233f);
									byte[] array5 = new byte[12];
									Buffer.BlockCopy(BitConverter.GetBytes(vector.X), 0, array5, 0, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(vector.Y), 0, array5, 4, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(vector.Z), 0, array5, 8, 4);
									for (int k = 0; k < 100; k++)
									{
										cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + this.ZM_Bot_ArraySize_Offset * k + this.ZM_Bot_Coords, array5, 12L, out intPtr);
									}

								}

								// NE PAS TOUCHER !!!
                                if (this.ZombieTPchk.Checked)
                                {
                                    byte[] array3 = new byte[4];
                                    byte[] array4 = new byte[4];
                                    cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_XY, array3, 4L, out intPtr);
                                    cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_Z, array4, 4L, out intPtr);
                                    double num4 = -this.ConvertToRadians((double)BitConverter.ToSingle(array4, 0));
                                    double num5 = this.ConvertToRadians((double)BitConverter.ToSingle(array3, 0));
                                    float x = Convert.ToSingle(Math.Cos(num5) * Math.Cos(num4));
                                    float y = Convert.ToSingle(Math.Sin(num5) * Math.Cos(num4));
                                    float z = Convert.ToSingle(Math.Sin(num4));
                                    Vector3 vector = this.updatedPlayerPos + new Vector3(x, y, z) * (float)this.zmTeleportDistance; 
									byte[] array5 = new byte[12];
                                    Buffer.BlockCopy(BitConverter.GetBytes(vector.X), 0, array5, 0, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(vector.Y), 0, array5, 4, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(vector.Z), 0, array5, 8, 4);
                                    for (int k = 0; k < 90; k++)
                                    {
                                        cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + this.ZM_Bot_ArraySize_Offset * k + this.ZM_Bot_Coords, array5, 12L, out intPtr);
                                    }
                                }

                                if (this.UnlimitedCashChk.Checked)
                                {
                                    cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + this.PC_Points, 100000, 8L, out intPtr);
                                }


								if (this.PlayerSpeedChk.Checked)
								{
									//cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + this.PC_Points, 100000, 8L, out intPtr);
									m.WriteMemory("BlackOpsColdWar.exe+0xFD6C7C8,0x5C30", "float", PlayerSpeedNumeric.Value.ToString()); ;

								}

								if (this.EXPModifierChk.Checked)
                                {
                                    if (this.WeaponNumeric.Value <= 0m)
                                    {
                                        byte[] array6 = new byte[4];
                                        cwapi.ReadProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + this.XPGun_Offset, array6, 4L, out intPtr);
                                        this.WeaponNumeric.Value = (decimal)BitConverter.ToSingle(array6, 0);
                                        this.WeaponTrkBar.Value = (int)BitConverter.ToSingle(array6, 0);
                                    }
                                    if (this.PlayerNumeric.Value <= 0m)
                                    {
                                        byte[] array7 = new byte[4];
                                        cwapi.ReadProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + this.XPUNK02_Offset, array7, 4L, out intPtr);
                                        this.PlayerNumeric.Value = (decimal)BitConverter.ToSingle(array7, 0);
                                        this.PlayerTrkBar.Value = (int)BitConverter.ToSingle(array7, 0);
                                    }
                                    byte[] array8 = new byte[4];
                                    Buffer.BlockCopy(BitConverter.GetBytes(this.gunXpModifier), 0, array8, 0, 4);
                                    byte[] array9 = new byte[4];
                                    Buffer.BlockCopy(BitConverter.GetBytes(this.xpModifier), 0, array9, 0, 4);
                                    cwapi.WriteProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + this.XPGun_Offset, array8, 4L, out intPtr);
                                    cwapi.WriteProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + this.XPUNK02_Offset, array9, 4L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + this.XPEP_RealAdd_Offset, array9, 4L, out intPtr);

								}
								byte[] array10 = new byte[4];
                                cwapi.ReadProcessMemory(this.hProc, this.ZMGlobalBase + this.ZM_Global_ZMLeftCount, array10, 4L, out intPtr);
                                this.ZombiesLeftLbl.Text = "Zombies Left: " + BitConverter.ToInt32(array10, 0).ToString();
                                this.lastKnownPlayerPos = this.updatedPlayerPos;
                                if (Marshal.GetLastWin32Error() != 0)
                                {
                                    this.ConsoleOut(Marshal.GetLastWin32Error().ToString());
                                }
                            }
                            else
							{
								//ConsoleOut("Game is not running");
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ConsoleOut(ex.Message);
				}
			}
		}

        private void btnOnOff_Click(object sender, EventArgs e)
        {
			this.trainerOn = !this.trainerOn;
			if (this.trainerOn)
			{
				this.btnOnOff.Text = "HOOKED";
				this.ConsoleOut("Facility:CW - Enabled");
				//timer1.Start();
				m.OpenProcess("BlackOpsColdWar");

				return;
			}
			this.btnOnOff.Text = "UNHOOKED";
			this.ConsoleOut("Facility:CW - Disabled");
		}


		public string ToHex(object num)
		{
			return string.Format("0x{0:X}", num);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000348D File Offset: 0x0000168D
		public double ConvertToRadians(double angle)
		{
			return 0.017453292519943295 * angle;
		}

		public void UpdatePlayerPosition(Vector3 pos)
		{
			byte[] array = new byte[12];
			Buffer.BlockCopy(BitConverter.GetBytes(pos.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(pos.Y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(pos.Z), 0, array, 8, 4);
			IntPtr intPtr;
			cwapi.WriteProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Coords, array, 12L, out intPtr);
		}

		

        private void MainForm_Load(object sender, EventArgs e)
        {
			if (!this.backgroundWorker1.IsBusy)
			{
				this.backgroundWorker1.RunWorkerAsync();
			}
		}

        private void GodModeChk_CheckedChanged(object sender, EventArgs e)
        {
			if(GodModeChk.Checked == true)
            {
				ConsoleOut("[+] God Mode has been enabled.");

			}
            else
            {
				ConsoleOut("[-] God Mode has been disabled.");

			}
		}

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
			
		}

        private void WeaponTrkBar_Scroll(object sender, EventArgs e)
        {
			this.gunXpModifier = (float)this.WeaponTrkBar.Value;
			this.WeaponNumeric.Value = this.WeaponTrkBar.Value;
		}

        private void WeaponNumeric_ValueChanged(object sender, EventArgs e)
        {
			this.gunXpModifier = (float)this.WeaponNumeric.Value;
			this.WeaponTrkBar.Value = (int)this.WeaponNumeric.Value;
		}

        private void PlayerTrkBar_Scroll(object sender, EventArgs e)
        {
			this.xpModifier = (float)this.PlayerTrkBar.Value;
			this.PlayerNumeric.Value = (int)this.PlayerTrkBar.Value;
		}

        private void PlayerNumeric_ValueChanged(object sender, EventArgs e)
        {
			this.xpModifier = (float)this.PlayerNumeric.Value;
			this.PlayerTrkBar.Value = (int)this.PlayerNumeric.Value;
		}

        private void AmmoChk_CheckedChanged(object sender, EventArgs e)
        {
			if (AmmoChk.Checked == true)
			{
				ConsoleOut("[+] Infinite Ammo has been enabled.");

			}
			else
			{
				ConsoleOut("[-] Infinite Ammo has been disabled.");

			}
		}

        private void InstaKillChk_CheckedChanged(object sender, EventArgs e)
        {
			if (InstaKillChk.Checked == true)
			{
				ConsoleOut("[+] Insta Kill has been enabled.");

			}
			else
			{
				ConsoleOut("[-] Insta Kill has been disabled.");

			}
		}

        private void ZombieTPchk_CheckedChanged(object sender, EventArgs e)
        {
			if (ZombieTPchk.Checked == true)
			{
				ConsoleOut("[+] Teleport Zombie to crosshair has been enabled.");

			}
			else
			{
				ConsoleOut("[+] Teleport Zombie to crosshair has been enabled.");

			}
		}

        private void UnlimitedCashChk_CheckedChanged(object sender, EventArgs e)
        {
			if (UnlimitedCashChk.Checked == true)
			{
				ConsoleOut("[+] Unlimited Cash has been enabled.");

			}
			else
			{
				ConsoleOut("[-] Unlimited Cash has been disabled.");

			}
		}

        private void EXPModifierChk_CheckedChanged(object sender, EventArgs e)
        {
			if (EXPModifierChk.Checked == true)
			{
				ConsoleOut("[+] EXP Modifier has been enabled.");

			}
			else
			{
				ConsoleOut("[-] EXP Modifier has been disabled.");

			}
		}

        private void materialButton4_Click(object sender, EventArgs e)
        {
			tabPage7.Show();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

			ZombieCounter F1 = new ZombieCounter();
			F1.Show();

		}

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
		
				this.PlayerSpeedNumeric.Value = this.PlayerSpeedTrk.Value;
			

		
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
			this.PlayerSpeedTrk.Value = (int)this.PlayerSpeedNumeric.Value;
		}

        private void PlayerSpeedChk_CheckedChanged(object sender, EventArgs e)
        {
			if (PlayerSpeedChk.Checked == true)
			{
				ConsoleOut("[+] Player Speed has been enabled.");

			}
			else
			{
				ConsoleOut("[-] Player Speed has been disabled.");

			}
		}

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
			IntPtr intPtr;
			byte[] array3 = new byte[4];
			byte[] array4 = new byte[4];
			cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_XY, array3, 4L, out intPtr);
			cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + this.PP_Heading_Z, array4, 4L, out intPtr);
			double num4 = -this.ConvertToRadians((double)BitConverter.ToSingle(array4, 0));
			double num5 = this.ConvertToRadians((double)BitConverter.ToSingle(array3, 0));
			float x = Convert.ToSingle(Math.Cos(num5) * Math.Cos(num4));
			float y = Convert.ToSingle(Math.Sin(num5) * Math.Cos(num4));
			float z = Convert.ToSingle(Math.Sin(num4));
			Vector3 vector = this.updatedPlayerPos + new Vector3(x, y, z);

			ConsoleOut(updatedPlayerPos.ToString());
			//savedpost = Convert.ToInt32(LocationLbl);

		}

        
    }
}


