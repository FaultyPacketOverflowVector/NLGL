using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Nightlight_Launcher;

public class RDR2 : Form
{
	private string selectedFolderPath;

	private IContainer components = null;

	private TextBox selectedFolderTextBox;

	private Label label1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Label labelOptiBoost1;

	private Button OpenGameLocation;

	public RDR2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(selectedFolderTextBox.Text))
		{
			button3_Click(sender, e);
		}
		else
		{
			DownloadFiles();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string text = selectedFolderPath + "\\RDR2Launcher.exe";
		if (File.Exists(text))
		{
			try
			{
				Process.Start(text);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while launching the application: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("The file Launcher.exe was not found at the location: " + text);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		DialogResult dialogResult = folderBrowserDialog.ShowDialog();
		if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
		{
			selectedFolderPath = folderBrowserDialog.SelectedPath;
			selectedFolderTextBox.Text = selectedFolderPath;
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		selectedFolderPath = selectedFolderTextBox.Text;
	}

	private void DownloadFiles()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "RDR2.exe", "https://github.com/onajlikezz/rdr2host/releases/download/nlglhost1/RDR2.exe" },
			{ "1911.dll", "https://github.com/onajlikezz/Nightlight-Game-Launcher/raw/main/Modules/RDR2/1911.dll" },
			{ "Launcher.exe", "https://github.com/onajlikezz/Nightlight-Game-Launcher/raw/main/Modules/RDR2/Launcher.exe" },
			{ "bink2w64.dll", "https://github.com/onajlikezz/Nightlight-Game-Launcher/raw/main/Modules/RDR2/bink2w64.dll" },
			{ "RDR2Launcher.exe", "https://github.com/onajlikezz/Nightlight-Game-Launcher/raw/main/Modules/RDR2/RDR2Launcher.exe" }
		};
		string path = selectedFolderPath + "\\RDR2.exe";
		if (File.Exists(path))
		{
			string command = "powershell -Command \"& {Add-Type -AssemblyName System.Windows.Forms; Add-Type -AssemblyName System.Drawing; $notify = New-Object System.Windows.Forms.NotifyIcon; $notify.Icon = [System.Drawing.SystemIcons]::Information; $notify.Visible = $true; $notify.ShowBalloonTip(0, 'NLGL Information', 'The location you entered probably contains the game!', [System.Windows.Forms.ToolTipIcon]::None)}\"";
			ExecuteCommand(command);
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				string key = item.Key;
				string value = item.Value;
				string fileName = Path.Combine(selectedFolderPath, key);
				try
				{
					using WebClient webClient = new WebClient();
					webClient.DownloadFile(value, fileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error downloading file '" + key + "': " + ex.Message);
				}
			}
			MessageBox.Show("The game has been successfully bypassed!\nGame Location: " + selectedFolderPath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		string command2 = "powershell -Command \"& {Add-Type -AssemblyName System.Windows.Forms; Add-Type -AssemblyName System.Drawing; $notify = New-Object System.Windows.Forms.NotifyIcon; $notify.Icon = [System.Drawing.SystemIcons]::Information; $notify.Visible = $true; $notify.ShowBalloonTip(0, 'NLGL Information', 'The location you entered probably does not contain the game!', [System.Windows.Forms.ToolTipIcon]::None)}\"";
		ExecuteCommand(command2);
		foreach (KeyValuePair<string, string> item2 in dictionary)
		{
			string key2 = item2.Key;
			string value2 = item2.Value;
			string fileName2 = Path.Combine(selectedFolderPath, key2);
			try
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile(value2, fileName2);
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error downloading file '" + key2 + "': " + ex2.Message);
			}
		}
		MessageBox.Show("The bypass files have been downloaded to the location:\n" + selectedFolderPath + "\n\nNote: NLGL did not detect that the game is installed at this location! You may encounter issues when trying to run it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void exit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void OpenGameLocation_Click(object sender, EventArgs e)
	{
		if (Directory.Exists(selectedFolderPath))
		{
			Process.Start("explorer.exe", selectedFolderPath);
		}
		else
		{
			MessageBox.Show("The folder path is not valid. Please enter a valid folder path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
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
		this.selectedFolderTextBox = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.labelOptiBoost1 = new System.Windows.Forms.Label();
		this.OpenGameLocation = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.selectedFolderTextBox.Location = new System.Drawing.Point(83, 178);
		this.selectedFolderTextBox.Name = "selectedFolderTextBox";
		this.selectedFolderTextBox.Size = new System.Drawing.Size(387, 20);
		this.selectedFolderTextBox.TabIndex = 0;
		this.selectedFolderTextBox.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Bold);
		this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label1.Location = new System.Drawing.Point(79, 155);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(109, 22);
		this.label1.TabIndex = 1;
		this.label1.Text = "Game folder:";
		this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.Location = new System.Drawing.Point(280, 271);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(112, 39);
		this.button1.TabIndex = 2;
		this.button1.Text = "install modules";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9.75f);
		this.button2.Location = new System.Drawing.Point(465, 271);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(112, 39);
		this.button2.TabIndex = 3;
		this.button2.Text = "Start Game";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button3.Font = new System.Drawing.Font("Trebuchet MS", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(492, 178);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(120, 21);
		this.button3.TabIndex = 4;
		this.button3.Text = "Change Location";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.labelOptiBoost1.AutoSize = true;
		this.labelOptiBoost1.BackColor = System.Drawing.Color.Transparent;
		this.labelOptiBoost1.Font = new System.Drawing.Font("Mont Heavy DEMO", 24f, System.Drawing.FontStyle.Bold);
		this.labelOptiBoost1.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.labelOptiBoost1.Location = new System.Drawing.Point(140, 66);
		this.labelOptiBoost1.Name = "labelOptiBoost1";
		this.labelOptiBoost1.Size = new System.Drawing.Size(421, 44);
		this.labelOptiBoost1.TabIndex = 6;
		this.labelOptiBoost1.Text = "Red Dead Redemption II";
		this.OpenGameLocation.Font = new System.Drawing.Font("Trebuchet MS", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.OpenGameLocation.Location = new System.Drawing.Point(95, 271);
		this.OpenGameLocation.Name = "OpenGameLocation";
		this.OpenGameLocation.Size = new System.Drawing.Size(120, 39);
		this.OpenGameLocation.TabIndex = 7;
		this.OpenGameLocation.Text = "Open selected folder";
		this.OpenGameLocation.UseVisualStyleBackColor = true;
		this.OpenGameLocation.Click += new System.EventHandler(OpenGameLocation_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(23, 21, 35);
		base.ClientSize = new System.Drawing.Size(695, 501);
		base.Controls.Add(this.OpenGameLocation);
		base.Controls.Add(this.labelOptiBoost1);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.selectedFolderTextBox);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "RDR2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Nightlight Launcher | Grand Theft Auto V";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
