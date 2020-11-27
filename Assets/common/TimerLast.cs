using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerLast : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerDisplay;
    public float timer;
    bool hasLost;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hasLost = gameObject.GetComponent<GameMaster>().hasLost;
        if (!hasLost){
            timerDisplay.text = timer.ToString("F0");
        }
        if (timer<=0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }else{
            timer-=Time.deltaTime;
        }
    }
}
