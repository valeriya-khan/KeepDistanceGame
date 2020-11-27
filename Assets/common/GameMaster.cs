using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject restartPanel;
    
    public GameObject menuPanel;
    // public float timer;
    public bool hasLost;

    // public bool Last;
    void Start(){
        // if(!Last){
        //     hasLost = gameObject.GetComponent<TimerNotLast>().hasLost;
        // }
        // else{
        //     hasLost = gameObject.GetComponent<TimerLast>().hasLost;
        // }
    }
    private void Update(){
        
    }
    public void GameOver(){
        hasLost = true;
        Time.timeScale = 0;
        restartPanel.SetActive(true);
    }
    public void GoToGameScene(){
        SceneManager.LoadScene("gameScene");
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("titleScene");
    }

    
    public void Menu(){
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }

    public void Continue(){
        Time.timeScale = 1;
        menuPanel.SetActive(false);
    }
}
