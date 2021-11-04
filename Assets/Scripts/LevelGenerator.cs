using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    //private string spriteNames = "Wall_";
    //private SpriteRenderer spriteR;
    //private Sprite[] sprites;

    public GameObject closeGrid;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;
    public GameObject m6;
    public GameObject m7;

    float pY = 0f;
    float pZ = 0f;
    float x = -14.0f;
    float y = 14.0f;
    int[,] levelMap =
            {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };

    // Start is called before the first frame update
    void Start()
    {
        //spriteR = gameObject.GetComponent<SpriteRenderer>();
        //sprites = Resources.LoadAll<Sprite>(spriteNames);
        closeGrid.SetActive(false);
        drawLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void drawLevel()
    {

        //Vector3 position = new Vector3(x, y, 0f);
        for (int row = 0; row < levelMap.GetLength(0); row++)
        {
            
            for (int col = 0; col < levelMap.GetLength(1); col++)
            {
                switch (levelMap[row, col])
                {
                    // Case 0
                    case 0:
                        break;

                    // Case 1
                    case 1:
                        Instantiate(m1, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    // Case 2
                    case 2:
                        /*if (levelMap[row - 1, col] == 1 && pZ!= 90f)
                        {
                            Instantiate(m2, new Vector3(x, y, 90f), Quaternion.identity);
                            pZ = 90f;
                            break;
                        }
                        else if (pZ == 90f)
                        {
                            Instantiate(m2, new Vector3(x, y, 90f), Quaternion.identity);
                            break;
                        }
                        else
                        {*/
                            Instantiate(m2, new Vector3(x, y, 0f), Quaternion.identity);
                            break;
                        //}
                    // Case 3
                    case 3:
                        Instantiate(m3, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    // Case 4
                    case 4:
                        Instantiate(m4, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    // Case 5
                    case 5:
                        Instantiate(m5, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    // Case 6
                    case 6:
                        Instantiate(m6, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    // Case 7
                    case 7:
                        Instantiate(m7, new Vector3(x, y, 0f), Quaternion.identity);
                        break;

                    default:
                        break;
                }
                x = x + 1.0f;
            }
            y = y - 1.0f;
            x = -14.0f;
        }
    }
}
