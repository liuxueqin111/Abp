using System;
using System.Collections.Generic;
using System.Text;
using my.bookstore.Localization;
using Volo.Abp.Application.Services;

namespace my.bookstore
{
    /* Inherit your application services from this class.
     */
    public abstract class bookstoreAppService : ApplicationService
    {
        protected bookstoreAppService()
        {
            LocalizationResource = typeof(bookstoreResource);
        }
    }
}
