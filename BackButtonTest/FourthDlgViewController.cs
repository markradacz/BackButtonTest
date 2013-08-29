using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace BackButtonTest
{
	public partial class FourthDlgViewController : DialogViewController
	{
		public FourthDlgViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("FourthDlgViewController") {
				new Section ("First Section"){
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section"){
				},
			};
		}
	}
}
