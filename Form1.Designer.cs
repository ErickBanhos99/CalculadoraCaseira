namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonPorcentagem = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonMais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplay.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 25);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(275, 57);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(232, 338);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(55, 55);
            this.buttonIgual.TabIndex = 1;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(86, 88);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(55, 55);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAC.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAC.FlatAppearance.BorderSize = 2;
            this.buttonAC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAC.Location = new System.Drawing.Point(12, 88);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(55, 55);
            this.buttonAC.TabIndex = 3;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonPorcentagem
            // 
            this.buttonPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPorcentagem.Location = new System.Drawing.Point(12, 338);
            this.buttonPorcentagem.Name = "buttonPorcentagem";
            this.buttonPorcentagem.Size = new System.Drawing.Size(55, 55);
            this.buttonPorcentagem.TabIndex = 4;
            this.buttonPorcentagem.Text = "+/-";
            this.buttonPorcentagem.UseVisualStyleBackColor = true;
            this.buttonPorcentagem.Click += new System.EventHandler(this.buttonSinal_Click);
            // 
            // buttonCinco
            // 
            this.buttonCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinco.Location = new System.Drawing.Point(86, 214);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(55, 55);
            this.buttonCinco.TabIndex = 5;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = true;
            this.buttonCinco.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonUm
            // 
            this.buttonUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUm.Location = new System.Drawing.Point(12, 153);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(55, 55);
            this.buttonUm.TabIndex = 6;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = true;
            this.buttonUm.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDois
            // 
            this.buttonDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDois.Location = new System.Drawing.Point(86, 153);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(55, 55);
            this.buttonDois.TabIndex = 7;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = true;
            this.buttonDois.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonTres
            // 
            this.buttonTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTres.Location = new System.Drawing.Point(158, 153);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(55, 55);
            this.buttonTres.TabIndex = 8;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = true;
            this.buttonTres.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeis.Location = new System.Drawing.Point(158, 214);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(55, 55);
            this.buttonSeis.TabIndex = 9;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = true;
            this.buttonSeis.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuatro.Location = new System.Drawing.Point(12, 214);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(55, 55);
            this.buttonQuatro.TabIndex = 10;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = true;
            this.buttonQuatro.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonSete
            // 
            this.buttonSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSete.Location = new System.Drawing.Point(12, 275);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(55, 55);
            this.buttonSete.TabIndex = 11;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = true;
            this.buttonSete.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOito.Location = new System.Drawing.Point(86, 275);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(55, 55);
            this.buttonOito.TabIndex = 12;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = true;
            this.buttonOito.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNove
            // 
            this.buttonNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNove.Location = new System.Drawing.Point(158, 275);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(55, 55);
            this.buttonNove.TabIndex = 13;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = true;
            this.buttonNove.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacao.Location = new System.Drawing.Point(232, 153);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(55, 55);
            this.buttonMultiplicacao.TabIndex = 14;
            this.buttonMultiplicacao.Text = "x";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplica_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivisao.Location = new System.Drawing.Point(158, 88);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(55, 55);
            this.buttonDivisao.TabIndex = 15;
            this.buttonDivisao.Text = "÷";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(86, 338);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(55, 55);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgula.Location = new System.Drawing.Point(158, 338);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(55, 55);
            this.buttonVirgula.TabIndex = 17;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = true;
            this.buttonVirgula.Click += new System.EventHandler(this.buttonVirgula_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(232, 88);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(55, 55);
            this.buttonApagar.TabIndex = 18;
            this.buttonApagar.Text = "⌫";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.Location = new System.Drawing.Point(232, 275);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(55, 55);
            this.buttonMenos.TabIndex = 19;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // buttonMais
            // 
            this.buttonMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMais.Location = new System.Drawing.Point(232, 214);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(55, 55);
            this.buttonMais.TabIndex = 20;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = true;
            this.buttonMais.Click += new System.EventHandler(this.buttonAdicao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 401);
            this.Controls.Add(this.buttonMais);
            this.Controls.Add(this.buttonMenos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonVirgula);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonNove);
            this.Controls.Add(this.buttonOito);
            this.Controls.Add(this.buttonSete);
            this.Controls.Add(this.buttonQuatro);
            this.Controls.Add(this.buttonSeis);
            this.Controls.Add(this.buttonTres);
            this.Controls.Add(this.buttonDois);
            this.Controls.Add(this.buttonUm);
            this.Controls.Add(this.buttonCinco);
            this.Controls.Add(this.buttonPorcentagem);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.Text = "EEE_OMAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonPorcentagem;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonQuatro;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonMais;
    }
}

