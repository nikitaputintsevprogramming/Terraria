using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon_movement : MonoBehaviour
{
    public Transform Target; //позиция цели
	public float Speed; // скорость движения

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(2.0f,0.7f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Target.position = new Vector2(Target.position.x, Target.position.y);
			Speed += 0.08f;
			float step = Speed * Time.deltaTime; // скорость * время между кадрами
			transform.position = Vector3.MoveTowards (transform.position, Target.position, step); 
		
        
        // while(true)
        // {
        //     for(float pos=0.6f;pos<=2.1f;pos = pos + 0.01f)
        //     {
        //         transform.position = new Vector2(2.0f,pos);
        //     }
        //     for(float pos=2.1f;pos>=0.6f;pos = pos - 0.01f)
        //     {
        //         transform.position = new Vector2(2.0f,pos);
        //     }
            
        // }
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.name == "Wizard")
        {
            Application.LoadLevel(0);
        }
        
    }
}
