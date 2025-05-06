namespace CuervoBD;

public partial class MainForm : Form
{
    private readonly PersonaRepository _repo;

    public MainForm()
    {
        InitializeComponent();
        _repo = new PersonaRepository(RavenDbStore.Store);
        CargarPersonas();
    }

    private void CargarPersonas()
    {
        var personas = _repo.GetAll();
        dgvPersonas.DataSource = personas;
    }

    private Persona LeerFormulario()
    {
        return new Persona
        {
            Dni = txtDni.Text,
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            FechaNacimiento = dtpFechaNacimiento.Value
        };
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var persona = LeerFormulario();
        _repo.Add(persona);
        CargarPersonas();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (dgvPersonas.CurrentRow?.DataBoundItem is Persona seleccionada)
        {
            var personaEditada = LeerFormulario();
            personaEditada.Id = seleccionada.Id;
            _repo.Update(personaEditada);
            CargarPersonas();
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvPersonas.CurrentRow?.DataBoundItem is Persona seleccionada)
        {
            _repo.Delete(seleccionada.Id);
            CargarPersonas();
        }
    }

    private void btnActualizarLista_Click(object sender, EventArgs e)
    {
        CargarPersonas();
    }

    private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvPersonas.CurrentRow?.DataBoundItem is Persona persona)
        {
            txtDni.Text = persona.Dni;
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            dtpFechaNacimiento.Value = persona.FechaNacimiento;
        }
    }
}
