using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Data;
using VentaDeProductos.Models;

namespace VentaDeProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            using var db = new VentaProductosContext();

            var productos = db.Catproductos
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .Select(p => new
                {
                    p.Id,
                    p.Descripcion
                })
                .ToList();

            dgvProductos.DataSource = productos;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == null)
                return;

            txtId.Text =
                dgvProductos.CurrentRow.Cells["Id"].Value?.ToString();

            txtDescripcion.Text =
                dgvProductos.CurrentRow.Cells["Descripcion"].Value?.ToString();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtDescripcion.Clear();
            txtDescripcion.Focus();

            dgvProductos.ClearSelection();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show(
                    "La descripción es obligatoria.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDescripcion.Focus();
                return;
            }

            if (descripcion.Length > 40)
            {
                MessageBox.Show(
                    "La descripción no puede tener más de 40 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDescripcion.Focus();
                return;
            }

            try
            {
                using var db = new VentaProductosContext();

                // NUEVO REGISTRO
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    bool existe = db.Catproductos
                        .Any(p => p.Descripcion == descripcion);

                    if (existe)
                    {
                        MessageBox.Show(
                            "Ya existe un producto con esa descripción.",
                            "Producto duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    var producto = new Catproducto
                    {
                        Descripcion = descripcion
                    };

                    db.Catproductos.Add(producto);
                    db.SaveChanges();

                    MessageBox.Show(
                        "Producto guardado correctamente.",
                        "Guardado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                // EDITAR REGISTRO EXISTENTE
                else
                {
                    int id = int.Parse(txtId.Text);

                    var producto = db.Catproductos
                        .FirstOrDefault(p => p.Id == id);

                    if (producto == null)
                    {
                        MessageBox.Show(
                            "No se encontró el producto.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    bool existeOtro = db.Catproductos
                        .Any(p => p.Descripcion == descripcion && p.Id != id);

                    if (existeOtro)
                    {
                        MessageBox.Show(
                            "Ya existe otro producto con esa descripción.",
                            "Producto duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    producto.Descripcion = descripcion;

                    db.SaveChanges();

                    MessageBox.Show(
                        "Producto actualizado correctamente.",
                        "Actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                CargarProductos();

                txtId.Clear();
                txtDescripcion.Clear();
                txtDescripcion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar el producto:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show(
                    "Selecciona un producto para eliminar.",
                    "Eliminar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int id = int.Parse(txtId.Text);

            var confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                using var db = new VentaProductosContext();

                var producto = db.Catproductos
                    .FirstOrDefault(p => p.Id == id);

                if (producto == null)
                {
                    MessageBox.Show(
                        "El producto ya no existe.",
                        "Eliminar producto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    CargarProductos();
                    return;
                }

                bool tieneMovimientos = db.Tblinventarios
                    .Any(i => i.Idproducto == id);

                if (tieneMovimientos)
                {
                    MessageBox.Show(
                        "No se puede eliminar el producto porque tiene movimientos de inventario asociados.",
                        "Producto en uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                db.Catproductos.Remove(producto);
                db.SaveChanges();

                MessageBox.Show(
                    "Producto eliminado correctamente.",
                    "Eliminar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarProductos();

                txtId.Clear();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al eliminar el producto:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SeleccionarFila(int indice)
        {
            dgvProductos.ClearSelection();

            dgvProductos.Rows[indice].Selected = true;

            dgvProductos.CurrentCell =
                dgvProductos.Rows[indice].Cells["Id"];

            dgvProductos.FirstDisplayedScrollingRowIndex = indice;
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
                return;

            SeleccionarFila(0);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
                return;

            int filaActual = dgvProductos.CurrentRow?.Index ?? 0;

            if (filaActual > 0)
            {
                SeleccionarFila(filaActual - 1);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
                return;

            int filaActual = dgvProductos.CurrentRow?.Index ?? 0;

            if (filaActual < dgvProductos.Rows.Count - 1)
            {
                SeleccionarFila(filaActual + 1);
            }
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
                return;

            SeleccionarFila(dgvProductos.Rows.Count - 1);
        }
    }
}
