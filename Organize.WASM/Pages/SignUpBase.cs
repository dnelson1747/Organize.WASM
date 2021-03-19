using GeneralUI.DropdownControl;
using Organize.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organize.WASM.Pages
{
    public class SignUpBase : SignBase
    {
        protected IList<DropdownItem<GenderTypeEnum>> GenderTypeDropdownItems { get; } = new List<DropdownItem<GenderTypeEnum>>();

        protected DropdownItem<GenderTypeEnum> SelectedGenderTypedropdownItem { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized(); 
            {
                base.OnInitialized();

                var male = new DropdownItem<GenderTypeEnum>
                {
                    ItemObject = GenderTypeEnum.Male,
                    DisplayText = "Male"
                };

                var female = new DropdownItem<GenderTypeEnum>
                {
                    ItemObject = GenderTypeEnum.Female,
                    DisplayText = "Female"
                };

                var neutral = new DropdownItem<GenderTypeEnum>
                {
                    ItemObject = GenderTypeEnum.Neutral,
                    DisplayText = "Others"
                };

                GenderTypeDropdownItems.Add(male);
                GenderTypeDropdownItems.Add(female);
                GenderTypeDropdownItems.Add(neutral);

                SelectedGenderTypedropdownItem = female;
            
            }

        }
    }
}
