using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms.FormsFacturación;


namespace BosquejoProyecto1.Forms
{
    public partial class FormFacturación : Form
    {
        private readonly FormService _formService = new FormService();

        public FormFacturación()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var form = new FormsPago();
            form.ShowDialog();
        }
    }
}
