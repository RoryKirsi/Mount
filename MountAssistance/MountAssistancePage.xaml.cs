using System;
using Xamarin.Forms;

namespace MountAssistance
{
	public partial class MountAssistancePage : ContentPage
	{
		public MountAssistancePage()
		{
			InitializeComponent();
		}

		async void NavigateToList(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MountPage());
		}

		async void NavigateToFeedback(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Feedback());
		}
	}

}