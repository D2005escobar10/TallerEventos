namespace TallerDeEventos
{
    partial class ControlTareas
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
            TxtIngresarTarea = new TextBox();
            BtnAgregarTareas = new Button();
            PnlTareasPorRealizar = new FlowLayoutPanel();
            BtnEliminarTarea = new Button();
            PnlTareasEnProceso = new FlowLayoutPanel();
            PnlTareasTerminadas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // TxtIngresarTarea
            // 
            TxtIngresarTarea.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIngresarTarea.Location = new Point(179, 66);
            TxtIngresarTarea.Name = "TxtIngresarTarea";
            TxtIngresarTarea.PlaceholderText = "Ingresar Tareas";
            TxtIngresarTarea.Size = new Size(160, 26);
            TxtIngresarTarea.TabIndex = 0;
            TxtIngresarTarea.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnAgregarTareas
            // 
            BtnAgregarTareas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarTareas.Location = new Point(377, 63);
            BtnAgregarTareas.Name = "BtnAgregarTareas";
            BtnAgregarTareas.Size = new Size(104, 29);
            BtnAgregarTareas.TabIndex = 1;
            BtnAgregarTareas.Text = "Agregar +";
            BtnAgregarTareas.UseVisualStyleBackColor = true;
            BtnAgregarTareas.Click += BtnAgregarTareas_Click;
            // 
            // PnlTareasPorRealizar
            // 
            PnlTareasPorRealizar.FlowDirection = FlowDirection.TopDown;
            PnlTareasPorRealizar.Location = new Point(179, 149);
            PnlTareasPorRealizar.Name = "PnlTareasPorRealizar";
            PnlTareasPorRealizar.Size = new Size(131, 272);
            PnlTareasPorRealizar.TabIndex = 2;
            // 
            // BtnEliminarTarea
            // 
            BtnEliminarTarea.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminarTarea.Location = new Point(512, 65);
            BtnEliminarTarea.Name = "BtnEliminarTarea";
            BtnEliminarTarea.Size = new Size(157, 26);
            BtnEliminarTarea.TabIndex = 3;
            BtnEliminarTarea.Text = "Eliminar Tarea";
            BtnEliminarTarea.UseVisualStyleBackColor = true;
            BtnEliminarTarea.Click += BtnEliminarTarea_Click;
            // 
            // PnlTareasEnProceso
            // 
            PnlTareasEnProceso.FlowDirection = FlowDirection.TopDown;
            PnlTareasEnProceso.Location = new Point(362, 149);
            PnlTareasEnProceso.Name = "PnlTareasEnProceso";
            PnlTareasEnProceso.Size = new Size(131, 272);
            PnlTareasEnProceso.TabIndex = 3;
            // 
            // PnlTareasTerminadas
            // 
            PnlTareasTerminadas.FlowDirection = FlowDirection.TopDown;
            PnlTareasTerminadas.Location = new Point(538, 149);
            PnlTareasTerminadas.Name = "PnlTareasTerminadas";
            PnlTareasTerminadas.Size = new Size(131, 272);
            PnlTareasTerminadas.TabIndex = 4;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlTareasTerminadas);
            Controls.Add(PnlTareasEnProceso);
            Controls.Add(BtnEliminarTarea);
            Controls.Add(PnlTareasPorRealizar);
            Controls.Add(BtnAgregarTareas);
            Controls.Add(TxtIngresarTarea);
            Name = "ControlTareas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIngresarTarea;
        private Button BtnAgregarTareas;
        private FlowLayoutPanel PnlTareasPorRealizar;
        private Button BtnEliminarTarea;
        private FlowLayoutPanel PnlTareasEnProceso;
        private FlowLayoutPanel PnlTareasTerminadas;
    }
}
