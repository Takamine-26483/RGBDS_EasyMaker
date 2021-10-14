using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RGBDS_EasyMaker
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			if (args.Length >= 1)
				if (args[0] == "/build")
					return Builder.Build();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Window());
			return 0;
		}
	}



	static class Builder
	{
		static public int Build()
		{
			try
			{
				var args = new Window().GetArgs();
				var asmPathes = Directory.GetFiles(Environment.CurrentDirectory, "*.asm", SearchOption.AllDirectories)
					.Concat(Directory.GetFiles(Environment.CurrentDirectory, "*.s", SearchOption.AllDirectories))
					.Select(x => new Uri(Environment.CurrentDirectory + "\\").MakeRelativeUri(new Uri(x)).ToString())
					.OrderBy(x => x)
					.ToArray();


				Console.WriteLine("\n◆ rgbasm  実行(1/3) ◆");
				DoRGBAsm(args.asm, asmPathes);
				Console.WriteLine("\n◆ rgblink 実行(2/3) ◆");
				DoRGBLink(args.link, asmPathes.Select(x => x = Path.ChangeExtension(x, ".o")).ToArray());
				Console.WriteLine("\n◆ rgbfix  実行(3/3) ◆");
				DoRGBFix(args.fix);
			}
			catch
			{
				Console.WriteLine("＜！＞エラーが発生しました。ビルドがここで中止されます。");
#if DEBUG
				Console.ReadKey();
#endif
				return 1;
			}
#if DEBUG
			Console.ReadKey();
#endif
			return 0;
		}

		static void DoRGBLink(string arg, string[] objlist)
			=> Execute("rgblink", arg + " " + string.Join(" ", objlist.Select(x => "\"" + x + "\"")));


		static void DoRGBFix(string arg)
			=> Execute("rgbfix", arg);


		static void DoRGBAsm(string arg, string[] asmPathes)
		{
			foreach (var path in asmPathes)
				Execute("rgbasm", arg + " -o \"" + Path.ChangeExtension(path, ".o") + "\" \"" + path + "\"");
		}

		static int Execute(in string command, in string arg)
		{
			Console.WriteLine(">" + command + " " + arg);
			var process = Process.Start(new ProcessStartInfo(command, arg)
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			process.WaitForExit();

			var so = process.StandardOutput.ReadToEnd();
			var eo = process.StandardError.ReadToEnd();
			Console.Write(so + (so != "" ? "\n" : ""));
			Console.Write(eo + (eo != "" ? "\n" : ""));
			if (process.ExitCode != 0)
				throw new Exception();
			else
				return process.ExitCode;
		}
	}
}
