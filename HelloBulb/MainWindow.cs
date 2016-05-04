using System;
using Gtk;
using Gdk;
using HelloBulb;

public partial class MainWindow: Gtk.Window
{
	Gtk.Image img = Gtk.Image.LoadFromResource ("HelloBulb.bulb.png");
	public static bool gitt;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.buttonON.Clicked += this.bulb_on;
		this.buttonOFF.Clicked += this.bulb_off;
		this.Resizable = false;
		spinbuttonDimmer.Value = spinbuttonDimmer.Adjustment.Upper;
		zgaszapal (false, (uint)spinbuttonDimmer.Value);
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a) // zamykanie
	{
		ResponseType result = MsgBox.ZamknijAplikacje (this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Zamknąć aplikację?", "Zamknij");
		if (result == Gtk.ResponseType.Yes) {
			a.RetVal = false;
			Application.Quit ();
		} else if((result == Gtk.ResponseType.No || result == ResponseType.DeleteEvent)){
			a.RetVal = true;
		}			
	}
	private void bulb_off (object sender, EventArgs e) // przycisk off
	{
		zgaszapal (true, (uint)spinbuttonDimmer.Adjustment.Lower);	
	}
	private void bulb_on (object sender, EventArgs e) // przycisk on
	{
		zgaszapal (false, (uint)spinbuttonDimmer.Adjustment.Upper);
	}
	private void togglebut(object sender, EventArgs e) // togglebutton
	{
		if (gitt == false) zgaszapal (false, (uint)spinbuttonDimmer.Adjustment.Upper);
		else zgaszapal (true, (uint)spinbuttonDimmer.Adjustment.Lower);
	}
	private bool zgaszapal(bool git, uint c){		// funkcje do przycisków
		if (git == true) {
			this.Title = "Żarówka wyłączona";
			set_brithness (c);
			togglebutton1.Label = "Zapal";
			spinbuttonDimmer.Value = c;
			return gitt = false;
		} else if (git == false) {
			this.Title = "Żarówka włączona";
			set_brithness (c);
			togglebutton1.Label = "Zgaś";
			spinbuttonDimmer.Value = c;
			return gitt = true;
		}
		return false;
	}
	protected void spindim (object sender, EventArgs e) // spinbutton
	{
		if (spinbuttonDimmer.Value <= spinbuttonDimmer.Adjustment.Upper && spinbuttonDimmer.Value >= 15)
			zgaszapal (false, (uint)spinbuttonDimmer.Value);
		else if (spinbuttonDimmer.Value <= 14)
			zgaszapal (true, (uint)spinbuttonDimmer.Value);
	}
	private void res(object sender, EventArgs e) // skalowanie hscrollbar
	{
		set_brithness ((uint)spinbuttonDimmer.Value);
	}
	public void set_brithness (uint b) //ściemnianie i skalowanie
	{
		Pixbuf tmp = this.img.Pixbuf.Copy();
		tmp.SaturateAndPixelate (tmp, (b / 100.0f), false);
		this.image1.Pixbuf = tmp.ScaleSimple(((int)(hscrollbar1.Value * this.img.Pixbuf.Width)/100),((int)(hscrollbar1.Value * this.img.Pixbuf.Height)/100) , InterpType.Nearest);
	}
	private void about (object sender, EventArgs e) // okno about
	{
		AbouttWindow aw = new AbouttWindow ();
		aw.Show ();	
	}
	public void Dimmactive (object sender, EventArgs e) // okno dimm
	{
		DimmerWindow dw = new DimmerWindow ();
		dw.setFunction (this.zmiana, this.zmiana);	
	}
	public void zmiana(uint q, uint q1) 
	{
		this.spinbuttonDimmer.Adjustment.Upper = q;
		this.spinbuttonDimmer.Adjustment.Lower = q1;
	}
}