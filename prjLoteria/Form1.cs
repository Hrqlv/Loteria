using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLoteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCartela_Click(object sender, EventArgs e)
        {
            if (rbMegaSena.Checked)
            {
                Cartela jogo = new Cartela(60);
                jogo.Imprimir(pnCartela, 6, 10);
                jogo.Sortear(60, 6);
            }
            if (rbLotoMania.Checked)
            {
                Cartela jogo = new Cartela(60);
                jogo.Imprimir(pnCartela, 6, 10);
                jogo.Sortear(100, 50);
            }
            if (rbLotoFacil.Checked)
            {
                Cartela jogo = new Cartela(60);
                jogo.Imprimir(pnCartela, 6, 10);
                jogo.Sortear(25, 15);
            }
            if (rbQuina.Checked)
            {
                Cartela jogo = new Cartela(60);
                jogo.Imprimir(pnCartela, 6, 10);
                jogo.Sortear(60, 6);
            }
        }
    }
}
