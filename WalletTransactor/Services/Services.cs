using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletTransactor.Services
{
	public class Services
	{

		public async static void _GetFlashDrives(RichTextBox Status)
		{

			//ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");
			//foreach (ManagementObject currentObject in theSearcher.Get())
			//{
			//	ManagementObject theSerialNumberObjectQuery = new ManagementObject("Win32_PhysicalMedia.Tag='" + currentObject["DeviceID"] + "'");
			//	MessageBox.Show(theSerialNumberObjectQuery["SerialNumber"].ToString());
			//}

			DriveInfo[] mydrives = DriveInfo.GetDrives();

			foreach (DriveInfo mydrive in mydrives)
			{
				if (mydrive.DriveType == DriveType.Removable)
				{
					if (mydrive.IsReady == true)
					{
						if (mydrive.VolumeLabel == "TRANSACTOR")
						{
							//Read WalletConfiguration.json to validate USB HashKey , and Validate USB Configuration

							Status.Text = "Successfully found transactor Flashdrive.";

							bool isAvailable =  await _GetHost("http://validatefdrive.localhost/api/Validate");

							if (isAvailable)
							{
								Status.Text = "Successfully found host Flashdrive." + Environment.NewLine + "Will get the Appsettings.json";
							}

							else
							{
								Status.Text = "Host Flashdrive is not Found. " + Environment.NewLine + "Will get the Appsettings.json";
							}

						

						}
					}
				}

				else
				{
					Status.Text = "Wallet Host not found Transaction Disabled";
				}
			}
		}

		public static async Task<bool> _GetHost(string path)
		{
			HttpClient client = new HttpClient();

			bool status = null;
			HttpResponseMessage response = await client.GetAsync(path);
			if (response.IsSuccessStatusCode)
			{
				status = await response.Content.ReadAsStringAsync();
			}
			return status;

		}

		public static void _GetJsonSetting()
		{

		}
	}

}
