using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    // Use this for initialization
    public Button btnPlay;
	void Start () {
        btnPlay.onClick.AddListener(() => PlayGame());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
