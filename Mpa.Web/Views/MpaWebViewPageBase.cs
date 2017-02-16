using Abp.Web.Mvc.Views;

namespace Mpa.Web.Views
{
    public abstract class MpaWebViewPageBase : MpaWebViewPageBase<dynamic>
    {

    }

    public abstract class MpaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MpaWebViewPageBase()
        {
            LocalizationSourceName = MpaConsts.LocalizationSourceName;
        }
    }
}