using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour
{
    /*The food should be spawned within the borders, not outside. 
     * So I will also need a variable for each of the borders so that our Script knows their positions:
     */
    // Food Prefab
    public GameObject foodPrefab;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Use this for initialization
    void Start()
    {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 4);
    }
    /* the Spawn function that spawns one piece of food within the borders. 
     * At first I will choose the X axis position somewhere randomly between the left and right border. 
     * Then I will choose the y position randomly between the top and bottom border. 
     * Afterwards I will instantiate the food Prefab at that position:
     */

    // Spawn one piece of food
    void Spawn()
    {
        // x position between left & right border
        int x = (int)Random.Range(borderLeft.position.x,
                                  borderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y,
                                  borderTop.position.y);

        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }
}