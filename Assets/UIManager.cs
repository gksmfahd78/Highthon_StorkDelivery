using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public static UIManager Instance;

    public GameObject gameover;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    public void GameOver()
    {
        gameover.SetActive(true);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
