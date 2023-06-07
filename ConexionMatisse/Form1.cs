using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matisse;
using Matisse.Data;
using Matisse.Reflect;
using Matisse.Tools;

namespace ConexionMatisse
{
    public partial class Form1 : Form
    {
        string host;
        string database;
        MtDatabase db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Almacenan permanentemento lo que se ingrese en las cajas de texto para mantener la conexión.
            host = txtHost.Text; 
            database = txtDB.Text;
            db = new MtDatabase(host, database); //Mandar a traer un nuevo objeto con las variables globales host y database por cada transacción
            try
            {
                db.Open();
                MessageBox.Show("Conexión exitosa a " + db.ToString());
                cmbGrupos.DataSource = llenarCMBGrupos();
                cmbGrupos.ValueMember = "nomGru";
            }
            catch (MtException ex)
            {
                if (db.IsConnectionOpen() == true)
                {
                    db.Close();
                }
                MessageBox.Show("MtException expected: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string comando = "SELECT * FROM " + cmbTablas.SelectedItem.ToString();
            //    MtDataAdapter adapter = new MtDataAdapter(comando, db);
            //    DataTable datos = new DataTable();
            //    adapter.Fill(datos);
            //    adapter = null;
            //    dgvVisualizarTabla.DataSource = datos;
            //}
            //catch (MtException mt)
            //{
            //    MessageBox.Show("Error encontrado: " + mt.Message);
            //}
            MostrarInformacion();//Usando el metodo creado abajo
        }
        private void MostrarInformacion()
        {
            try
            {
                string comando = "SELECT * FROM " + cmbTablas.SelectedItem.ToString();
                MtDataAdapter adapter = new MtDataAdapter(comando, db);
                DataTable datos = new DataTable();
                adapter.Fill(datos);
                adapter = null;
                dgvVisualizarTabla.DataSource = datos;
            }
            catch (MtException mt)
            {
                MessageBox.Show("Error encontrado: " + mt.Message);
            }
        }
        //Método que rellena un combobox mediante una tabla, en este caso, grupo
        public DataTable llenarCMBGrupos()
        {
            try
            {
                DataTable data = new DataTable();
                string comando = "SELECT * FROM Grupo";
                MtDataAdapter adapter = new MtDataAdapter(comando, db);
                adapter.Fill(data);
                adapter = null;
                return data;
            }
            catch (MtException mt)
            {
                MessageBox.Show("Error encontrado en llenarCMBGrupos" + mt.Message);
                return null;
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                db = new MtDatabase(host, database);
                string comando = "Insert into Alumno(cveAlu, nomAlu, edaAlu, cveGru) VALUES ('"+txtClave.Text+"', '"+txtNombre.Text+"', '"+txtEdad.Text+"', '"+cmbGrupos.Text+"')";
                MtCommand command = new MtCommand(comando, db);

                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                MostrarInformacion();
                MessageBox.Show("El alumno =  " + txtNombre.Text + " ha sido creado correctamente");
            }
            catch (MtException mt)
            {
                MessageBox.Show("Error inesperado en botón agregar alumno: " + mt.Message);
                db.Close();
            }
        }

        private void btnEliminarAlu_Click(object sender, EventArgs e)
        {
            try
            {
                db = new MtDatabase(host, database);
                string comando = "DELETE FROM Alumno WHERE cveAlu=" + "'" + txtID_Eliminar.Text + "'"+"";
                //string comando = "DELETE FROM Alumno WHERE cveAlu= 'DA01'";
                MtCommand command = new MtCommand(comando, db);
                //                delete from Alumno
                //where ID = 2;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("El alumno con id =  " + txtID_Eliminar.Text + " ha sido eliminado correctamente");
                MostrarInformacion();
                txtID_Eliminar.Text = "";

            }
            catch (MtException mt)
            {
                MessageBox.Show("Error inesperado en botón eliminar alumno: " + mt.Message);
                db.Close();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                db = new MtDatabase(host, database);
                string comando = "UPDATE Alumno SET nomAlu = '"+ txt_NameUpdt.Text + "', edaAlu = '" + txt_EdadUpdt.Text + "', cveGru = '" + cmb_GrupoUpdt.Text + "' WHERE cveAlu= '"+ txt_IdUpdt.Text +"'";
                //update Alumno SET nomAlu='Ramiro', edaAlu='15', cveGru='A03' where cveAlu='J03'
                MtCommand command = new MtCommand(comando, db);


                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("El alumno con id =  " + txt_IdUpdt.Text + " ha sido modificado correctamente");
                MostrarInformacion();
                //txtID_Eliminar.Text = "";

            }
            catch (MtException mt)
            {
                MessageBox.Show("Error inesperado en botón modificsr alumno: " + mt.Message);
                db.Close();
            }

        }
    }
}
