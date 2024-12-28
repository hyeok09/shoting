using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public AudioSource audio;
    public float speed = 1;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wall")
        {
            gameObject.SetActive(false);
        }
        else if(other.tag == "enemy")
        {
            audio.Play();
            Gamemanager.instance.score++;
            gameObject.SetActive(false);
        }
    }

    void Shot()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
