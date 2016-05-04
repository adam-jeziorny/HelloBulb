using System;
using Gtk;
using HelloBulb;

namespace HelloBulb
{
	public class MsgBox
	{
 		public static Gtk.ResponseType ZamknijAplikacje(Gtk.Window window, Gtk.DialogFlags dialogflags, MessageType msgType,ButtonsType btnType,string Message,String caption)
		{
			MessageDialog md = new MessageDialog (window,dialogflags,msgType,btnType, Message);
			md.AddButton ("Zamknij",ResponseType.Yes);
			md.AddButton ("Anuluj",ResponseType.No);
			md.Title = caption;
			ResponseType tp = (Gtk.ResponseType)md.Run();       
			md.Destroy ();
			return tp;
		}
	}
}