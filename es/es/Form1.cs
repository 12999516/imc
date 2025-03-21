using System.Runtime.CompilerServices;

namespace es
{
    public partial class Form1 : Form
    {
        struct imc
        {
            public string nome;
            public float altezza;
            public float peso;
            public char sesso;
            public imc(string n, float a, float p, char s)
            {
                nome = n;
                altezza = a;
                peso = p;
                sesso = s;
            }
        }
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
            aggiorna();
            rdb_maschio.Checked = true;
        }

        imc[] persone = new imc[10];
        private void aggiorna()
        {
            string perc = @"..\..\..\..\nomi.txt";
            using (StreamReader sr = new StreamReader(perc))
            {
                cont = 0;
                lst_lista.Items.Clear();
                while (sr.Peek() != -1)
                {
                    try
                    {
                        string riga = sr.ReadLine();
                        string[] campi = riga.Split(';');
                        persone[cont].nome = campi[0];
                        persone[cont].peso = float.Parse(campi[1]);
                        persone[cont].altezza = float.Parse(campi[2]);
                        persone[cont].sesso = campi[3][0];
                        lst_lista.Items.Add($"{persone[cont].nome}; {persone[cont].altezza}; {persone[cont].peso}; {persone[cont].sesso}");
                    }
                    catch { MessageBox.Show("Caricamento un po' sbagliato"); }

                    cont++;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            float altezza;
            float peso;
            string sesso;
            float.TryParse(txt_altezza.Text, out altezza);
            float.TryParse(txt_peso.Text, out peso);

            if (rdb_maschio.Checked)
            {
                sesso = "M";
                lst_lista.Items.Add($"{nome.PadRight(20)}; {altezza.ToString().PadLeft(8)}; {peso.ToString().PadRight(8)}; {sesso.PadLeft(8)}");
            }
            else
            {
                sesso = "F";
                lst_lista.Items.Add($"{nome.PadRight(20)}; {altezza.ToString().PadRight(8)}; {peso.ToString().PadRight(8)}; {sesso.PadRight(8)}");
            }
            AggiungiAlFile(nome, altezza, peso, sesso);
            aggiorna();
        }

        private void AggiungiAlFile(string nome, float altezza, float peso, string sesso)
        {
            string perc = @"..\..\..\..\nomi.txt";
            using (StreamWriter sw = new StreamWriter(perc, true))
            {
                sw.WriteLine($"{nome};{altezza};{peso};{sesso}");
            }
        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {
            int indice = lst_lista.SelectedIndex;
            double risultato = 0;

            if (rdb_calcolo.Checked)
            {
                risultato = persone[indice].peso * 1.0 / (Math.Pow(persone[indice].altezza / 100.0, 2));
                risultato *= 10;
                MessageBox.Show("L'indice di massa corporea di " + persone[indice].nome + " è " + risultato);
            }
            else if (rdb_media.Checked)
            {
                double med = 0;
                for (int i = 0; i < cont; i++)
                {
                    med += persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                }
                med /= cont;
                med *= 10;
                MessageBox.Show("La media è " + med);
            }
            else if (rdb_mediana.Checked)
            {
                double[] imc = new double[cont];
                for (int i = 0; i < cont; i++)
                {
                    imc[i] = persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                }

                for (int i = 0; i < imc.Length - 1; i++)
                {
                    for (int j = 0; j < imc.Length - 1 - i; j++)
                    {
                        if (imc[j] > imc[j + 1])
                        {
                            
                            double temp = imc[j];
                            imc[j] = imc[j + 1];
                            imc[j + 1] = temp;
                        }
                    }
                }

                double mediana;
                if (imc.Length % 2 == 0)
                {
                    mediana = (imc[imc.Length / 2 - 1] + imc[imc.Length / 2]) / 2.0;
                }
                else
                {
                    mediana = imc[imc.Length / 2];
                }
                mediana *= 10;
                MessageBox.Show("La mediana è " + mediana);
            }
            else if (rdb_moda.Checked)
            {
                double[] imc = new double[cont];
                for (int i = 0; i < cont; i++)
                {
                    imc[i] = persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                }

                double moda = imc[0];
                int maxCount = 0;

                for (int i = 0; i < cont; i++)
                {
                    int count = 0;

                    for (int j = 0; j < cont; j++)
                    {
                        if (imc[i] == imc[j])
                        {
                            count++;
                        }
                    }
                    
                    if (count > maxCount)
                    {
                        maxCount = count;
                        moda = imc[i];
                    }
                }

                moda *= 10;
                MessageBox.Show("La moda è " + moda);
            }
            else if (rdb_varianza.Checked)
            {
                double[] imc = new double[cont];
                double media = 0;
                for (int i = 0; i < cont; i++)
                {
                    imc[i] = persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                    media += imc[i];
                }
                media /= cont;

                double varianza = 0;
                for (int i = 0; i < cont; i++)
                {
                    varianza += Math.Pow(imc[i] - media, 2);
                }
                varianza /= cont;
                varianza *= 10;
                MessageBox.Show("La varianza è " + varianza);
            }
        }
    }
}


/*using System.Runtime.CompilerServices;

namespace es
{
    public partial class Form1 : Form
    {
        struct imc
        {
            public string nome;
            public float altezza;
            public float peso;
            public char sesso;
            imc(string n, float a, float p, char s)
            {
                nome = n;
                altezza = a;
                peso = p;
                sesso = s;
            }
        }
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
            aggiorna();
            rdb_maschio.Checked = true;
        }

        imc[] persone = new imc[10];
        private void aggiorna()
        {
            string perc = @"..\..\..\nomi.txt";
            using (StreamReader sr = new StreamReader(perc))
            {
                cont = 0;
                lst_lista.Items.Clear();
                while (sr.Peek() != -1)
                {
                    try
                    {
                        string riga = sr.ReadLine();
                        string[] campi = riga.Split(';');
                        persone[cont].nome = campi[0];
                        persone[cont].peso = int.Parse(campi[1]);
                        persone[cont].altezza = int.Parse(campi[2]);
                        persone[cont].sesso = campi[3][0];
                        lst_lista.Items.Add($"");
                    }
                    catch { MessageBox.Show("Caricamento un po' sbagliato"); }

                    cont++;
                }
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            float altezza;
            float peso;
            for(int i = 0; i < persone.Length; i++)
            {
                persone[i] = new imc();
            }
            float.TryParse(txt_altezza.Text, out altezza);
            float.TryParse(txt_peso.Text, out peso);

            if (rdb_maschio.Checked)
            {
                lst_lista.Items.Add(nome + "; " + altezza + "; " + peso + "; M");
            }
            else
            {
                lst_lista.Items.Add(nome + "; " + altezza / 10 + "; " + peso + "; F");
            }
        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {
            int indice = lst_lista.SelectedIndex;
            double risultato = 0;

            if (rdb_calcolo.Checked)
            {

                risultato = persone[indice].peso * 1.0 / (Math.Pow(persone[indice].altezza / 100.0, 2) );

                MessageBox.Show("L'indice di massa corporea di " + persone[indice].nome + " è " + risultato);
            } else if(rdb_media.Checked)
            {
                double med = 0;
                for (int i = 0; i < cont; i++)
                {
                    med += persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                }
                med /= cont;
                MessageBox.Show("La media è " + med);
            } else if (rdb_mediana.Checked)
            {
                double[] imc = new double[cont];

                for(int i = 0; i < imc.Length; i++)
                {
                    for (int j = 0; j < imc.Length; j++)
                    {
                        if (imc[i] < imc[j])
                        {
                            double temp = imc[i];
                            imc[i] = imc[j];
                            imc[j] = temp;
                        }
                    }
                }
                MessageBox.Show("La mediana è " + imc[imc.Length / 2]);

            } else if(rdb_moda.Checked)
            {
                double[] freq = new double[cont];
                double moda = 0;
                int contat = 0;

                for (int i = 0; i < cont; i++)
                {
                    freq[i] = persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                }
                for(int i = 0; i < freq.Length; i++)
                {
                    for(int j = 0; j < freq.Length; i++)
                    {
                        if (freq[i] == freq[j])
                        {
                            contat += 1;
                        }

                    }
                    if (contat > contat)
                    {
                        moda = freq[i];
                    }
                }
                MessageBox.Show( "La moda è: " + moda);

            } else if(rdb_varianza.Checked)
            {
                double[] freq = new double[cont];
                double med = 0;
                double somm_qua = 0;

                for (int i = 0; i < cont; i++)
                {
                    freq[i] = persone[i].peso * 1.0 / (Math.Pow(persone[i].altezza / 100.0, 2));
                    med += freq[i];
                }
                med /= cont;
                for (int i = 0; i < cont; i++)
                {
                    somm_qua += Math.Pow(freq[i] - med, 2);
                }
                somm_qua /= cont - 1;
            }
        }
    }
}
*/