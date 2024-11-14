using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.ViewModels
{
    internal class RegistracijaViewModel
    {

        public string webApiKey = "AIzaSyAEY8Y2vB2GMYTlbSVS2e_UXgCM-0Kq08A";

        private INavigation _navigation;

        public Command RegistracijaUporabnika { get; }

        public string email { get; set; }
        public string geslo { get; set; }

        private Entry _eTxEmail;
        private Entry _eTxpass;

        public RegistracijaViewModel(INavigation navigation, Entry eTxEmail, Entry eTxPass)
        {
            _navigation = navigation;
            _eTxEmail = eTxEmail;
            _eTxpass = eTxPass;

            RegistracijaUporabnika = new Command(RegistracijaUporabnikaTappendAsync);
        }

        private async void RegistracijaUporabnikaTappendAsync(object obj)
        {

            email = _eTxEmail.Text;
            geslo = _eTxpass.Text;

            try
            {
                var config = new FirebaseAuthConfig
                {
                    ApiKey = webApiKey,
                    AuthDomain = "rmrvaje2.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                    {
                        new GoogleProvider().AddScopes("email"),
                        new EmailProvider()
                    }
                };

                var client = new FirebaseAuthClient(config);
                var userCredential = await client.CreateUserWithEmailAndPasswordAsync(email, geslo, "Prikazno ime");

                if (userCredential != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obvestilo", "Uporabnik uspesno registriran", "OK");
                    _navigation.PopAsync();
                }
            }

            catch (FirebaseAuthException firebaseEx)
            {
                if (firebaseEx.Reason.ToString() == "EmailExists")
                {
                    await Application.Current.MainPage.DisplayAlert("Opozorilo", "Email je ze v uporabi. Vnesite drugo uporabnisko ime.", "OK");
                }

            }

           
        }
    }
}
