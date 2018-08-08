using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletTransactor
{
	public partial class Form1 : Form
	{
		private const int DEVICE_CHANGE = 0x219;
		private const int DEVICE_ARRIVAL = 0x8000;
		private const int DEVICE_SAFE_REMOVE = 0x8004;
		private const int DEVICE_VOLUME = 0x00000002;

		public Form1()
		{
			InitializeComponent();

			Services.Services._GetFlashDrives(StatusRichTextBox);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == DEVICE_CHANGE)
			{
				Services.Services._GetFlashDrives(StatusRichTextBox);
			}
		}


	}
}
