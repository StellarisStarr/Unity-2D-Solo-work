using UnityEngine;
using UnityEngine.Tilemaps;


public class GameBoardManager : MonoBehaviour
{
    private Tilemap tilemap;
    public int Width;
    public int Height;

    public Tile[] GroundTiles;
    public Tile[] WallTiles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tilemap = GetComponentInChildren<Tilemap>();

        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Tile tile;
                
                if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                {
                    tile = WallTiles[Random.Range(0, WallTiles.Length)];
                }
                else
                {
                    tile = GroundTiles[Random.Range(0, GroundTiles.Length)];
                }
                tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }
    }

  
}
