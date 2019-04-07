using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zad3_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valcm = val / 10;
                await DisplayAlert("Milimetry na Centymetry", val + " milimetrów daje " + valcm + " centrymetrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }           
        }

        async void OnButtonClickedv2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valmm = val * 10;
                await DisplayAlert("Centymetry na Milimetry", val + " centymetrów daje " + valmm + " milimetrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }     
        }

        async void OnButtonClicked1(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valm = val / 100;
                await DisplayAlert("Centymetry na Metry", val + " centymetrów daje " + valm + " metrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }         
        }

        async void OnButtonClicked1v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valcm = val * 100;
                await DisplayAlert("Metry na Centymetry", val + " Metrów daje " + valcm + " centymetrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }            
        }

        async void OnButtonClicked2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valkm = val / 1000;
                await DisplayAlert("Metry na Kilometry", val + " metrów daje " + valkm + " kilometrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }         
        }

        async void OnButtonClicked2v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valm = val * 1000;
                await DisplayAlert("Kilometry na Metry", val + " kilometrów daje " + valm + " metrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }        
        }

        async void OnButtonClicked3(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valmi = val * 0.62137;
                await DisplayAlert("Kilometry na Mile", val + " kilometrów daje " + valmi + " mil", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }           
        }

        async void OnButtonClicked3v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valkm = val / 0.62137;
                await DisplayAlert("Mile na Kilometry", val + " Mil daje " + valkm + " kilometrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }           
        }

        async void OnButtonClicked4(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valcm = val / 0.032808;
                await DisplayAlert("Stopy na centymetry", val + " stóp daje " + valcm + " centymetrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }         
        }

        async void OnButtonClicked4v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valft = val * 0.032808;
                await DisplayAlert("Centymetry na Stopy", val + " centrymetrów daje " + valft + " stóp", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }          
        }

        async void OnButtonClicked5(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valm = val / 1.0936;
                await DisplayAlert("Jardy na Metry", val + " jardów daje " + valm + " metrów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }         
        }

        async void OnButtonClicked5v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valyd = val * 1.0936;
                await DisplayAlert("Metry na Jardy", val + " metrów daje " + valyd + " jardów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked6(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valfahr = (val * 1.8) + 32;
                await DisplayAlert("Celsjusze na Fahrenheity", val + " stopni Celsjusza daje " + valfahr + " stopni Fahrenheita", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked6v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valcel = (val - 32) / 1.8;
                await DisplayAlert("Fahrenheity na Celsjusze", val + " stopni Fahrenheita daje " + valcel + " stopni Celsjusza", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked7(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valdek = val / 10;
                await DisplayAlert("Gramy na Dekagramy", val + " gramów daje " + valdek + " dekagramów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked7v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valg = val * 10;
                await DisplayAlert("Dekagramy na Gramy", val + " dekagramów daje " + valg + " gramów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked8(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valkg = val / 1000;
                await DisplayAlert("Gramy na Kilogramy", val + " gramów daje " + valkg + " kilogramów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked8v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valg = val * 1000;
                await DisplayAlert("Kilogramy na gramy", val + " kilogramów daje " + valg + " gramów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked9(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valton = val / 1000;
                await DisplayAlert("Kilogramy na Tony", val + " kilogramów daje " + valton + " ton", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }

        async void OnButtonClicked9v2(object sender, EventArgs args)
        {
            try
            {
                var val = double.Parse(wartosc.Text);
                var valton = val * 1000;
                await DisplayAlert("Tony na Kilogramy", val + " ton daje " + valton + " kilogramów", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Proszę podać wartość", "OK");
            }
        }
    }
}
