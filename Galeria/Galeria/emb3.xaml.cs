using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galeria
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class emb3 : ContentPage
	{
		public emb3 ()
		{
			InitializeComponent ();
            var imag = new Image
            {
                Source = ImageSource.FromResource("Galeria.img3.jpg")
            };
            Content = imag;
        }
	}
}