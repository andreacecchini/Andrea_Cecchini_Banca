using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cecchini.Andrea.Banca
{
    public partial class Gestione_Banca : Form
    {
        
        public string[] IBAN = new string[10]; // Vettore di IBAN della banca.
        public Random r = new Random(); 
        public Banca banca = new Banca("Valconca", "Via riccione"); //Inizializzazione della banca.
        public Gestione_Banca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo scatenatod dalla pressione del bottone "Aggiungi", permette di aggiungerer un determinato conto corrente alla banca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
           
            //Se le caselle di testo non sono state riempite viene segnalato tramite un messaggio d'errore.
            if(txtNome.Text== "" || txtCognome.Text== "" || txtCodiceFiscale.Text== "" || txtLuogo.Text=="" || txtNascita.Text == "")
            {

                MessageBox.Show("Attenzione, i campi non sono stati impostati correttamente");
            }
            else
            {
                try
                {
                    string[] Data = txtNascita.Text.Split('/');
                    if (cbConto.Text == "Conto Corrente") //Se è stato selezionato nella combobox l'opzione Conto Corrente
                    {
                        banca.aggiungiConto(new ContoCorrente(new Persona(txtNome.Text, txtCognome.Text, txtLuogo.Text, new DateTime(int.Parse(Data[2]), int.Parse(Data[1]), int.Parse(Data[0])), txtCodiceFiscale.Text), IBAN[r.Next(0, 9)])); //Aggiunta del conto corrente nella lista della banca.
                        Attiva();
                    }
                    else
                    {
                        if (cbConto.Text == "Conto Online")//Se è stato selezionato nella combobox l'opzione Conto Online
                        {
                            banca.aggiungiConto(new ContoOnline(new Persona(txtNome.Text, txtCognome.Text, txtLuogo.Text, new DateTime(2002, 05, 02), txtCodiceFiscale.Text), IBAN[r.Next(0, 9)]));//Aggiunta del conto onlinbe nella lista della banca.
                            Attiva();
                        }
                        else
                        {
                            //Messaggio d'errore.
                            MessageBox.Show("Attenzione, scegliere la tipologia del conto");
                        }


                    }
                    //Refresh delle textbox dopo la pressione del bottone.
                    txtNome.Clear();
                    txtCognome.Clear();
                    txtNascita.Clear();
                    txtLuogo.Clear();
                    txtCodiceFiscale.Clear();
                }
                catch
                {
                    MessageBox.Show("Controllare la validità dei dati");
                }
            }

        }

        //Inizializzazione della form ad inzio programma
       public  void Gestione_Banca_Load(object sender, EventArgs e)
        {
            IBAN[0] = "ITAS4XA4XA8XECQW";
            IBAN[1] = "ITAS4CSDXASXQECA";
            IBAN[2] = "ITAS4XDVDVSDSWEC";
            IBAN[3] = "ITAS4DHBQKCMALAI";
            IBAN[4] = "ITAS4MNCJSJNSAJK";
            IBAN[5] = "ITAS4SDJBSJCBSJN";
            IBAN[6] = "ITAS4DNBDHCJBDJS";
            IBAN[7] = "ITAS4SASANSKCMSK";
            IBAN[8] = "ITAS4SDSCXCSASAW";
            IBAN[9] = "ITAS4ASXZXCVCVCX";
            Disattiva();
        }

        /// <summary>
        /// Evento scatenato dalla pressione del bottone "Elimina" per un determinato conto corrente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminaSingolo_Click(object sender, EventArgs e)
        {
            if (txtIban.Text != "")
            {
                banca.EliminaConto(txtIban.Text);
                txtIban.Clear();
                txtInfoCf.Clear();
                txtInfoNome.Clear();
                txtInfoTipologia.Clear();

                //Se non ci sono più conti correnti, si ritorna allo stato iniziale della form.
                if (banca.listaConti.Count == 0)
                {
                    Disattiva();
                }
            }
            else
            {
                //Messaggio d'errore
                MessageBox.Show("Riempire correttaemente i campi richiesti");
            }
        }

        /// <summary>
        ///  Evento scatenato dalla pressione del bottone "Elimina" per un determinato intestatario, permett di eliminare tutti i conti correnti a lui associati.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminaAll_Click(object sender, EventArgs e)
        {
            banca.EliminaPerIntestatario(txtEliminaNome.Text, txtEliminaCognome.Text , txtEliminaCF.Text);
            txtEliminaNome.Clear();
            txtEliminaCognome.Clear();
            txtEliminaCF.Clear();
            if (banca.listaConti.Count==0)
            {
                Disattiva();
            }
        }

        /// <summary>
        ///  Evento scatenato dalla pressione del bottone "Esegui" riferito al gruppo Bonifico, permette la creazione di un Bonifico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEseguiBonifico_Click(object sender, EventArgs e)
        {
            
           try
            {
                ContoCorrente mittente = banca.CercaConto(txtIban.Text);
                if (mittente.Bonifico(txtIbanDestinatario.Text, Convert.ToDouble(txtImporto.Text)))
                {

                }
                else
                {
                    MessageBox.Show("Saldo insufficiente!");
                }
               
            }
            catch //Per qualunque tipologia d'errore viene visualizzato il messaggio
            {
                MessageBox.Show("Riempire correttamente i campi richiesti");
            }
            //Refresh delle caselle di testo.
            txtImporto.Clear();
            txtIbanDestinatario.Clear();
        }


        /// <summary>
        /// Evento scatenato dalla pressione del bottone "Esegui" riferito al gruppo dei movimenti interni, permette la creazione di un versamento o bonifico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEsegui_Click(object sender, EventArgs e)
        {
            try { 
                ContoCorrente mittente = banca.CercaConto(txtIban.Text);
                if (cbTipologiaMovimento.Text == "Versamento") 
                {
                    mittente.Versa(Convert.ToInt32(txtImporto.Text));//Esecuzione del versamento.
                }
                else
                {
                    if (cbTipologiaMovimento.Text == "Prelievo")
                    {
                        if (mittente.Preleva(Convert.ToDouble(txtImporto.Text)) == true)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Saldo insufficiente!");
                        }
                    }
                    else
                    {
                        //Messaggio d'errore
                        MessageBox.Show("Non hai selezionato la tipologia del movimento");
                    }
                }
        }
            catch(Exception k )
            {
                MessageBox.Show("Riempire correttamente i campi richiesti");
            }
            //Resfresh delle caselle di testo.
            txtImporto.Clear();
          
           
        }

        /// <summary>
        ///Evento scatenato dalla pressione del bottone "Aggiorna", permette di aggiornare la visualizzazione della lista conti..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAggiorna_Click(object sender, EventArgs e)
        {
            string r;
            lstConti.Items.Clear();
           foreach(ContoCorrente c in banca.ListaConti)
            {
                if (c is ContoOnline)
                {
                     r = "Conto online-- IBAN: " + c.Iban + "\n Intestarario: " + c.Intestatario.Nome + "\n Saldo:" + c.Saldo;
                }
                else
                {
                    r= "Conto corrente-- IBAN: " + c.Iban + "\n Intestarario: " + c.Intestatario.Nome + "\n Saldo:" + c.Saldo;
                }
                lstConti.Items.Add(r);
               

            }
        }

        /// <summary>
        ///Evento scatenato dalla pressione del bottone "Aggiorna", permette di aggiornare la visualizzazione della lista di movimenti rispetto ad un determinato account..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRicercaMovimenti_Click(object sender, EventArgs e)
        {
            if (txtIban.Text != "")
            {
                lstRicercaMovimenti.Items.Clear();
                ContoCorrente c = banca.CercaConto(txtIban.Text);
                foreach (Movimento m in c.Movimenti)
                {
                    if (m is Bonifico)
                        lstRicercaMovimenti.Items.Add("Bonifico " + "| Destinatario: " + ((Bonifico)m).Destinatario + " |Importo: " + m.Importo + " | Data: " + m.DataMovimento);
                    else
                    {
                        if (m is Versamento)
                            lstRicercaMovimenti.Items.Add("Versamento " + "|Importo: " + m.Importo + " | Data: " + m.DataMovimento);
                        else
                            lstRicercaMovimenti.Items.Add("Prelievo " + "|Importo: " + m.Importo + " | Data: " + m.DataMovimento);
                    }

                }
            }
            else
            {
                MessageBox.Show("Riempire correttamente i campi richiesti");
            }
        }

        /// <summary>
        /// Metodo che permette di attivare i vari gruppi.
        /// </summary>
        public void Attiva()
        {
            grpSeleziona.Enabled = true; ;
            grpRicercaMovimenti.Enabled = true;
            grpEliminaAll.Enabled = true;
        }

        /// <summary>
        /// Metodo che permette di disattivare i vari gruppi.
        /// </summary>
        public void Disattiva()
        {
            grpSeleziona.Enabled = false;
            grpRicercaMovimenti.Enabled = false;
            grpEliminaAll.Enabled = false;
            lstRicercaMovimenti.Items.Clear();
        }

        /// <summary>
        /// Evento scatenato dalla pressione del bottone "Info", permette di visualizzare le info di un determianto account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ContoCorrente c = banca.CercaConto(txtIban.Text);
                txtInfoNome.Text = c.Intestatario.Nome;
                txtInfoCf.Text = c.Intestatario.Cf;
                if (c is ContoOnline)
                    txtInfoTipologia.Text = "Conto online";
                else
                    txtInfoTipologia.Text = "Conto online";
            }
            catch(Exception k)
            {
                MessageBox.Show("IBAN non corretto!");
            }
        }
    } 
}

    
  