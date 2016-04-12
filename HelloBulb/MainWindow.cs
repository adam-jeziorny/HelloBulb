using System;
using Gtk;
using Gdk;
using HelloBulb;

public partial class MainWindow: Gtk.Window
{
	//zaladowanie obrazka zarowki
	Gtk.Image img = Gtk.Image.LoadFromResource ("bulb.png");

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.image1.Pixbuf = img.Pixbuf;

		//przypisanie zdarzen do przyciskow
		this.buttonON.Clicked += this.bulb_on;
		this.buttonOFF.Clicked += this.bulb_off;

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	private void bulb_off (object sender, EventArgs e)
	{
		//do uzupelnienia
		//przyklad wykorzystania klasy MsgBox
		MsgBox.Show ("Żarówka zgaszona! \n\n metoda do samodzielnego uzupełnienia");
		this.image1.Pixbuf = null;
	}

	private void bulb_on (object sender, EventArgs e)
	{
		//do uzupelniena
		this.image1.Pixbuf = this.img.Pixbuf;
	}

	private void about (object sender, EventArgs e)
	{
		//okienko z informacja o programie
		MsgBox.Show ("O programie...");

		//ale docelowo z wykorzystaniem samodzielnie
		//stworzonej klasy AboutWindow
	}
}
