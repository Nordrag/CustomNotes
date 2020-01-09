using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace CustomNotes
{
    public class SearchViewModel : ObservableObject
    {
        private Services Services = new Services();

		private ObservableCollection<CashDiffModel> mDiffModel = new ObservableCollection<CashDiffModel>();
		public ObservableCollection<CashDiffModel> DiffModel
		{
			get => mDiffModel;
			set
			{
				if (value != mDiffModel)
				{
					mDiffModel = value;
					OnPropertyChanged(nameof(DiffModel));
				}
			}
		}

		private ICommand mLoadCashDiff;

		public ICommand LoadCashDiff
		{
			get
			{
				if (mLoadCashDiff == null)
				{
					mLoadCashDiff = new RelayCommand(r => GetDifferences()); 
				}
				return mLoadCashDiff;
			}
			
		}

		private void GetDifferences()
		{
			DiffModel = Services.SearchService.GetDifferences();
		}
	}
}
