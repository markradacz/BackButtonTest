
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BackButtonTest
{
	public class SecondDlgViewController : DialogViewController
	{
		StringElement SecondDlgBtn;

		public SecondDlgViewController () : base (null, true)
		{
		}

		public override void LoadView ()
		{	
			base.LoadView ();

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain, (o,e) => {
				//do some stuff
				NavigationController.PopViewControllerAnimated(true);
			});

			SecondDlgBtn = new StringElement("Third Dlg", OnThirdDlgBtn) { Alignment = UITextAlignment.Center };

			var root = new RootElement ("Second Dlg")
			{
				new Section("", "")
				{ 
				},
				new Section("")
				{ 
					SecondDlgBtn
				},
			};
			Root = root;

		}


		private void OnThirdDlgBtn ()
		{
			this.Title = "Back";
			var dlg = new ThirdDlgViewController ();
			NavigationController.PushViewController(dlg, true);
		}
	}
}

