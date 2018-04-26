using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CoreCMS.Localization
{
    public static class CoreCMSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CoreCMSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CoreCMSLocalizationConfigurer).GetAssembly(),
                        "CoreCMS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
