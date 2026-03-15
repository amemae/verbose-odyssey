using UnityEngine;

public class DoorTile : ITile
{
    private bool _isOpen = false;

    protected bool IsWalkable() => _isOpen;
}
