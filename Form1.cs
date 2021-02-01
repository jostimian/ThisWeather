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
		String apiKey = "&appid=6a6bfcb730cdf7f8507bb5c849d13fe1&units=metric";
		public Form1()
		{
			InitializeComponent();
		}
		public string getWeatherData(String location)
		{
			try
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
			catch(Exception e)
			{
				MessageBox.Show("There is an error finding that country");
				return null;
			}
		}

		private void getWeather_Click(object sender, EventArgs e)
		{
			resetForms();
			getWeatherFromAPI();
		}
		public void getWeatherFromAPI()
		{
			String location = locationBar.Text;
			String dataout = getWeatherData(location);
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(dataout);
			longhText.Text = longhText.Text + obj["coord"]["lon"];
			latText.Text = latText.Text + obj["coord"]["lat"];
			weatherText.Text = weatherText.Text + obj["weather"][0]["description"];
			HumidityText.Text = HumidityText.Text + obj["main"]["humidity"] + "%";
			minTmpText.Text = minTmpText.Text + obj["main"]["temp_min"] + "°C";
			MaxTmpText.Text = MaxTmpText.Text + obj["main"]["temp_max"] + "°C";
		}
		public void resetForms()
		{
			longhText.Text = "Longhitude : ";
			latText.Text = "Latitude : ";
			weatherText.Text = "Weather : ";
			HumidityText.Text = "Humidity : ";
			minTmpText.Text = "MinTemp : ";
			MaxTmpText.Text = "MaxTemp : ";
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			locationBar.Text = Properties.Settings.Default.DefaultLocation;
		}
	}
}
