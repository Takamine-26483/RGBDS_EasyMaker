namespace RGBDS_EasyMaker
{
	partial class Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TBasm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TBfix = new System.Windows.Forms.TextBox();
			this.TBlink = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSaveClose = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TBasm
			// 
			this.TBasm.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.TBasm.Location = new System.Drawing.Point(90, 26);
			this.TBasm.Name = "TBasm";
			this.TBasm.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.TBasm.Size = new System.Drawing.Size(618, 26);
			this.TBasm.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label1.Location = new System.Drawing.Point(18, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "rgbasm";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.TBfix);
			this.groupBox1.Controls.Add(this.TBlink);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.TBasm);
			this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.groupBox1.Location = new System.Drawing.Point(12, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(975, 141);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "コマンドライン引数";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label7.Location = new System.Drawing.Point(714, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 19);
			this.label7.TabIndex = 9;
			this.label7.Text = "+ \" *.o\"";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label4.Location = new System.Drawing.Point(714, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "+ \" -o *.o asmﾌｧｲﾙ\"";
			// 
			// TBfix
			// 
			this.TBfix.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.TBfix.Location = new System.Drawing.Point(90, 90);
			this.TBfix.Name = "TBfix";
			this.TBfix.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.TBfix.Size = new System.Drawing.Size(618, 26);
			this.TBfix.TabIndex = 5;
			// 
			// TBlink
			// 
			this.TBlink.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.TBlink.Location = new System.Drawing.Point(90, 58);
			this.TBlink.Name = "TBlink";
			this.TBlink.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.TBlink.Size = new System.Drawing.Size(618, 26);
			this.TBlink.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label3.Location = new System.Drawing.Point(18, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "rgblink";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label2.Location = new System.Drawing.Point(18, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "rgbfix";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Location = new System.Drawing.Point(222, 320);
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(202, 34);
			this.btnSaveClose.TabIndex = 9;
			this.btnSaveClose.Text = "変更を保存して終了";
			this.btnSaveClose.UseVisualStyleBackColor = true;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(550, 320);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(202, 34);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "変更を破棄して終了";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(975, 130);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "使い方";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label9.Location = new System.Drawing.Point(86, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(372, 19);
			this.label9.TabIndex = 4;
			this.label9.Text = "・rgbasm→rgblink→rgbfixの順で実行されます。";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label5.Location = new System.Drawing.Point(140, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(637, 38);
			this.label5.TabIndex = 2;
			this.label5.Text = "・rgbasmはカレントディレクトリ内と、\r\n　そこから見えるフォルダ内の全てのasmﾌｧｲﾙ(*.asm or *.s)を対象にアセンブルします";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.label8.Location = new System.Drawing.Point(18, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(778, 19);
			this.label8.TabIndex = 1;
			this.label8.Text = "・このウィンドウで引数を設定し保存して終了→コマンドライン上から/buildを引数にしてこのアプリを実行。";
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(999, 364);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSaveClose);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Window";
			this.Text = "RGBDS簡易ビルダー v1.0";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox TBasm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TBfix;
		private System.Windows.Forms.TextBox TBlink;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSaveClose;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
	}
}