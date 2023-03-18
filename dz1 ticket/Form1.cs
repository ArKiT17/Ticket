namespace dz1_ticket {
	public partial class ticketWindow : Form {
		public ticketWindow(string firstName_, string lastName_, string from_, string to_, DateTime date_) {
			InitializeComponent();
			nameOfPassngerL.Text = nameOfPassngerR.Text = firstName_ + " " + lastName_;
			fromL.Text = fromR.Text = from_;
			toL.Text = to_;
			Random rnd = new Random();
			flightL.Text = flightR.Text = $"{Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100, 999)}";
			dateL.Text = dateR.Text = $"{date_.Date}";
			int time = rnd.Next(0, 10);
			timeL.Text = timeR.Text = $"{time}:30";
			gateL.Text = gateR.Text = $"{Convert.ToChar(rnd.Next(65, 70))}{rnd.Next(1, 15)}";
			boardingL.Text = boardingR.Text = $"{time + 4}:00";
			seatL.Text = seatR.Text = $"{rnd.Next(1, 120)}";
		}
		private void ticketWindow_FormClosed(object sender, EventArgs e) {
			Application.Exit();
		}
		private void button1_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}