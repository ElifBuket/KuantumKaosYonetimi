using System;
using KuantumKaosYonetimi.Exceptions;

namespace KuantumKaosYonetimi.Base
{
    public abstract class KuantumNesnesi
    {
        public string ID { get; set; }
        private double stabilite;
        public double Stabilite
        {
            get => stabilite;
            set
            {
                if (value > 100) stabilite = 100;
                else if (value < 0) stabilite = 0;
                else stabilite = value;
            }
        }
        public int TehlikeSeviyesi { get; set; }

        public KuantumNesnesi(string id, double stab, int tehlike)
        {
            ID = id;
            Stabilite = stab;
            TehlikeSeviyesi = tehlike;
        }

        public abstract void AnalizEt();

        public string DurumBilgisi()
        {
            return $"{ID} - Stabilite: {Stabilite}% - Tehlike: {TehlikeSeviyesi}";
        }

        protected void CheckCollapse()
        {
            if (Stabilite <= 0)
                throw new KuantumCokusuException(ID);
        }
    }
}
