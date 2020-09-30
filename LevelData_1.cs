using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData_1 : MonoBehaviour
{
    public Tile[] red;
    public Tile[] blue;
    public Tile[] orange;
    public Tile[] green;
    public Tile[] white;
    public Tile[] yellow;

    public Tile.Colour[] Red_Tile;
    public Tile.Colour[] Blue_Tile;
    public Tile.Colour[] Orange_Tile;
    public Tile.Colour[] Green_Tile;
    public Tile.Colour[] White_Tile;
    public Tile.Colour[] Yellow_Tile;

    void Start()
    {
        GM.isInitiation = true;

        for (int i=0; i<9; i++)
        {
            red[i].InitializeTile(Red_Tile[i], GM.Face.Red);
            blue[i].InitializeTile(Blue_Tile[i], GM.Face.Blue);
            orange[i].InitializeTile(Orange_Tile[i], GM.Face.Orange);
            green[i].InitializeTile(Green_Tile[i], GM.Face.Green);
            white[i].InitializeTile(White_Tile[i], GM.Face.White);
            yellow[i].InitializeTile(Yellow_Tile[i], GM.Face.Yellow);
        }
    }

    public GameObject[] critTile;



    private void Update()
    {
        if (critTile[0].transform.GetChild(1) != null && critTile[0].transform.GetChild(1).tag == "Green" &&
            critTile[1].transform.GetChild(1) != null && critTile[1].transform.GetChild(1).tag == "Red" &&
            critTile[2].transform.GetChild(1) != null && critTile[2].transform.GetChild(1).tag == "Blue" &&
            critTile[3].transform.GetChild(1) != null && critTile[3].transform.GetChild(1).tag == "Orange"
            )
            GM.gameWin = true;
    }

}
