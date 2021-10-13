using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RGBDS_EasyMaker
{
	public partial class Window : Form
	{
		const string filename = "RgbdsES.ini";
		

		public Window()
		{
			InitializeComponent();

			TBasm.Text = "";
			TBlink.Text = "-m _GBPROGRAM_.map -n _GBPROGRAM_.sym -o _GBPROGRAM_.gb";
			TBfix.Text = "-v -p 0 _GBPROGRAM_.gb";

			if (File.Exists(filename))
			{
				try
				{
					var lines = File.ReadAllLines(filename);
					if (lines.Length >= 3)
					{
						TBasm.Text = lines[0];
						TBlink.Text = lines[1];
						TBfix.Text = lines[2];
					}
					else
						throw new IOException();
				}
				catch
				{
					MessageBox.Show("設定ファイルの読み込みに失敗しました。初期設定で起動します。", "読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public (string asm, string link, string fix) GetArgs() => (TBasm.Text, TBlink.Text, TBfix.Text);

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			try
			{
				File.WriteAllText(filename, string.Join("\n", TBasm.Text, TBlink.Text, TBfix.Text));
			}
			catch(Exception)
			{
				MessageBox.Show("設定ファイルの保存に失敗しました。", "書き込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Close();
		}

		private void btnClose_Click(object sender, EventArgs e) => Close();
	}
}
