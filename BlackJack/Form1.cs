namespace BlackJack
{
    public partial class Form1 : Form
    {
        private int rank;
        private int suit;
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button for hit

            //Add items in the listview
            string[] arr = new string[3];
            ListViewItem item;

            //Add first item
            arr[0] = "Spade";
            arr[1] = "10";

            item = new ListViewItem(arr);
            listView_player.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button for stand

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listview player
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button start
            listView_dealer.Clear();
            listView_player.Clear();
            initializeListviewPlayer();
            initializeListviewDealer();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listview dealer

        }

        private void initializeListviewPlayer()
        {
            //listview player
            listView_player.View = View.Details;
            listView_player.GridLines = true;
            listView_player.FullRowSelect = true;

            //Add column header
            listView_player.Columns.Add("Suite", 100);
            listView_player.Columns.Add("Rank", 100);

        }
        public void initializeListviewDealer()
        {
            //listview player
            listView_dealer.View = View.Details;
            listView_dealer.GridLines = true;
            listView_dealer.FullRowSelect = true;

            //Add column header
            listView_dealer.Columns.Add("Suite", 100);
            listView_dealer.Columns.Add("Rank", 100);

            //Add 2 cards to dealer
            string[] arr = new string[3];
            ListViewItem item;

            //Add first item
            getCard();
            arr[0] = Card.Suit[rank];
            arr[1] = Card.Rank[suit];

            item = new ListViewItem(arr);
            listView_dealer.Items.Add(item);

            //Add second item
            arr[0] = Card.Suit[2];
            arr[1] = Card.Rank[2];

            item = new ListViewItem(arr);
            listView_dealer.Items.Add(item);

            value_dealer.Text = arr[1];
        }

        public void getCard()
        {
            Random rnd = new Random();
            rank = rnd.Next(0, 14);  // creates a number between 0 and 13
            suit = rnd.Next(0, 5);  // creates a number between 0 and 4
        }
        private void label3_Click(object sender, EventArgs e)
        {
            //value_dealer
        }


    }

    public class Card
    {
        public static readonly String[] Rank = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public static readonly String[] Suit = { "Diamond", "Clover", "Heart", "Spade" };
      
    }

}

