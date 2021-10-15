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
		const string FILENAME = "RGBDS_EM.ini";
		

		public Window()
		{
			InitializeComponent();

			TBasm.Text = "";
			TBlink.Text = "-m _GBPROGRAM_.map -n _GBPROGRAM_.sym -o _GBPROGRAM_.gb";
			TBfix.Text = "-v -p 0 _GBPROGRAM_.gb";

			if (File.Exists(FILENAME))
			{
				try
				{
					var lines = File.ReadAllLines(FILENAME);
					TBasm.Text = lines[0];
					TBlink.Text = lines[1];
					TBfix.Text = lines[2];
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
			RETRY:
			try
			{
				File.WriteAllText(FILENAME, string.Join("\n", TBasm.Text, TBlink.Text, TBfix.Text));
			}
			catch
			{
				switch(MessageBox.Show("設定ファイルの保存に失敗しました。\n再試行しますか？", "書き込みエラー", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
				{
					case DialogResult.Yes:
						goto RETRY;
					case DialogResult.Cancel:
						return;//★breakではない。
				}
			}

			Close();
		}

		private void btnClose_Click(object sender, EventArgs e) => Close();
	}
}
