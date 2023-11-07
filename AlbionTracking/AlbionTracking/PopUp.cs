using __Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static __Entidades.HistoryAVG;

namespace AlbionTracking
{
    public partial class PopUp : Form
    {
        private HistoryAVG hour, day;
        private Image img;
        private string[] info;

        List<long> avgH, avgD, avgHcount, avgDcount;

        public PopUp(HistoryAVG hour, HistoryAVG day, Image img, string[] info)
        {
            InitializeComponent();
            this.hour = hour;
            this.day = day;
            this.img = img;
            this.info = info;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {
            this.picBox.Image = img;
            this.txtName.Text = $"[{info[3].ToUpper()}] {info[2]}";

            AVGs();
            this.txtAVGh.Text = $"AVG/h: {((long)avgH.Average()).ToString("###,###,##0")}";
            this.txtAVGhCount.Text = $"Cnt/h: {((long)avgHcount.Average()).ToString("###,###,##0")}";
            this.txtAVGd.Text = $"AVG/d: {((long)avgD.Average()).ToString("###,###,##0")}";
            this.txtAVGdCount.Text = $"Cnt/d: {((long)avgDcount.Average()).ToString("###,###,##0")}";

            foreach (var i in this.hour.data)
            {
                this.listHistoryHour.Items.Add($"AVG: {(i.avg_price).ToString("###,###,##0").PadRight(12, ' ')}|Count: {(i.item_count).ToString("###,##0").PadRight(6, ' ')}|Date: {i.timestamp.ToString().Replace('T', ' ')}");
            }

            foreach (var i in this.day.data)
            {
                this.listHistoryDay.Items.Add($"AVG: {(i.avg_price).ToString("###,###,##0").PadRight(12, ' ')}|Count: {(i.item_count).ToString("###,##0").PadRight(6, ' ')}|Date: {i.timestamp.ToString().Replace('T', ' ')}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AVGs()
        {
            avgH = new List<long>();
            avgD = new List<long>();
            avgHcount = new List<long>();
            avgDcount = new List<long>();

            foreach (DataEntry i in hour.data)
            {
                avgH.Add(i.avg_price);
                avgHcount.Add(i.item_count);
            }

            foreach (DataEntry i in day.data)
            {
                avgD.Add(i.avg_price);
                avgDcount.Add(i.item_count);
            }
        }
    }
}
