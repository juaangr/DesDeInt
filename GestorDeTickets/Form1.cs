using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestorDeTickets
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable tablaTickets;
        private string rutaFichero = "tickets.csv";

        public VentanaPrincipal()
        {
            InitializeComponent();
            InicializarTabla();
            CargarTicketsDesdeFichero();
        }

        private void InicializarTabla()
        {
            tablaTickets = new DataTable();
            tablaTickets.Columns.Add("TicketID", typeof(int));
            tablaTickets.Columns.Add("Descripcion", typeof(string));
            tablaTickets.Columns.Add("UsuarioID", typeof(int));
            tablaTickets.Columns.Add("Estado", typeof(string));
            tablaTickets.Columns.Add("FechaCreacion", typeof(DateTime));
        }

        private void CargarTicketsDesdeFichero()
        {
            if (File.Exists(rutaFichero))
            {
                var lineas = File.ReadAllLines(rutaFichero);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(",");
                    tablaTickets.Rows.Add(Convert.ToInt32(datos[0]), datos[1], Convert.ToInt32(datos[2]), datos[3], DateTime.Parse(datos[4]));
                }
            }

            tablaTicketsDataGridView.DataSource = tablaTickets;
        }

        private void GuardarTicketsEnFichero()
        {
            var lineas = new string[tablaTickets.Rows.Count];
            for (int i = 0; i < tablaTickets.Rows.Count; i++)
            {
                var fila = tablaTickets.Rows[i];
                lineas[i] = string.Join(",", fila.ItemArray);
            }
            File.WriteAllLines(rutaFichero, lineas);
        }

        private void AgregarTicket(string descripcion, int usuarioId, string estado)
        {
            int nuevoId = tablaTickets.Rows.Count > 0 ? (int)tablaTickets.Compute("MAX(TicketID)", string.Empty) + 1 : 1;
            tablaTickets.Rows.Add(nuevoId, descripcion, usuarioId, estado, DateTime.Now);
            GuardarTicketsEnFichero();
            tablaTicketsDataGridView.DataSource = tablaTickets;
        }

        private void ModificarAsignacionUsuario(int ticketId, int nuevoUsuarioId)
        {
            foreach (DataRow fila in tablaTickets.Rows)
            {
                if ((int)fila["TicketID"] == ticketId)
                {
                    fila["UsuarioID"] = nuevoUsuarioId;
                    break;
                }
            }
            GuardarTicketsEnFichero();
            tablaTicketsDataGridView.DataSource = tablaTickets;
        }

        private void MostrarInformacionTickets()
        {
            var tablaResumen = tablaTickets.Clone();
            foreach (DataRow fila in tablaTickets.Select("Estado = 'Resuelto' OR Estado = 'Pendiente'"))
            {
                tablaResumen.ImportRow(fila);
            }

            resumenTicketsDataGridView.DataSource = tablaResumen;
        }

        private void ExportarBaseDatos()
        {
            SaveFileDialog guardarDialogo = new SaveFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                Title = "Exportar Tickets"
            };

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(rutaFichero, guardarDialogo.FileName, overwrite: true);
                    MessageBox.Show("Tickets exportados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar los tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportarBaseDatos()
        {
            OpenFileDialog abrirDialogo = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                Title = "Importar Tickets"
            };

            if (abrirDialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(abrirDialogo.FileName, rutaFichero, overwrite: true);
                    MessageBox.Show("Tickets importados con éxito. Recargando datos...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTicketsDesdeFichero();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al importar los tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BotonExportar_Click(object sender, EventArgs e)
        {
            ExportarBaseDatos();
        }

        private void BotonImportar_Click(object sender, EventArgs e)
        {
            ImportarBaseDatos();
        }

        private void BotonModificarAsignacion_Click(object sender, EventArgs e)
        {
            int ticketId = Convert.ToInt32(inputTicketID.Text); // Suponiendo un TextBox para ingresar el ID del ticket
            int nuevoUsuarioId = Convert.ToInt32(inputNuevoUsuarioID.Text); // Suponiendo un TextBox para ingresar el nuevo ID de usuario
            ModificarAsignacionUsuario(ticketId, nuevoUsuarioId);
        }

        private void BotonMostrarResumen_Click(object sender, EventArgs e)
        {
            MostrarInformacionTickets();
        }
    }
}


