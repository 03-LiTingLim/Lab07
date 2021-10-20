using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
                                       Mathf.Clamp(transform.position.y, -3f, 3f),
                                        transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();
    }
}
