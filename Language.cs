// Copyright Candra Agung Prasetyo yuyevon777@gmail.com 2019
// Credit my name if my code helped you

using UnityEngine;

namespace CAP
{
    public static class Language
    {
        [System.Serializable]
        private class TranslatedDictionary
        {
            public TranslatedWords[] Dictionary = null;
        }

        [System.Serializable]
        private class TranslatedWords
        {
            public string key = string.Empty;
            public string words = string.Empty;
        }
		
		private const string DefaultFileName = "Dictionary_";

        private static TranslatedDictionary LanguageDictionary = null;
        private static string CurrentLanguage = "INA";

        public static string DefaultLanguage { get; set; } = "INA";

        public static string Translate(string key)
        {
            string _result = string.Empty;

            if (LanguageDictionary == null || CurrentLanguage != DefaultLanguage)
            {
                CurrentLanguage = DefaultLanguage;

                if (Resources.Load(DefaultFileName + CurrentLanguage) != null)//
                {
                    LanguageDictionary = JsonUtility.FromJson<TranslatedDictionary>("{\"Dictionary\":" + Resources.Load(DefaultFileName + CurrentLanguage).ToString() + "}");
                }
                else
                {
                    LanguageDictionary = null;
                }
            }

            if (LanguageDictionary != null)
            {
                foreach (TranslatedWords item in LanguageDictionary.Dictionary)
                {
                    if (item.key == key)
                    {
                        _result = item.words;
                        break;
                    }
                }
            }

            if (_result == string.Empty)
            {
                _result = "[<color=red>" + key + "</color>][<color=red>" + CurrentLanguage + "</color>]";
#if UNITY_EDITOR
                Debug.LogError("[DBG] [Localization] [<color=red>Not Found</color>][" + key + "][" + CurrentLanguage + "]");
#endif
            }

            return _result;
        }
    }
}

