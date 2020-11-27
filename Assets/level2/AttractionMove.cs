using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AttractionMove : MonoBehaviour
{
    // Start is called before the first frame update

    // public float minSpeed;
    // public float maxSpeed;
    public float speed;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public Transform otherPerson;
    
    Vector2 targetPosition;
    // bool collided;
    void Start()
    {
        // targetPosition = otherPerson.position;
        // collided = false;
        targetPosition = (Vector2)otherPerson.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position == otherPerson.position){
        //     collided = true;
        // }
        // if (collided==false){
        //     targetPosition = otherPerson.position;
        // }else{
        //     targetPosition = GetRandomPosition();
        // }
        // targetPosition = GetRandomPosition();
        // transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if((Vector2)transform.position != targetPosition)
        {
            // speed = Mathf.Lerp(minSpeed,maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }
}
