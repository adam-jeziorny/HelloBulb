
// This file has been generated by the GUI designer. Do not modify.
namespace HelloBulb
{
	public partial class AbouttWindow
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Button button1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HelloBulb.AbouttWindow
			this.Name = "HelloBulb.AbouttWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AbouttWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child HelloBulb.AbouttWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.fixed1.Add (this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
			w1.X = 25;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Zamknij");
			this.fixed1.Add (this.button1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
			w2.X = 167;
			w2.Y = 101;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 167;
			this.Show ();
		}
	}
}
