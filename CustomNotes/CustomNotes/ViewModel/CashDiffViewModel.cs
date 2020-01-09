using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CustomNotes
{
    public class CashDiffViewModel
    {
        private Services Services = new Services();

        public int Difference { get; set; }       

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
            Services.CashDiffServices.Add(new CashDiff 
            {
                Difference = Difference,
                PostedBy = ApplicationViewModel.CurrentUser
            });
            MessageBox.Show("done");
        }
    }
}
