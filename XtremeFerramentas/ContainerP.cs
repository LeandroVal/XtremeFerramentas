using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    public partial class ContainerP : Form
    {
        public ContainerP()
        {
            InitializeComponent();
        }

        private void ContainerP_Load(object sender, EventArgs e)
        {

             //////////////// Propriedades do MDIContainer
            /////////////////////////////////////////////////////////////////////////////
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];    ///
            ctlMDI.BackColor = Color.WhiteSmoke;                                    ///
            ctlMDI.BackgroundImage = Properties.Resources.fundo4;                  ///
            /////////////////////////////////////////////////////////////////////////
        }

        private void ms_princ_fer_emp_Click(object sender, EventArgs e)
        {
            cefEmprestimo CefEmprestimo = new cefEmprestimo();
            CefEmprestimo.MdiParent = this;
            CefEmprestimo.Show();
        }

        private void ms_princ_fer_cad_Click(object sender, EventArgs e)
        {
            cadFerramentas CadFerramentas = new cadFerramentas();
            CadFerramentas.MdiParent = this;
            CadFerramentas.Show();
        }

        private void ms_princ_fer_dev_Click(object sender, EventArgs e)
        {
            cefDevolucao CefDevolucao = new cefDevolucao();
            CefDevolucao.MdiParent = this;
            CefDevolucao.Show();
        }

        private void ms_princ_fer_con_Click(object sender, EventArgs e)
        {
            conFerramenta ConFerramenta = new conFerramenta();
            ConFerramenta.MdiParent = this;
            ConFerramenta.Show();

        }

        private void ms_princ_fer_mod_Click(object sender, EventArgs e)
        {
            ferMod FerMod = new ferMod();
            FerMod.MdiParent = this;
            FerMod.Show();
        }

        private void ms_princ_fer_exc_Click(object sender, EventArgs e)
        {
            ferExc FerExc = new ferExc();
            FerExc.MdiParent = this;
            FerExc.Show();
            
        }

        private void ms_princ_fer_ins_Click(object sender, EventArgs e)
        {
            ferrInserir FerrInserir = new ferrInserir();
            FerrInserir.MdiParent = this;
            FerrInserir.Show();
        }

        private void ms_princ_fer_rem_Click(object sender, EventArgs e)
        {
            ferrRemover FerrRemover = new ferrRemover();
            FerrRemover.MdiParent = this;
            FerrRemover.Show();
        }
    }
}
