using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSoApp
{
    public class PhanSo
    {
        public int TuSo { get; private set; }
        public int MauSo { get; private set; }

        //constructor default

        public PhanSo(int tuso, int mauso)
        {
            if (mauso == 0)
            {
                throw new ArgumentException(" Mau so ko duoc bang 0");
                
            }
            if (mauso < 0)
            {
                tuso = -tuso;
                mauso = -mauso;
            }
            int ucln = UCLN(Math.Abs(tuso), mauso);
            TuSo = tuso / ucln;
            MauSo = mauso / ucln;
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public PhanSo RutGon()
        {
            return new PhanSo(TuSo, MauSo);// constructor da tu dong rut
        }

        public override string ToString()
        {
            if (MauSo == 1) return TuSo.ToString();
            return $"{TuSo}/{MauSo}";
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tuSoMoi = (a.TuSo * b.MauSo) + (a.MauSo * b.TuSo);
            int mauSoMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.TuSo * b.MauSo - a.MauSo * b.TuSo;
            int mausoMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuSoMoi, mausoMoi);
        }

        public static PhanSo operator * (PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.TuSo * b.TuSo;
            int mauSoMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }


        public static PhanSo operator / (PhanSo a, PhanSo b)
        {
            if(b.TuSo ==0)
            {
                throw new DivideByZeroException("khong the chia phan so cho 0");
            }
            return new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);

        }


        //nang cao
        public static PhanSo operator + (PhanSo a , int b)
        {
            PhanSo n = new PhanSo(b, 1);
            return a + n;
        }
        public static PhanSo operator +(int a , PhanSo b)
        {
            return b + a;
        }


        // bai 3
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo == a.MauSo * b.TuSo;
        }

        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo < a.MauSo * b.TuSo;
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return b < a;
        }

    }
}
