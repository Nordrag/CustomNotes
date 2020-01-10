using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace CustomNotes
{
    public class CustomViewModel : ObservableObject
    {
        public CustomViewModel()
        {
            Init();
        }

        private Services Services = new Services();
        public ObservableCollection<string> RelevanceList { get; set; }

        private ObservableCollection<string> mTagList;

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
