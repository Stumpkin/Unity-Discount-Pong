using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip pain;
    private AudioSource sause;
    private float pitched = 1f;
    // Start is called before the first frame update
    void Start()
    {
        sause = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane")
        {
            return;
        }

        if (Test.faster > 5)
        {
            pitched += .2f;
            sause.pitch = pitched;
        }
        sause.PlayOneShot(pain, .5f);
   
    }
}
