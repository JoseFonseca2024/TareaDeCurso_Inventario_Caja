using BosquejoProyecto1.Class;


namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormInicializacionInventario : Form
    {
        private readonly FormService formService = new FormService();
        public FormInicializacionInventario()
        {
            InitializeComponent();
            formService.CerrarConValidación(lblExit,this);
            formService.CambiodeColor(lblExit);
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
            }
        }


    }
}
