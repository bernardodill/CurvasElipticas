using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurvasElipticas
{
    public partial class Form1 : Form
    {
        Point p, q, r;
        double lambda;
        int a,mod;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void escreveValores() {
            texto.Text = String.Format("P({0}, {1}) Q({2}, {3}) R({4}, {5})\n  A: {6}   P: {7}", p.X, p.Y, q.X,q.Y,r.X,r.Y,a,mod);
        }

        public void calculaY3()
        {
            r.Y  = (int) ((lambda * (p.X - r.X) - p.Y) % mod);
            escreveValores();
        }

        public void calculaX3()
        {
           r.X  = (int) (((Math.Pow(lambda, 2))-p.X -p.X) % mod);
            calculaY3();
        }

        public void pontosIguais(Point p, Point q) {
           lambda =  (3 * Math.Pow(p.X, 2) + a)/(2*p.Y);
            calculaX3();
        }

        public void pontosDiferentes(Point p, Point q) {
            lambda = (q.Y - p.Y) / (q.X - p.X);
            calculaX3();
        }

        public void ativaBotao(object sender, EventArgs e)
        {
            if(x1.Text != ""  && y1.Text != "" && x2.Text != "" && y2.Text != "")
            {
                calculaLambda.Enabled = true;
            }else{
                calculaLambda.Enabled = false;
            }                    
        }


        public void calcularLambda(object sender, EventArgs e)
        {
            p.X = int.Parse(x1.Text);
            p.Y = int.Parse(y1.Text);
            q.X = int.Parse(x2.Text);
            q.Y = int.Parse(y2.Text);
            a = int.Parse(fieldA.Text);
            mod = int.Parse(fieldMod.Text);

            if (p.ToString().Equals(q.ToString()))
            {
                pontosIguais(p,q);
            }
            else
            {
                pontosDiferentes(p,q);
            }


        }
    }
}
