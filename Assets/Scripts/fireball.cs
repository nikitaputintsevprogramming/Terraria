using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public Transform dragon;
    public Transform WizardPos;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, WizardPos.position, Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.name == "Wizard")
        {
            gameObject.transform.position = dragon.position;
        }
        
    }

}
