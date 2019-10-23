using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int hitPoints = 10;
    public Text healthtext;
    public Slider healthSlider;
    public int lives = 10;

    private void Start()
    {
        healthtext.text = "Hit-Points: " + hitPoints;
        healthSlider.maxValue = hitPoints;
        healthSlider.value = hitPoints;
        //PlayerPrefs.SetInt("lives", lives);
        lives = PlayerPrefs.GetInt("lives");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            hitPoints--;
            healthtext.text = "Hit-Points: " + hitPoints;
            healthSlider.value = hitPoints;
            if (hitPoints < 1)
            {
                if(lives > 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                PlayerPrefs.SetInt("lives", lives - 1);
            }
            else
            {
                SceneManager.LoadScene("mainMenu");
            }
        }
    }
}
