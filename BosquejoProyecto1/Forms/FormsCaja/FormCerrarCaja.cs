

using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsCaja
{
    public partial class FormCerrarCaja : Form
    {
        private readonly FormService _formService = new FormService();
        public FormCerrarCaja()
        {
            InitializeComponent();
            _formService.CerrarConValidación(lblSalir,this);
            _formService.CambiodeColor(lblSalir);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
