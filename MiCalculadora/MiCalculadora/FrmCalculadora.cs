namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacionCerrar = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacionCerrar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacionCerrar = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacionCerrar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOperacion_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblPrimerOperador_Click(object sender, EventArgs e)
        {
        }

        private void lblSegundoOperador_Click(object sender, EventArgs e)
        {
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
        }
    }
}