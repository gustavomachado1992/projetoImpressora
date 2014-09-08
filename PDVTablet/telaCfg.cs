
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PDVTablet
{
	[Activity (Label = "telaCfg", WindowSoftInputMode = SoftInput.AdjustPan)]			
	public class telaCfg : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.telaCfg);
		}
	}
}

