using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2_ChildrenProcesses
{
	public class User32DlLLImport
	{
		// Коды сообщений
		public const int WM_CLOSE = 0x0010;
		public const int WM_SETTEXT = 0x000C;
		public const int WM_GETTEXT = 0x000D;

		//Подключение FindWindow
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		//Подключение SendMessage
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
	}
}
