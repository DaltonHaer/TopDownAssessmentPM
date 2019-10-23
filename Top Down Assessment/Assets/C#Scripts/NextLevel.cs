using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OncollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Objective")
        {
            SceneManager.LoadScene("Level-2");
        }

    }
}