using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
