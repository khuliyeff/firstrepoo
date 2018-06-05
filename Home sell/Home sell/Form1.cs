using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home_sell.Models;

namespace Home_sell
{
    public partial class Form1 : Form
    {
        private Ad ad;
       
        Home_SellEntities db = new Home_SellEntities();
        public Form1()
        {
            InitializeComponent();
            FillAds();
            FillStreet();
            FillType();
            FillAddTypes();
        }

        private void FillAds()
        {
            Dgvv.Rows.Clear();
            foreach (var item in db.Ads.ToList())
            {
                Dgvv.Rows.Add(
                    item.Id,
                    item.Street.Name,
                    item.Type.Name,
                    item.RoomCount,
                    item.Price,
                    item.AdType,
                    item.Area,
                    item.Floor


                    );
            }
        }

        private void FillStreet()
        {
            foreach (var item in db.Streets.ToList())
            {
                CmbStreet.Items.Add(item.Id + " - " + item.Name);
            }
        }
        private void FillType()
        {
            foreach (var item in db.Types.ToList())
            {
                CmbType.Items.Add(item.Id + " - " + item.Name);
            }
        }
        private void FillAddTypes()
        {
            foreach (var item in db.Ads.ToList())
            {
                CmbAdType.Items.Add(item.AdType);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            if (CmbStreet.Text==string.Empty||CmbType.Text == string.Empty|| CmbAdType.Text == string.Empty)
            {
                MessageBox.Show("Doldurmadiginiz hisseler var");
                return;
            }

            if (TxbRCount.Text==string.Empty||TxtPrice.Text==string.Empty||TxbFloor.Text==string.Empty||TxbArea.Text==string.Empty)
            {
                MessageBox.Show("*Yerleri Bos buraxmayin");
                return;
            }


            Ad ad = new Ad();
            ad.StreetsId= Convert.ToInt32(CmbStreet.Text.Split('-')[0]);
            ad.TypeId = Convert.ToInt32(CmbType.Text.Split('-')[0]);
            ad.RoomCount = Convert.ToInt32(TxbRCount.Text);
            ad.Price = Convert.ToDecimal(TxtPrice.Text);
            ad.AdType = Convert.ToInt32(CmbAdType.Text);
            ad.Area = Convert.ToDecimal(TxbArea.Text);
            ad.Floor = Convert.ToInt32(TxbFloor.Text);


            db.Ads.Add(ad);
            db.SaveChanges();

            FillAds();

        }

        private void Dgvv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            BtnAdd.Visible = false;
            BtnDelet.Visible = true;
            BtnUpdate.Visible = true;

            this.ad = db.Ads.Find(Convert.ToInt32(Dgvv.Rows[e.RowIndex].Cells[0].Value.ToString()));
            TxtPrice.Text = Convert.ToDecimal(Dgvv.Rows[e.RowIndex].Cells[4].Value).ToString("#.##");
            TxbRCount.Text = Dgvv.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxbFloor.Text = Dgvv.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxbArea.Text = Dgvv.Rows[e.RowIndex].Cells[6].Value.ToString();

            CmbStreet.Text = this.ad.StreetsId + "-" + this.ad.Street.Name;
            CmbType.Text = this.ad.TypeId + "-" + this.ad.Type.Name;
            CmbAdType.Text = this.ad.AdType + "-" + this.ad.AdType;
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.ad.StreetsId = Convert.ToInt32(CmbStreet.Text.Split('-')[0]);
            this.ad.TypeId = Convert.ToInt32(CmbType.Text.Split('-')[0]);
            this.ad.RoomCount = Convert.ToInt32(TxbRCount.Text);
            this.ad.Price = Convert.ToDecimal(TxtPrice.Text);
            this.ad.AdType = Convert.ToInt32(CmbAdType.Text);
            this.ad.Area = Convert.ToDecimal(TxbArea.Text);
            this.ad.Floor = Convert.ToInt32(TxbFloor.Text);

            db.SaveChanges();

            FillAds();
        }
    }
}
