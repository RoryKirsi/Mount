using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MountAssistance
{
	public partial class MountPage : ContentPage
	{
		public MountPage()
		{
			InitializeComponent();
		}

		async void NavigateToFeedback(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Feedback());
		}

		async void NavigateToList(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MountAssistancePage());
		}

		async void NavigateToHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MountAssistancePage());
		}
	}
}

