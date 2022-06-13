using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "My Tools/Custom Tiles/Ground Rule Tile")]
public class GroundRuleTile : RuleTile<GroundRuleTile.Neighbor> {
    [Header("Advanced Tile")]
    [Tooltip("If enabled, the tile will connect to these tiles too when the mode is set to \"This\"")]
    public bool alwaysConnect;

    [Tooltip("Tiles to connect to")]
    public TileBase[] grass;

    [Space]

    [Tooltip("Tiles to connect to")]
    public TileBase[] dirt;

    public bool checkSelf = true;
    
    public class Neighbor : RuleTile.TilingRule.Neighbor
    {
        public const int Grass = 3;
        public const int Dirt = 4;
    }
 
    public override bool RuleMatch(int neighbor, TileBase tile)
    {
        // Debug.Log(neighbor);
        // Debug.Log(tile);
        switch (neighbor)
        {
            case Neighbor.This: return CheckThis(tile);
            case Neighbor.NotThis: return CheckNotThis(tile);
            case Neighbor.Grass: return CheckGrass(tile);
            case Neighbor.Dirt: return CheckDirt(tile);
        }
        return base.RuleMatch(neighbor, tile);
    }

    bool CheckThis(TileBase tile)
    {
        if (!alwaysConnect) return tile == this;
        else return  (dirt.Contains(tile) || grass.Contains(tile)) || tile == this;
        //.Contains requires "using System.Linq;"
    }

    bool CheckNotThis(TileBase tile)
    {
        if (!alwaysConnect) return tile != this;
        else return !dirt.Contains(tile) && !grass.Contains(tile) && tile != this;
        //.contains requires "using system.linq;"
    }

    private bool CheckGrass(TileBase tile)
    {
        return grass.Contains(tile);
        // Debug.Log(tile == grass.Contains(tile));
        // if (checkSelf) return tile != null;
        // else return tile != null && tile != this && tile == grass.Contains(tile);
    }

    private bool CheckDirt(TileBase tile)
    {
        return dirt.Contains(tile);
        // if (checkSelf) return tile != null;
        // else return tile != null && tile != this && tile == dirt.Contains(tile);
    }
}

// public class GroundRuleTile : RuleTile<GroundRuleTile.Neighbor> {
//     public bool isSpecificTile;
 
//     public class Neighbor : RuleTile.TilingRule.Neighbor
//     {
//         public const int Grass = 3;
//         public const int Dirt = 4;
//     }
 
//     public override bool RuleMatch(int neighbor, TileBase tile)
//     {
//         var customRule = tile as GroundRuleTile;
//         switch (neighbor)
//         {
//             case Neighbor.Grass:
//                 return customRule && this.isSpecificTile == customRule.isSpecificTile;
//             case Neighbor.Dirt:
//                 return customRule && this.isSpecificTile != customRule.isSpecificTile;
//         }
//         return base.RuleMatch(neighbor, tile);
//     }
// }