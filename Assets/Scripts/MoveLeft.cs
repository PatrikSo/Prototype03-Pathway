using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); //finds Player in hierarchy and get's it's script
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) //we can use gameOver as it isn't private, it's public! 
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) //when they drop out of bounds
        {
            Destroy(gameObject);
        }
    }
}
