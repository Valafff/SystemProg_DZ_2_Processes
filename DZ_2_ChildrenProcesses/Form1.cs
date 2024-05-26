using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZ_2_ChildrenProcesses
{
	public partial class Form1 : Form
	{
		int ExitCode;
		Process ChildProcess;
		string ProcessName;
		string ChildPath;
		string FilePath;

		public Form1()
		{
			InitializeComponent();
			cb_Apps.SelectedIndex = 0;
			cb_Apps2.SelectedIndex = 0;
			cb_symbol.SelectedIndex = 0;
		}


		private void cb_Apps_TextChanged(object sender, EventArgs e)
		{
			ProcessName = cb_Apps.Text;
		}
		private void bt_Start_Click(object sender, EventArgs e)
		{
			try
			{
				Process ChildProc = new Process();
				ChildProc.StartInfo = new System.Diagnostics.ProcessStartInfo(ProcessName);
				ChildProc.Start();
				lb_AppStatus.Text = $"Запущено приложение {ProcessName}";
				ChildProc.WaitForExit();
				ExitCode = ChildProc.ExitCode;
				lb_AppStatus.Text = $"Приложение {ProcessName} было закрыто с кодом {ExitCode}";
			}
			catch (Exception)
			{
				MessageBox.Show("Приложение не найдено");
			}
		}


		private void cb_Apps2_TextChanged(object sender, EventArgs e)
		{
			ProcessName = cb_Apps.Text;
		}

		private void bt_Start2_Click(object sender, EventArgs e)
		{

			try
			{
				if (radioButton1.Checked)
				{
					Process ChildProc = new Process();
					ChildProc.StartInfo = new System.Diagnostics.ProcessStartInfo(ProcessName);
					ChildProc.Start();
					lb_AppStatus2.Text = $"Запущено приложение {ProcessName}";
					ChildProc.WaitForExit();
					ExitCode = ChildProc.ExitCode;
					lb_AppStatus2.Text = $"Приложение {ProcessName} было закрыто с кодом {ExitCode}";
					bt_shudown.Enabled = false;
				}
				else
				{
					Process ChildProc = new Process();
					ChildProc.StartInfo = new System.Diagnostics.ProcessStartInfo(ProcessName);
					ChildProc.Start();
					lb_AppStatus2.Text = $"Запущено приложение {ProcessName} Нажмите кнопку \"Завершить процесс\"";
					ChildProcess = ChildProc;
					bt_shudown.Enabled = true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Приложение не найдено");
			}

		}

		private void bt_shudown_Click(object sender, EventArgs e)
		{
			ChildProcess.Kill();
			lb_AppStatus2.Text = $"Приложение {ProcessName} было принудительно закрыто";
			bt_shudown.Enabled = false;
		}

		private void bt_Execute_Click(object sender, EventArgs e)
		{
			string t = "net6.0";
			try
			{
				ChildPath = Environment.CurrentDirectory;
				if (ChildPath.Contains("net6.0"))
				{
					t = "net6.0";
				}
				if (ChildPath.Contains("net7.0"))
				{
					t = "net7.0";
				}
				if (ChildPath.Contains("net8.0"))
				{
					t = "net8.0";
				}
				ChildPath = ChildPath.Replace($"\\DZ_2_ChildrenProcesses\\bin\\Debug\\{t}", "\\ChildCalc\\bin\\Debug\\net6.0\\ChildCalc.exe");
				ChildPath = ChildPath.Replace("-windows", "");
				var processInfo = new ProcessStartInfo
				{
					//FileName = @"C:\Users\Vetal\source\repos\SystemProgramming\DZ_2_ChildrenProcesses\ChildCalc\bin\Debug\net6.0\ChildCalc.exe",
					FileName = ChildPath,
					Arguments = $"{num_arg1.Value} {num_arg2.Value} {cb_symbol.Text}",
				};
				var process = new Process { StartInfo = processInfo };
				process.Start();
				process.WaitForExit();
			}
			catch (Exception)
			{
				MessageBox.Show("Дочернее приложение не найдено");
			}

		}

		private void bt_GenerateFile_Click(object sender, EventArgs e)
		{
			using (var saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
				saveFileDialog.Title = "Сохранить файл";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = saveFileDialog.FileName;
					// Сохраните данные в fileName
					File.WriteAllText(fileName, rtb_SomeText.Text);
					FilePath = fileName;
					MessageBox.Show($"Файл сохранен: {fileName}");
				}
			}
			tb_Path.Text = FilePath;
		}

		private void bt_Search_Click(object sender, EventArgs e)
		{
			string t = "net6.0";
			ChildPath = Environment.CurrentDirectory;
			//try
			{
				if (ChildPath.Contains("net6.0"))
				{
					t = "net6.0";
				}
				if (ChildPath.Contains("net7.0"))
				{
					t = "net7.0";
				}
				if (ChildPath.Contains("net8.0"))
				{
					t = "net8.0";
				}
				ChildPath = ChildPath.Replace($"\\DZ_2_ChildrenProcesses\\bin\\Debug\\{t}", "\\ChildSearch\\bin\\Debug\\net6.0\\ChildSearch.exe");
				ChildPath = ChildPath.Replace("-windows", "");
				var processInfo = new ProcessStartInfo
				{
					//FileName = @"C:\Users\Vetal\source\repos\SystemProgramming\DZ_2_ChildrenProcesses\ChildSearch\bin\Debug\net6.0\ChildSearch.exe",
					FileName = ChildPath,
					Arguments = $"{FilePath} {tb_targetSymbol.Text}",
				};
				var process = new Process { StartInfo = processInfo };
				process.Start();
				process.WaitForExit();
			}
			//catch (Exception)
			//{
			//	MessageBox.Show("Ошибка поиска");
			//}

		}
	}
}
