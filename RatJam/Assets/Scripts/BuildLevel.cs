using UnityEngine;

public class BuildLevel : MonoBehaviour
{
    public GameObject TilePrefab;
    [SerializeField] private Sprite[] sprite;




    //DEBUG
    public int[,] Map = {{ 0, 0, 0, 0, 0 },
                        { 0, 1, 1, 1, 0 },
                        { 0, 1, 1, 1, 0 },
                        { 0, 1, 1, 1, 0 },
                        { 0, 0, 0, 0, 0 } };
    private void Start()
    {
        Map[2, 1] = 0;
        DrawLevel(5, 5);
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
