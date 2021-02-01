using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherSearch
{
	public partial class Form1 : Form
	{
		String url = @"http://api.openweathermap.org/data/2.5/weather?q=";
		String apiKey = "&appid=6a6bfcb730cdf7f8507bb5c849d13fe1";
		public Form1()
		{
			InitializeComponent();
		}
		public string getWeatherData(String location)
		{
			WebRequest req = WebRequest.Create(url + location + apiKey);
			WebResponse resp = req.GetResponse();
			using (Stream data = resp.GetResponseStream())
			{
				StreamReader reader = new StreamReader(data);
				String dataout = reader.ReadToEnd();
				return dataout;
			}
		}

		private void getWeather_Click(object sender, EventArgs e)
		{
			String location = locationBar.Text;
			String dataout = getWeatherData(location);
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(dataout);
			longhText.Text = longhText.Text + obj["coord"]["lon"];
			latText.Text = latText.Text + obj["coord"]["lat"];
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			locationBar.Text = Properties.Settings.Default.DefaultLocation;
		}
	}
}
