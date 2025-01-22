namespace WinFormsApp1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            LU = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnConfirmarR = new Button();
            btnBorrar = new Button();
            btnCrearNuevo = new Button();
            btnEditar = new Button();
            tbxId = new TextBox();
            tbxNota = new TextBox();
            tbxNom = new TextBox();
            tbxLu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, LU, Nota, Nombre });
            dataGridView1.Location = new Point(26, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 234);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // LU
            // 
            LU.HeaderText = "LU";
            LU.Name = "LU";
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(648, 325);
            button1.Name = "button1";
            button1.Size = new Size(134, 62);
            button1.TabIndex = 1;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConfirmarR
            // 
            btnConfirmarR.Location = new Point(648, 25);
            btnConfirmarR.Name = "btnConfirmarR";
            btnConfirmarR.Size = new Size(140, 61);
            btnConfirmarR.TabIndex = 2;
            btnConfirmarR.Text = "Confirmar Registro";
            btnConfirmarR.UseVisualStyleBackColor = true;
            btnConfirmarR.Click += btnConfirmarR_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(648, 111);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(140, 61);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCrearNuevo
            // 
            btnCrearNuevo.Location = new Point(648, 237);
            btnCrearNuevo.Name = "btnCrearNuevo";
            btnCrearNuevo.Size = new Size(140, 61);
            btnCrearNuevo.TabIndex = 4;
            btnCrearNuevo.Text = "Crear Nuevo";
            btnCrearNuevo.UseVisualStyleBackColor = true;
            btnCrearNuevo.Click += btnCrearNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(648, 413);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 61);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(196, 45);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(56, 23);
            tbxId.TabIndex = 6;
            tbxId.Text = "Id";
            // 
            // tbxNota
            // 
            tbxNota.Location = new Point(196, 121);
            tbxNota.Name = "tbxNota";
            tbxNota.Size = new Size(79, 23);
            tbxNota.TabIndex = 8;
            tbxNota.Text = "Nota";
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(196, 83);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(179, 23);
            tbxNom.TabIndex = 9;
            tbxNom.Text = "Nombre";
            // 
            // tbxLu
            // 
            tbxLu.Location = new Point(196, 159);
            tbxLu.Name = "tbxLu";
            tbxLu.Size = new Size(79, 23);
            tbxLu.TabIndex = 10;
            tbxLu.Text = "LU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 486);
            Controls.Add(tbxLu);
            Controls.Add(tbxNom);
            Controls.Add(tbxNota);
            Controls.Add(tbxId);
            Controls.Add(btnEditar);
            Controls.Add(btnCrearNuevo);
            Controls.Add(btnBorrar);
            Controls.Add(btnConfirmarR);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnConfirmarR;
        private Button btnBorrar;
        private Button btnCrearNuevo;
        private Button btnEditar;
        private TextBox tbxId;
        private TextBox tbxNota;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn LU;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn Nombre;
        private TextBox tbxNom;
        private TextBox tbxLu;
    }
}
