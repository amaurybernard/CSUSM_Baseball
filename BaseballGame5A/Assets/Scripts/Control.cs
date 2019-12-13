using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Control : MonoBehaviour
{
    // A Animator to select animation
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void back()
    {
        SceneManager.LoadScene("MenuScene");
    }

    // Update is called once per frame
    void Update()
    {

        // Play the Batter animation when press button
        // then reset
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Batter", true);
        }
        else
        {
            anim.SetBool("Batter", false);
        }
    }
}
