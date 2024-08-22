using System.Drawing.Text;
using TallerDeEventos.Clases;

namespace TallerDeEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> Tareas = new List<Tarea>();

        public ControlTareas()
        {
            InitializeComponent();
        }

        private void BtnAgregarTareas_Click(object sender, EventArgs e)
        {
            if (TxtIngresarTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe un nombre para la tarea");
                return;
            }

            Tarea nuevatarea = new Tarea(TxtIngresarTarea.Text, "Pendiente");

            Tareas.Add(nuevatarea);

            Label etiquetaTarea = new Label();
            etiquetaTarea.Text = nuevatarea.nombre;
            etiquetaTarea.AutoSize = true;
            etiquetaTarea.MinimumSize = new Size(100, 30); 
            etiquetaTarea.MaximumSize = new Size(300, 30); 
            etiquetaTarea.BackColor = Color.Black; 
            etiquetaTarea.ForeColor = Color.White;
            etiquetaTarea.Padding = new Padding(5); 
            etiquetaTarea.BorderStyle = BorderStyle.FixedSingle; 

            etiquetaTarea.Size = new Size(etiquetaTarea.PreferredWidth + 10, etiquetaTarea.Height);

            PnlTareasPorRealizar.Controls.Add(etiquetaTarea);

            TxtIngresarTarea.Clear();

        }

        private void BtnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (PnlTareasPorRealizar.Controls.Count > 0) 
            { 
                PnlTareasPorRealizar.Controls.RemoveAt(PnlTareasPorRealizar.Controls.Count - 1);
            }
        }
    }
}
        


