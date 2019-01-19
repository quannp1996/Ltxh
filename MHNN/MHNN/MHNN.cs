using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MHNN
{
    class MHNN
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public string[] matran()
        {
            string[] g = new string[this.d + 1];
            for(int i = 0; i <= this.d; i++)
            {
                string hang = "";
                int mul = 0;
                if(i < this.c) { mul = i * this.b; } else { mul = this.c * this.b; }
                for(int j = 0; j <= this.d; j++)
                {
                    if (i == 0)
                    {
                        if(j == i) { hang += "-" + this.a+ "  "; }
                        else if(j == i + 1) { hang +=this.a+ "  "; }
                        else { hang += "0  "; }
                    }
                    else if(i == this.d)
                    {
                        if (j == i - 1) { hang += mul + "  "; }
                        else if (j == i) { hang += "-" + mul +"  "; }
                        else { hang += "0  "; }
                    }
                    else
                    {
                        if(j == i - 1) { hang += mul+ "  "; }
                        else if (j == i) { hang += "-" + (int) (this.a + mul)+"  "; }
                        else if (j == i + 1) { hang += this.a+ "  "; }
                        else { hang += "0  "; }
                    }
                }
                g[i] = hang;
            }
            return g;
        }
        public float[] buildPi()
        {
            
            float[] pii  = new float[this.d + 1];
            float[] mul  = new float[this.d + 2];
            float tong = 0;
            //Tinh mang MUL
            for (int i = 1; i <= this.d + 1; i++)
            {
                if (i < this.c) { mul[i] = i * this.b; } else { mul[i] = this.c * this.b; }
            }
            // Tính pi[0]
            for (int i = 1; i <= this.d; i++)
            {
                string str = "";
                float phanso = 1;
                for (int j = 0; j< i; j++)
                {
                    phanso *= this.a / mul[j+1];
                }
                tong += phanso;
            }
            pii[0] = 1 / (1 + tong);
            // Xác định các pi còn lại
            for (int i = 1; i <= this.d; i++)
            {
                pii[i] = (this.a / mul[i]) * pii[i - 1];
            }
            return pii;
        }
    }
}
