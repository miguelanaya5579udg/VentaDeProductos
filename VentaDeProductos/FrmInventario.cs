using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Data;
using VentaDeProductos.Models;

namespace VentaDeProductos
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();

            this.Load += FrmInventario_Load;
            btnRegistrar.Click += btnRegistrar_Click;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarPersonal();
            CargarTiposMovimiento();
            CargarMovimientos();
        }

        private void CargarProductos()
        {
            using var db = new VentaProductosContext();

            var productos = db.Catproductos
                .AsNoTracking()
                .OrderBy(p => p.Descripcion)
                .ToList();

            cboProducto.DataSource = productos;
            cboProducto.DisplayMember = "Descripcion";
            cboProducto.ValueMember = "Id";
        }

        private void CargarPersonal()
        {
            using var db = new VentaProductosContext();

            var personal = db.Catpersonals
                .AsNoTracking()
                .OrderBy(p => p.Nombre)
                .ToList();

            cboPersonal.DataSource = personal;
            cboPersonal.DisplayMember = "Nombre";
            cboPersonal.ValueMember = "Id";
        }

        private void CargarTiposMovimiento()
        {
            cboTipoMovimiento.Items.Clear();
            cboTipoMovimiento.Items.Add("ENTRADA");
            cboTipoMovimiento.Items.Add("SALIDA");

            cboTipoMovimiento.SelectedIndex = 0;
        }

        private void CargarMovimientos()
        {
            using var db = new VentaProductosContext();

            var movimientos = db.Tblinventarios
                .AsNoTracking()
                .OrderByDescending(i => i.FechaAlta)
                .Select(i => new
                {
                    i.Id,
                    Fecha = i.FechaAlta,
                    Producto = i.IdproductoNavigation.Descripcion,
                    Personal = i.IdpersonalNavigation.Nombre,
                    Movimiento = i.TipoMovimiento,
                    i.Cantidad
                })
                .ToList();

            dgvMovimientos.DataSource = movimientos;

            dgvMovimientos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedValue == null)
            {
                MessageBox.Show(
                    "Selecciona un producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboPersonal.SelectedValue == null)
            {
                MessageBox.Show(
                    "Selecciona una persona.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboTipoMovimiento.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona un tipo de movimiento.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idProducto = Convert.ToInt32(cboProducto.SelectedValue);
            int idPersonal = Convert.ToInt32(cboPersonal.SelectedValue);
            string tipoMovimiento = cboTipoMovimiento.SelectedItem.ToString()!;
            int cantidad = Convert.ToInt32(nudCantidad.Value);

            try
            {
                using var db = new VentaProductosContext();

                if (tipoMovimiento == "SALIDA")
                {
                    int existencia = ObtenerExistenciaProducto(db, idProducto);

                    if (cantidad > existencia)
                    {
                        MessageBox.Show(
                            $"No hay suficiente inventario.\n\nExistencia actual: {existencia}",
                            "Inventario insuficiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                var movimiento = new Tblinventario
                {
                    Idproducto = idProducto,
                    Idpersonal = idPersonal,
                    TipoMovimiento = tipoMovimiento,
                    Cantidad = cantidad
                };

                db.Tblinventarios.Add(movimiento);
                db.SaveChanges();

                MessageBox.Show(
                    "Movimiento registrado correctamente.",
                    "Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                nudCantidad.Value = 1;

                CargarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al registrar el movimiento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int ObtenerExistenciaProducto(
            VentaProductosContext db,
            int idProducto)
        {
            int entradas = db.Tblinventarios
                .Where(i =>
                    i.Idproducto == idProducto &&
                    i.TipoMovimiento == "ENTRADA")
                .Sum(i => (int?)i.Cantidad) ?? 0;

            int salidas = db.Tblinventarios
                .Where(i =>
                    i.Idproducto == idProducto &&
                    i.TipoMovimiento == "SALIDA")
                .Sum(i => (int?)i.Cantidad) ?? 0;

            return entradas - salidas;
        }
    }
}