using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PiggyBank.Model;
using PiggyBank.Enum;
using PiggyBank.Exception;

namespace PiggyBank
{
    public partial class Form1 : Form
    {

        private static readonly double KUMBARA_HACIM = 100000;

        public Kumbara Kumbara { get; set; } = new Kumbara { Boyut = KUMBARA_HACIM};

        public Form1()
        {
            InitializeComponent();
        }
        

        public static List<MadeniPara> bozukpara = new List<MadeniPara>()

        {
            new MadeniPara{ParaAdi=ParaAdi.BirKurus,Degeri=0.01m,Cap=16.5, Yukseklik=1.35 },
            new MadeniPara{ParaAdi=ParaAdi.BesKurus,Degeri=0.05m,Cap=17.5, Yukseklik=1.65 },
            new MadeniPara{ParaAdi=ParaAdi.OnKurus,Degeri=0.10m,Cap=18.5, Yukseklik=1.65 },
            new MadeniPara{ParaAdi=ParaAdi.YirmibesKurus,Degeri=0.25m,Cap=20.5, Yukseklik=1.65 },
            new MadeniPara{ParaAdi=ParaAdi.ElliKurus,Degeri=0.50m,Cap=23.85, Yukseklik=1.9 },
            new MadeniPara{ParaAdi=ParaAdi.BirLira,Degeri=1,Cap=26.15, Yukseklik=1.9 }

        };

        public static List<KagitPara> kagitpara = new List<KagitPara>()
        {
            new KagitPara {ParaAdi=ParaAdi.BesLira,Degeri=5,En=130, Boy=64},
            new KagitPara {ParaAdi=ParaAdi.OnLira,Degeri=10,En=136, Boy=64},
            new KagitPara {ParaAdi=ParaAdi.YirmiLira,Degeri=20,En=142, Boy=68},
            new KagitPara {ParaAdi=ParaAdi.ElliLira,Degeri=50,En=148, Boy=68},
            new KagitPara {ParaAdi=ParaAdi.YuzLira,Degeri=100,En=154, Boy=72},
            new KagitPara {ParaAdi=ParaAdi.IkiyuzLira,Degeri=200,En=160, Boy=72},

        };

        private void btnParaKoy_Click(object sender, EventArgs e)
        {
            Para eklenenKagitPara = (KagitPara)cbKagıtPara.SelectedItem;
                
            if (eklenenKagitPara != null)
            {
                try
                {
                    Kumbara.ParaEkle(eklenenKagitPara);
                    lblKagıtParaSonuc.Text = "Kağıt para başarıyla eklendi!";
                }
                catch (KumbaraDoluException ex)
                {
                    lblKagıtParaSonuc.Text = ex.Message;
                }
            }

            LabellarıGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (MadeniPara item in bozukpara)
            {
                cbMadeniPara.Items.Add(item);
            }

            foreach (KagitPara item in kagitpara)
            {
                cbKagıtPara.Items.Add(item);
            }

            lblTopamHacim.Text = KUMBARA_HACIM.ToString() + " mm^3";
            LabellarıGuncelle();
            
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }


        private void btnSalla_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\YGT\Desktop\Yazılım\Projeler\PIGGY BANK\PiggyBank\PiggyBank\Sound\Para.wav");
            splayer.Play();
            Shake(this);
            Kumbara.Salla();
            LabellarıGuncelle();
        }
        private static void Shake(Form1 form)
        {
            var original = form.Location;
            var rnd = new Random (1337);
            const int shake_amplitude = 8;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y +rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
                form.Location = original;

            }
        }

        private void btnKır_Click(object sender, EventArgs e)
        {

            SoundPlayer spKırma = new SoundPlayer(@"C:\Users\YGT\Desktop\Yazılım\Projeler\PIGGY BANK\PiggyBank\PiggyBank\Sound\Kırma (mp3cut.net).wav");
            spKırma.Play();

            this.BackgroundImage = Properties.Resources.Kırık__1_;

            if (!Kumbara.KırıldıMı)
                btnYapaistir.Enabled = true;


            sonucLabel.Text = Kumbara.Kır();
            btnKır.Enabled = false;
            btnMadeniParaKoy.Enabled = false;
            btnParaKoy.Enabled = false;
            btnSalla.Enabled = false;
            LabellarıGuncelle();
        }

        private void LabellarıGuncelle()
        {
            lblParaHacim.Text = string.Format("{0:0}", Kumbara.ParalarinToplamHacmi()) + " mm^3";
            lblParaEkstraHacim.Text = string.Format("{0:0}", Kumbara.EkstradanKaplananHacim()) + " mm^3";
        }

        private void btnYapaistir_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Tamir;
            btnYapaistir.Enabled = false;
            btnKır.Enabled = true;
            btnMadeniParaKoy.Enabled = true;
            btnParaKoy.Enabled = true;
            btnSalla.Enabled = true;
            sonucLabel.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Para eklenenBozukPara = (MadeniPara)cbMadeniPara.SelectedItem;

            if (eklenenBozukPara != null)
            {
                try
                {
                    Kumbara.ParaEkle(eklenenBozukPara);
                    lblMadeniParaSonuc.Text = "Para başarıyla eklendi!";
                }
                catch (KumbaraDoluException ex)
                {
                    lblMadeniParaSonuc.Text = ex.Message;
                }
            }

            LabellarıGuncelle();
        }
    }
}
