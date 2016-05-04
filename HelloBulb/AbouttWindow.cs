using System;
using Gtk;
using HelloBulb;

namespace HelloBulb
{
	public partial class AbouttWindow : Gtk.Window
	{
		public AbouttWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = "Informacje o aplikacji";
			this.DefaultWidth = 300;
			label1.Text = "Autorzy programu : \n" +
				" - Adam Jeziorny \n" +
				" - Piotr Strojny\n" +
				" - Michał Brudzyński\n" +
				" - Mateusz Brylikowski";
			this.button1.Clicked += this.button1zamknij;
		}
		protected void button1zamknij(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}