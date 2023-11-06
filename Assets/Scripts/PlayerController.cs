using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private GameObject Dog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootDog();
        }

    }

    private void ShootDog()
    {
        Instantiate(Dog, transform.position, Quaternion.Euler(0, 270, 0));
    }
}
