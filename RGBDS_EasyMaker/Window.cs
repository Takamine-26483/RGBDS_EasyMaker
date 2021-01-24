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

			bool err;
			(TBasm.Text, TBlink.Text,TBfix.Text , err) = ReadExtraArgs();
			if(err)
				MessageBox.Show("設定ファイルの読み込みに失敗しました。初期設定で起動します。", "読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}


		static public (string asm,string link,string fix, bool err) ReadExtraArgs()
		{
			const string asm_default = "";
			const string link_default = "-m _GBPROGRAM_.map -n _GBPROGRAM_.sym -o _GBPROGRAM_.gb";
			const string fix_default = "-v -p 0 _GBPROGRAM_.gb";

			if (File.Exists(filename))
			{
				try
				{
					var lines = File.ReadAllLines(filename);
					if (lines.Length >= 3)
						return (lines[0], lines[1], lines[2], false);
					else
						throw new IOException();
				}
				catch (Exception)
				{
					return (asm_default, link_default, fix_default, true);
				}
			}
			return (asm_default, link_default, fix_default, false);
		}

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
