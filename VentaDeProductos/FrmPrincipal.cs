namespace VentaDeProductos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.ShowDialog();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            var frm = new FrmPersonal();
            frm.ShowDialog();
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            var frm = new FrmInventario();
            frm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            var frm = new FrmExistencias();
            frm.ShowDialog();
        }
    }
}