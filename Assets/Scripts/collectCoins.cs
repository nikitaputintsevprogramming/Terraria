using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectCoins : MonoBehaviour
{
    public Text TitleScore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool OnCollisionEnter2D()
    {
        score++;
        TitleScore.text = score.ToString();
        gameObject.transform.position=new Vector2(Random.Range(-3.0f,3.51f),Random.Range(0.0f,1.7f));
        //gameObject.SetActive(false);
        return true;
    }
}
