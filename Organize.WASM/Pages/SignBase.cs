using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Organize.WASM.Pages
{
    public class SignBase : ComponentBase
    {
        //protected string Username { get; set; } = "Dave";
        protected User User { get; set; } = new User();

        protected EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            EditContext = new EditContext(User);
        }

        public string GetError(Expression<Func<object>> fu)
        {
            if (EditContext == null)
            {
                return null;
            }
            return EditContext.GetValidationMessages(fu).FirstOrDefault();
        }

        //protected void HandleUserNameChanged(ChangeEventArgs eventArgs)
        //{
        //    Username = eventArgs.Value.ToString();
        //}

        //protected void HandleUserNameValueChanged(string value)
        //{
        //    Username = value;
        //}
    }
}
