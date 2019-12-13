using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    public float TimeToLive = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToLive -= Time.deltaTime;
        if(TimeToLive <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
