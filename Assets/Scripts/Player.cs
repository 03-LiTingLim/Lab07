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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();

            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("wall"))
        {
           SceneManager.LoadScene("GameOver");
        }
        else if (collision.gameObject.tag.Equals("obstacle"))
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
