using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatiiTVA
{
    public  class calcul
    {
        public float pret = 0.0f;
        public float cotatva = 0.0f;
        public float tva = 0.0f;
        public float pretcutva = 0.0f;
        public float coeficienttva = 0.0f;
        public float tvadinpretcutva = 0.0f;

        public calcul()
        { 
        
        }
        public calcul(float ppret, float pcotatva)
        {
            this.pret = ppret;
            this.cotatva = pcotatva;
        }
        public void calcularetva(float ppret, float pcotatva)
        {
            this.tva =  ppret * pcotatva / 100;

        }
        public void calcularepretcutva(float ppret, float ptva)
        {
            this.pretcutva = ppret + ptva;

        }
        public void calculcoeficienttva(float pcotatva)
        { 
            this.coeficienttva = (pcotatva/(pcotatva+100))*100;
        }
        public void calculcoeficienttva()
        {
            this.coeficienttva = (this.cotatva / (this.cotatva + 100)) * 100;
        }
        public void calcultvadinpretcutva(float ppretcutva, float pcoeficienttva)
        {
            this.tvadinpretcutva = ppretcutva * pcoeficienttva / 100;
        }
        public void extrageretvadintvacupret(float ppretcutva, float pcotatva)
        {
            this.calculcoeficienttva(pcotatva);
            this.calcultvadinpretcutva(ppretcutva, this.coeficienttva);

        }
    }
}
