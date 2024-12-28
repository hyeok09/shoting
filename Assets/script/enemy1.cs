using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public AudioSource audio;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "underwall" || other.tag == "bullet")
        {
            Destroy(gameObject);
        }
        else if(other.tag == "Player")
        {
            audio.Play();
            Gamemanager.instance.health -= 10;
            Destroy(gameObject);
        }
    }
}
