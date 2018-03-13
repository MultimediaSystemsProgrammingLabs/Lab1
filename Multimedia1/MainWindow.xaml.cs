using SharpGL.SceneGraph;
using SharpGL.OpenGLAttributes;
using System.Windows;

namespace Multimedia1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SharpGL.WPF.OpenGLControl op = new SharpGL.WPF.OpenGLControl();
            op.Margin = new Thickness(0, 20, 0, 0);
            op.DrawFPS = true;
            op.OpenGLInitialized += Op_Initialized;
            this.grid.Children.Add(op);
        }

        private void Op_Initialized(object sender, OpenGLEventArgs e)
        {
            var gl = e.OpenGL;
            gl.ClearColor(1, 1, 1, 1);
            gl.Begin(SharpGL.OpenGL.)
        }
    }
}
