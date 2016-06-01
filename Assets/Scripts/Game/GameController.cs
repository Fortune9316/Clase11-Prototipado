using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    // Use this for initialization
    public Button share;
    public string TWITTER_INTENT = "http://twitter.com/intent/tweet";
    public string TWITTER_LANG = "en";
	void Start () {
        share.onClick.AddListener(() => shareTwitter());
	}

    void shareTwitter()
    {
        Application.OpenURL(TWITTER_INTENT + "?text=" + WWW.EscapeURL(":V") + "&amp;lang=" + WWW.EscapeURL(TWITTER_LANG));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
