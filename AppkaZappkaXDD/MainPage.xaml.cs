namespace AppkaZappkaXDD {
    public partial class MainPage : ContentPage {
        Random rnd = new Random();
        string[] karty = {"ace_diamond", "ace_heart", "ace_spade", "ace_trefl", "joker_black", "joker_red"};
        int[] wylosowane;
        int k;
        public MainPage() {
            InitializeComponent();
        }

        private void OnLosujClicked(object sender, EventArgs e) {
            if (wylosowane.Length-2<karty.Length) {
                while (!wylosowane.Contains(k))
                    k = rnd.Next(6);


                wylosowane[wylosowane.Length-1] = k;
                cardImg.Source = karty[k]+".png";


            }
            else
                cardImg.Source = "none.png";

        }
    }
}