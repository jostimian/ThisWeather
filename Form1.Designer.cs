
namespace WeatherSearch
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.locationBar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.getWeather = new System.Windows.Forms.Button();
			this.longhText = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.latText = new System.Windows.Forms.Label();
			this.weatherText = new System.Windows.Forms.Label();
			this.HumidityText = new System.Windows.Forms.Label();
			this.minTmpText = new System.Windows.Forms.Label();
			this.MaxTmpText = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// locationBar
			// 
			this.locationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.locationBar.Location = new System.Drawing.Point(66, 29);
			this.locationBar.Name = "locationBar";
			this.locationBar.Size = new System.Drawing.Size(405, 22);
			this.locationBar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Location";
			// 
			// getWeather
			// 
			this.getWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.getWeather.Location = new System.Drawing.Point(477, 29);
			this.getWeather.Name = "getWeather";
			this.getWeather.Size = new System.Drawing.Size(75, 23);
			this.getWeather.TabIndex = 4;
			this.getWeather.Text = "Search";
			this.getWeather.UseVisualStyleBackColor = true;
			this.getWeather.Click += new System.EventHandler(this.getWeather_Click);
			// 
			// longhText
			// 
			this.longhText.AutoSize = true;
			this.longhText.Location = new System.Drawing.Point(13, 71);
			this.longhText.Name = "longhText";
			this.longhText.Size = new System.Drawing.Size(74, 13);
			this.longhText.TabIndex = 6;
			this.longhText.Text = "longhitude : ";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// fIleToolStripMenuItem
			// 
			this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
			this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fIleToolStripMenuItem.Text = "FIle";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.settingsToolStripMenuItem.Text = "Preferences";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(557, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// latText
			// 
			this.latText.AutoSize = true;
			this.latText.Location = new System.Drawing.Point(13, 93);
			this.latText.Name = "latText";
			this.latText.Size = new System.Drawing.Size(58, 13);
			this.latText.TabIndex = 9;
			this.latText.Text = "Latitude : ";
			// 
			// weatherText
			// 
			this.weatherText.AutoSize = true;
			this.weatherText.Location = new System.Drawing.Point(13, 117);
			this.weatherText.Name = "weatherText";
			this.weatherText.Size = new System.Drawing.Size(60, 13);
			this.weatherText.TabIndex = 10;
			this.weatherText.Text = "Weather : ";
			// 
			// HumidityText
			// 
			this.HumidityText.AutoSize = true;
			this.HumidityText.Location = new System.Drawing.Point(13, 140);
			this.HumidityText.Name = "HumidityText";
			this.HumidityText.Size = new System.Drawing.Size(62, 13);
			this.HumidityText.TabIndex = 11;
			this.HumidityText.Text = "Humidity : ";
			// 
			// minTmpText
			// 
			this.minTmpText.AutoSize = true;
			this.minTmpText.Location = new System.Drawing.Point(158, 117);
			this.minTmpText.Name = "minTmpText";
			this.minTmpText.Size = new System.Drawing.Size(63, 13);
			this.minTmpText.TabIndex = 12;
			this.minTmpText.Text = "MinTemp : ";
			// 
			// MaxTmpText
			// 
			this.MaxTmpText.AutoSize = true;
			this.MaxTmpText.Location = new System.Drawing.Point(158, 140);
			this.MaxTmpText.Name = "MaxTmpText";
			this.MaxTmpText.Size = new System.Drawing.Size(61, 13);
			this.MaxTmpText.TabIndex = 13;
			this.MaxTmpText.Text = "MaxTemp :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 311);
			this.Controls.Add(this.MaxTmpText);
			this.Controls.Add(this.minTmpText);
			this.Controls.Add(this.HumidityText);
			this.Controls.Add(this.weatherText);
			this.Controls.Add(this.latText);
			this.Controls.Add(this.longhText);
			this.Controls.Add(this.getWeather);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.locationBar);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox locationBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button getWeather;
		private System.Windows.Forms.Label longhText;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label latText;
		private System.Windows.Forms.Label weatherText;
		private System.Windows.Forms.Label HumidityText;
		private System.Windows.Forms.Label minTmpText;
		private System.Windows.Forms.Label MaxTmpText;
	}
}

