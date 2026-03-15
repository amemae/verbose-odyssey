using UnityEngine;

public class TileMapGenerator
{
    private const int MAP_WIDTH = 10;
    private const int MAP_HEIGHT = 10;

    private ITile[] tileMap;

    public void GenerateMap()
    {
        tileMap = new ITile[MAP_WIDTH * MAP_HEIGHT];

        for (int y = 0; y < MAP_HEIGHT; ++y)
        {
            for (int x = 0; x < MAP_WIDTH; ++x)
            {
                ITile currTile = GenerateTile(x, y);
                SetTile(x, y, currTile);
            }
        }
    }

    private ITile GenerateTile(int x, int y)
    {
        if (x == 0 || y == 0 || x == MAP_WIDTH - 1 || y == MAP_HEIGHT - 1)
        {
            return new WallTile();
        }
        else
        {
            return new FloorTile();
        }
    }

    private ITile GetTile(int x, int y)
    {
        return tileMap[y * MAP_WIDTH + x];
    }

    private void SetTile(int x, int y, ITile tile)
    {
        tileMap[y * MAP_WIDTH + x] = tile;
    }
}
