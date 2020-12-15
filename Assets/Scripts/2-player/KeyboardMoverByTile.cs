using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile: KeyboardMover {
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileBase tile = null;

    private TileBase TileOnPosition(Vector3 worldPosition) {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    IEnumerator Func(Vector3 pos)
    {
        //Waiting one second to carve in the mountain
        yield return new WaitForSecondsRealtime(1);
        //Replace the tile from mountain to grass
        Vector3Int cellPosition = tilemap.WorldToCell(pos);
        tilemap.SetTile(cellPosition, tile);
    }

    void Update()  {
        Vector3 newPositionX = NewPositionX();
        TileBase tileOnNewXPosition = TileOnPosition(newPositionX);
        if(tileOnNewXPosition.name == "mountains")
        {
            StartCoroutine(Func(newPositionX));
        }
        Vector3 newPosition = NewPosition();
        TileBase tileOnNewPosition = TileOnPosition(newPosition);
        if (allowedTiles.Contain(tileOnNewPosition)) {
            transform.position = newPosition;
        } else {
            Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
        }
    }
}
