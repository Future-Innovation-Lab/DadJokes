using DadJokesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DadJokesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JokeHistoryPage : ContentPage
    {
        private List<DadJoke> _jokes;

        public List<DadJoke> Jokes
        {
            get { return _jokes; }
            set { _jokes = value;

                OnPropertyChanged();
            }
        }


        public JokeHistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DadJokeDatabase db = DadJokeDatabase.Instance;

            Jokes = db.GetJokes();

            BindingContext = this;

        }
    }
}