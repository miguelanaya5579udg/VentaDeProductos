using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Data;

namespace VentaDeProductos
{
    public partial class FrmExistencias : Form
    {
        public FrmExistencias()
        {
            InitializeComponent();

            this.Load += FrmExistencias_Load;
            btnActualizar.Click += btnActualizar_Click;
        }

        private void FrmExistencias_Load(object sender, EventArgs e)
        {
            CargarExistencias();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarExistencias();
        }

        private void CargarExistencias()
        {
            using var db = new VentaProductosContext();

            var existencias = db.Catproductos
                .AsNoTracking()
                .OrderBy(p => p.Descripcion)
                .Select(p => new
                {
                    p.Id,
                    Producto = p.Descripcion,

                    Entradas = p.Tblinventarios
                        .Where(i => i.TipoMovimiento == "ENTRADA")
                        .Sum(i => (int?)i.Cantidad) ?? 0,

                    Salidas = p.Tblinventarios
                        .Where(i => i.TipoMovimiento == "SALIDA")
                        .Sum(i => (int?)i.Cantidad) ?? 0,

                    Existencia =
                        (p.Tblinventarios
                            .Where(i => i.TipoMovimiento == "ENTRADA")
                            .Sum(i => (int?)i.Cantidad) ?? 0)
                        -
                        (p.Tblinventarios
                            .Where(i => i.TipoMovimiento == "SALIDA")
                            .Sum(i => (int?)i.Cantidad) ?? 0)
                })
                .ToList();

            dgvExistencias.DataSource = existencias;
        }
    }
}