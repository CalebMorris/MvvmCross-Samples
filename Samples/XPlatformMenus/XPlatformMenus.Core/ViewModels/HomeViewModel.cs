﻿namespace XPlatformMenus.Core.ViewModels
{
	public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel() 
        {
            Recycler = new RecyclerViewModel();
        }

        /// <summary>Gets the recycler.</summary>
        /// <value>The recycler.</value>
        public RecyclerViewModel Recycler { get; private set; }
    }
}