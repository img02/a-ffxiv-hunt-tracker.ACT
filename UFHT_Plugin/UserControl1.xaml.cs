using System.Windows.Controls;

namespace ACT_Plugin
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        //private Session _session;

        public UserControl1()
        {

            InitializeComponent();

            /*_session = Program.CreateSession(60);
           //_session.Start(new CancellationTokenSource());

            Thread.Sleep(3000);

            TheText.Text = _session.CurrentPlayer.Name;*/
        }
    }
}
