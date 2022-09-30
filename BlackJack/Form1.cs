namespace BlackJack
{
    public partial class Form1 : Form
    {
        //global variables
        private int rank;
        private int suit;
        int valueDealer;
        int valuePlayer;

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
            getCard();
            arr[0] = Card.Suit[suit];
            arr[1] = Card.Rank[rank];

            item = new ListViewItem(arr);
            listView_player.Items.Add(item);

            valuePlayer = valuePlayer + Convert.ToInt16(arr[1]);

            value_player.Text = Convert.ToString(valuePlayer);

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
            valueDealer = 0;
            valueDealer = 0;
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
            arr[0] = Card.Suit[suit];
            arr[1] = Card.Rank[rank];

            item = new ListViewItem(arr);
            listView_dealer.Items.Add(item);

            valuePlayer = valuePlayer + Convert.ToInt16(arr[1]);

            value_player.Text = Convert.ToString(valuePlayer);

            //Add second item
            getCard();
            arr[0] = Card.Suit[suit];
            arr[1] = Card.Rank[rank];

            item = new ListViewItem(arr);
            listView_dealer.Items.Add(item);

            valuePlayer = valuePlayer + Convert.ToInt16(arr[1]);

            value_player.Text = Convert.ToString(valuePlayer);

        }

        public void getCard()
        {
            Random rnd = new Random();
            rank = rnd.Next(0, 14);  // creates a number between 0 and 13
            suit = rnd.Next(0, 4);  // creates a number between 0 and 3
        }
        private void label3_Click(object sender, EventArgs e)
        {
            //value_dealer
        }

        private void value_player_Click(object sender, EventArgs e)
        {

        }
    }

   

}

