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
    /// Interaction logic for TagsControl.xaml
    /// </summary>
    public partial class TagsControlRoot : UserControl
    {

        public TagsControlRoot()
        {
            InitializeComponent();
        }

        private void NewTagTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                //add the tag
                IndividualTag newTag = new IndividualTag();
                newTag.TagStringValue = NewTagTextBox.Text;
                newTag.OnDeleteMyself += NewTag_OnDeleteMyself;

                //1 behind text box
                TagsContainer.Children.Insert(TagsContainer.Children.Count - 1, newTag);
                
                NewTagTextBox.Text = "";
            }
        }

        private void NewTag_OnDeleteMyself(object sender, EventArgs e)
        {
            if(sender!=null)
            { 
                TagsContainer.Children.Remove((UIElement)sender);
            }
        }
    }
}
