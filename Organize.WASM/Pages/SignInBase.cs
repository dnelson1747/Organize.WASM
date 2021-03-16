using Microsoft.AspNetCore.Components;
using Organize.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organize.WASM.Pages
{
    public class SignInBase : ComponentBase
    {

        protected string Day { get; } = DateTime.Now.DayOfWeek.ToString();
        protected string Username { get; set; } = "Dave";
        protected User User { get; set; } = new User();

        protected void HandleUserNameChanged(ChangeEventArgs eventArgs)
        {
            Username = eventArgs.Value.ToString();
        }

        protected void HandleUserNameValueChanged(string value)
        {
            Username = value;
        }

    }
}

