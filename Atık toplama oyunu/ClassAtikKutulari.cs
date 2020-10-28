/***********************************
 
 
            NDP PROJESİ 

ADEM KEPÇE      B191210058      1B


***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210058_1B_NDP_PROJE
{
    class KutuMetal : IAtikKutusu       // metal kutusu sınıfı
    {
        public void Sil()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }

        public bool Ekle(ClassAtik atik)
        {
            if (_doluHacim < Kapasite)
            {
                _doluHacim = _doluHacim + atik.Hacim;
                _dolulukOrani = _doluHacim / 23;
            }
            return true;
        }

        public bool Bosalt()
        {
            if (75 <= _dolulukOrani)
            {
                _dolulukOrani = 0;
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int _doluHacim;
        private int _dolulukOrani;
        public KutuMetal(int doluHacim)
        {
            _doluHacim = doluHacim;
        }
        public int Kapasite { get { return 2300; } set { } }
        public int DoluHacim { get { return _doluHacim; } }
        public int DolulukOrani { get { return _dolulukOrani; } }
        public int BosaltmaPuani { get { return 800; } }
    }
    class KolaKutusu : ClassAtik    // kola kutusu sınıfı
    {
        public KolaKutusu(int hacim) : base(hacim)
        {
        }
    }
    class SalcaKutusu : ClassAtik   // salca kutusu sınıfı
    {
        public SalcaKutusu(int hacim) : base(hacim)
        {
        }
    }

    class KutuCam : IAtikKutusu     // cam kutusu sınıfı
    {
        public void Sil()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }

        public bool Ekle(ClassAtik atik)
        {
            if (_doluHacim < Kapasite)
            {
                _doluHacim = _doluHacim + atik.Hacim;
                _dolulukOrani = _doluHacim / 22;
            }
            return true;
        }

        public bool Bosalt()
        {
            if (75 <= _dolulukOrani)
            {
                _dolulukOrani = 0;
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int _doluHacim;
        private int _dolulukOrani;
        public KutuCam(int doluHacim)
        {
            _doluHacim = doluHacim;
        }
        public int Kapasite { get { return 2200; } set { } }
        public int DoluHacim { get { return _doluHacim; } }
        public int DolulukOrani { get { return _dolulukOrani; } }
        public int BosaltmaPuani { get { return 600; } }
    }
    class Sise : ClassAtik  // sise sınıfı
    {
        public Sise(int hacim) : base(hacim)
        {
        }
    }
    class Bardak : ClassAtik    // bardak sınıfı
    {
        public Bardak(int hacim) : base(hacim)
        {
        }
    }

    class KutuKagit : IAtikKutusu     // kagit kutusu sınıfı
    {
        public void Sil()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }

        public bool Ekle(ClassAtik atik)
        {
            if (_doluHacim < Kapasite)
            {
                _doluHacim = _doluHacim + atik.Hacim;
                _dolulukOrani = _doluHacim / 12;
            }
            return true;
        }

        public bool Bosalt()
        {
            if (75 <= _dolulukOrani)
            {
                _dolulukOrani = 0;
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int _doluHacim;
        private int _dolulukOrani;
        public KutuKagit(int doluHacim)
        {
            _doluHacim = doluHacim;
        }
        public int Kapasite { get { return 1200; } set { } }
        public int DoluHacim { get { return _doluHacim; } }
        public int DolulukOrani { get { return _dolulukOrani; } }
        public int BosaltmaPuani { get { return 1000; } }
    }
    class Gazete : ClassAtik    // gazete sınıfı
    {
        public Gazete(int hacim) : base(hacim)
        {
        }
    }
    class Dergi : ClassAtik     // dergi sınıfı
    {
        public Dergi(int hacim) : base(hacim)
        {
        }
    }

    class KutuOrganik : IAtikKutusu     // organik kutusu sınıfı
    {
        public void Sil()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }

        public bool Ekle(ClassAtik atik)
        {
            if (_doluHacim < Kapasite)
            {
                _doluHacim = _doluHacim + atik.Hacim;
                _dolulukOrani = _doluHacim / 7;
            }
            return true;
        }

        public bool Bosalt()
        {
            if (75 <= _dolulukOrani)
            {
                _dolulukOrani = 0;
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int _doluHacim;
        private int _dolulukOrani;
        public KutuOrganik(int doluHacim)
        {
            _doluHacim = doluHacim;
        }
        public int Kapasite { get { return 700; } set { } }
        public int DoluHacim { get { return _doluHacim; } }
        public int DolulukOrani { get { return _dolulukOrani; } }
        public int BosaltmaPuani { get { return 0; } }
    }
    class Domates : ClassAtik    // domates sınıfı
    {
        public Domates(int hacim) : base(hacim)
        {
        }
    }
    class Salatalik : ClassAtik     // salatalik sınıfı
    {
        public Salatalik(int hacim) : base(hacim)
        {
        }
    }
}