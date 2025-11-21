using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Nightlight_Launcher.Properties;

namespace Nightlight_Launcher;

public class Main : Form
{
	private IContainer components = null;

	private Panel panelMain;

	private Button RDR2;

	private Button GTAV;

	private Panel panelLogo;

	private Label label2;

	private Label label1;

	private Panel panelDisplay;

	private Label V51;

	private Label labelOptiBoost1;

	private Button Discord;

	private Button minecraft;

	private Button Updates;

	private PictureBox updatespic;

	private PictureBox discordpic;

	private PictureBox gta4pic;

	private PictureBox rdr2pic;

	private PictureBox gtavpic;

	public Main()
	{
		string command = "powershell -Command \"& {Add-Type -AssemblyName System.Windows.Forms; Add-Type -AssemblyName System.Drawing; $notify = New-Object System.Windows.Forms.NotifyIcon; $notify.Icon = [System.Drawing.SystemIcons]::Information; $notify.Visible = $true; $notify.ShowBalloonTip(0, 'You have successfully launched NLGL', 'This software is free. If you purchased it, please request a refund!', [System.Windows.Forms.ToolTipIcon]::None)}\"";
		ExecuteCommand(command);
		InitializeComponent();
	}

	private static void ExecuteCommand(string command)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		string text2 = process.StandardError.ReadToEnd();
		process.WaitForExit();
		Console.WriteLine("Output: " + text);
		Console.WriteLine("Error: " + text2);
	}

	private void GTAV_Click(object sender, EventArgs e)
	{
		GTAV gTAV = new GTAV();
		gTAV.TopLevel = false;
		panelDisplay.Controls.Add(gTAV);
		gTAV.BringToFront();
		gTAV.Show();
	}

	private void RDR2_Click(object sender, EventArgs e)
	{
		RDR2 rDR = new RDR2();
		rDR.TopLevel = false;
		panelDisplay.Controls.Add(rDR);
		rDR.BringToFront();
		rDR.Show();
	}

	private void gtaiv_Click(object sender, EventArgs e)
	{
		GTAIV gTAIV = new GTAIV();
		gTAIV.TopLevel = false;
		panelDisplay.Controls.Add(gTAIV);
		gTAIV.BringToFront();
		gTAIV.Show();
	}

	private void Discord_Click(object sender, EventArgs e)
	{
		string fileName = "https://discord.gg/pBFaCQQVBV";
		Process.Start(fileName);
	}

	private void Updates_Click(object sender, EventArgs e)
	{
		string fileName = "https://github.com/onajlikezz/Nightlight-Game-Launcher/releases";
		Process.Start(fileName);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nightlight_Launcher.Main));
		this.panelMain = new System.Windows.Forms.Panel();
		this.updatespic = new System.Windows.Forms.PictureBox();
		this.discordpic = new System.Windows.Forms.PictureBox();
		this.gta4pic = new System.Windows.Forms.PictureBox();
		this.rdr2pic = new System.Windows.Forms.PictureBox();
		this.gtavpic = new System.Windows.Forms.PictureBox();
		this.Updates = new System.Windows.Forms.Button();
		this.Discord = new System.Windows.Forms.Button();
		this.minecraft = new System.Windows.Forms.Button();
		this.RDR2 = new System.Windows.Forms.Button();
		this.GTAV = new System.Windows.Forms.Button();
		this.panelLogo = new System.Windows.Forms.Panel();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.panelDisplay = new System.Windows.Forms.Panel();
		this.V51 = new System.Windows.Forms.Label();
		this.labelOptiBoost1 = new System.Windows.Forms.Label();
		this.panelMain.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.updatespic).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.discordpic).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gta4pic).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.rdr2pic).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gtavpic).BeginInit();
		this.panelLogo.SuspendLayout();
		this.panelDisplay.SuspendLayout();
		base.SuspendLayout();
		this.panelMain.BackColor = System.Drawing.Color.FromArgb(1, 1, 1);
		this.panelMain.Controls.Add(this.updatespic);
		this.panelMain.Controls.Add(this.discordpic);
		this.panelMain.Controls.Add(this.gta4pic);
		this.panelMain.Controls.Add(this.rdr2pic);
		this.panelMain.Controls.Add(this.gtavpic);
		this.panelMain.Controls.Add(this.Updates);
		this.panelMain.Controls.Add(this.Discord);
		this.panelMain.Controls.Add(this.minecraft);
		this.panelMain.Controls.Add(this.RDR2);
		this.panelMain.Controls.Add(this.GTAV);
		this.panelMain.Controls.Add(this.panelLogo);
		this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
		this.panelMain.Location = new System.Drawing.Point(0, 0);
		this.panelMain.Name = "panelMain";
		this.panelMain.Size = new System.Drawing.Size(161, 501);
		this.panelMain.TabIndex = 1;
		this.updatespic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.updatespic.Enabled = false;
		this.updatespic.Image = Nightlight_Launcher.Properties.Resources.githubimg;
		this.updatespic.Location = new System.Drawing.Point(12, 226);
		this.updatespic.Name = "updatespic";
		this.updatespic.Size = new System.Drawing.Size(25, 26);
		this.updatespic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.updatespic.TabIndex = 23;
		this.updatespic.TabStop = false;
		this.discordpic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.discordpic.Enabled = false;
		this.discordpic.Image = Nightlight_Launcher.Properties.Resources.discordimg;
		this.discordpic.Location = new System.Drawing.Point(12, 190);
		this.discordpic.Name = "discordpic";
		this.discordpic.Size = new System.Drawing.Size(25, 26);
		this.discordpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.discordpic.TabIndex = 22;
		this.discordpic.TabStop = false;
		this.gta4pic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.gta4pic.Enabled = false;
		this.gta4pic.Image = Nightlight_Launcher.Properties.Resources.gta4img;
		this.gta4pic.Location = new System.Drawing.Point(12, 154);
		this.gta4pic.Name = "gta4pic";
		this.gta4pic.Size = new System.Drawing.Size(25, 26);
		this.gta4pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.gta4pic.TabIndex = 21;
		this.gta4pic.TabStop = false;
		this.rdr2pic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.rdr2pic.Enabled = false;
		this.rdr2pic.Image = Nightlight_Launcher.Properties.Resources.rdr2img;
		this.rdr2pic.Location = new System.Drawing.Point(12, 118);
		this.rdr2pic.Name = "rdr2pic";
		this.rdr2pic.Size = new System.Drawing.Size(25, 26);
		this.rdr2pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.rdr2pic.TabIndex = 20;
		this.rdr2pic.TabStop = false;
		this.gtavpic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.gtavpic.Enabled = false;
		this.gtavpic.Image = Nightlight_Launcher.Properties.Resources.gta5img;
		this.gtavpic.Location = new System.Drawing.Point(12, 83);
		this.gtavpic.Name = "gtavpic";
		this.gtavpic.Size = new System.Drawing.Size(25, 26);
		this.gtavpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.gtavpic.TabIndex = 2;
		this.gtavpic.TabStop = false;
		this.Updates.Dock = System.Windows.Forms.DockStyle.Top;
		this.Updates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Updates.Font = new System.Drawing.Font("Mont Heavy DEMO", 9.75f, System.Drawing.FontStyle.Bold);
		this.Updates.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Updates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Updates.Location = new System.Drawing.Point(0, 221);
		this.Updates.Name = "Updates";
		this.Updates.Size = new System.Drawing.Size(161, 36);
		this.Updates.TabIndex = 19;
		this.Updates.Text = "Updates";
		this.Updates.UseVisualStyleBackColor = true;
		this.Updates.Click += new System.EventHandler(Updates_Click);
		this.Discord.Dock = System.Windows.Forms.DockStyle.Top;
		this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Discord.Font = new System.Drawing.Font("Mont Heavy DEMO", 9.75f, System.Drawing.FontStyle.Bold);
		this.Discord.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Discord.Location = new System.Drawing.Point(0, 185);
		this.Discord.Name = "Discord";
		this.Discord.Size = new System.Drawing.Size(161, 36);
		this.Discord.TabIndex = 17;
		this.Discord.Text = "Discord";
		this.Discord.UseVisualStyleBackColor = true;
		this.Discord.Click += new System.EventHandler(Discord_Click);
		this.minecraft.Dock = System.Windows.Forms.DockStyle.Top;
		this.minecraft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.minecraft.Font = new System.Drawing.Font("Mont Heavy DEMO", 9.75f, System.Drawing.FontStyle.Bold);
		this.minecraft.ForeColor = System.Drawing.SystemColors.Window;
		this.minecraft.Location = new System.Drawing.Point(0, 149);
		this.minecraft.Name = "minecraft";
		this.minecraft.Size = new System.Drawing.Size(161, 36);
		this.minecraft.TabIndex = 16;
		this.minecraft.Text = "GTA IV";
		this.minecraft.UseVisualStyleBackColor = true;
		this.minecraft.Click += new System.EventHandler(gtaiv_Click);
		this.RDR2.Dock = System.Windows.Forms.DockStyle.Top;
		this.RDR2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RDR2.Font = new System.Drawing.Font("Mont Heavy DEMO", 9.75f, System.Drawing.FontStyle.Bold);
		this.RDR2.ForeColor = System.Drawing.SystemColors.Window;
		this.RDR2.Location = new System.Drawing.Point(0, 113);
		this.RDR2.Name = "RDR2";
		this.RDR2.Size = new System.Drawing.Size(161, 36);
		this.RDR2.TabIndex = 8;
		this.RDR2.Text = "RDR II";
		this.RDR2.UseVisualStyleBackColor = true;
		this.RDR2.Click += new System.EventHandler(RDR2_Click);
		this.GTAV.Dock = System.Windows.Forms.DockStyle.Top;
		this.GTAV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.GTAV.Font = new System.Drawing.Font("Mont Heavy DEMO", 9.75f, System.Drawing.FontStyle.Bold);
		this.GTAV.ForeColor = System.Drawing.SystemColors.Window;
		this.GTAV.Location = new System.Drawing.Point(0, 78);
		this.GTAV.Name = "GTAV";
		this.GTAV.Size = new System.Drawing.Size(161, 35);
		this.GTAV.TabIndex = 6;
		this.GTAV.Text = "GTA V";
		this.GTAV.UseVisualStyleBackColor = true;
		this.GTAV.Click += new System.EventHandler(GTAV_Click);
		this.panelLogo.BackColor = System.Drawing.Color.FromArgb(1, 1, 1);
		this.panelLogo.Controls.Add(this.label2);
		this.panelLogo.Controls.Add(this.label1);
		this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
		this.panelLogo.Location = new System.Drawing.Point(0, 0);
		this.panelLogo.Name = "panelLogo";
		this.panelLogo.Size = new System.Drawing.Size(161, 78);
		this.panelLogo.TabIndex = 0;
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.Color.Transparent;
		this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.label2.Location = new System.Drawing.Point(120, 46);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(22, 16);
		this.label2.TabIndex = 2;
		this.label2.Text = "V4";
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Font = new System.Drawing.Font("Mont Heavy DEMO", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.label1.Location = new System.Drawing.Point(3, 27);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(151, 19);
		this.label1.TabIndex = 1;
		this.label1.Text = "Nightlight Launcher";
		this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(23, 21, 35);
		this.panelDisplay.Controls.Add(this.V51);
		this.panelDisplay.Controls.Add(this.labelOptiBoost1);
		this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelDisplay.Location = new System.Drawing.Point(161, 0);
		this.panelDisplay.Name = "panelDisplay";
		this.panelDisplay.Size = new System.Drawing.Size(695, 501);
		this.panelDisplay.TabIndex = 2;
		this.V51.AutoSize = true;
		this.V51.BackColor = System.Drawing.Color.Transparent;
		this.V51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.V51.Font = new System.Drawing.Font("Mont Heavy DEMO", 12f, System.Drawing.FontStyle.Bold);
		this.V51.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.V51.Location = new System.Drawing.Point(327, 221);
		this.V51.Name = "V51";
		this.V51.Size = new System.Drawing.Size(31, 22);
		this.V51.TabIndex = 1;
		this.V51.Text = "V4";
		this.labelOptiBoost1.AutoSize = true;
		this.labelOptiBoost1.BackColor = System.Drawing.Color.Transparent;
		this.labelOptiBoost1.Font = new System.Drawing.Font("Mont Heavy DEMO", 24f, System.Drawing.FontStyle.Bold);
		this.labelOptiBoost1.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.labelOptiBoost1.Location = new System.Drawing.Point(161, 185);
		this.labelOptiBoost1.Name = "labelOptiBoost1";
		this.labelOptiBoost1.Size = new System.Drawing.Size(351, 44);
		this.labelOptiBoost1.TabIndex = 0;
		this.labelOptiBoost1.Text = "Nightlight Launcher";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(856, 501);
		base.Controls.Add(this.panelDisplay);
		base.Controls.Add(this.panelMain);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Main";
		this.Text = "Nightlight Game Launcher | Version 4";
		this.panelMain.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.updatespic).EndInit();
		((System.ComponentModel.ISupportInitialize)this.discordpic).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gta4pic).EndInit();
		((System.ComponentModel.ISupportInitialize)this.rdr2pic).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gtavpic).EndInit();
		this.panelLogo.ResumeLayout(false);
		this.panelLogo.PerformLayout();
		this.panelDisplay.ResumeLayout(false);
		this.panelDisplay.PerformLayout();
		base.ResumeLayout(false);
	}
}
