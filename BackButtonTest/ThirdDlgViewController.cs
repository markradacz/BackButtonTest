using System.Drawing;

using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BackButtonTest
{
	public class ThirdDlgViewController : DialogViewController
	{
		public ThirdDlgViewController () : base (null, true)
		{
		}

		public override void LoadView ()
		{	
			base.LoadView ();

			NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain, delegate { OnBackBtn();} ), true);

			var label = new UILabel() {
				Frame = new RectangleF(0, 0, 300, 20),
				TextAlignment =  UITextAlignment.Center,
				Text = "The End",
				Font = UIFont.BoldSystemFontOfSize (20f),
				TextColor = new UIColor (76/255f, 86/255f, 108/255f, 1.0f),
				BackgroundColor = UIColor.Clear
			};

			var root = new RootElement ("Third Dlg")
			{
				new Section("", "")
				{ 
				},
				new Section(label)
				{ 
				},
			};
			Root = root;

		}

		private void OnBackBtn()
		{
			//do some stuff
			NavigationController.PopToRootViewController(true);
		}
	}
}


