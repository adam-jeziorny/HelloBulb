using System;
using Gtk;
using HelloBulb;

namespace HelloBulb
{
	public partial class DimmerWindow : Gtk.Window
	{
		public delegate void SendValue(uint v, uint v1);
		SendValue f = null;
		SendValue f1 = null;

		public DimmerWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = "Dimmer Options ";
			this.WidthRequest = 300;
			this.button3.Clicked += this.button3zamknij;
		}
		protected void button3zamknij(object sender, EventArgs e)
		{
			this.Destroy();
		}
		public void setFunction( SendValue f, SendValue f1)
		{
			this.f = f;
			this.f1 = f1;
		}
		public void zmin (object sender, EventArgs e)
		{
			this.f ((uint)this.spinbutton1.Value, (uint)this.spinbutton2.Value);
		}
		public void zmin1 (object sender, EventArgs e)
		{
			this.f1 ((uint)this.spinbutton1.Value, (uint)this.spinbutton2.Value);
		}
	}
}