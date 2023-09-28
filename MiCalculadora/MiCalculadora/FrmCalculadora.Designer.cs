namespace MiCalculadora
{
    partial class FrmCalculadora
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
            ComboBox cbxOperacion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            txtResultadoValor = new TextBox();
            grpSistemaResultado = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            txtPrimerOperador = new TextBox();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            cbxOperacion = new ComboBox();
            grpSistemaResultado.SuspendLayout();
            SuspendLayout();
            // 
            // cbxOperacion
            // 
            cbxOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cbxOperacion.FormattingEnabled = true;
            cbxOperacion.Items.AddRange(new object[] { "    +", "    -", "    *", "    /" });
            cbxOperacion.Location = new Point(575, 549);
            cbxOperacion.Name = "cbxOperacion";
            cbxOperacion.Size = new Size(138, 62);
            cbxOperacion.TabIndex = 5;
            cbxOperacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtResultadoValor
            // 
            txtResultadoValor.BackColor = SystemColors.MenuHighlight;
            txtResultadoValor.BorderStyle = BorderStyle.None;
            txtResultadoValor.Font = new Font("Cascadia Mono SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultadoValor.ForeColor = SystemColors.GradientActiveCaption;
            txtResultadoValor.Location = new Point(467, 75);
            txtResultadoValor.Multiline = true;
            txtResultadoValor.Name = "txtResultadoValor";
            txtResultadoValor.PlaceholderText = "000000";
            txtResultadoValor.Size = new Size(697, 109);
            txtResultadoValor.TabIndex = 2;
            txtResultadoValor.Text = "0123456789";
            txtResultadoValor.TextAlign = HorizontalAlignment.Right;
            // 
            // grpSistemaResultado
            // 
            grpSistemaResultado.Controls.Add(rdbBinario);
            grpSistemaResultado.Controls.Add(rdbDecimal);
            grpSistemaResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistemaResultado.ForeColor = SystemColors.WindowText;
            grpSistemaResultado.Location = new Point(399, 251);
            grpSistemaResultado.Name = "grpSistemaResultado";
            grpSistemaResultado.Size = new Size(500, 150);
            grpSistemaResultado.TabIndex = 3;
            grpSistemaResultado.TabStop = false;
            grpSistemaResultado.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(292, 75);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(113, 36);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(67, 75);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(125, 36);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.BackColor = SystemColors.ButtonFace;
            txtPrimerOperador.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerOperador.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerOperador.ForeColor = SystemColors.WindowText;
            txtPrimerOperador.Location = new Point(58, 549);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.PlaceholderText = "0";
            txtPrimerOperador.Size = new Size(344, 61);
            txtPrimerOperador.TabIndex = 4;
            txtPrimerOperador.TextAlign = HorizontalAlignment.Center;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(45, 76);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(380, 96);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(63, 475);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(339, 54);
            lblPrimerOperador.TabIndex = 7;
            lblPrimerOperador.Text = "Primer Operador:";
            lblPrimerOperador.Click += lblPrimerOperador_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(535, 475);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(220, 54);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operación:";
            lblOperacion.Click += lblOperacion_Click;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(869, 475);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(381, 54);
            lblSegundoOperador.TabIndex = 9;
            lblSegundoOperador.Text = "Segundo Operador:";
            lblSegundoOperador.Click += lblSegundoOperador_Click;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.BackColor = SystemColors.ButtonFace;
            txtSegundoOperador.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoOperador.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoOperador.ForeColor = SystemColors.WindowText;
            txtSegundoOperador.Location = new Point(882, 548);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.PlaceholderText = "0";
            txtSegundoOperador.Size = new Size(344, 61);
            txtSegundoOperador.TabIndex = 6;
            txtSegundoOperador.TextAlign = HorizontalAlignment.Center;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(45, 725);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(367, 76);
            btnOperar.TabIndex = 7;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(457, 725);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(367, 76);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(869, 725);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(367, 76);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1278, 844);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cbxOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(txtPrimerOperador);
            Controls.Add(grpSistemaResultado);
            Controls.Add(txtResultadoValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Candela Bogado";
            FormClosing += FrmCalculadora_FormClosing;
            grpSistemaResultado.ResumeLayout(false);
            grpSistemaResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnOperar;

        //calculadora: Operacion

        private ComboBox cbxOperacion;


        //components: IContainer

        private GroupBox grpSistemaResultado;
        private Label lblOperacion;
        private Label lblPrimerOperador;
        private Label lblResultado;
        private Label lblSegundoOperador;

        //primerOperando: Numeracion

        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;

        //resultado: Numeracion
        //segundoOperando: Numeracion

        //sistema: ESistema

        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;

        private TextBox txtResultadoValor; //-> SOBRA
    }
}