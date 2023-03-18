using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_ticket {
	public partial class orderWindow : Form {
		string firstName, lastName, from, to;
		DateTime date;
		public orderWindow() {
			InitializeComponent();
		}

		private void buyButton_Click(object sender, EventArgs e) {
			if (firstNameBox.Text != "" && lastNameBox.Text != "" && fromBox.Text != "" && toBox.Text != "") {
				firstName = firstNameBox.Text;
				lastName = lastNameBox.Text;
				from = fromBox.Text;
				to = toBox.Text;
				date = calendar.Value;

				ticketWindow form = new ticketWindow(firstName, lastName, from, to, date);
				form.Show();
				this.Visible = false;
				this.Enabled = false;
			}
			else
				warning.Visible = true;
		}
	}
}
