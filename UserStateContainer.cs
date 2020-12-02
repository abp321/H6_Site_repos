using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace H6_Site
{
    public class UserStateContainer
    {
        public UserModel CurrentUser { get; set; }

        public event Action OnUserChange;

        public void SetUser(UserModel NewUser)
        {
            CurrentUser = NewUser;
            OnUserChange?.Invoke();
        }

        public bool UserLoggedIn
        {
            get
            {
                if (CurrentUser == null || CurrentUser == default) return false;

                return CurrentUser?.UserName?.Length > 0 && CurrentUser?.UserPassword?.Length > 0;
            }
        }

        public MarkupString PanelProp => CurrentUser.Admin ? new MarkupString("block") : new MarkupString("none");
        public MarkupString LoginIcon => UserLoggedIn ? new MarkupString("oi oi-account-logout") : new MarkupString("oi oi-account-login");

        public List<ItemModel> BasketList = new List<ItemModel>();

    }
}
