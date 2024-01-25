using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainingJan.Components.Pages.modul5
{
    public class BooststrapFixFieldClassCSSprovider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            bool IsInValid=editContext.GetValidationMessages(fieldIdentifier).Any();
            return IsInValid?"is-invalid": "is-valid";
        }
    }
}
