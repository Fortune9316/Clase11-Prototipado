using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    // Use this for initialization
    public Button btnPlay;
	void Start () {
      
        StartCoroutine(saveDeviceData());

        btnPlay.onClick.AddListener(() => PlayGame());
	}
	
	// Update is called once per frame
    IEnumerator saveDeviceData()
    {
        WWWForm form = new WWWForm();
        form.AddField("uid", SystemInfo.deviceUniqueIdentifier);
        form.AddField("device_model", SystemInfo.deviceModel);
        form.AddField("device_name", SystemInfo.deviceName);
        WWW url = new WWW("https://prototipadoclase11-fortune9316.c9users.io/prueba/",form);
        yield return url;
        if(url.error == null)
        {
            print(url.text);
        }
        else
        {
            print(url.error);
        }
    }
	void Update () {
	
	}

    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
