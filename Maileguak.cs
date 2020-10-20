using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilboMetropolikoKutxa
{
    public partial class Maileguak : Form
    {
        string zureIzena_bezeroa;
        string[] lanEgoera_baliagarriak = { "Funtzionarioa", "Langabea", "Ikaslea", "Erretiratua", "Langile kontratua", "Autonomoa", "Ezgaitua" };
        int[] kuota_baliagarriak = { 12, 24, 36, 60, 120, 180, 240 };
        string[] udalerri_baliagarriak;
        Dictionary<int, double> interes_oinarria;

        public Maileguak(string zureIzena)
        {
            zureIzena_bezeroa = zureIzena;

            string zerrenda_hiriak = Properties.Resources.lekuak.ToString();
            udalerri_baliagarriak = zerrenda_hiriak.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            interes_oinarria = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < kuota_baliagarriak.Length; i++, interes += 0.5)
            {
                interes_oinarria[kuota_baliagarriak[i]] = interes;
            }
        }
        private void Prestamos_Load(object sender, EventArgs e)
        {
            kuotaPopularrak();
            lanEgoeraPopularrak();
            udalerriPopularrak();
            Agurra.Text += zureIzena_bezeroa;
        }
        void kuotaPopularrak()
        {
            for (int i = 0; i < kuota_baliagarriak.Length; i++)
            {
                cbKuotak.Items.Add(kuota_baliagarriak[i]);
            }
        }
        void lanEgoeraPopularrak()
        {
            for (int i = 0; i < lanEgoera_baliagarriak.Length; i++)
            {
                cbLanEgoera.Items.Add(lanEgoera_baliagarriak[i]);
            }
        }
        void udalerriPopularrak()
        {
            for (int i = 0; i < udalerri_baliagarriak.Length; i++)
            {
                cbUdalerria.Items.Add(udalerri_baliagarriak[i]);
            }
        }
        private void Atzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void eskaintzaKonfirmatu_Click(object sender, EventArgs e)
        {
            switch (balidatzeak())
            {
                case 0:
                    {
                        errorProvider1.SetError(datuPertsonalak, "");
                        errorProvider1.SetError(MaileguEzaugarriak, "");
                        double interes_hilekoa = interesakKalkulatu();
                        double zifra_eskatua = double.Parse(Zifra.Text);
                        int kuotak_eskatuak = (int)kuotaCombo.SelectedItem;
                        double interes_totala = zifra_eskatua * (interes_hilekoa / 100) * kuotak_eskatuak;
                        double zifra_ordaintzeke = zifra_eskatua + interes_totala;
                        string mezua = "Zure Mailegua" + zifra_eskatua + kuotak_eskatuak + " -etan " + " hurrengo interesekin eskainiko dira " + interes_hilekoa + "% hilekoa.\nEl amaierako zifra finala honela geratuko litzateke " + zifra_ordaintzeke;
                        MessageBoxButtons botoiak = MessageBoxButtons.OK;
                        MessageBox.Show(mezua, "Cálculo de intereses", botoiak);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(datuPertsonalak, "Datu Pertsonal guztiak bete behar dira");
                        errorProvider1.SetError(MaileguEzaugarriak, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(MaileguEzaugarriak, "Zenbaki zifra bat txertatu behar duzu eta kuota kantita espezifiko bat");
                        errorProvider1.SetError(datuPertsonalak, "");
                        break;
                    }

            }
        }
        int balidatzeak()
        {
            if ((cbLanEgoera.SelectedIndex <= -1) || (cbUdalerria.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(txtZifra.Text.All(Char.IsDigit)) || (txtZifra.Text == "") || (cbKuotak.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
        double interesakKalkulatu()
        {
            int kuota_hautatuak = (int)cbKuotak.SelectedItem;
            string lanEgoera_hautatua = cbKuotak.SelectedItem.ToString().ToLower();
            string udalerri_hautatua = cbUdalerria.SelectedItem.ToString().ToLower();
            double interes = interes_oinarria[kuota_hautatuak];
            if (new[] { "Langabea", "Autonomoa", "Funtzionarioa", "Ikaslea", "Erretiratua" }.Contains(lanEgoera_hautatua))
            {
                interes += 0.3;
            }
            if (new[] { "Sestao", "Santurtzi", "Getxo", "Bilbo", "Leioa", "Galdakao" }.Contains(udalerri_hautatua))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void Maileguak_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maileguak));
            this.Saludo = new System.Windows.Forms.Label();
            this.atzera = new System.Windows.Forms.Button();
            this.eskaintzaKonfirmatu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPertsonalak = new System.Windows.Forms.Panel();
            this.panelMaileguak = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLanEgoera = new System.Windows.Forms.ComboBox();
            this.cbUdalerria = new System.Windows.Forms.ComboBox();
            this.cbKuotak = new System.Windows.Forms.ComboBox();
            this.txtZifra = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPertsonalak.SuspendLayout();
            this.panelMaileguak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.Location = new System.Drawing.Point(33, 39);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(121, 24);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Ongi etorri, ";
            // 
            // atzera
            // 
            this.atzera.BackColor = System.Drawing.Color.Red;
            this.atzera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atzera.Location = new System.Drawing.Point(668, 382);
            this.atzera.Name = "atzera";
            this.atzera.Size = new System.Drawing.Size(110, 39);
            this.atzera.TabIndex = 1;
            this.atzera.Text = "Atzera";
            this.atzera.UseVisualStyleBackColor = false;
            // 
            // eskaintzaKonfirmatu
            // 
            this.eskaintzaKonfirmatu.BackColor = System.Drawing.Color.Black;
            this.eskaintzaKonfirmatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eskaintzaKonfirmatu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eskaintzaKonfirmatu.Location = new System.Drawing.Point(312, 266);
            this.eskaintzaKonfirmatu.Name = "eskaintzaKonfirmatu";
            this.eskaintzaKonfirmatu.Size = new System.Drawing.Size(180, 68);
            this.eskaintzaKonfirmatu.TabIndex = 2;
            this.eskaintzaKonfirmatu.Text = "Eskaintza Konfirmatu";
            this.eskaintzaKonfirmatu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(147, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datu Pertsonalak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(448, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mailegu Ezaugarriak:";
            // 
            // panelPertsonalak
            // 
            this.panelPertsonalak.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelPertsonalak.Controls.Add(this.cbUdalerria);
            this.panelPertsonalak.Controls.Add(this.cbLanEgoera);
            this.panelPertsonalak.Controls.Add(this.label5);
            this.panelPertsonalak.Controls.Add(this.label4);
            this.panelPertsonalak.Location = new System.Drawing.Point(54, 149);
            this.panelPertsonalak.Name = "panelPertsonalak";
            this.panelPertsonalak.Size = new System.Drawing.Size(297, 100);
            this.panelPertsonalak.TabIndex = 5;
            // 
            // panelMaileguak
            // 
            this.panelMaileguak.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelMaileguak.Controls.Add(this.txtZifra);
            this.panelMaileguak.Controls.Add(this.cbKuotak);
            this.panelMaileguak.Controls.Add(this.label6);
            this.panelMaileguak.Controls.Add(this.label7);
            this.panelMaileguak.Location = new System.Drawing.Point(406, 149);
            this.panelMaileguak.Name = "panelMaileguak";
            this.panelMaileguak.Size = new System.Drawing.Size(321, 100);
            this.panelMaileguak.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lan egoera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Udalerria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kuotak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Zifra:";
            // 
            // cbLanEgoera
            // 
            this.cbLanEgoera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanEgoera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanEgoera.FormattingEnabled = true;
            this.cbLanEgoera.Location = new System.Drawing.Point(120, 18);
            this.cbLanEgoera.Name = "cbLanEgoera";
            this.cbLanEgoera.Size = new System.Drawing.Size(121, 21);
            this.cbLanEgoera.TabIndex = 2;
            // 
            // cbUdalerria
            // 
            this.cbUdalerria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUdalerria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUdalerria.FormattingEnabled = true;
            this.cbUdalerria.Location = new System.Drawing.Point(120, 54);
            this.cbUdalerria.Name = "cbUdalerria";
            this.cbUdalerria.Size = new System.Drawing.Size(121, 21);
            this.cbUdalerria.TabIndex = 3;
            // 
            // cbKuotak
            // 
            this.cbKuotak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKuotak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKuotak.FormattingEnabled = true;
            this.cbKuotak.Location = new System.Drawing.Point(108, 54);
            this.cbKuotak.Name = "cbKuotak";
            this.cbKuotak.Size = new System.Drawing.Size(121, 21);
            this.cbKuotak.TabIndex = 4;
            // 
            // txtZifra
            // 
            this.txtZifra.Location = new System.Drawing.Point(108, 15);
            this.txtZifra.Name = "txtZifra";
            this.txtZifra.Size = new System.Drawing.Size(121, 20);
            this.txtZifra.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Maileguak
            // 
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panelMaileguak);
            this.Controls.Add(this.panelPertsonalak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eskaintzaKonfirmatu);
            this.Controls.Add(this.atzera);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Maileguak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilbo Metropoliko Kutxa";
            this.Load += new System.EventHandler(this.Maileguak_Load);
            this.panelPertsonalak.ResumeLayout(false);
            this.panelPertsonalak.PerformLayout();
            this.panelMaileguak.ResumeLayout(false);
            this.panelMaileguak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

        







