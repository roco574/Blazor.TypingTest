using System;
namespace Blazor.TypingTest.Helpers
{
	public static class DictionaryHelper
	{
		public static List<string> ComplexWords = new List<string>() { "aberration", "behoove", "candid", "dormant", "elusive", "feisty", "grateful", "hazardous", "impetuous", "jovial", "keen", "lucid", "meander", "nebulous", "omnipotent", "pensive", "quaint", "resilient", "surreal", "taciturn", "ubiquitous", "verbose", "wistful", "xylophone", "yielding", "zealot", "altruistic", "benevolent", "cacophonous", "diligent", "ebullient", "fervent", "gregarious", "histrionic", "inquisitive", "jocular", "kinesthetic", "laconic", "meticulous", "nonchalant", "omniscient", "perfunctory", "quizzical", "rhetorical", "sardonic", "tremulous", "unpretentious", "vexing", "wily", "xenophobic", "yearning", "zany", "amiable", "benign", "caustic", "derisive", "ebullience", "fastidious", "gregariousness", "hackneyed", "incendiary", "juxtaposed", "kaleidoscopic", "loquacious", "myriad", "nonplussed", "opulent", "pithy", "querulous", "recondite", "soporific", "tenuous", "unassailable", "vivacious", "wary", "xenial", "yearly", "zenith", "amorphous", "bucolic", "complacent", "delineate", "ebulliently", "facetious", "grandiose", "hegemony", "iconoclast", "judicious", "knavery", "lugubrious", "magnanimous", "nonentity", "opprobrious", "panacea", "quagmire", "reiterate", "spurious", "tirade", "unbridled", "vitriolic", "wizened", "xeric", "yore", "zeitgeist" };

        public static List<string> Shuffle(List<string> dictionary)
        {
            var random = new Random();
            int n = dictionary.Count;

            while (n > 1)
            {
                n--;
                var k = random.Next(n + 1);
                var value = dictionary[k];
                dictionary[k] = dictionary[n];
                dictionary[n] = value;
            }
            return dictionary;
        }
    }
}