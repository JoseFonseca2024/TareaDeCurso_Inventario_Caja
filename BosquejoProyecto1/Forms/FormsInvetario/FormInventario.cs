using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormInventario : Form
    {
        private readonly FormService _formService = new FormService();
        public FormInventario()
        {
            InitializeComponent();
            _formService.CerrarSinValidar(lblExit, this);
            _formService.CambiodeColor(lblExit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormRegistroCompra();
            form.ShowDialog();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            var form = new FormInicializacionInventario();
            form.ShowDialog();
        }
    }
}
