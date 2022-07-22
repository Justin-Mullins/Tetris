using UnityEngine;
using UnityEngine.Tilemaps;

public enum Piece
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z
}

[System.Serializable]
public struct PieceData
{
    public Piece piece;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.piece];
    }
}