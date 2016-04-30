using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Data;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Localization;
using Nop.Data;
using Nop.Services.Events;
using Nop.Services.Logging;

namespace Nop.Services.Localization
{
    public class ExtendedLocalizationService : LocalizationService
    {
        public ExtendedLocalizationService(ICacheManager cacheManager, ILogger logger, IWorkContext workContext, IRepository<LocaleStringResource> lsrRepository, ILanguageService languageService, IDataProvider dataProvider, IDbContext dbContext, CommonSettings commonSettings, LocalizationSettings localizationSettings, IEventPublisher eventPublisher) : base(cacheManager, logger, workContext, lsrRepository, languageService, dataProvider, dbContext, commonSettings, localizationSettings, eventPublisher)
        {
        }

        public override string GetResource(string resourceKey, int languageId, bool logIfNotFound = true, string defaultValue = "",
            bool returnEmptyIfNotFound = false)
        {
            if (this.WorkContext.IsAdmin)
            {
                languageId = 1;
            }
            return base.GetResource(resourceKey, languageId, logIfNotFound, defaultValue, returnEmptyIfNotFound);
        }
    }
}
