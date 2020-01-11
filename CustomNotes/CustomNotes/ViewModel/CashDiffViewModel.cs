using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CustomNotes
{
    public class CashDiffViewModel : ObservableObject
    {
        private Services Services = new Services();

        public CustomModel CustomModel { get; set; } = new CustomModel();

        public int Difference { get; set; }

        public CashDiffViewModel()
        {
            GetDifferences();
            //GetDiffAsync();
        }

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

        private ICommand mSubmit;

        public ICommand Submit
        {
            get
            {
                if (mSubmit == null)
                {
                    mSubmit = new RelayCommand(r => SubmitMethod());
                }
                return mSubmit;
            }
        }

        private void SubmitMethod()
        {
            if (Difference == 0)
            {
                GetDifferences();
            }
            Services.CashDiffServices.Add(new CashDiff 
            {
                Difference = Difference,
                PostedBy = ApplicationViewModel.CurrentUser
            });
            GetDifferences();
            //MessageBox.Show("done");
        }

        private void GetDifferences()
        {

            DiffModel = Services.SearchService.GetDifferences();
        }    
        
        /*
        private async void GetDiffAsync()
        {
            
            do
            {
               await GetDifferences();
            } while (true);
        }
        */
    }
}
