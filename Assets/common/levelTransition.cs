using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToLevel1(){
        SceneManager.LoadScene("GameScene");
    }

    public void GoToLevel2(){
        SceneManager.LoadScene("level2");
    }
}
