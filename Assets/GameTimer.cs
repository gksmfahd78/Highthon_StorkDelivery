using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {


    public Text timerText;
    private float _gameTimer;
    private int minutsTime;

	void Start () {
        _gameTimer = 0f;
	}
	
	void Update () {
        timerText.text = string.Format("{0} : {1}", minutsTime, (int)_gameTimer);
        if (minutsTime >= 5)
        {
            UIManager.Instance.GameOver();
            return;
        }

        _gameTimer += Time.deltaTime;

        if(_gameTimer >= 60f)
        {
            minutsTime++;
            _gameTimer = 0f;
        }
    }
}
