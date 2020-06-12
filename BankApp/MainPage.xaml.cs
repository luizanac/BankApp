using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BankApp
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

			BindingContext = this;
		}

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
		}


		private async void PanUpdated(object sender, PanUpdatedEventArgs e)
		{
			switch (e.StatusType)
			{
				case GestureStatus.Running:
					await CardFrame.TranslateTo(0, e.TotalY, 100); break;
				case GestureStatus.Completed:
					await TranslateCardFrame(); break;
				case GestureStatus.Canceled:
					await TranslateCardFrame(); break;
			}
		}

		private async Task TranslateCardFrame()
		{
			if (CardFrame.TranslationY < 100)
				await CardFrame.TranslateTo(0, 0, 250);
			else
				await CardFrame.TranslateTo(0, 350, 250);
		}
	}
}
