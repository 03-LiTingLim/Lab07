using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float speed;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();
        transform.position += new Vector3(0, 2, 0) * Time.deltaTime;
    
    }
}
