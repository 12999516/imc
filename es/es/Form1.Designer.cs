namespace es
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_main = new Panel();
            btn_esegui = new Button();
            txt_altezza = new TextBox();
            txt_peso = new TextBox();
            txt_nome = new TextBox();
            lst_lista = new ListBox();
            btn_salva = new Button();
            btn_add = new Button();
            lbl_genere = new Label();
            lbl_altezza = new Label();
            lbl_peso = new Label();
            lbl_nome = new Label();
            pnl_gender = new Panel();
            rdb_femmina = new RadioButton();
            rdb_maschio = new RadioButton();
            pnl_calcoli = new Panel();
            rdb_media = new RadioButton();
            rdb_moda = new RadioButton();
            rdb_mediana = new RadioButton();
            rdb_calcolo = new RadioButton();
            rdb_varianza = new RadioButton();
            pnl_main.SuspendLayout();
            pnl_gender.SuspendLayout();
            pnl_calcoli.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = Color.DarkGray;
            pnl_main.Controls.Add(txt_altezza);
            pnl_main.Controls.Add(txt_peso);
            pnl_main.Controls.Add(txt_nome);
            pnl_main.Controls.Add(lst_lista);
            pnl_main.Controls.Add(btn_salva);
            pnl_main.Controls.Add(btn_add);
            pnl_main.Controls.Add(lbl_genere);
            pnl_main.Controls.Add(lbl_altezza);
            pnl_main.Controls.Add(lbl_peso);
            pnl_main.Controls.Add(lbl_nome);
            pnl_main.Controls.Add(pnl_gender);
            pnl_main.Controls.Add(pnl_calcoli);
            pnl_main.Location = new Point(4, 3);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1209, 444);
            pnl_main.TabIndex = 0;
            // 
            // btn_esegui
            // 
            btn_esegui.Location = new Point(914, 3);
            btn_esegui.Name = "btn_esegui";
            btn_esegui.Size = new Size(262, 49);
            btn_esegui.TabIndex = 4;
            btn_esegui.Text = "esegui";
            btn_esegui.UseVisualStyleBackColor = true;
            btn_esegui.Click += btn_esegui_Click;
            // 
            // txt_altezza
            // 
            txt_altezza.Location = new Point(482, 33);
            txt_altezza.Name = "txt_altezza";
            txt_altezza.Size = new Size(222, 27);
            txt_altezza.TabIndex = 11;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(236, 33);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(230, 27);
            txt_peso.TabIndex = 10;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(8, 33);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(211, 27);
            txt_nome.TabIndex = 9;
            // 
            // lst_lista
            // 
            lst_lista.FormattingEnabled = true;
            lst_lista.Location = new Point(0, 93);
            lst_lista.Name = "lst_lista";
            lst_lista.Size = new Size(1209, 284);
            lst_lista.TabIndex = 8;
            // 
            // btn_salva
            // 
            btn_salva.Location = new Point(1067, 49);
            btn_salva.Name = "btn_salva";
            btn_salva.Size = new Size(122, 38);
            btn_salva.TabIndex = 7;
            btn_salva.Text = "salva";
            btn_salva.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(1067, 6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(122, 37);
            btn_add.TabIndex = 6;
            btn_add.Text = "aggiungi";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_genere
            // 
            lbl_genere.Location = new Point(746, 6);
            lbl_genere.Name = "lbl_genere";
            lbl_genere.Size = new Size(237, 25);
            lbl_genere.TabIndex = 5;
            lbl_genere.Text = "genere";
            // 
            // lbl_altezza
            // 
            lbl_altezza.Location = new Point(482, 6);
            lbl_altezza.Name = "lbl_altezza";
            lbl_altezza.Size = new Size(176, 31);
            lbl_altezza.TabIndex = 4;
            lbl_altezza.Text = "altezza in metri";
            // 
            // lbl_peso
            // 
            lbl_peso.Location = new Point(236, 6);
            lbl_peso.Name = "lbl_peso";
            lbl_peso.Size = new Size(184, 27);
            lbl_peso.TabIndex = 3;
            lbl_peso.Text = "peso in kg";
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(8, 6);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(128, 24);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "nome e cognome";
            // 
            // pnl_gender
            // 
            pnl_gender.Controls.Add(rdb_femmina);
            pnl_gender.Controls.Add(rdb_maschio);
            pnl_gender.Location = new Point(746, 34);
            pnl_gender.Name = "pnl_gender";
            pnl_gender.Size = new Size(286, 31);
            pnl_gender.TabIndex = 1;
            // 
            // rdb_femmina
            // 
            rdb_femmina.Location = new Point(145, 4);
            rdb_femmina.Name = "rdb_femmina";
            rdb_femmina.Size = new Size(146, 30);
            rdb_femmina.TabIndex = 1;
            rdb_femmina.TabStop = true;
            rdb_femmina.Text = "femmina";
            rdb_femmina.UseVisualStyleBackColor = true;
            // 
            // rdb_maschio
            // 
            rdb_maschio.Location = new Point(3, 3);
            rdb_maschio.Name = "rdb_maschio";
            rdb_maschio.Size = new Size(146, 30);
            rdb_maschio.TabIndex = 0;
            rdb_maschio.TabStop = true;
            rdb_maschio.Text = "maschio";
            rdb_maschio.UseVisualStyleBackColor = true;
            // 
            // pnl_calcoli
            // 
            pnl_calcoli.Controls.Add(btn_esegui);
            pnl_calcoli.Controls.Add(rdb_varianza);
            pnl_calcoli.Controls.Add(rdb_media);
            pnl_calcoli.Controls.Add(rdb_moda);
            pnl_calcoli.Controls.Add(rdb_mediana);
            pnl_calcoli.Controls.Add(rdb_calcolo);
            pnl_calcoli.Location = new Point(2, 388);
            pnl_calcoli.Name = "pnl_calcoli";
            pnl_calcoli.Size = new Size(1207, 55);
            pnl_calcoli.TabIndex = 0;
            // 
            // rdb_media
            // 
            rdb_media.Location = new Point(195, 16);
            rdb_media.Name = "rdb_media";
            rdb_media.Size = new Size(117, 24);
            rdb_media.TabIndex = 3;
            rdb_media.TabStop = true;
            rdb_media.Text = "media IMC";
            rdb_media.UseVisualStyleBackColor = true;
            // 
            // rdb_moda
            // 
            rdb_moda.Location = new Point(358, 16);
            rdb_moda.Name = "rdb_moda";
            rdb_moda.Size = new Size(117, 24);
            rdb_moda.TabIndex = 2;
            rdb_moda.TabStop = true;
            rdb_moda.Text = "moda IMC";
            rdb_moda.UseVisualStyleBackColor = true;
            // 
            // rdb_mediana
            // 
            rdb_mediana.Location = new Point(539, 16);
            rdb_mediana.Name = "rdb_mediana";
            rdb_mediana.Size = new Size(117, 24);
            rdb_mediana.TabIndex = 1;
            rdb_mediana.TabStop = true;
            rdb_mediana.Text = "mediana IMC";
            rdb_mediana.UseVisualStyleBackColor = true;
            // 
            // rdb_calcolo
            // 
            rdb_calcolo.Location = new Point(32, 12);
            rdb_calcolo.Name = "rdb_calcolo";
            rdb_calcolo.Size = new Size(129, 33);
            rdb_calcolo.TabIndex = 0;
            rdb_calcolo.TabStop = true;
            rdb_calcolo.Text = "calcolo IMC";
            rdb_calcolo.UseVisualStyleBackColor = true;
            // 
            // rdb_varianza
            // 
            rdb_varianza.AutoSize = true;
            rdb_varianza.Location = new Point(725, 15);
            rdb_varianza.Name = "rdb_varianza";
            rdb_varianza.Size = new Size(115, 24);
            rdb_varianza.TabIndex = 4;
            rdb_varianza.TabStop = true;
            rdb_varianza.Text = "varianza IMC";
            rdb_varianza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 448);
            Controls.Add(pnl_main);
            Name = "Form1";
            Text = "Form1";
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            pnl_gender.ResumeLayout(false);
            pnl_calcoli.ResumeLayout(false);
            pnl_calcoli.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_main;
        private Label lbl_altezza;
        private Label lbl_peso;
        private Label lbl_nome;
        private Panel pnl_gender;
        private Panel pnl_calcoli;
        private Button btn_salva;
        private Button btn_add;
        private Label lbl_genere;
        private RadioButton rdb_femmina;
        private RadioButton rdb_maschio;
        private RadioButton rdb_media;
        private RadioButton rdb_moda;
        private RadioButton rdb_mediana;
        private RadioButton rdb_calcolo;
        private TextBox txt_altezza;
        private TextBox txt_peso;
        private TextBox txt_nome;
        private ListBox lst_lista;
        private Button btn_esegui;
        private RadioButton rdb_varianza;
    }
}
