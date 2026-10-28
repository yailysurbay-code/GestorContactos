namespace GestorContactos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTNombre = new System.Windows.Forms.Label();
            this.lblTCorreo = new System.Windows.Forms.Label();
            this.lblTTelefono = new System.Windows.Forms.Label();
            this.lblTBuscar = new System.Windows.Forms.Label();
            this.lblTDetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();

            // Etiquetas de rótulo
            this.lblTNombre.AutoSize = true; this.lblTNombre.Location = new System.Drawing.Point(12, 15); this.lblTNombre.Text = "Nombre:";
            this.lblTCorreo.AutoSize = true; this.lblTCorreo.Location = new System.Drawing.Point(12, 45); this.lblTCorreo.Text = "Correo:";
            this.lblTTelefono.AutoSize = true; this.lblTTelefono.Location = new System.Drawing.Point(12, 75); this.lblTTelefono.Text = "Teléfono:";
            this.lblTBuscar.AutoSize = true; this.lblTBuscar.Location = new System.Drawing.Point(12, 125); this.lblTBuscar.Text = "Buscar:";

            // Entradas
            this.txtNombre.Name = "txtNombre"; this.txtNombre.Location = new System.Drawing.Point(90, 12); this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtCorreo.Name = "txtCorreo"; this.txtCorreo.Location = new System.Drawing.Point(90, 42); this.txtCorreo.Size = new System.Drawing.Size(250, 23);
            this.txtTelefono.Name = "txtTelefono"; this.txtTelefono.Location = new System.Drawing.Point(90, 72); this.txtTelefono.Size = new System.Drawing.Size(250, 23);

            this.btnAgregar.Name = "btnAgregar"; this.btnAgregar.Location = new System.Drawing.Point(360, 12);
            this.btnAgregar.Size = new System.Drawing.Size(110, 83); this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // Búsqueda
            this.txtBuscar.Name = "txtBuscar"; this.txtBuscar.Location = new System.Drawing.Point(90, 122); this.txtBuscar.Size = new System.Drawing.Size(250, 23);
            this.btnBuscar.Name = "btnBuscar"; this.btnBuscar.Location = new System.Drawing.Point(360, 121);
            this.btnBuscar.Size = new System.Drawing.Size(110, 25); this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnMostrarTodos.Name = "btnMostrarTodos"; this.btnMostrarTodos.Location = new System.Drawing.Point(480, 121);
            this.btnMostrarTodos.Size = new System.Drawing.Size(110, 25); this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);

            // Tabla
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Location = new System.Drawing.Point(12, 160);
            this.dgvContactos.Size = new System.Drawing.Size(578, 200);
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Detalles
            this.lblTDetalle.AutoSize = true; this.lblTDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTDetalle.Location = new System.Drawing.Point(12, 372); this.lblTDetalle.Text = "Detalle del contacto seleccionado";
            this.lblNombre.Name = "lblNombre"; this.lblNombre.AutoSize = true; this.lblNombre.Location = new System.Drawing.Point(12, 395);
            this.lblCorreo.Name = "lblCorreo"; this.lblCorreo.AutoSize = true; this.lblCorreo.Location = new System.Drawing.Point(12, 418);
            this.lblTelefono.Name = "lblTelefono"; this.lblTelefono.AutoSize = true; this.lblTelefono.Location = new System.Drawing.Point(12, 441);

            // Estado
            this.lblEstado.Name = "lblEstado"; this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEstado.Location = new System.Drawing.Point(12, 475);

            // Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 505);
            this.Controls.Add(this.lblTNombre); this.Controls.Add(this.lblTCorreo);
            this.Controls.Add(this.lblTTelefono); this.Controls.Add(this.lblTBuscar);
            this.Controls.Add(this.txtNombre); this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono); this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar); this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrarTodos); this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.lblTDetalle); this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCorreo); this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTNombre;
        private System.Windows.Forms.Label lblTCorreo;
        private System.Windows.Forms.Label lblTTelefono;
        private System.Windows.Forms.Label lblTBuscar;
        private System.Windows.Forms.Label lblTDetalle;
    }
}