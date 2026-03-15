using UnityEngine;

public class TileMapGenerator
{
    public const int MAP_WIDTH = 10;
    public const int MAP_HEIGHT = 10;

    private ITile[] tileMap;
    private TileFactory tileFactory;

    public TileMapGenerator(TileFactory tileFactory)
    {
        this.tileFactory = tileFactory;
    }

    public void GenerateMap()
    {
        tileMap = new ITile[MAP_WIDTH * MAP_HEIGHT];

        for (int y = 0; y < MAP_HEIGHT; ++y)
        {
            for (int x = 0; x < MAP_WIDTH; ++x)
            {
                SetTile(x, y, tileFactory.CreateTile(x, y));
            }
        }
    }

    public ITile GetTile(int x, int y)
    {
        return tileMap[y * MAP_WIDTH + x];
    }

    private void SetTile(int x, int y, ITile tile)
    {
        tileMap[y * MAP_WIDTH + x] = tile;
    }
}
