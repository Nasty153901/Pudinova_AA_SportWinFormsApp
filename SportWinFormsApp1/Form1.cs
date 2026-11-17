using System.Diagnostics;
using System.Text.Json;
using SportWinFormsApp1.Models;
using SportWinFormsApp1.Models.Activity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                try
                {
                    var content = File.ReadAllText(fileName);

                    var data = JsonSerializer.Deserialize<ActivityModel>(content);

                    if (data == null || data.DeviceLog == null)
                    {
                        MessageBox.Show("Пустой файл");
                    }

                    //...
                    var header = data.DeviceLog.Header;


                    listBox1.Items.Add($"Имя файла: {Path.GetFileName(fileName)}");
                    listBox1.Items.Add($"Дистанция: {data.DeviceLog.Header.Distance}");
                    listBox1.Items.Add($"Время тренировки: {data.DeviceLog.Header.DateTime.ToString("dd.MM.yyyy HH:mm:ss")}");


                    dataGridView1.DataSource = data.DeviceLog.Windows.Select(x => new WindowData
                    {
                        Duration = x.Window.Duration,
                        Distance = x.Window.Distance,
                        AvgSpeed = x.Window.Speed.FirstOrDefault()?.Avg ?? 0,
                        MaxSpeed = x.Window.Speed.FirstOrDefault()?.Max ?? 0,
                        MinSpeed = x.Window.Speed.FirstOrDefault()?.Min ?? 0,

                    }).ToList();


                }



                catch (Exception ex)
                {
                    MessageBox.Show($"Некорректный файл ({ex.Message})");
                }

               

               

                var i = 0;


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
