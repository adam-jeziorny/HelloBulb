using System;
using Gtk;

namespace HelloBulb
{

	/*
	 * Klasa pomocnicza MsgBox
	 * 
	 * wyświetlanie okienek dialogowych
	 * przydatne np. do pytania dot. zamknięcia programu
	 * 
	 */

public class MsgBox
{
	public static void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
	{
		MessageDialog md = new MessageDialog (parent_window, flags, msgtype, btntype, msg);
		md.Run ();
		md.Destroy();
	}

	public static void Show(string msg)
	{
		MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, msg);
		md.Run ();
		md.Destroy();
	}
} 

}
