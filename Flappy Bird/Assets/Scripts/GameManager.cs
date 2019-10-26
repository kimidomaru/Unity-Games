using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start() {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void gameOver() {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay(){
        SceneManager.LoadScene(0);
    }
}
