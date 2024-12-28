using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int gamestats = 1;
    public Text scoretext;
    public Slider healthslider;
    public int score = 0;
    public float health = 100;
    public static Gamemanager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        healthslider.value = health / 100;
        if(health <= 0)
        {
            Time.timeScale = 0;
            gamestats = 0;
        }

        if(Input.GetKey(KeyCode.Mouse0) && gamestats == 0)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
