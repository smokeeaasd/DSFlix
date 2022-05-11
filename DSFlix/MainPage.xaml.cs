using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Evangelion.Source = ImageSource.FromResource("DSFlix.Posters.Evangelion.png");
            OnePiece.Source = ImageSource.FromResource("DSFlix.Posters.OnePiece.png");
            RecordsOfRagnarok.Source = ImageSource.FromResource("DSFlix.Posters.RecordsOfRagnarok.png");
            Bleach.Source = ImageSource.FromResource("DSFlix.Posters.Bleach.png");
        }

        private void Evangelion_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Animes.Evangelion());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void OnePiece_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Animes.OnePiece());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void RecordsOfRagnarok_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Animes.RecordsOfRagnarok());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Bleach_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Animes.Bleach());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
