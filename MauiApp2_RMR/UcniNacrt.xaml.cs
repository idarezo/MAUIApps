using Firebase.Database;
using MauiApp2_RMR.Models;
using Newtonsoft.Json;

namespace MauiApp2_RMR.Views;

public partial class UcniNacrt : ContentPage
{
    FirebaseClient firebaseClient;
    List<Predmet> zbirkaPredmetovRis;
    List<Predmet> zbirkaPredmetovSPI;

    public UcniNacrt()
	{
		InitializeComponent();
        firebaseClient = new FirebaseClient(baseUrl: "https://rmrvaje2-default-rtdb.europe-west1.firebasedatabase.app/");
        zbirkaPredmetovRis = new List<Predmet>();
        zbirkaPredmetovSPI = new List<Predmet>();
        //beriIzBaze();
    }
    private async void IzbranaSmer(object sender, EventArgs e)
	 {
        zbirkaPredmetovRis.Clear();
        zbirkaPredmetovSPI.Clear();
        risSection.Clear();
        spiSection.Clear();
        HttpClient httpclient = new HttpClient();
        var response = await httpclient.GetStringAsync("https://rmrvaje2-default-rtdb.europe-west1.firebasedatabase.app/predmeti/.json");
        var predmetiList = JsonConvert.DeserializeObject<List<Predmet>>(response);

        int izbranaSmer = smerIzbira.SelectedIndex;
        foreach (var predmet in predmetiList)
        {
            Predmet predmetNovi = new Predmet(predmet.predmetId, predmet.Naziv, predmet.ECTS, predmet.Semester);
            if (predmetNovi.Naziv == "Prosto izbirni predmet 2" || predmetNovi.Naziv == "Prosto izbirni predmet 3" || predmetNovi.Naziv == "Prosto izbirni predmet 4" || predmetNovi.Naziv == "Diplomsko delo" || predmetNovi.Naziv == "Prakticno usposabljanje")
            {
                zbirkaPredmetovRis.Add(predmetNovi);
                zbirkaPredmetovSPI.Add(predmetNovi);
                var textCell = new TextCell { Text = predmetNovi.Naziv, Detail = $"ECTS - {predmetNovi.ECTS}", TextColor = Colors.White };
                risSection.Add(textCell);
                spiSection.Add(textCell);


            }
            else if (predmetNovi.Naziv == "upravljanje IKT" || predmetNovi.Naziv == "Razvoj informacijskih storitev" || predmetNovi.Naziv == "Portali in sistemi znanja" || predmetNovi.Naziv == "Razvoj mobilnih resitev")
            {
                zbirkaPredmetovRis.Add(predmetNovi);
                var textCell = new TextCell { Text = predmetNovi.Naziv, Detail = $"ECTS - {predmetNovi.ECTS}", TextColor = Colors.White };
                risSection.Add(textCell);

            }
            else
            {
                zbirkaPredmetovSPI.Add(predmetNovi);
                var textCell = new TextCell { Text = predmetNovi.Naziv, Detail = $"ECTS - {predmetNovi.ECTS}", TextColor= Colors.White };
                spiSection.Add(textCell);


            }
        }         
        if (izbranaSmer == 0)
        {
            tableViewRis.IsVisible = true;
            tableViewSPI.IsVisible = false;
            izbirniPredmeti.IsVisible = true;
            izbirniPredmeti.BackgroundColor = Color.FromHex("#006385");

        }
        else
        {
            tableViewSPI.IsVisible = true;
            tableViewRis.IsVisible = false;
            izbirniPredmeti.IsVisible = true;
            tableViewSPI.BackgroundColor = Colors.LightSalmon;
            izbirniPredmeti.BackgroundColor = Colors.LightSalmon;
            spletnaStoritevBtn.BackgroundColor = Colors.LightSalmon;

        }	
	}
	private void izbirciInfo(object sender, EventArgs e)
	{
        DisplayAlert("Informacije o izbirnih predmetih", "Za Prosto izbirni predmet II, III in IV lahko študent izbere katerikoli predmet iz ponudbe predmetov visokosolskih strokovnih studijskih programov 1. stopnje UM FERI, drugih clanic UM ali drugih univerz, v skupni vrednosti najmanj 5 ECTS tock. Kontaktne ure pri diplomskem delu so misljene kot individualne konzultacije z mentorjem.", "Razumem");
    }

    private async void spletneStortiveClicked(object sender, EventArgs e)

    {
        await Navigation.PushAsync(new UporabnikiPage());
    }
}

