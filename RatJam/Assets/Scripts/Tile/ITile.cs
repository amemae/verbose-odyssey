using UnityEngine;

public interface ITile
{
    TileType TileType { get => throw new System.NotImplementedException(); }
    int TileSpriteIndex { get => throw new System.NotImplementedException(); }
    protected virtual bool IsWalkable()
    {
        throw new System.NotImplementedException();
    }
}