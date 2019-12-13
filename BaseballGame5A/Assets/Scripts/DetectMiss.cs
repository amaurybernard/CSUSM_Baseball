using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectMiss : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerEnter (Collider other) {
        Lives.instance.lives -= 1;
        if (Lives.instance.lives <= 0)
            SceneManager.LoadScene ("GameOverScene");
        Destroy (other);
    }
}