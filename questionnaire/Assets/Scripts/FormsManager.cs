using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormsManager : MonoBehaviour {
    public GameObject ConsentForm;
    public GameObject SurveyForm;
    public GameObject NoInternetSign;
    public GameObject Messages;

    public enum FormType
    {
        Consent,
        Survey,
        NoInternet,
        Messages
    }

    void Start() {
        ConsentForm.SetActive(false);

        // check internet
        StartCoroutine(CheckInternet());
    }

    
    void Update() {

    }

    public void ShowForm(FormType form, bool active)
    {
        switch (form)
        {
            case FormType.Consent:
                ConsentForm.SetActive(active);
                break;
            case FormType.Survey:
                SurveyForm.SetActive(active);
                break;
            case FormType.NoInternet:
                NoInternetSign.SetActive(active);
                break;
            case FormType.Messages:
                Messages.SetActive(active);
                break;
        }
    }

    public void ShowMessage(string title, string desc)
    {
        ShowForm(FormType.Messages, true);
        Messages.transform.GetChild(1).GetComponent<Text>().text = title;
        Messages.transform.GetChild(2).GetComponent<Text>().text = desc;
    }

    void _checkInternet()
    {
        StartCoroutine(checkInternetConnection((isConnected) => {
            has_internet = isConnected;

            // handle connection status here
            if (!has_internet)
            {
                // make internet message visible
                ShowForm(FormType.NoInternet, true);
            }
            else
            {
                ShowForm(FormType.NoInternet, false);
            }
        }));
    }

    IEnumerator checkInternetConnection(Action<bool> action)
    {
        WWW www = new WWW("http://google.com");
        yield return www;
        if (www.error != null)
        {
            action(false);
        }
        else
        {
            action(true);
        }
    }

    bool has_internet = false;
    IEnumerator CheckInternet()
    {
        // check for internet every three seconds
        // stop checking, once connection is established
        while (!has_internet)
        {
            _checkInternet();
            yield return new WaitForSeconds(3.0f);
        }

    }
}
