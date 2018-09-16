using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRSSUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {

            List<Haber> Kayitlar =xmlCevir();

            lstBaslik.DataSource = Kayitlar;





        }

        private List<Haber> xmlCevir()
        {

            List<Haber> Haberkayitlari = new List<Haber>();
            XDocument  XmlKaynak=XDocument.Load(txtRSSUrl.Text);
            List<XElement> Rows=XmlKaynak.Descendants("item").ToList();



            foreach (var item  in Rows)
            {

                Haber temp = new Haber();

                temp.Baslik = item.Element("title").Value;
                temp.Aciklama = item.Element("description").Value;
                temp.Link = item.Element("link").Value;

                Haberkayitlari.Add(temp);

            }

            return Haberkayitlari;

        }

        private void lstBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {


            ListBox SecilenDeger = (ListBox) sender;

           Haber SecilenHaber=(Haber)SecilenDeger.SelectedItem;


            web_Browser1.DocumentText = SecilenHaber.Aciklama;


        }
    }
}
