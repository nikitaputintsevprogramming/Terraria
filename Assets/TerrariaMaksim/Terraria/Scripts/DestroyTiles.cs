// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Tilemaps;

// public class DestroyTiles : MonoBehaviour
// {
//     public Grid grid;
//     public Tilemap tilemap;
//     public Transform wizard;
    
//     void FunctionToGetRidOfTile()
//     {        

//     }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);        
//         // Vector3Int position = grid.WorldToCell(mousePos);
//         var position = map.WorldToCell(transform.position);

//         if(Input.GetMouseButtonDown(0))
//         {
//             tilemap.SetTile(position, null);
//         }
//     }
// }

using UnityEngine;
using UnityEngine.Tilemaps;
 
public class DestroyTiles : MonoBehaviour
{
    public Tile GroundTile;
    public Tilemap tilemapLayer1;
 
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        if (Input.GetMouseButtonDown(0))
        {
            Vector3Int selectedTile = tilemapLayer1.WorldToCell(pos);
            tilemapLayer1.SetTile(selectedTile, null);
        }
    }
}