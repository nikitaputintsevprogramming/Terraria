using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


 
public class DestroyTiles1 : MonoBehaviour
{
    public Text BlockScore;
    
    public Tile GroundTile;
    public Tilemap tilemapLayer1;
    private int Block_Score = 0;
 
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        if (Input.GetMouseButtonDown(0))
        {
            Vector3Int selectedTile = tilemapLayer1.WorldToCell(pos);
            tilemapLayer1.SetTile(selectedTile, null);
            print (selectedTile);
            if (selectedTile != null)
            {
                Block_Score++;
                //print(Block_Score);
                BlockScore.text = Block_Score.ToString();
            }
                

        }
    }
}