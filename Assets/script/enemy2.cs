using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public AudioSource audio;
    public GameObject player;
    public float speed;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Vector2 playerpos = player.transform.position;
        Vector2 pos = transform.position;
        direction = (playerpos - pos).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "underwall" || other.tag == "bullet")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "Player")
        {
            audio.Play();
            Gamemanager.instance.health -= 10;
            Destroy(gameObject);
        }
    }
}
