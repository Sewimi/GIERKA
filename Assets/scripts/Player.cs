using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float movementX;
    private float movementY;
    private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = new Vector3(movementX, 0,movementY);

        transform.Translate(movementDirection*movementSpeed*Time.deltaTime,Space.World);

        
       
    }

}
