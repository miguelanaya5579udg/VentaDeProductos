using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Data;
using VentaDeProductos.Models;

namespace VentaDeProductos
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();

            this.Load += FrmPersonal_Load;
            dgvPersonal.SelectionChanged += dgvPersonal_SelectionChanged;

            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Click += btnEliminar_Click;

            btnPrimero.Click += btnPrimero_Click;
            btnAnterior.Click += btnAnterior_Click;
            btnSiguiente.Click += btnSiguiente_Click;
            btnUltimo.Click += btnUltimo_Click;
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            CargarPersonal();
        }

        private void CargarPersonal()
        {
            using var db = new VentaProductosContext();

            var personal = db.Catpersonals
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Cargo
                })
                .ToList();

            dgvPersonal.DataSource = personal;

            dgvPersonal.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPersonal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow == null)
                return;

            txtId.Text =
                dgvPersonal.CurrentRow.Cells["Id"].Value?.ToString();

            txtNombre.Text =
                dgvPersonal.CurrentRow.Cells["Nombre"].Value?.ToString();

            txtCargo.Text =
                dgvPersonal.CurrentRow.Cells["Cargo"].Value?.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCargo.Clear();

            dgvPersonal.ClearSelection();

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cargo = txtCargo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "El nombre es obligatorio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show(
                    "El cargo es obligatorio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCargo.Focus();
                return;
            }

            if (nombre.Length > 80)
            {
                MessageBox.Show(
                    "El nombre no puede tener más de 80 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cargo.Length > 80)
            {
                MessageBox.Show(
                    "El cargo no puede tener más de 80 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using var db = new VentaProductosContext();

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    var persona = new Catpersonal
                    {
                        Nombre = nombre,
                        Cargo = cargo
                    };

                    db.Catpersonals.Add(persona);
                    db.SaveChanges();

                    MessageBox.Show(
                        "Personal guardado correctamente.",
                        "Guardado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    int id = int.Parse(txtId.Text);

                    var persona = db.Catpersonals
                        .FirstOrDefault(p => p.Id == id);

                    if (persona == null)
                    {
                        MessageBox.Show(
                            "No se encontró el registro.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    persona.Nombre = nombre;
                    persona.Cargo = cargo;

                    db.SaveChanges();

                    MessageBox.Show(
                        "Personal actualizado correctamente.",
                        "Actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                CargarPersonal();

                txtId.Clear();
                txtNombre.Clear();
                txtCargo.Clear();

                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show(
                    "Selecciona un registro para eliminar.",
                    "Eliminar personal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = int.Parse(txtId.Text);

            var confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                using var db = new VentaProductosContext();

                var persona = db.Catpersonals
                    .FirstOrDefault(p => p.Id == id);

                if (persona == null)
                {
                    MessageBox.Show(
                        "El registro ya no existe.",
                        "Eliminar personal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    CargarPersonal();
                    return;
                }

                bool tieneMovimientos = db.Tblinventarios
                    .Any(i => i.Idpersonal == id);

                if (tieneMovimientos)
                {
                    MessageBox.Show(
                        "No se puede eliminar esta persona porque tiene movimientos de inventario asociados.",
                        "Registro en uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                db.Catpersonals.Remove(persona);
                db.SaveChanges();

                MessageBox.Show(
                    "Registro eliminado correctamente.",
                    "Eliminar personal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPersonal();

                txtId.Clear();
                txtNombre.Clear();
                txtCargo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al eliminar:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.Rows.Count == 0)
                return;

            SeleccionarFila(0);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.Rows.Count == 0)
                return;

            int filaActual = dgvPersonal.CurrentRow?.Index ?? 0;

            if (filaActual > 0)
                SeleccionarFila(filaActual - 1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.Rows.Count == 0)
                return;

            int filaActual = dgvPersonal.CurrentRow?.Index ?? 0;

            if (filaActual < dgvPersonal.Rows.Count - 1)
                SeleccionarFila(filaActual + 1);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.Rows.Count == 0)
                return;

            SeleccionarFila(dgvPersonal.Rows.Count - 1);
        }

        private void SeleccionarFila(int indice)
        {
            dgvPersonal.ClearSelection();

            dgvPersonal.Rows[indice].Selected = true;

            dgvPersonal.CurrentCell =
                dgvPersonal.Rows[indice].Cells["Id"];

            dgvPersonal.FirstDisplayedScrollingRowIndex = indice;
        }
    }
}
