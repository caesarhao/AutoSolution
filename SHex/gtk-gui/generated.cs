
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;

		internal static void Initialize (Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false)) {
				Stetic.Gui.initialized = true;
				global::Gtk.IconFactory w1 = new global::Gtk.IconFactory ();
				global::Gtk.IconSet w2 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("SHex.fileBin_96x96.ico"));
				w1.Add ("fileBin", w2);
				global::Gtk.IconSet w3 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("SHex.fileHex_96x96.ico"));
				w1.Add ("fileHex", w3);
				global::Gtk.IconSet w4 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("SHex.fileSRec_96x96.ico"));
				w1.Add ("fileSRec", w4);
				global::Gtk.IconSet w5 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("SHex.fileTiTxt_96x96.ico"));
				w1.Add ("fileTiTxt", w5);
				w1.AddDefault ();
			}
		}
	}

	internal class ActionGroups
	{
		public static Gtk.ActionGroup GetActionGroup (System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup (type.FullName);
		}

		public static Gtk.ActionGroup GetActionGroup (string name)
		{
			return null;
		}
	}
}
