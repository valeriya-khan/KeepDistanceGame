using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    // Start is called before the first frame update
    bool MoveAllowed;
    Collider2D col;
    

    private float sickNum;
    private float healthyNum;
    void Start()
    {
        
        col = GetComponent<Collider2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began){
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider){
                    MoveAllowed = true;
                }
            }
            if (touch.phase == TouchPhase.Moved){
                if(MoveAllowed){
                    transform.position = new Vector2(touchPosition.x,touchPosition.y);
                }
                
            }
            if (touch.phase == TouchPhase.Ended){
                MoveAllowed = false;
            }
        }
    }

    
}
