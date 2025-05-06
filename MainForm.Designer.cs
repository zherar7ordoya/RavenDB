namespace CuervoBD
{
    partial class MainForm
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
            dgvPersonas = new DataGridView();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            txtId = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnActualizarLista = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(12, 13);
            dgvPersonas.Margin = new Padding(3, 4, 3, 4);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(656, 202);
            dgvPersonas.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(674, 83);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(674, 48);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(228, 27);
            txtDni.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(674, 13);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(228, 27);
            txtId.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(674, 188);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(228, 27);
            txtEdad.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(674, 118);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(228, 27);
            txtApellido.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(674, 153);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.Location = new Point(12, 222);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(120, 30);
            btnActualizarLista.TabIndex = 8;
            btnActualizarLista.Text = "Actualizar Lista";
            btnActualizarLista.UseVisualStyleBackColor = true;
            btnActualizarLista.Click += btnActualizarLista_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(530, 222);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 30);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(656, 222);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 30);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(782, 222);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 30);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 266);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizarLista);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtEdad);
            Controls.Add(txtId);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(dgvPersonas);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtId;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnActualizarLista;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
