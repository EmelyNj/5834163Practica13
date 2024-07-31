namespace _5834163Practica13
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Suma());
        }

        private void Triangulo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Triangulo());
        }

        private void Brocha_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Brocha());
        }

        private void Distancia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Distancia());
        }

        private void Sueldo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sueldo());
        }
    }

}
