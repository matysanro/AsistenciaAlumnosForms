using MaterialSkin;
using MaterialSkin.Controls;

namespace AsistenciaAlumnosForms
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            // Inicializar MaterialSkinManager en el constructor
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Cambiar el tema y los colores de la barra superior y otros elementos
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple600, // Color primario (barra superior)
                Primary.Purple800, // Color oscuro
                Primary.Purple400, // Color claro
                Accent.Orange700,  // Acento
                TextShade.WHITE    // Color del texto
            );
        }
    }
}
