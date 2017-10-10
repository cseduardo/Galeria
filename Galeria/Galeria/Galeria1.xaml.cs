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
	public partial class Galeria1 : ContentPage
	{
		public Galeria1 ()
		{
			InitializeComponent ();
            var img = new List<string>
            {
                "lol.jpg",
                "i.jpg",
                "mp.jpg",
                "t.jpg",
                "yo.jpg",
                "http://3.bp.blogspot.com/-GuZHIuEG_us/UMqhU1FYABI/AAAAAAAACS4/gSIIi_K7meo/s1600/frases-de-homero-simpson.jpg",
                "http://mx.hola.com/imagenes/actualidad/2017082498514/ariana-grande-suspende-concierto/0-481-246/ariana-grande1-t.jpg",
                "http://www.joblo.com/newsimages1/robert-downey-jr-iron-man.jpg",
                "https://lamenteesmaravillosa.com/wp-content/uploads/2016/07/el-principito-conversando-con-su-rosa.jpg",
            };
            listView.ItemsSource = img;
        }

        private void meGusta_Clicked(object sender, EventArgs e)
        {
            meGusta.Image = "me_gusta_a.png";
            noMeGusta.Image = "no_me_gusta_b.png";
        }

        private void noMeGusta_Clicked(object sender, EventArgs e)
        {
            meGusta.Image = "me_gusta_b.png";
            noMeGusta.Image = "no_me_gusta_a.png";
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            imgBig.Source = e.SelectedItem as string;
            if (imgBig != e.SelectedItem)
            {
                meGusta.Image = "me_gusta_b.png";
                noMeGusta.Image = "no_me_gusta_b.png";
            }
        }
    }
}