using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wfHttpClientDemo
{
    public partial class ViewDataGridForm : Form
    {
        public ViewDataGridForm()
        {
            InitializeComponent();
        }

        private void dataGridViewURL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewImageForm vif = new ViewImageForm();
            ViewDataGridForm vdgf = new ViewDataGridForm();

            //var url = vdgf.dataGridViewURL.CurrentRow.Cells[1].Value.ToString();

            //using (var client = new HttpClient())
            //{
            //    var req = client.GetAsync(url).ContinueWith(res =>
            //    {
            //        var result = res.Result;
            //        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            //        {
            //            var readData = result.Content.ReadAsStringAsync();
            //            readData.Wait();

            //            var readStream = readData.Result;

            //            var image = Image.FromStream(readStream);

            //            vif.pictureBox1.Image = image;
            //        }
            //    });
            //}

            vif.Show();
        }
    }
}
