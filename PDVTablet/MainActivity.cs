using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Timers;
using System.Security;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Provider;
using Android.Views.InputMethods;
using Android.Net;
using Android.Webkit;
using Android.Content.PM;
using Android.Content.Res;


namespace PDVTablet
{
	[Activity (Label = "PDVTablet", MainLauncher = true, Icon = "@drawable/icon", WindowSoftInputMode = SoftInput.AdjustPan, ConfigurationChanges = ConfigChanges.Orientation , ScreenOrientation = ScreenOrientation.SensorLandscape)]
	public class MainActivity : Activity
	{

	

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button botao1 = FindViewById<Button> (Resource.Id.button1);

			botao1.Click += delegate {

				//pegaE.checkApp();
				StartActivity(typeof(telaLogin));

				Finish();

				};
		


	}
}

}
