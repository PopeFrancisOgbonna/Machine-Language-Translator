using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTranslator
{
    class AppCache
    {
        public static string api { get; } = @"https://www.dictionaryapi.com/api/v3/references/learners/json/{0}?key={1}";
        public static string key { get; } = @"8bb2389c-ba18-4591-9928-70d26044290d";
        public static string API { get; } = @"trnsl.1.1.20191108T080839Z.aef0afce81b80a92.6c5b982ac316cf5b0f422ecc11227fdc08b61657";
        public string URLgetLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&ui={1}";
        public  static string UrlDetect { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/detect?key={0}&text={1}";
        public string urlTranslate { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&langs={2}";
    }
}
