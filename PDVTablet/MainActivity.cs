using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PDVTablet
{
	[Activity (Label = "PDVTablet", MainLauncher = true, Icon = "@drawable/icon")]
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
