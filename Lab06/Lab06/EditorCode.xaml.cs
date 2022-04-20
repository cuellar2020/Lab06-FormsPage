using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorCode : ContentPage
    {
        public EditorCode()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout { Padding = 10 };
            var MyEditor = new Editor { Text = "I'm an editor" };
            stack.Children.Add(MyEditor);
            Content = stack;
        }
    }
}