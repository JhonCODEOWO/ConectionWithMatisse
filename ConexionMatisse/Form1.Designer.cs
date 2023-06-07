
namespace ConexionMatisse
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvVisualizarTabla = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarAlu = new System.Windows.Forms.Button();
            this.txtID_Eliminar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cmb_GrupoUpdt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_EdadUpdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NameUpdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_IdUpdt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarTabla)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTablas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDB);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 512);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecciona una tabla";
            // 
            // cmbTablas
            // 
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Items.AddRange(new object[] {
            "Alumno",
            "Department",
            "Employee",
            "Grupo"});
            this.cmbTablas.Location = new System.Drawing.Point(215, 127);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manipular datos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvVisualizarTabla);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar tablas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVisualizarTabla
            // 
            this.dgvVisualizarTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarTabla.Location = new System.Drawing.Point(6, 6);
            this.dgvVisualizarTabla.Name = "dgvVisualizarTabla";
            this.dgvVisualizarTabla.Size = new System.Drawing.Size(324, 273);
            this.dgvVisualizarTabla.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mostrar información";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarAlumno);
            this.tabPage2.Controls.Add(this.cmbGrupos);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtEdad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtClave);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(192, 210);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(131, 48);
            this.btnAgregarAlumno.TabIndex = 9;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Items.AddRange(new object[] {
            "",
            "Alumno",
            "Department",
            "Employee",
            "Grupo"});
            this.cmbGrupos.Location = new System.Drawing.Point(110, 167);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(213, 21);
            this.cmbGrupos.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grupo";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(110, 133);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(213, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre del alumno";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(110, 72);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(213, 20);
            this.txtClave.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clave del alumno";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminarAlu);
            this.tabPage3.Controls.Add(this.txtID_Eliminar);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(336, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar datos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlu
            // 
            this.btnEliminarAlu.Location = new System.Drawing.Point(16, 194);
            this.btnEliminarAlu.Name = "btnEliminarAlu";
            this.btnEliminarAlu.Size = new System.Drawing.Size(298, 109);
            this.btnEliminarAlu.TabIndex = 2;
            this.btnEliminarAlu.Text = "Eliminar todos los datos";
            this.btnEliminarAlu.UseVisualStyleBackColor = true;
            this.btnEliminarAlu.Click += new System.EventHandler(this.btnEliminarAlu_Click);
            // 
            // txtID_Eliminar
            // 
            this.txtID_Eliminar.Location = new System.Drawing.Point(82, 10);
            this.txtID_Eliminar.Name = "txtID_Eliminar";
            this.txtID_Eliminar.Size = new System.Drawing.Size(61, 20);
            this.txtID_Eliminar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Escribe el id";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Modificar);
            this.tabPage4.Controls.Add(this.cmb_GrupoUpdt);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_EdadUpdt);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_NameUpdt);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txt_IdUpdt);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(336, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Modificar datos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el nomre de la base de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el nombre del host";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(18, 100);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(178, 20);
            this.txtDB.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(18, 39);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(128, 20);
            this.txtHost.TabIndex = 0;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(196, 206);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(131, 48);
            this.btn_Modificar.TabIndex = 18;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cmb_GrupoUpdt
            // 
            this.cmb_GrupoUpdt.FormattingEnabled = true;
            this.cmb_GrupoUpdt.Items.AddRange(new object[] {
            "",
            "Alumno",
            "Department",
            "Employee",
            "Grupo"});
            this.cmb_GrupoUpdt.Location = new System.Drawing.Point(114, 163);
            this.cmb_GrupoUpdt.Name = "cmb_GrupoUpdt";
            this.cmb_GrupoUpdt.Size = new System.Drawing.Size(213, 21);
            this.cmb_GrupoUpdt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Grupo";
            // 
            // txt_EdadUpdt
            // 
            this.txt_EdadUpdt.Location = new System.Drawing.Point(114, 129);
            this.txt_EdadUpdt.Name = "txt_EdadUpdt";
            this.txt_EdadUpdt.Size = new System.Drawing.Size(213, 20);
            this.txt_EdadUpdt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Edad";
            // 
            // txt_NameUpdt
            // 
            this.txt_NameUpdt.Location = new System.Drawing.Point(114, 98);
            this.txt_NameUpdt.Name = "txt_NameUpdt";
            this.txt_NameUpdt.Size = new System.Drawing.Size(213, 20);
            this.txt_NameUpdt.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nombre del alumno";
            // 
            // txt_IdUpdt
            // 
            this.txt_IdUpdt.Location = new System.Drawing.Point(114, 68);
            this.txt_IdUpdt.Name = "txt_IdUpdt";
            this.txt_IdUpdt.Size = new System.Drawing.Size(213, 20);
            this.txt_IdUpdt.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Clave del alumno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conexion con matisse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarTabla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvVisualizarTabla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarAlu;
        private System.Windows.Forms.TextBox txtID_Eliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ComboBox cmb_GrupoUpdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_EdadUpdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NameUpdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_IdUpdt;
        private System.Windows.Forms.Label label12;
    }
}

