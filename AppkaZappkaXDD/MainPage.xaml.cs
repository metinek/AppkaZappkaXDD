namespace AppkaZappkaXDD {
    public partial class MainPage : ContentPage {
        Random rnd = new Random();
        string[] karty = {"ace_diamond", "ace_heart", "ace_spade", "ace_trefl", "joker_black", "joker_red"};
        HashSet<int> wylosowane = new HashSet<int>();
        int k=0;
        public MainPage() { 
            InitializeComponent();
        }

        private void OnLosujClicked(object sender, EventArgs e) {
            if (wylosowane.Count < karty.Length) {
                k = rnd.Next(karty.Length);
                while (wylosowane.Contains(k))
                    k = rnd.Next(karty.Length);

                wylosowane.Add(k);
                cardImg.Source = karty[k] + ".png";

            }
            else {
                cardImg.Source = "none.png";
                losujBtn.IsEnabled = false;
            }
        }

        private void OnResetClicked(object sender, EventArgs e) {
            wylosowane.Clear();
            k = 0;
            losujBtn.IsEnabled = true;
        }



    }
}