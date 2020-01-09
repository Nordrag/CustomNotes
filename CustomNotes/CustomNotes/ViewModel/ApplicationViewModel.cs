﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CustomNotes
{
    public class ApplicationViewModel : ObservableObject
    {
		private int mCurrentPage = 0;
		public static string CurrentUser = "Porg";
		public int CurrentPage
		{
			get { return mCurrentPage; }
			set
			{
				if (value != mCurrentPage)
				{
					mCurrentPage = value;
					OnPropertyChanged(nameof(CurrentPage));
				}
			}
		}

		private int mSideMenuWidth = 0;

		public int SideMenuWidth
		{
			get { return mSideMenuWidth; }
			set
			{
				if (value != mSideMenuWidth)
				{
					mSideMenuWidth = value;
					OnPropertyChanged(nameof(SideMenuWidth));
				}
			}
		}

		private ICommand mNewCashDiff;

		public ICommand NewCashDiff
		{
			get
			{
				if (mNewCashDiff == null)
				{
					mNewCashDiff = new RelayCommand(r => ChangeView(1));
				}
				return mNewCashDiff;
			}
			
		}

		private ICommand mNewCustom;

		public ICommand NewCustom
		{
			get
			{
				if (mNewCustom == null)
				{
					mNewCustom = new RelayCommand(r => ChangeView(2));
				}
				return mNewCustom;
			}
			
		}

		private ICommand mSearch;

		public ICommand Search
		{
			get
			{
				if (mSearch == null)
				{
					mSearch = new RelayCommand(r => ChangeView(3));
				}
				return mSearch;
			}
		}

		public CashDiffViewModel CashDiff { get; set; } = new CashDiffViewModel();
		public SearchViewModel SearchViewModel { get; set; } = new SearchViewModel();

		private void ChangeView(int target)
		{
			CurrentPage = target;
		}
	}
}
