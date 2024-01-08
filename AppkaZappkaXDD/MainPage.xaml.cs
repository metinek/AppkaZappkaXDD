﻿namespace AppkaZappkaXDD {
    public partial class MainPage : ContentPage {
        Random rnd = new Random();
        string[] karty = {
            "ace_diamond", "ace_heart", "ace_spade", "ace_trefl",
            "clubs_2", "clubs_3", "clubs_4", "clubs_5", "clubs_6", "clubs_7", "clubs_8", "clubs_9", "clubs_10",
            "diamonds_2", "diamonds_3", "diamonds_4", "diamonds_5", "diamonds_6", "diamonds_7", "diamonds_8", "diamonds_9", "diamonds_10",
            "spades_2", "spades_3", "spades_4", "spades_5", "spades_6", "spades_7", "spades_8", "spades_9", "spades_10",
            "hearts_2", "hearts_3", "hearts_4", "hearts_5", "hearts_6", "hearts_7", "hearts_8", "hearts_9", "hearts_10",
            "hearts_king", "hearts_jack", "hearts_queen",
            "spades_king", "spades_jack", "spades_queen",
            "diamonds_king", "diamonds_jack", "diamonds_queen",
            "clubs_king", "clubs_jack", "clubs_queen"
        };
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

            ileLbl.Text = "wylosowano: " + wylosowane.Count.ToString();
        }

        private void OnResetClicked(object sender, EventArgs e) {
            cardImg.Source = "none.png";
            wylosowane.Clear();
            k = 0;
            losujBtn.IsEnabled = true;
            ileLbl.Text = "wylosowano: 0";
        }




    }
}