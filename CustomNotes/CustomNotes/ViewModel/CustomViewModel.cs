using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CustomNotes
{
    public class CustomViewModel : ObservableObject
    {
        public CustomViewModel()
        {
            Init();
        }

        #region properties

        public string NewCustomTag { get; set; }

        private Services Services = new Services();
        public ObservableCollection<string> RelevanceList { get; set; }

        private ObservableCollection<string> mTagList;

        public CustomModel CustomModel { get; set; } = new CustomModel();

        public ObservableCollection<string> TagList
        {
            get => mTagList;
            set
            {
                if (value != mTagList)
                {
                    mTagList = value;
                    OnPropertyChanged(nameof(TagList));
                }
            }
        }
        #endregion

        private ICommand mSubmitCommand;

        public ICommand SubmitCommand
        {
            get
            {
                if (mSubmitCommand == null)
                {
                    mSubmitCommand = new RelayCommand(r => SubmitMethod());
                }
                return mSubmitCommand;
            }
            
        }

        private void SubmitMethod()
        {
            if (!String.IsNullOrEmpty(NewCustomTag))
            {
                Services.CustomService.AddCustom(new CustomTable
                {
                    PostedBy = ApplicationViewModel.CurrentUser,
                    Description = CustomModel.Description,
                    Title = CustomModel.Title,
                    Relevance = CustomModel.Relevance,
                    Tags = new CustomTag { Tag = NewCustomTag }
                });
            }
            else
            {
                Services.CustomService.AddCustom(new CustomTable
                {
                    PostedBy = ApplicationViewModel.CurrentUser,
                    Description = CustomModel.Description,
                    Title = CustomModel.Title,
                    Relevance = CustomModel.Relevance,
                    Tags = new CustomTag { Tag = CustomModel.Tag }
                });
            }
           
        }

        private void Init()
        {
            if (Services.Context.CustomTag.Count() == 0)
            {
                Services.CustomService.AddTag(new CustomTag 
                {
                    Tag ="Rendelések",                   
                });
                Services.CustomService.AddTag(new CustomTag
                {
                    Tag = "Készlet Eltérés",
                });
                Services.CustomService.AddTag(new CustomTag
                {
                    Tag = "Garanciális dolgok",
                });
                Services.CustomService.AddTag(new CustomTag
                {
                    Tag = "Emlékeztetőnek",
                });
            }
            RelevanceList = new ObservableCollection<string>();
            RelevanceList.Add("Új");
            RelevanceList.Add("Folyamatban");
            RelevanceList.Add("Kész");
            mTagList = new ObservableCollection<string>();
            mTagList = Services.SearchService.GetTags();
        }
    }
}
