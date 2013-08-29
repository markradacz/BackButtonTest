using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BackButtonTest
{
	public class BackButtonTestViewController : DialogViewController
	{
		StringElement FirstDlgBtn, CustomDlgBtn, ImageDlgBtn, FourthDlgBtn;

		public BackButtonTestViewController () : base (null, true)
		{
		}

		public override void LoadView ()
		{	
			base.LoadView ();

			FirstDlgBtn	  	= new StringElement("Regular 'Back'", OnFirstDlgBtn) { Alignment = UITextAlignment.Center };
			CustomDlgBtn 	= new StringElement("Custom 'Back' Text", OnCustomDlgBtn) { Alignment = UITextAlignment.Center };
			ImageDlgBtn	  	= new StringElement("Image 'Back' Button", OnImageDlgBtn) { Alignment = UITextAlignment.Center };
			FourthDlgBtn	= new StringElement("Fourth 'Back' Button", OnFourthDlgBtn) { Alignment = UITextAlignment.Center };

			var root = new RootElement ("Back Button Test")
			{
				new Section("", "")
				{ 
				},
				new Section("")
				{ 
					FirstDlgBtn 
				},
				new Section("")
				{ 
					CustomDlgBtn 
				},
				new Section("")
				{ 
					ImageDlgBtn
				},
				new Section("")
				{ 
					FourthDlgBtn
				},

			};
			Root = root;

		}


		private void OnFirstDlgBtn ()
		{
			this.Title = "Back";
			var firstDlg = new FirstDlgViewController ();
			NavigationController.PushViewController(firstDlg, true);
		}

		private void OnCustomDlgBtn()
		{
			this.Title = "Custom Back";
			var firstDlg = new FirstDlgViewController ();
			firstDlg.NavigationItem.LeftBarButtonItem = new UIBarButtonItem("< back", UIBarButtonItemStyle.Plain, (o,e) => {
				//do some stuff			
				NavigationController.PopViewControllerAnimated(true);
			});

			NavigationController.PushViewController(firstDlg, true);
		}

		private void OnImageDlgBtn()
		{
			this.Title = "Image Back";
			var firstDlg = new FirstDlgViewController ();
			firstDlg.NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIImage.FromFile("29_icon.png"), UIBarButtonItemStyle.Plain, (o,e) => {
				//do some stuff
				NavigationController.PopViewControllerAnimated(true);
			});

			NavigationController.PushViewController(firstDlg, true);
		}


		private void OnFourthDlgBtn()
		{
			this.Title = "Back";
			var dlg = new FourthDlgViewController ();
			var btn = new UIBarButtonItem(UIImage.FromFile("29_icon.png"), UIBarButtonItemStyle.Plain, (o,e) => {
				//do some stuff
				NavigationController.PopViewControllerAnimated(true);
			});

			dlg.NavigationItem.LeftBarButtonItem = btn;

			NavigationController.PushViewController(dlg, true);
		}

		private void DisplayAlert(string msg)
		{
			var alert = new UIAlertView ("Home", msg, null, "Ok");
			alert.Show ();
		}

	}
}

