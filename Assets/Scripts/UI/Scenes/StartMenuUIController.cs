using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;



public class StartMenuUIController : MonoBehaviour
{

    private void Awake() {
        StartCoroutine(SetLocale(2));
    }

    IEnumerator SetLocale(int localeId)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeId];
    }
}
