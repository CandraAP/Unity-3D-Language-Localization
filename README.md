# Unity-3D-Language-Localization
Make your game easier to support multiple languages


How to install:</br>
- put Language.cs inside your unity 3D project content. </br>
- Put Dictionary_INA.json & Dictionary_ENG.json inside Resources folder inside your unity project content, if there is no Resources folder available, you need to create it manually. </br>
- You can add your own custom language json file dictionary, just look at files Dictionary_INA.json & Dictionary_ENG.json for example.</br>
- Please remember to name your json file with this format "Dictionary_LanguageCode.json" , and use "LanguageCode" as code to call your language dictionary json file.</br>


How to use:</br>

private void Awake()
{ 
   CAP.Language.DefaultLanguage = "INA"; //Set your default language code

   string checkDefaultLanguage = CAP.Language.DefaultLanguage; //To get current language code

   string translatedWords = CAP.Language.Translate("C_LANG"); //put your key inside json file to get translated words
}


With this code you can easily support multiple language, without wasting time to create your own localization language manager.</br>

Credit my name if my code help your game.</br>
