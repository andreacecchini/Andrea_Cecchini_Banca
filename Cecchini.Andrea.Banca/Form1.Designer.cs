namespace Cecchini.Andrea.Banca
{
    partial class Gestione_Banca
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpConto = new System.Windows.Forms.GroupBox();
            this.cbConto = new System.Windows.Forms.ComboBox();
            this.lblScelta = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.grpIntestatario = new System.Windows.Forms.GroupBox();
            this.txtCodiceFiscale = new System.Windows.Forms.TextBox();
            this.txtNascita = new System.Windows.Forms.TextBox();
            this.txtLuogo = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodiceFiscale = new System.Windows.Forms.Label();
            this.lblNascita = new System.Windows.Forms.Label();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpEliminaAll = new System.Windows.Forms.GroupBox();
            this.btnEliminaAll = new System.Windows.Forms.Button();
            this.txtEliminaCF = new System.Windows.Forms.TextBox();
            this.txtEliminaCognome = new System.Windows.Forms.TextBox();
            this.txtEliminaNome = new System.Windows.Forms.TextBox();
            this.lblEliminaCF = new System.Windows.Forms.Label();
            this.lblEliminaCognome = new System.Windows.Forms.Label();
            this.lblEliminaNome = new System.Windows.Forms.Label();
            this.btnEliminaSingolo = new System.Windows.Forms.Button();
            this.grpMovimenti = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIbanDestinatario = new System.Windows.Forms.TextBox();
            this.lblIbanDestinatario = new System.Windows.Forms.Label();
            this.btnEseguiBonifico = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.lblTipologiaMovimento = new System.Windows.Forms.Label();
            this.cbTipologiaMovimento = new System.Windows.Forms.ComboBox();
            this.lblImporto = new System.Windows.Forms.Label();
            this.txtImporto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpListaConti = new System.Windows.Forms.GroupBox();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.lstConti = new System.Windows.Forms.ListBox();
            this.grpRicercaMovimenti = new System.Windows.Forms.GroupBox();
            this.lstRicercaMovimenti = new System.Windows.Forms.ListBox();
            this.grpSeleziona = new System.Windows.Forms.GroupBox();
            this.btnRicercaMovimenti = new System.Windows.Forms.Button();
            this.grpInfoAccount = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grpInfoIntestatario = new System.Windows.Forms.GroupBox();
            this.txtInfoCf = new System.Windows.Forms.TextBox();
            this.txtInfoTipologia = new System.Windows.Forms.TextBox();
            this.lblInfoNome = new System.Windows.Forms.Label();
            this.lblInfoTipologia = new System.Windows.Forms.Label();
            this.lblInfoCf = new System.Windows.Forms.Label();
            this.txtInfoNome = new System.Windows.Forms.TextBox();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblInfoIban = new System.Windows.Forms.Label();
            this.grpConto.SuspendLayout();
            this.grpIntestatario.SuspendLayout();
            this.grpEliminaAll.SuspendLayout();
            this.grpMovimenti.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpListaConti.SuspendLayout();
            this.grpRicercaMovimenti.SuspendLayout();
            this.grpSeleziona.SuspendLayout();
            this.grpInfoAccount.SuspendLayout();
            this.grpInfoIntestatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConto
            // 
            this.grpConto.Controls.Add(this.cbConto);
            this.grpConto.Controls.Add(this.lblScelta);
            this.grpConto.Controls.Add(this.btnAggiungi);
            this.grpConto.Controls.Add(this.grpIntestatario);
            this.grpConto.Location = new System.Drawing.Point(12, 50);
            this.grpConto.Name = "grpConto";
            this.grpConto.Size = new System.Drawing.Size(368, 238);
            this.grpConto.TabIndex = 0;
            this.grpConto.TabStop = false;
            this.grpConto.Text = "Creazione Conto corrente";
            // 
            // cbConto
            // 
            this.cbConto.FormattingEnabled = true;
            this.cbConto.Items.AddRange(new object[] {
            "Conto Corrente",
            "Conto Online"});
            this.cbConto.Location = new System.Drawing.Point(111, 22);
            this.cbConto.Name = "cbConto";
            this.cbConto.Size = new System.Drawing.Size(121, 21);
            this.cbConto.TabIndex = 10;
            // 
            // lblScelta
            // 
            this.lblScelta.AutoSize = true;
            this.lblScelta.Location = new System.Drawing.Point(12, 27);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(81, 13);
            this.lblScelta.TabIndex = 10;
            this.lblScelta.Text = "Tipologia Conto";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(265, 117);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(96, 40);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // grpIntestatario
            // 
            this.grpIntestatario.Controls.Add(this.txtCodiceFiscale);
            this.grpIntestatario.Controls.Add(this.txtNascita);
            this.grpIntestatario.Controls.Add(this.txtLuogo);
            this.grpIntestatario.Controls.Add(this.txtCognome);
            this.grpIntestatario.Controls.Add(this.txtNome);
            this.grpIntestatario.Controls.Add(this.lblCodiceFiscale);
            this.grpIntestatario.Controls.Add(this.lblNascita);
            this.grpIntestatario.Controls.Add(this.lblLuogo);
            this.grpIntestatario.Controls.Add(this.lblCognome);
            this.grpIntestatario.Controls.Add(this.lblNome);
            this.grpIntestatario.Location = new System.Drawing.Point(6, 55);
            this.grpIntestatario.Name = "grpIntestatario";
            this.grpIntestatario.Size = new System.Drawing.Size(242, 173);
            this.grpIntestatario.TabIndex = 0;
            this.grpIntestatario.TabStop = false;
            this.grpIntestatario.Text = "Intestatario";
            // 
            // txtCodiceFiscale
            // 
            this.txtCodiceFiscale.Location = new System.Drawing.Point(105, 132);
            this.txtCodiceFiscale.Name = "txtCodiceFiscale";
            this.txtCodiceFiscale.Size = new System.Drawing.Size(100, 20);
            this.txtCodiceFiscale.TabIndex = 8;
            // 
            // txtNascita
            // 
            this.txtNascita.Location = new System.Drawing.Point(105, 106);
            this.txtNascita.Name = "txtNascita";
            this.txtNascita.Size = new System.Drawing.Size(100, 20);
            this.txtNascita.TabIndex = 7;
            // 
            // txtLuogo
            // 
            this.txtLuogo.Location = new System.Drawing.Point(105, 77);
            this.txtLuogo.Name = "txtLuogo";
            this.txtLuogo.Size = new System.Drawing.Size(100, 20);
            this.txtLuogo.TabIndex = 6;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(105, 51);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblCodiceFiscale
            // 
            this.lblCodiceFiscale.AutoSize = true;
            this.lblCodiceFiscale.Location = new System.Drawing.Point(6, 138);
            this.lblCodiceFiscale.Name = "lblCodiceFiscale";
            this.lblCodiceFiscale.Size = new System.Drawing.Size(76, 13);
            this.lblCodiceFiscale.TabIndex = 4;
            this.lblCodiceFiscale.Text = "Codice Fiscale";
            // 
            // lblNascita
            // 
            this.lblNascita.AutoSize = true;
            this.lblNascita.Location = new System.Drawing.Point(6, 106);
            this.lblNascita.Name = "lblNascita";
            this.lblNascita.Size = new System.Drawing.Size(80, 13);
            this.lblNascita.TabIndex = 3;
            this.lblNascita.Text = "Data di Nascita";
            // 
            // lblLuogo
            // 
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Location = new System.Drawing.Point(6, 76);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(87, 13);
            this.lblLuogo.TabIndex = 2;
            this.lblLuogo.Text = "Luogo di Nascita";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(6, 51);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // grpEliminaAll
            // 
            this.grpEliminaAll.Controls.Add(this.btnEliminaAll);
            this.grpEliminaAll.Controls.Add(this.txtEliminaCF);
            this.grpEliminaAll.Controls.Add(this.txtEliminaCognome);
            this.grpEliminaAll.Controls.Add(this.txtEliminaNome);
            this.grpEliminaAll.Controls.Add(this.lblEliminaCF);
            this.grpEliminaAll.Controls.Add(this.lblEliminaCognome);
            this.grpEliminaAll.Controls.Add(this.lblEliminaNome);
            this.grpEliminaAll.Location = new System.Drawing.Point(396, 50);
            this.grpEliminaAll.Name = "grpEliminaAll";
            this.grpEliminaAll.Size = new System.Drawing.Size(313, 119);
            this.grpEliminaAll.TabIndex = 1;
            this.grpEliminaAll.TabStop = false;
            this.grpEliminaAll.Text = "Elimina intestatario e relativi conti associati";
            // 
            // btnEliminaAll
            // 
            this.btnEliminaAll.Location = new System.Drawing.Point(211, 43);
            this.btnEliminaAll.Name = "btnEliminaAll";
            this.btnEliminaAll.Size = new System.Drawing.Size(85, 35);
            this.btnEliminaAll.TabIndex = 2;
            this.btnEliminaAll.Text = "Elimina";
            this.btnEliminaAll.UseVisualStyleBackColor = true;
            this.btnEliminaAll.Click += new System.EventHandler(this.BtnEliminaAll_Click);
            // 
            // txtEliminaCF
            // 
            this.txtEliminaCF.Location = new System.Drawing.Point(88, 81);
            this.txtEliminaCF.Name = "txtEliminaCF";
            this.txtEliminaCF.Size = new System.Drawing.Size(100, 20);
            this.txtEliminaCF.TabIndex = 9;
            // 
            // txtEliminaCognome
            // 
            this.txtEliminaCognome.Location = new System.Drawing.Point(88, 51);
            this.txtEliminaCognome.Name = "txtEliminaCognome";
            this.txtEliminaCognome.Size = new System.Drawing.Size(100, 20);
            this.txtEliminaCognome.TabIndex = 9;
            // 
            // txtEliminaNome
            // 
            this.txtEliminaNome.Location = new System.Drawing.Point(88, 23);
            this.txtEliminaNome.Name = "txtEliminaNome";
            this.txtEliminaNome.Size = new System.Drawing.Size(100, 20);
            this.txtEliminaNome.TabIndex = 6;
            // 
            // lblEliminaCF
            // 
            this.lblEliminaCF.AutoSize = true;
            this.lblEliminaCF.Location = new System.Drawing.Point(3, 84);
            this.lblEliminaCF.Name = "lblEliminaCF";
            this.lblEliminaCF.Size = new System.Drawing.Size(76, 13);
            this.lblEliminaCF.TabIndex = 5;
            this.lblEliminaCF.Text = "Codice Fiscale";
            // 
            // lblEliminaCognome
            // 
            this.lblEliminaCognome.AutoSize = true;
            this.lblEliminaCognome.Location = new System.Drawing.Point(6, 58);
            this.lblEliminaCognome.Name = "lblEliminaCognome";
            this.lblEliminaCognome.Size = new System.Drawing.Size(52, 13);
            this.lblEliminaCognome.TabIndex = 2;
            this.lblEliminaCognome.Text = "Cognome";
            // 
            // lblEliminaNome
            // 
            this.lblEliminaNome.AutoSize = true;
            this.lblEliminaNome.Location = new System.Drawing.Point(6, 26);
            this.lblEliminaNome.Name = "lblEliminaNome";
            this.lblEliminaNome.Size = new System.Drawing.Size(35, 13);
            this.lblEliminaNome.TabIndex = 1;
            this.lblEliminaNome.Text = "Nome";
            // 
            // btnEliminaSingolo
            // 
            this.btnEliminaSingolo.Location = new System.Drawing.Point(20, 220);
            this.btnEliminaSingolo.Name = "btnEliminaSingolo";
            this.btnEliminaSingolo.Size = new System.Drawing.Size(85, 35);
            this.btnEliminaSingolo.TabIndex = 2;
            this.btnEliminaSingolo.Text = "Elimina";
            this.btnEliminaSingolo.UseVisualStyleBackColor = true;
            this.btnEliminaSingolo.Click += new System.EventHandler(this.BtnEliminaSingolo_Click);
            // 
            // grpMovimenti
            // 
            this.grpMovimenti.Controls.Add(this.groupBox4);
            this.grpMovimenti.Controls.Add(this.groupBox3);
            this.grpMovimenti.Controls.Add(this.lblImporto);
            this.grpMovimenti.Controls.Add(this.txtImporto);
            this.grpMovimenti.Location = new System.Drawing.Point(369, 57);
            this.grpMovimenti.Name = "grpMovimenti";
            this.grpMovimenti.Size = new System.Drawing.Size(729, 131);
            this.grpMovimenti.TabIndex = 3;
            this.grpMovimenti.TabStop = false;
            this.grpMovimenti.Text = "Movimenti";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIbanDestinatario);
            this.groupBox4.Controls.Add(this.lblIbanDestinatario);
            this.groupBox4.Controls.Add(this.btnEseguiBonifico);
            this.groupBox4.Location = new System.Drawing.Point(414, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 63);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bonifico";
            // 
            // txtIbanDestinatario
            // 
            this.txtIbanDestinatario.Location = new System.Drawing.Point(109, 23);
            this.txtIbanDestinatario.Name = "txtIbanDestinatario";
            this.txtIbanDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtIbanDestinatario.TabIndex = 23;
            // 
            // lblIbanDestinatario
            // 
            this.lblIbanDestinatario.AutoSize = true;
            this.lblIbanDestinatario.Location = new System.Drawing.Point(6, 26);
            this.lblIbanDestinatario.Name = "lblIbanDestinatario";
            this.lblIbanDestinatario.Size = new System.Drawing.Size(97, 13);
            this.lblIbanDestinatario.TabIndex = 22;
            this.lblIbanDestinatario.Text = "Destinatario (IBAN)";
            // 
            // btnEseguiBonifico
            // 
            this.btnEseguiBonifico.Location = new System.Drawing.Point(228, 14);
            this.btnEseguiBonifico.Name = "btnEseguiBonifico";
            this.btnEseguiBonifico.Size = new System.Drawing.Size(75, 36);
            this.btnEseguiBonifico.TabIndex = 21;
            this.btnEseguiBonifico.Text = "Esegui";
            this.btnEseguiBonifico.UseVisualStyleBackColor = true;
            this.btnEseguiBonifico.Click += new System.EventHandler(this.BtnEseguiBonifico_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEsegui);
            this.groupBox3.Controls.Add(this.lblTipologiaMovimento);
            this.groupBox3.Controls.Add(this.cbTipologiaMovimento);
            this.groupBox3.Location = new System.Drawing.Point(6, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 63);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimento interno";
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(252, 17);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(78, 38);
            this.btnEsegui.TabIndex = 22;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.BtnEsegui_Click);
            // 
            // lblTipologiaMovimento
            // 
            this.lblTipologiaMovimento.AutoSize = true;
            this.lblTipologiaMovimento.Location = new System.Drawing.Point(6, 30);
            this.lblTipologiaMovimento.Name = "lblTipologiaMovimento";
            this.lblTipologiaMovimento.Size = new System.Drawing.Size(104, 13);
            this.lblTipologiaMovimento.TabIndex = 15;
            this.lblTipologiaMovimento.Text = "Tipologia movimento";
            // 
            // cbTipologiaMovimento
            // 
            this.cbTipologiaMovimento.FormattingEnabled = true;
            this.cbTipologiaMovimento.Items.AddRange(new object[] {
            "Versamento",
            "Prelievo"});
            this.cbTipologiaMovimento.Location = new System.Drawing.Point(116, 26);
            this.cbTipologiaMovimento.Name = "cbTipologiaMovimento";
            this.cbTipologiaMovimento.Size = new System.Drawing.Size(121, 21);
            this.cbTipologiaMovimento.TabIndex = 11;
            // 
            // lblImporto
            // 
            this.lblImporto.AutoSize = true;
            this.lblImporto.Location = new System.Drawing.Point(6, 26);
            this.lblImporto.Name = "lblImporto";
            this.lblImporto.Size = new System.Drawing.Size(113, 13);
            this.lblImporto.TabIndex = 13;
            this.lblImporto.Text = "Importo del movimento";
            // 
            // txtImporto
            // 
            this.txtImporto.Location = new System.Drawing.Point(122, 23);
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(100, 20);
            this.txtImporto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gestione conti";
            // 
            // grpListaConti
            // 
            this.grpListaConti.Controls.Add(this.btnAggiorna);
            this.grpListaConti.Controls.Add(this.lstConti);
            this.grpListaConti.Location = new System.Drawing.Point(765, 9);
            this.grpListaConti.Name = "grpListaConti";
            this.grpListaConti.Size = new System.Drawing.Size(517, 296);
            this.grpListaConti.TabIndex = 6;
            this.grpListaConti.TabStop = false;
            this.grpListaConti.Text = "Lista conti";
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(6, 250);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(78, 38);
            this.btnAggiorna.TabIndex = 23;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.BtnAggiorna_Click);
            // 
            // lstConti
            // 
            this.lstConti.FormattingEnabled = true;
            this.lstConti.Location = new System.Drawing.Point(6, 32);
            this.lstConti.Name = "lstConti";
            this.lstConti.Size = new System.Drawing.Size(465, 212);
            this.lstConti.TabIndex = 0;
            // 
            // grpRicercaMovimenti
            // 
            this.grpRicercaMovimenti.Controls.Add(this.lstRicercaMovimenti);
            this.grpRicercaMovimenti.Location = new System.Drawing.Point(369, 194);
            this.grpRicercaMovimenti.Name = "grpRicercaMovimenti";
            this.grpRicercaMovimenti.Size = new System.Drawing.Size(479, 247);
            this.grpRicercaMovimenti.TabIndex = 8;
            this.grpRicercaMovimenti.TabStop = false;
            this.grpRicercaMovimenti.Text = "Lista movimenti";
            // 
            // lstRicercaMovimenti
            // 
            this.lstRicercaMovimenti.FormattingEnabled = true;
            this.lstRicercaMovimenti.Location = new System.Drawing.Point(6, 19);
            this.lstRicercaMovimenti.Name = "lstRicercaMovimenti";
            this.lstRicercaMovimenti.Size = new System.Drawing.Size(465, 225);
            this.lstRicercaMovimenti.TabIndex = 0;
            // 
            // grpSeleziona
            // 
            this.grpSeleziona.Controls.Add(this.btnRicercaMovimenti);
            this.grpSeleziona.Controls.Add(this.grpInfoAccount);
            this.grpSeleziona.Controls.Add(this.grpRicercaMovimenti);
            this.grpSeleziona.Controls.Add(this.txtIban);
            this.grpSeleziona.Controls.Add(this.btnEliminaSingolo);
            this.grpSeleziona.Controls.Add(this.lblInfoIban);
            this.grpSeleziona.Controls.Add(this.grpMovimenti);
            this.grpSeleziona.Location = new System.Drawing.Point(12, 305);
            this.grpSeleziona.Name = "grpSeleziona";
            this.grpSeleziona.Size = new System.Drawing.Size(1103, 449);
            this.grpSeleziona.TabIndex = 9;
            this.grpSeleziona.TabStop = false;
            this.grpSeleziona.Text = "Seleziona Conto ed esegui operazioni su esso ";
            // 
            // btnRicercaMovimenti
            // 
            this.btnRicercaMovimenti.Location = new System.Drawing.Point(870, 202);
            this.btnRicercaMovimenti.Name = "btnRicercaMovimenti";
            this.btnRicercaMovimenti.Size = new System.Drawing.Size(78, 38);
            this.btnRicercaMovimenti.TabIndex = 24;
            this.btnRicercaMovimenti.Text = "Ricerca Movimenti";
            this.btnRicercaMovimenti.UseVisualStyleBackColor = true;
            this.btnRicercaMovimenti.Click += new System.EventHandler(this.BtnRicercaMovimenti_Click);
            // 
            // grpInfoAccount
            // 
            this.grpInfoAccount.Controls.Add(this.btnInfo);
            this.grpInfoAccount.Controls.Add(this.grpInfoIntestatario);
            this.grpInfoAccount.Location = new System.Drawing.Point(6, 57);
            this.grpInfoAccount.Name = "grpInfoAccount";
            this.grpInfoAccount.Size = new System.Drawing.Size(339, 157);
            this.grpInfoAccount.TabIndex = 25;
            this.grpInfoAccount.TabStop = false;
            this.grpInfoAccount.Text = "Info account";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(239, 26);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(85, 35);
            this.btnInfo.TabIndex = 26;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // grpInfoIntestatario
            // 
            this.grpInfoIntestatario.Controls.Add(this.txtInfoCf);
            this.grpInfoIntestatario.Controls.Add(this.txtInfoTipologia);
            this.grpInfoIntestatario.Controls.Add(this.lblInfoNome);
            this.grpInfoIntestatario.Controls.Add(this.lblInfoTipologia);
            this.grpInfoIntestatario.Controls.Add(this.lblInfoCf);
            this.grpInfoIntestatario.Controls.Add(this.txtInfoNome);
            this.grpInfoIntestatario.Location = new System.Drawing.Point(9, 23);
            this.grpInfoIntestatario.Name = "grpInfoIntestatario";
            this.grpInfoIntestatario.Size = new System.Drawing.Size(224, 120);
            this.grpInfoIntestatario.TabIndex = 26;
            this.grpInfoIntestatario.TabStop = false;
            this.grpInfoIntestatario.Text = "Intestatario";
            // 
            // txtInfoCf
            // 
            this.txtInfoCf.Enabled = false;
            this.txtInfoCf.Location = new System.Drawing.Point(105, 54);
            this.txtInfoCf.Name = "txtInfoCf";
            this.txtInfoCf.Size = new System.Drawing.Size(113, 20);
            this.txtInfoCf.TabIndex = 11;
            // 
            // txtInfoTipologia
            // 
            this.txtInfoTipologia.Enabled = false;
            this.txtInfoTipologia.Location = new System.Drawing.Point(105, 88);
            this.txtInfoTipologia.Name = "txtInfoTipologia";
            this.txtInfoTipologia.Size = new System.Drawing.Size(113, 20);
            this.txtInfoTipologia.TabIndex = 12;
            // 
            // lblInfoNome
            // 
            this.lblInfoNome.AutoSize = true;
            this.lblInfoNome.Location = new System.Drawing.Point(6, 25);
            this.lblInfoNome.Name = "lblInfoNome";
            this.lblInfoNome.Size = new System.Drawing.Size(92, 13);
            this.lblInfoNome.TabIndex = 2;
            this.lblInfoNome.Text = "Nome e Cognome";
            // 
            // lblInfoTipologia
            // 
            this.lblInfoTipologia.AutoSize = true;
            this.lblInfoTipologia.Location = new System.Drawing.Point(6, 91);
            this.lblInfoTipologia.Name = "lblInfoTipologia";
            this.lblInfoTipologia.Size = new System.Drawing.Size(50, 13);
            this.lblInfoTipologia.TabIndex = 26;
            this.lblInfoTipologia.Text = "Tipologia";
            // 
            // lblInfoCf
            // 
            this.lblInfoCf.AutoSize = true;
            this.lblInfoCf.Location = new System.Drawing.Point(6, 57);
            this.lblInfoCf.Name = "lblInfoCf";
            this.lblInfoCf.Size = new System.Drawing.Size(76, 13);
            this.lblInfoCf.TabIndex = 9;
            this.lblInfoCf.Text = "Codice Fiscale";
            // 
            // txtInfoNome
            // 
            this.txtInfoNome.Enabled = false;
            this.txtInfoNome.Location = new System.Drawing.Point(105, 25);
            this.txtInfoNome.Name = "txtInfoNome";
            this.txtInfoNome.Size = new System.Drawing.Size(113, 20);
            this.txtInfoNome.TabIndex = 3;
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(55, 27);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(130, 20);
            this.txtIban.TabIndex = 24;
            // 
            // lblInfoIban
            // 
            this.lblInfoIban.AutoSize = true;
            this.lblInfoIban.Location = new System.Drawing.Point(17, 32);
            this.lblInfoIban.Name = "lblInfoIban";
            this.lblInfoIban.Size = new System.Drawing.Size(32, 13);
            this.lblInfoIban.TabIndex = 0;
            this.lblInfoIban.Text = "IBAN";
            // 
            // Gestione_Banca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 902);
            this.Controls.Add(this.grpSeleziona);
            this.Controls.Add(this.grpEliminaAll);
            this.Controls.Add(this.grpListaConti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpConto);
            this.Name = "Gestione_Banca";
            this.Text = "Gestione Banca";
            this.Load += new System.EventHandler(this.Gestione_Banca_Load);
            this.grpConto.ResumeLayout(false);
            this.grpConto.PerformLayout();
            this.grpIntestatario.ResumeLayout(false);
            this.grpIntestatario.PerformLayout();
            this.grpEliminaAll.ResumeLayout(false);
            this.grpEliminaAll.PerformLayout();
            this.grpMovimenti.ResumeLayout(false);
            this.grpMovimenti.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpListaConti.ResumeLayout(false);
            this.grpRicercaMovimenti.ResumeLayout(false);
            this.grpSeleziona.ResumeLayout(false);
            this.grpSeleziona.PerformLayout();
            this.grpInfoAccount.ResumeLayout(false);
            this.grpInfoIntestatario.ResumeLayout(false);
            this.grpInfoIntestatario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConto;
        private System.Windows.Forms.GroupBox grpIntestatario;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.Label lblNascita;
        private System.Windows.Forms.Label lblLuogo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.TextBox txtNascita;
        private System.Windows.Forms.TextBox txtLuogo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox grpEliminaAll;
        private System.Windows.Forms.Button btnEliminaAll;
        private System.Windows.Forms.TextBox txtEliminaCF;
        private System.Windows.Forms.TextBox txtEliminaCognome;
        private System.Windows.Forms.TextBox txtEliminaNome;
        private System.Windows.Forms.Label lblEliminaCF;
        private System.Windows.Forms.Label lblEliminaCognome;
        private System.Windows.Forms.Label lblEliminaNome;
        private System.Windows.Forms.Button btnEliminaSingolo;
        private System.Windows.Forms.Label lblScelta;
        private System.Windows.Forms.GroupBox grpMovimenti;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtImporto;
        private System.Windows.Forms.ComboBox cbTipologiaMovimento;
        private System.Windows.Forms.Label lblImporto;
        private System.Windows.Forms.Label lblTipologiaMovimento;
        private System.Windows.Forms.Button btnEseguiBonifico;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.TextBox txtIbanDestinatario;
        private System.Windows.Forms.Label lblIbanDestinatario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpListaConti;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.ListBox lstConti;
        private System.Windows.Forms.GroupBox grpRicercaMovimenti;
        private System.Windows.Forms.ListBox lstRicercaMovimenti;
        private System.Windows.Forms.GroupBox grpSeleziona;
        private System.Windows.Forms.GroupBox grpInfoAccount;
        private System.Windows.Forms.Label lblInfoCf;
        private System.Windows.Forms.TextBox txtInfoNome;
        private System.Windows.Forms.Label lblInfoNome;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label lblInfoIban;
        private System.Windows.Forms.TextBox txtInfoCf;
        private System.Windows.Forms.Button btnRicercaMovimenti;
        private System.Windows.Forms.TextBox txtInfoTipologia;
        private System.Windows.Forms.Label lblInfoTipologia;
        private System.Windows.Forms.GroupBox grpInfoIntestatario;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ComboBox cbConto;
    }
}

