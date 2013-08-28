
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BackButtonTest
{
	public class FirstDlgViewController : DialogViewController
	{
		StringElement SecondDlgBtn;

		public FirstDlgViewController () : base (null, true)
		{
		}

		public override void LoadView ()
		{	
			base.LoadView ();

//			NavigationItem.LeftBarButtonItem = new UIBarButtonItem("Back", UIBarButtonItemStyle.Done, (o,e) => {
//				parentNav.NavigationController.PopViewControllerAnimated(true);
//			});

			SecondDlgBtn	= new StringElement("Second Dlg", OnSecondDlgBtn) { Alignment = UITextAlignment.Center };
			var root = new RootElement ("First Dlg")
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


		private void OnSecondDlgBtn ()
		{
			this.Title = "Back";
			var firstDlg = new SecondDlgViewController ();
			NavigationController.PushViewController(firstDlg, true);
		}
	}
}

