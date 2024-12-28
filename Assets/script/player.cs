using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public AudioSource audio;
    public int bulletcount = 10;
    public GameObject bulletp;
    public List<GameObject> bullet;
    public float cooltime = 1;
    public float ct = 0;
    // Start is called before the first frame update
    void Start()
    {
        bullet = new List<GameObject>();
        for(int i = 0; i < bulletcount; i++)
        {
            bullet.Add(Instantiate(bulletp));
            bullet[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 viewmouse = Camera.main.ScreenToViewportPoint(mouse);
            if (viewmouse.x < 0f) viewmouse.x = 0f;
            if (viewmouse.y < 0f) viewmouse.y = 0f;
            if (viewmouse.x > 1f) viewmouse.x = 1f;
            if (viewmouse.y > 1f) viewmouse.y = 1f;
            Vector3 mousepos = Camera.main.ViewportToWorldPoint(viewmouse);
            transform.position = mousepos;
        }
        if(Input.GetKey(KeyCode.Space) && ct <= 0)
        {
            Shot();
            ct = cooltime;
        }
        ct -= Time.deltaTime;
    }

    int bulletindex = 0;
    void Shot()
    {
        audio.Play();
        bullet[bulletindex].SetActive(true);
        bullet[bulletindex].transform.position = transform.position;
        if (bulletindex < bulletcount-1)
        {
            bulletindex++;
        }
        else
        {
            bulletindex = 0;
        }
    }
}