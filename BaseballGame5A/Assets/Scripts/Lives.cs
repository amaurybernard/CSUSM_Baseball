using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {
    public static Lives instance;
    public int lives = 3;
    Text livesText;
    // Start is called before the first frame update
    void Start () {
        livesText = GetComponent<Text> ();
        instance = this;
    }

    // Update is called once per frame
    void Update () {
        livesText.text = "Lives: " + lives;
    }
}