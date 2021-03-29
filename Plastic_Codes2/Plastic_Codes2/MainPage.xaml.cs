using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plastic_Codes2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            image1.Source = ImageSource.FromResource("Plastic_Codes2.content.png");
            image1.Aspect = Aspect.Fill;

            image2.Source = ImageSource.FromResource("Plastic_Codes2.thefirstone.jpg");
            image2.Aspect = Aspect.Fill;

            image3.Source = ImageSource.FromResource("Plastic_Codes2.secondone.jpg");
            image3.Aspect = Aspect.Fill;

            image4.Source = ImageSource.FromResource("Plastic_Codes2.thirdone.jpg");
            image4.Aspect = Aspect.Fill;

            image5.Source = ImageSource.FromResource("Plastic_Codes2.fourone.jpg");
            image5.Aspect = Aspect.Fill;

            image6.Source = ImageSource.FromResource("Plastic_Codes2.fiveone.jpg");
            image6.Aspect = Aspect.Fill;

            image7.Source = ImageSource.FromResource("Plastic_Codes2.sixone.jpg");
            image7.Aspect = Aspect.Fill;

            image8.Source = ImageSource.FromResource("Plastic_Codes2.sevenone.jpg");
            image8.Aspect = Aspect.Fill;

            image9.Source = ImageSource.FromResource("Plastic_Codes2.eightone.jpg");
            image9.Aspect = Aspect.Fill;


        }
    }
}
