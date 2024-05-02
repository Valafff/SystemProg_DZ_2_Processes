namespace DZ_2_ChildrenProcesses
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			groupBox1 = new GroupBox();
			bt_Start = new Button();
			lb_AppStatus = new Label();
			cb_Apps = new ComboBox();
			groupBox2 = new GroupBox();
			lb_AppStatus2 = new Label();
			bt_shudown = new Button();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			bt_Start2 = new Button();
			cb_Apps2 = new ComboBox();
			label2 = new Label();
			groupBox3 = new GroupBox();
			label4 = new Label();
			bt_Execute = new Button();
			cb_symbol = new ComboBox();
			num_arg2 = new NumericUpDown();
			num_arg1 = new NumericUpDown();
			groupBox4 = new GroupBox();
			tb_Path = new TextBox();
			label5 = new Label();
			bt_Search = new Button();
			tb_targetSymbol = new TextBox();
			label3 = new Label();
			bt_GenerateFile = new Button();
			rtb_SomeText = new RichTextBox();
			label1 = new Label();
			tableLayoutPanel1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)num_arg2).BeginInit();
			((System.ComponentModel.ISupportInitialize)num_arg1).BeginInit();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
			tableLayoutPanel1.Controls.Add(groupBox3, 1, 0);
			tableLayoutPanel1.Controls.Add(groupBox4, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(bt_Start);
			groupBox1.Controls.Add(lb_AppStatus);
			groupBox1.Controls.Add(cb_Apps);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(394, 219);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Задание 1";
			// 
			// bt_Start
			// 
			bt_Start.Location = new Point(136, 37);
			bt_Start.Name = "bt_Start";
			bt_Start.Size = new Size(145, 23);
			bt_Start.TabIndex = 3;
			bt_Start.Text = "Старт";
			bt_Start.UseVisualStyleBackColor = true;
			bt_Start.Click += bt_Start_Click;
			// 
			// lb_AppStatus
			// 
			lb_AppStatus.AutoSize = true;
			lb_AppStatus.Location = new Point(9, 76);
			lb_AppStatus.Name = "lb_AppStatus";
			lb_AppStatus.Size = new Size(153, 15);
			lb_AppStatus.TabIndex = 2;
			lb_AppStatus.Text = "Приложение не запущено";
			// 
			// cb_Apps
			// 
			cb_Apps.FormattingEnabled = true;
			cb_Apps.Items.AddRange(new object[] { "charmap", "notepad", "cmd" });
			cb_Apps.Location = new Point(9, 38);
			cb_Apps.Name = "cb_Apps";
			cb_Apps.Size = new Size(121, 23);
			cb_Apps.TabIndex = 1;
			cb_Apps.TextChanged += cb_Apps_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lb_AppStatus2);
			groupBox2.Controls.Add(bt_shudown);
			groupBox2.Controls.Add(radioButton2);
			groupBox2.Controls.Add(radioButton1);
			groupBox2.Controls.Add(bt_Start2);
			groupBox2.Controls.Add(cb_Apps2);
			groupBox2.Controls.Add(label2);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(3, 228);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(394, 219);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Задание 2";
			// 
			// lb_AppStatus2
			// 
			lb_AppStatus2.AutoSize = true;
			lb_AppStatus2.Location = new Point(17, 168);
			lb_AppStatus2.Name = "lb_AppStatus2";
			lb_AppStatus2.Size = new Size(153, 15);
			lb_AppStatus2.TabIndex = 8;
			lb_AppStatus2.Text = "Приложение не запущено";
			// 
			// bt_shudown
			// 
			bt_shudown.Enabled = false;
			bt_shudown.Location = new Point(17, 133);
			bt_shudown.Name = "bt_shudown";
			bt_shudown.Size = new Size(156, 23);
			bt_shudown.TabIndex = 7;
			bt_shudown.Text = "Завершить процесс";
			bt_shudown.UseVisualStyleBackColor = true;
			bt_shudown.Click += bt_shudown_Click;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(17, 108);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(331, 19);
			radioButton2.TabIndex = 6;
			radioButton2.Text = "Принудительно завершить работу дочернего процесса";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(17, 83);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(243, 19);
			radioButton1.TabIndex = 5;
			radioButton1.TabStop = true;
			radioButton1.Text = "Ожитадь закрытия дочернего процесса";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// bt_Start2
			// 
			bt_Start2.Location = new Point(145, 37);
			bt_Start2.Name = "bt_Start2";
			bt_Start2.Size = new Size(145, 23);
			bt_Start2.TabIndex = 4;
			bt_Start2.Text = "Старт";
			bt_Start2.UseVisualStyleBackColor = true;
			bt_Start2.Click += bt_Start2_Click;
			// 
			// cb_Apps2
			// 
			cb_Apps2.FormattingEnabled = true;
			cb_Apps2.Items.AddRange(new object[] { "charmap", "notepad", "cmd" });
			cb_Apps2.Location = new Point(9, 37);
			cb_Apps2.Name = "cb_Apps2";
			cb_Apps2.Size = new Size(121, 23);
			cb_Apps2.TabIndex = 2;
			cb_Apps2.TextChanged += cb_Apps2_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(9, 19);
			label2.Name = "label2";
			label2.Size = new Size(272, 15);
			label2.TabIndex = 1;
			label2.Text = "Укажите или выберете приложение для запуска";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(bt_Execute);
			groupBox3.Controls.Add(cb_symbol);
			groupBox3.Controls.Add(num_arg2);
			groupBox3.Controls.Add(num_arg1);
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(403, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(394, 219);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Задание 3";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 33);
			label4.Name = "label4";
			label4.Size = new Size(113, 15);
			label4.TabIndex = 5;
			label4.Text = "Задайте аргументы";
			// 
			// bt_Execute
			// 
			bt_Execute.Location = new Point(6, 80);
			bt_Execute.Name = "bt_Execute";
			bt_Execute.Size = new Size(379, 23);
			bt_Execute.TabIndex = 4;
			bt_Execute.Text = "Выполнить расчет";
			bt_Execute.UseVisualStyleBackColor = true;
			bt_Execute.Click += bt_Execute_Click;
			// 
			// cb_symbol
			// 
			cb_symbol.FormattingEnabled = true;
			cb_symbol.Items.AddRange(new object[] { "+", "-", "*", "/" });
			cb_symbol.Location = new Point(138, 51);
			cb_symbol.Name = "cb_symbol";
			cb_symbol.Size = new Size(121, 23);
			cb_symbol.TabIndex = 3;
			// 
			// num_arg2
			// 
			num_arg2.Location = new Point(265, 51);
			num_arg2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			num_arg2.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
			num_arg2.Name = "num_arg2";
			num_arg2.Size = new Size(120, 23);
			num_arg2.TabIndex = 2;
			// 
			// num_arg1
			// 
			num_arg1.Location = new Point(6, 51);
			num_arg1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			num_arg1.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
			num_arg1.Name = "num_arg1";
			num_arg1.Size = new Size(120, 23);
			num_arg1.TabIndex = 1;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(tb_Path);
			groupBox4.Controls.Add(label5);
			groupBox4.Controls.Add(bt_Search);
			groupBox4.Controls.Add(tb_targetSymbol);
			groupBox4.Controls.Add(label3);
			groupBox4.Controls.Add(bt_GenerateFile);
			groupBox4.Controls.Add(rtb_SomeText);
			groupBox4.Controls.Add(label1);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(403, 228);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(394, 219);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Задание 4";
			// 
			// tb_Path
			// 
			tb_Path.Location = new Point(92, 148);
			tb_Path.Name = "tb_Path";
			tb_Path.Size = new Size(293, 23);
			tb_Path.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 148);
			label5.Name = "label5";
			label5.Size = new Size(80, 15);
			label5.TabIndex = 5;
			label5.Text = "Путь к файлу";
			// 
			// bt_Search
			// 
			bt_Search.Location = new Point(6, 191);
			bt_Search.Name = "bt_Search";
			bt_Search.Size = new Size(379, 22);
			bt_Search.TabIndex = 4;
			bt_Search.Text = "Поиск";
			bt_Search.UseVisualStyleBackColor = true;
			bt_Search.Click += bt_Search_Click;
			// 
			// tb_targetSymbol
			// 
			tb_targetSymbol.Location = new Point(125, 123);
			tb_targetSymbol.Name = "tb_targetSymbol";
			tb_targetSymbol.Size = new Size(260, 23);
			tb_targetSymbol.TabIndex = 3;
			tb_targetSymbol.Text = "bicycle";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 126);
			label3.Name = "label3";
			label3.Size = new Size(106, 15);
			label3.TabIndex = 2;
			label3.Text = "Слово для поиска";
			// 
			// bt_GenerateFile
			// 
			bt_GenerateFile.Location = new Point(6, 100);
			bt_GenerateFile.Name = "bt_GenerateFile";
			bt_GenerateFile.Size = new Size(379, 23);
			bt_GenerateFile.TabIndex = 1;
			bt_GenerateFile.Text = "Создать файл";
			bt_GenerateFile.UseVisualStyleBackColor = true;
			bt_GenerateFile.Click += bt_GenerateFile_Click;
			// 
			// rtb_SomeText
			// 
			rtb_SomeText.Location = new Point(6, 38);
			rtb_SomeText.Name = "rtb_SomeText";
			rtb_SomeText.Size = new Size(379, 56);
			rtb_SomeText.TabIndex = 0;
			rtb_SomeText.Text = "bicycle bicycle bicycle";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(160, 15);
			label1.TabIndex = 0;
			label1.Text = "Задайте текс для обработки";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "ДЗ_2_Процессы";
			tableLayoutPanel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)num_arg2).EndInit();
			((System.ComponentModel.ISupportInitialize)num_arg1).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private ComboBox cb_Apps;
		private Label label1;
		private Label lb_AppStatus;
		private Button bt_Start;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Button bt_Start2;
		private ComboBox cb_Apps2;
		private Label label2;
		private Button bt_shudown;
		private Label lb_AppStatus2;
		private NumericUpDown num_arg1;
		private ComboBox cb_symbol;
		private NumericUpDown num_arg2;
		private Button bt_Execute;
		private RichTextBox rtb_SomeText;
		private Button bt_Search;
		private TextBox tb_targetSymbol;
		private Label label3;
		private Button bt_GenerateFile;
		private Label label4;
		private TextBox tb_Path;
		private Label label5;
	}
}
