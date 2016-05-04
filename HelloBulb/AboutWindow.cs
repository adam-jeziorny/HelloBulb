using System;
using Gtk;

namespace HelloBulb
{
	public partial class AboutWindow : Gtk.Window
	{
		public AboutWindow () : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = "About";
			//Label label;

			//Label label1 = new Label ("Autorzy programu : ");
		}
	}
}

