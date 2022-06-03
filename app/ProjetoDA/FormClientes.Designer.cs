namespace ProjetoDA
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNomePRegistar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbRuaPRegistar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCidadePRegistar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodPostalPRegistar = new System.Windows.Forms.TextBox();
            this.tbPaisPRegistar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelemovelRegistar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.rbtTrabalhador = new System.Windows.Forms.RadioButton();
            this.tbSalarioRegistar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumContriRegistar = new System.Windows.Forms.TextBox();
            this.tbPosicaoRegistar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btCriarPessoa = new System.Windows.Forms.Button();
            this.lbPessoas = new System.Windows.Forms.ListBox();
            this.btApagarPessoa = new System.Windows.Forms.Button();
            this.btAlterarPessoa = new System.Windows.Forms.Button();
            this.tbTelemovelAlterar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPosicaoAlterar = new System.Windows.Forms.TextBox();
            this.tbCodPostalPAlterar = new System.Windows.Forms.TextBox();
            this.tbCidadeAlterar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNumContriAlterar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSalarioAlterar = new System.Windows.Forms.TextBox();
            this.tbRuaPAlterar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPaisPAlterar = new System.Windows.Forms.TextBox();
            this.tbNomePAlterar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelemovelRegistar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btCriarPessoa);
            this.groupBox1.Controls.Add(this.tbPosicaoRegistar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbNumContriRegistar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSalarioRegistar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbtTrabalhador);
            this.groupBox1.Controls.Add(this.rbtCliente);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbNomePRegistar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 625);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTelemovelAlterar);
            this.groupBox2.Controls.Add(this.btAlterarPessoa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.tbPosicaoAlterar);
            this.groupBox2.Controls.Add(this.tbNomePAlterar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbNumContriAlterar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbSalarioAlterar);
            this.groupBox2.Location = new System.Drawing.Point(829, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 625);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar";
            // 
            // tbNomePRegistar
            // 
            this.tbNomePRegistar.Location = new System.Drawing.Point(80, 34);
            this.tbNomePRegistar.Name = "tbNomePRegistar";
            this.tbNomePRegistar.Size = new System.Drawing.Size(314, 31);
            this.tbNomePRegistar.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPaisPRegistar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbCodPostalPRegistar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbCidadePRegistar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbRuaPRegistar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 175);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Morada";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbRuaPRegistar
            // 
            this.tbRuaPRegistar.Location = new System.Drawing.Point(86, 24);
            this.tbRuaPRegistar.Name = "tbRuaPRegistar";
            this.tbRuaPRegistar.Size = new System.Drawing.Size(302, 31);
            this.tbRuaPRegistar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua:";
            // 
            // tbCidadePRegistar
            // 
            this.tbCidadePRegistar.Location = new System.Drawing.Point(86, 61);
            this.tbCidadePRegistar.Name = "tbCidadePRegistar";
            this.tbCidadePRegistar.Size = new System.Drawing.Size(302, 31);
            this.tbCidadePRegistar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo Postal:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbCodPostalPRegistar
            // 
            this.tbCodPostalPRegistar.Location = new System.Drawing.Point(158, 98);
            this.tbCodPostalPRegistar.Name = "tbCodPostalPRegistar";
            this.tbCodPostalPRegistar.Size = new System.Drawing.Size(230, 31);
            this.tbCodPostalPRegistar.TabIndex = 9;
            // 
            // tbPaisPRegistar
            // 
            this.tbPaisPRegistar.Location = new System.Drawing.Point(86, 135);
            this.tbPaisPRegistar.Name = "tbPaisPRegistar";
            this.tbPaisPRegistar.Size = new System.Drawing.Size(302, 31);
            this.tbPaisPRegistar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pais:";
            // 
            // tbTelemovelRegistar
            // 
            this.tbTelemovelRegistar.Location = new System.Drawing.Point(129, 263);
            this.tbTelemovelRegistar.Name = "tbTelemovelRegistar";
            this.tbTelemovelRegistar.Size = new System.Drawing.Size(265, 31);
            this.tbTelemovelRegistar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telemovel:";
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Location = new System.Drawing.Point(221, 306);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(110, 29);
            this.rbtCliente.TabIndex = 3;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Cliente\r\n";
            this.rbtCliente.UseVisualStyleBackColor = true;
            // 
            // rbtTrabalhador
            // 
            this.rbtTrabalhador.AutoSize = true;
            this.rbtTrabalhador.Location = new System.Drawing.Point(37, 306);
            this.rbtTrabalhador.Name = "rbtTrabalhador";
            this.rbtTrabalhador.Size = new System.Drawing.Size(159, 29);
            this.rbtTrabalhador.TabIndex = 4;
            this.rbtTrabalhador.TabStop = true;
            this.rbtTrabalhador.Text = "Trabalhador";
            this.rbtTrabalhador.UseVisualStyleBackColor = true;
            // 
            // tbSalarioRegistar
            // 
            this.tbSalarioRegistar.Location = new System.Drawing.Point(92, 338);
            this.tbSalarioRegistar.Name = "tbSalarioRegistar";
            this.tbSalarioRegistar.Size = new System.Drawing.Size(104, 31);
            this.tbSalarioRegistar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Num. Contribuinte:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbNumContriRegistar
            // 
            this.tbNumContriRegistar.Location = new System.Drawing.Point(221, 372);
            this.tbNumContriRegistar.Name = "tbNumContriRegistar";
            this.tbNumContriRegistar.Size = new System.Drawing.Size(173, 31);
            this.tbNumContriRegistar.TabIndex = 17;
            // 
            // tbPosicaoRegistar
            // 
            this.tbPosicaoRegistar.Location = new System.Drawing.Point(101, 418);
            this.tbPosicaoRegistar.Name = "tbPosicaoRegistar";
            this.tbPosicaoRegistar.Size = new System.Drawing.Size(293, 31);
            this.tbPosicaoRegistar.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Posicao:";
            // 
            // btCriarPessoa
            // 
            this.btCriarPessoa.Location = new System.Drawing.Point(129, 475);
            this.btCriarPessoa.Name = "btCriarPessoa";
            this.btCriarPessoa.Size = new System.Drawing.Size(148, 46);
            this.btCriarPessoa.TabIndex = 20;
            this.btCriarPessoa.Text = "Criar";
            this.btCriarPessoa.UseVisualStyleBackColor = true;
            // 
            // lbPessoas
            // 
            this.lbPessoas.FormattingEnabled = true;
            this.lbPessoas.ItemHeight = 25;
            this.lbPessoas.Location = new System.Drawing.Point(446, 29);
            this.lbPessoas.Name = "lbPessoas";
            this.lbPessoas.Size = new System.Drawing.Size(368, 429);
            this.lbPessoas.TabIndex = 21;
            // 
            // btApagarPessoa
            // 
            this.btApagarPessoa.Location = new System.Drawing.Point(537, 487);
            this.btApagarPessoa.Name = "btApagarPessoa";
            this.btApagarPessoa.Size = new System.Drawing.Size(148, 46);
            this.btApagarPessoa.TabIndex = 21;
            this.btApagarPessoa.Text = "Apagar";
            this.btApagarPessoa.UseVisualStyleBackColor = true;
            // 
            // btAlterarPessoa
            // 
            this.btAlterarPessoa.Location = new System.Drawing.Point(129, 475);
            this.btAlterarPessoa.Name = "btAlterarPessoa";
            this.btAlterarPessoa.Size = new System.Drawing.Size(148, 46);
            this.btAlterarPessoa.TabIndex = 30;
            this.btAlterarPessoa.Text = "Alterar";
            this.btAlterarPessoa.UseVisualStyleBackColor = true;
            // 
            // tbTelemovelAlterar
            // 
            this.tbTelemovelAlterar.Location = new System.Drawing.Point(129, 266);
            this.tbTelemovelAlterar.Name = "tbTelemovelAlterar";
            this.tbTelemovelAlterar.Size = new System.Drawing.Size(265, 31);
            this.tbTelemovelAlterar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo Postal:";
            // 
            // tbPosicaoAlterar
            // 
            this.tbPosicaoAlterar.Location = new System.Drawing.Point(101, 418);
            this.tbPosicaoAlterar.Name = "tbPosicaoAlterar";
            this.tbPosicaoAlterar.Size = new System.Drawing.Size(293, 31);
            this.tbPosicaoAlterar.TabIndex = 29;
            // 
            // tbCodPostalPAlterar
            // 
            this.tbCodPostalPAlterar.Location = new System.Drawing.Point(158, 98);
            this.tbCodPostalPAlterar.Name = "tbCodPostalPAlterar";
            this.tbCodPostalPAlterar.Size = new System.Drawing.Size(230, 31);
            this.tbCodPostalPAlterar.TabIndex = 9;
            // 
            // tbCidadeAlterar
            // 
            this.tbCidadeAlterar.Location = new System.Drawing.Point(86, 61);
            this.tbCidadeAlterar.Name = "tbCidadeAlterar";
            this.tbCidadeAlterar.Size = new System.Drawing.Size(302, 31);
            this.tbCidadeAlterar.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Posicao:";
            // 
            // tbNumContriAlterar
            // 
            this.tbNumContriAlterar.Location = new System.Drawing.Point(221, 372);
            this.tbNumContriAlterar.Name = "tbNumContriAlterar";
            this.tbNumContriAlterar.Size = new System.Drawing.Size(173, 31);
            this.tbNumContriAlterar.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Num. Contribuinte:";
            // 
            // tbSalarioAlterar
            // 
            this.tbSalarioAlterar.Location = new System.Drawing.Point(92, 338);
            this.tbSalarioAlterar.Name = "tbSalarioAlterar";
            this.tbSalarioAlterar.Size = new System.Drawing.Size(104, 31);
            this.tbSalarioAlterar.TabIndex = 25;
            // 
            // tbRuaPAlterar
            // 
            this.tbRuaPAlterar.Location = new System.Drawing.Point(86, 24);
            this.tbRuaPAlterar.Name = "tbRuaPAlterar";
            this.tbRuaPAlterar.Size = new System.Drawing.Size(302, 31);
            this.tbRuaPAlterar.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Pais:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Rua:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "Salario:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "Telemovel:";
            // 
            // tbPaisPAlterar
            // 
            this.tbPaisPAlterar.Location = new System.Drawing.Point(86, 135);
            this.tbPaisPAlterar.Name = "tbPaisPAlterar";
            this.tbPaisPAlterar.Size = new System.Drawing.Size(302, 31);
            this.tbPaisPAlterar.TabIndex = 11;
            // 
            // tbNomePAlterar
            // 
            this.tbNomePAlterar.Location = new System.Drawing.Point(80, 34);
            this.tbNomePAlterar.Name = "tbNomePAlterar";
            this.tbNomePAlterar.Size = new System.Drawing.Size(314, 31);
            this.tbNomePAlterar.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "Cidade:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPaisPAlterar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbCodPostalPAlterar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbCidadeAlterar);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tbRuaPAlterar);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 175);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Morada";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.btApagarPessoa);
            this.Controls.Add(this.lbPessoas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClientes";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNomePRegistar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCidadePRegistar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRuaPRegistar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelemovelRegistar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPaisPRegistar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodPostalPRegistar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSalarioRegistar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtTrabalhador;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.Button btCriarPessoa;
        private System.Windows.Forms.TextBox tbPosicaoRegistar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNumContriRegistar;
        private System.Windows.Forms.Button btAlterarPessoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbTelemovelAlterar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPaisPAlterar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCodPostalPAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCidadeAlterar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRuaPAlterar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPosicaoAlterar;
        private System.Windows.Forms.TextBox tbNomePAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNumContriAlterar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSalarioAlterar;
        private System.Windows.Forms.ListBox lbPessoas;
        private System.Windows.Forms.Button btApagarPessoa;
    }
}