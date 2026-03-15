using UnityEngine;

public class TileFactory : MonoBehaviour
{
    public ITile CreateTile(int x, int y)
    {
        if (x == 0 || y == 0 || x == TileMapGenerator.MAP_WIDTH - 1 || y == TileMapGenerator.MAP_HEIGHT - 1)
        {
            return new WallTile();
        }
        else
        {
            return new FloorTile();
        }
    }
}
