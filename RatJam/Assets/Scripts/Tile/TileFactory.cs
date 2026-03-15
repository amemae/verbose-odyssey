using UnityEngine;

<<<<<<< HEAD
public class TileFactory
=======
public class TileFactory : MonoBehaviour
>>>>>>> c7854168294e829612b039cb2d9ae32b9aa3704a
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
