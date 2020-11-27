using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEvent : MonoBehaviour
{
    // Start is called before the first frame update
    private GameMaster gm;
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private int HealthyNum;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
        // Debug.Log(HealthyNum.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag== "sick" && gameObject.tag == "healthy"){
            gameObject.tag = "sick";
            spriteRenderer.sprite = newSprite;
            HealthyNum = GameObject.FindGameObjectsWithTag("healthy").Length;
            // Debug.Log(HealthyNum.ToString());
            // Debug.Log(GameObject.FindGameObjectsWithTag("healthy").Length.ToString());
            if(HealthyNum==0){
                gm.GameOver();
                
            }
            // gm.GameOver();
        }
    }
}
