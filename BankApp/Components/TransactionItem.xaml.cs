using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.Components
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransactionItem : FlexLayout
	{

		private string _name;
		private string _icon;

		public string Name
		{
			get => _name;
			set
			{
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public string Icon
		{
			get => _icon;
			set
			{
				_icon = value;
				OnPropertyChanged(nameof(Icon));
			}
		}

		public TransactionItem()
		{
			InitializeComponent();
			BindingContext = this;
		}
	}
}