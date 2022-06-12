using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "My Tools/Custom Tiles/Ground Rule Tile")]
public class GroundRuleTile : RuleTile<GroundRuleTile.Neighbor> {
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
        switch (neighbor)
        {
            case Neighbor.Grass: return CheckGrass(tile);
            case Neighbor.Dirt: return CheckDirt(tile);
        }
        return base.RuleMatch(neighbor, tile);
    }

    private bool CheckGrass(TileBase tile)
    {
        if (checkSelf) return tile != null;
        else return tile != null && tile != this && tile == grass.Contains(tile);
    }

    private bool CheckDirt(TileBase tile)
    {
        if (checkSelf) return tile != null;
        else return tile != null && tile != this && tile == dirt.Contains(tile);
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