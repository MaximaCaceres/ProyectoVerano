using WebApplication1.Services;
using WinFormsApp1.ClientService;
using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AlumnoClientServices Service = new AlumnoClientServices();
        async private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var p in await Service.GetAll())
            {
                dataGridView1.Rows.Add(new object[] { p.Id, p.LU, p.Nota, p.Nombre });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            string nom = tbxNom.Text;
            int lu = Convert.ToInt32(tbxLu.Text);
            int id = Convert.ToInt32(tbxId.Text);
            double not = Convert.ToDouble(tbxNota.Text);
            Alumno a = new Alumno(nom,id,lu,not);

            dataGridView1.Rows.Clear();
            Alumno data = await Service.EditAlumno(a);
            dataGridView1.Rows.Add(new object[] { data.Id, data.LU, data.Nota, data.Nombre });
        }

        private async void btnConfirmarR_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);
            Alumno a = await Service.GetId(id);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(new object[] { a.Id, a.LU, a.Nota, a.Nombre });
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int lu = Convert.ToInt32(tbxLu.Text);
            Alumno data = await Service.DeleteAlumno(lu);
            dataGridView1.Rows.Clear();
            foreach (var p in await Service.GetAll())
            {
                dataGridView1.Rows.Add(new object[] { p.Id, p.LU, p.Nota, p.Nombre });
            }
        }

        private async void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            string nom = tbxNom.Text;
            int lu = Convert.ToInt32(tbxLu.Text);
            int id = Convert.ToInt32(tbxId.Text);
            double not = Convert.ToDouble(tbxNota.Text);
            Alumno a = new Alumno(nom,id,lu,not);

            dataGridView1.Rows.Clear();
            Alumno data = await Service.AgregarAlumno(a);
            dataGridView1.Rows.Add(new object[] { data.Id, data.LU, data.Nota, data.Nombre });

        }
    }
}
