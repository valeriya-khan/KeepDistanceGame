using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleGameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToGameScene(){
        SceneManager.LoadScene("gameScene");
    }

}
