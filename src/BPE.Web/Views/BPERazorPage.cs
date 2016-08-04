using Abp.AspNetCore.Mvc.Views;

namespace BPE.Web.Views
{
    public abstract class BPERazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BPERazorPage()
        {
            LocalizationSourceName = BPEConsts.LocalizationSourceName;
        }
    }
}
