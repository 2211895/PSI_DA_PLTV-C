namespace ProjetoDA
{
    partial class FormPrincipal
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
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonRestaurantes = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.lbRestaurantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(139, 63);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(189, 131);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            // 
            // buttonRestaurantes
            // 
            this.buttonRestaurantes.Location = new System.Drawing.Point(139, 256);
            this.buttonRestaurantes.Name = "buttonRestaurantes";
            this.buttonRestaurantes.Size = new System.Drawing.Size(189, 131);
            this.buttonRestaurantes.TabIndex = 1;
            this.buttonRestaurantes.Text = "Restaurantes";
            this.buttonRestaurantes.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(970, 63);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(189, 131);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu Restuarantes";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(970, 256);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(189, 131);
            this.buttonPedidos.TabIndex = 3;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            // 
            // lbRestaurantes
            // 
            this.lbRestaurantes.FormattingEnabled = true;
            this.lbRestaurantes.ItemHeight = 25;
            this.lbRestaurantes.Location = new System.Drawing.Point(468, 63);
            this.lbRestaurantes.Name = "lbRestaurantes";
            this.lbRestaurantes.Size = new System.Drawing.Size(374, 554);
            this.lbRestaurantes.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.lbRestaurantes);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonRestaurantes);
            this.Controls.Add(this.buttonClientes);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonRestaurantes;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.ListBox lbRestaurantes;
    }
}

