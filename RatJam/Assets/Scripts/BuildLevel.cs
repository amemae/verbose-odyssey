using UnityEngine;

public class BuildLevel : MonoBehaviour
{
    public GameObject TilePrefab;
    [SerializeField] private Sprite[] sprite;

    public int[,] Map;

    private void Start()
    {
        TileMapGenerator _tm = new TileMapGenerator(new TileFactory());
        _tm.GenerateMap();
        Map = new int[TileMapGenerator.MAP_WIDTH, TileMapGenerator.MAP_WIDTH];
        for (int y = 0; y < TileMapGenerator.MAP_HEIGHT; y++)
            for (int x = 0; x < TileMapGenerator.MAP_WIDTH; x++)
            {
                if (_tm.GetTile(x, y).TileType == TileType.Floor) Map[x, y] = 1;
                if (_tm.GetTile(x, y).TileType == TileType.Wall) Map[x, y] = 0;
            }
        DrawLevel(TileMapGenerator.MAP_WIDTH, TileMapGenerator.MAP_HEIGHT);
    }


    public void DrawLevel(int _sizeX, int _sizeY)
    {
        for (int y = 0; y < _sizeY; y++)
            for (int x = 0; x < _sizeX; x++)
            {
                {
                    GameObject _go = Instantiate(TilePrefab, new Vector3(x, -y, 0), Quaternion.identity, this.transform);
                    _go.GetComponent<SpriteRenderer>().sprite = sprite[Map[x, y]];
                }
            }
    }
}
