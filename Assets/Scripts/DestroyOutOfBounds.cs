using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField] private float leftBound = -35f;
    [SerializeField] private float bottomBound = 5f;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log(message: "GAME OVER");
            Time.timeScale = 0;
        }
        
    }
}
