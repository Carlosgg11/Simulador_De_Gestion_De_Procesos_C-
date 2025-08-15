using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Procesos
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
        }
        // Variables para los procesos
        string PRO;
        int TLL, TCP, PRI;
        public List<Procesos> lista = new List<Procesos>();
        public List<string> Listos = new List<string>();
        public List<string> Ejecucion = new List<string>();
        public List<string> Terminado = new List<string>();
        public class Procesos
        {
            public string Proceso;
            public int Tiempocpu;
            public int Prioridad;
            public int Tiempollegada;
            public int Quantum;

            public Procesos(string Pro1, int TiLle1, int TCPU1, int Pri1, int Qtm1)
            {
                Proceso = Pro1;
                Tiempollegada = TiLle1;
                Tiempocpu = TCPU1;
                Prioridad = Pri1;
                Quantum = Qtm1;
            }
        }
        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            PRO = "P" + lista.Count.ToString();
            TLL = X;
            TCP = R.Next(5, 20);
            PRI = R.Next(0, 3);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            Procesos proceso = new Procesos(PRO, TLL, TCP, PRI, Int16.Parse(textBox1.Text));
            lista.Add(proceso);
            dataGridViewProceso.Rows.Add(PRO);
            dataGridViewLlegada.Rows.Add(TLL);
            dataGridViewCPU.Rows.Add(TCP);
            dataGridViewPrioridad.Rows.Add(PRI);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSJF_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int I = 0; I <= lista.Count; I++)
            {
                for (int J = I + 1; J <= lista.Count - 1; J++)
                {
                    if (lista[I].Tiempocpu > lista[J].Tiempocpu)
                    {
                        Procesos Auxi = lista[I];
                        lista[I] = lista[J];
                        lista[J] = Auxi;
                        // Intercambiar nombres de proceso
                        var Auxi1 = dataGridViewProceso.Rows[I].Cells[0].Value.ToString();
                        dataGridViewProceso.Rows[I].Cells[0].Value = dataGridViewProceso.Rows[J].Cells[0].Value;
                        dataGridViewProceso.Rows[J].Cells[0].Value = Auxi1;

                        // Intercambiar tiempos de llegada
                        var Auxi2 = dataGridViewLlegada.Rows[I].Cells[0].Value.ToString();
                        dataGridViewLlegada.Rows[I].Cells[0].Value = dataGridViewLlegada.Rows[J].Cells[0].Value;
                        dataGridViewLlegada.Rows[J].Cells[0].Value = Auxi2;

                        // Intercambiar tiempos de CPU
                        var Auxi4 = dataGridViewCPU.Rows[I].Cells[0].Value.ToString();
                        dataGridViewCPU.Rows[I].Cells[0].Value = dataGridViewCPU.Rows[J].Cells[0].Value;
                        dataGridViewCPU.Rows[J].Cells[0].Value = Auxi4;

                        // Intercambiar prioridades
                        var Auxi5 = dataGridViewPrioridad.Rows[I].Cells[0].Value.ToString();
                        dataGridViewPrioridad.Rows[I].Cells[0].Value = dataGridViewPrioridad.Rows[J].Cells[0].Value;
                        dataGridViewPrioridad.Rows[J].Cells[0].Value = Auxi5;
                    }
                }
            }
            foreach (Procesos P in lista)
            {
                Listos.Add(P.Proceso);
                int index = dataGridViewListo.Rows.Add();
                dataGridViewListo.Rows[index].Cells[0].Value = P.Proceso;
            }
        }
        int D = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Código que querés ejecutar cada segundo
            D++;
            lblTMR.Text = D.ToString();
            if (Listos.Count >= 1 || Ejecucion.Count >= 1)
            {
                if (Ejecucion.Count == 0)
                {
                    Ejecucion.Add(Listos[0]);
                    lstEJC.Items.Add(lstLIS.Items[0]);
                    Listos.RemoveAt(0);
                    lstLIS.Items.RemoveAt(0);
                }
                int I = 0;
                for (I = 0; I < lista.Count; I++)
                {
                    if (Ejecucion[0] == lista[I].Proceso)
                    {
                        break;
                    }
                }
                lista[I].Tiempocpu--;
                lstTCP.Items[I] = lista[I].Tiempocpu;
                if (lista[I].Tiempocpu == 0)
                {
                    Terminado.Add(Ejecucion.ElementAt(0));
                    D = 0;
                    lstTER.Items.Add(lstEJC.Items[0]);
                    Ejecucion.RemoveAt(0);
                    lstEJC.Items.RemoveAt(0);
                }
            }
            if (lista.Count == lstTER.Items.Count)
            {
                timer1.Enabled = false;
                lblTMR.Text = "";
            }
        }
        private void cmdRR_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            foreach (Procesos P in lista)
            {
                Listos.Add(P.Proceso);
                lstLIS.Items.Add(P.Proceso);
            }
        }
        int X = 0;
        int I = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            D++;
            lblTMR.Text = D.ToString();
            if (Listos.Count > 0 || Ejecucion.Count > 0)
            {
                if (Ejecucion.Count == 0)
                {
                    Ejecucion.Add(Listos[0]);
                    Listos.RemoveAt(0);
                    lstEJC.Items.Add(lstLIS.Items[0]);
                    lstLIS.Items.RemoveAt(0);
                    lstTCP.Items[I] = lista[I].Tiempocpu;
                }
                else
                {
                    if (lista[I].Tiempocpu == 0)
                    {
                        Terminado.Add(Ejecucion[0]);
                        Ejecucion.RemoveAt(0);
                        lstTER.Items.Add(lstEJC.Items[0]);
                        lstEJC.Items.RemoveAt(0);
                        lstTCP.Items[I] = lista[I].Tiempocpu;
                    }
                    else if (lista[I].Quantum == 0)
                    {
                        Listos.Add(Ejecucion[0]);
                        Ejecucion.RemoveAt(0);
                        lstLIS.Items.Add(lstEJC.Items[0]);
                        lstEJC.Items.RemoveAt(0);
                        lista[I].Quantum = Int16.Parse(txtQTM.Text);
                        lstTCP.Items[I] = lista[I].Tiempocpu;
                    }
                    else
                    {
                        for (I = 0; I < lista.Count; I++)
                        {
                            if (Ejecucion[0] == lista[I].Proceso)
                            {
                                break;
                            }
                        }
                        if (Ejecucion.Count == 0)
                        {
                            if (Listos.Count > 0)
                            {
                                Ejecucion.Add(Listos[0]);
                                Listos.RemoveAt(0);
                                lstEJC.Items.Add(lstLIS.Items[0]);
                                lstLIS.Items.RemoveAt(0);
                                lstTCP.Items[I] = lista[I].Tiempocpu;
                            }
                        }
                    }
                    if (Ejecucion.Count == 0)
                    {
                        if (Listos.Count > 0)
                        {
                            Ejecucion.Add(Listos[0]);
                            Listos.RemoveAt(0);
                            lstEJC.Items.Add(lstLIS.Items[0]);
                            lstLIS.Items.RemoveAt(0);
                            lstTCP.Items[I] = lista[I].Tiempocpu;
                        }
                    }
                    lista[I].Tiempocpu--;
                    if (lista[I].Tiempocpu > 0)
                        lista[I].Quantum--;
                }
            }
            if (lista.Count == lstTER.Items.Count)
            {
                timer1.Enabled = false;
                lblTMR.Text = "";
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            X++;
        }
        private void cmdRRPR_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            for (int I = 0; I <= lista.Count; I++)
            {
                for (int J = I + 1; J <= lista.Count - 1; J++)
                {
                    if (lista[I].Prioridad > lista[J].Prioridad)
                    {
                        Procesos Auxi = lista[I];
                        lista[I] = lista[J];
                        lista[J] = Auxi;
                        string Auxi1 = (lstPRO.Items[I].ToString());
                        lstPRO.Items[I] = lstPRO.Items[J];
                        lstPRO.Items[J] = Auxi1;
                        int Auxi2 = int.Parse(lstTLL.Items[I].ToString());
                        lstTLL.Items[I] = lstTLL.Items[J];
                        lstTLL.Items[J] = Auxi2;
                        int Auxi4 = int.Parse(lstTCP.Items[I].ToString());
                        lstTCP.Items[I] = lstTCP.Items[J];
                        lstTCP.Items[J] = Auxi4;
                        int Auxi5 = int.Parse(lstPRI.Items[I].ToString());
                        lstPRI.Items[I] = lstPRI.Items[J];
                        lstPRI.Items[J] = Auxi5;
                    }
                }
            }
            foreach (Procesos P in lista)
            {
                Listos.Add(P.Proceso);
                lstLIS.Items.Add(P.Proceso);
            }
        }
        int Z = 0;
        int C = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            Z++;
            lblTMR.Text = Z.ToString();
            if (Listos.Count > 0 || Ejecucion.Count > 0)
            {
                if (Ejecucion.Count == 0)
                {
                    Ejecucion.Add(Listos[0]);
                    Listos.RemoveAt(0);
                    lstEJC.Items.Add(lstLIS.Items[0]);
                    lstLIS.Items.RemoveAt(0);
                    lstTCP.Items[C] = lista[I].Tiempocpu;
                }
                else
                {
                    if (lista[C].Tiempocpu == 0)
                    {
                        Terminado.Add(Ejecucion[0]);
                        Ejecucion.RemoveAt(0);
                        lstTER.Items.Add(lstEJC.Items[0]);
                        lstEJC.Items.RemoveAt(0);
                        lstTCP.Items[C] = lista[C].Tiempocpu;
                    }
                    else if (lista[C].Quantum == 0)
                    {
                        Listos.Add(Ejecucion[0]);
                        Ejecucion.RemoveAt(0);
                        lstLIS.Items.Add(lstEJC.Items[0]);
                        lstEJC.Items.RemoveAt(0);
                        lista[C].Quantum = Int16.Parse(txtQTM.Text);
                        lstTCP.Items[C] = lista[C].Tiempocpu;
                        lista[C].Prioridad++;
                        lstPRI.Items[C] = lista[C].Prioridad;
                    }
                    else
                    {
                        for (C = 0; C < lista.Count; C++)
                        {
                            if (Ejecucion[0] == lista[C].Proceso)
                            {
                                break;
                            }
                        }
                        if (Ejecucion.Count == 0)
                        {
                            if (Listos.Count > 0)
                            {
                                Ejecucion.Add(Listos[0]);
                                Listos.RemoveAt(0);
                                lstEJC.Items.Add(lstLIS.Items[0]);
                                lstLIS.Items.RemoveAt(0);
                                lstTCP.Items[C] = lista[C].Tiempocpu;
                            }
                        }
                    }
                    if (Ejecucion.Count == 0)
                    {
                        if (Listos.Count > 0)
                        {
                            Ejecucion.Add(Listos[0]);
                            Listos.RemoveAt(0);
                            lstEJC.Items.Add(lstLIS.Items[0]);
                            lstLIS.Items.RemoveAt(0);
                            lstTCP.Items[C] = lista[C].Tiempocpu;
                        }
                    }
                    lista[C].Tiempocpu--;
                    if (lista[C].Tiempocpu > 0)
                        lista[C].Quantum--;
                }
            }
            if (lista.Count == lstTER.Items.Count)
            {
                timer1.Enabled = false;
                lblTMR.Text = "";
            }
        }
    }
}
