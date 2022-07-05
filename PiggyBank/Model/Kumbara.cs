using PiggyBank.Enum;
using PiggyBank.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Model
{
    public class Kumbara
    {
        public List<Para> Paralar { get; set; } = new List<Para>();

        public double Boyut { get; set; }

        public bool KırıldıMı { get; set; }

        public void ParaEkle(Para para) 
        {
            if (Boyut > ParalarinToplamHacmi() + para.KaplananHacim)
            {
                para.FazladanKaplananHacimOranı = RandomEkstraHacim();
                Paralar.Add(para);
            }
            else
            {
                throw new KumbaraDoluException("Para sığmadı!");
            } 
        }

        public string Kır()
        {
            string sonuc = string.Empty;
            KırıldıMı = true;
            decimal toplamPara = 0;
            int birKurusSayısı = 0;
            int besKurusSayısı = 0;
            int onKurusSayısı = 0;
            int yirmibesKurusSayisi = 0;
            int elliKurusSayisi = 0;
            int birLiraSayisi = 0;
            int besLiraSayisi = 0;
            int onLiraSayisi = 0;
            int yirmiLiraSayisi = 0;
            int elliLiraSayisi = 0;
            int yuzLiraSayis = 0;
            int ikiyuzLiraSayisi = 0;

            foreach (Para para in Paralar)
            {
                toplamPara += para.Degeri;
                if (para.ParaAdi == ParaAdi.BirKurus)
                    birKurusSayısı++;
                else if (para.ParaAdi == ParaAdi.BesKurus)
                    besKurusSayısı++;
                else if (para.ParaAdi == ParaAdi.OnKurus)
                    onKurusSayısı++;
                else if (para.ParaAdi == ParaAdi.YirmibesKurus)
                    yirmibesKurusSayisi++;
                else if (para.ParaAdi == ParaAdi.ElliKurus)
                    elliKurusSayisi++;
                else if (para.ParaAdi == ParaAdi.BirLira)
                    birLiraSayisi++;
                else if (para.ParaAdi == ParaAdi.BesLira)
                    besLiraSayisi++;
                else if (para.ParaAdi == ParaAdi.OnLira)
                    onLiraSayisi++;
                else if (para.ParaAdi == ParaAdi.YirmiLira)
                    yirmiLiraSayisi++;
                else if (para.ParaAdi == ParaAdi.ElliLira)
                    elliLiraSayisi++;
                else if (para.ParaAdi == ParaAdi.YuzLira)
                    yuzLiraSayis++;
                else if (para.ParaAdi == ParaAdi.IkiyuzLira)
                    ikiyuzLiraSayisi++;
            }

            sonuc += "Bir kuruş X " + birKurusSayısı + "\n";
            sonuc += "Beş kuruş X " + besKurusSayısı + "\n";
            sonuc += "On kuruş X " + onKurusSayısı + "\n";
            sonuc += "Yirmibeş kuruş X " + yirmibesKurusSayisi + "\n";
            sonuc += "Elli kuruş X " + elliKurusSayisi + "\n";
            sonuc += "Bir lira X " + birLiraSayisi + "\n";
            sonuc += "Beş lira X " + besLiraSayisi + "\n";
            sonuc += "On lira X " + onLiraSayisi + "\n";
            sonuc += "Yirmi lira X " + yirmiLiraSayisi + "\n";
            sonuc += "Elli lira X " + elliLiraSayisi + "\n";
            sonuc += "Yüz lira X " + yuzLiraSayis + "\n";
            sonuc += "İkiyüz lira X " + ikiyuzLiraSayisi + "\n";
            sonuc += "TOPLAM: " + toplamPara + " Lira";

            Paralar.Clear();

            return sonuc;
        }

        public double ParalarinToplamHacmi()
        {
            double sonuc = 0;

            foreach (Para para in Paralar)
                sonuc += para.KaplananHacim;

            return sonuc;
        }

        public void Salla()
        {
            foreach (Para para in Paralar)
                para.FazladanKaplananHacimOranı = 1.25;
        }

        public double EkstradanKaplananHacim()
        {
            double gercekHacimToplami = 0;
            double kaplananHacimToplami = 0;

            foreach (Para para in Paralar)
            {
                gercekHacimToplami += para.GercekHacim;
                kaplananHacimToplami += para.KaplananHacim;
            }
            return kaplananHacimToplami - gercekHacimToplami;
        }

        private double RandomEkstraHacim()
        {
            Random random = new Random();
            return (random.NextDouble() * (175 - 125) + 125) / 100;
        }
    }
}
