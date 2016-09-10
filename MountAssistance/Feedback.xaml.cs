using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MountAssistance
{
	public partial class Feedback : ContentPage
	{
		public Feedback()
		{
			InitializeComponent();
		}

		async void NavigateToHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MountAssistancePage());
		}
	}
}

