using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.Components
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreditCard : Frame
	{
		private string _cardName;
		public string CardName
		{
			get => _cardName;
			set
			{
				_cardName = value;
				OnPropertyChanged(nameof(CardName));
			}
		}

		public CreditCard()
		{
			InitializeComponent();
			BindingContext = this;
		}
	}
}