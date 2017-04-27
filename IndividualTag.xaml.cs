using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TagsControl
{
    /// <summary>
    /// Interaction logic for IndividualTag.xaml
    /// </summary>
    public partial class IndividualTag : UserControl
    {
        public event EventHandler OnDeleteMyself;

        public String TagStringValue
        {
          get { return (String)this.GetValue(TagStringValueProperty); }
          set { this.SetValue(TagStringValueProperty, value); } 
        }
        public static readonly DependencyProperty TagStringValueProperty = DependencyProperty.Register(
          "TagStringValue", typeof(String), typeof(IndividualTag),new PropertyMetadata(""));

        public IndividualTag()
        {
            InitializeComponent();
        }

        private void DeleteTagBtn_Click(object sender, RoutedEventArgs e)
        {
            if(OnDeleteMyself != null)
            {
                OnDeleteMyself(this, e);
            }
        }
    }
}
