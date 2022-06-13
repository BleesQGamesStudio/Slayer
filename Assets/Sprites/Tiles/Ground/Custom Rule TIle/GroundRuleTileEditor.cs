using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEngine;

namespace UnityEditor
{
    [CustomEditor(typeof(GroundRuleTile))]
    [CanEditMultipleObjects]
    public class GroundRuleTileEditor : RuleTileEditor
    {
        public Texture2D Grass;
        public Texture2D Dirt;

        public override void RuleOnGUI(Rect rect, Vector3Int position, int neighbor)
        {
            switch (neighbor)
            {
                case GroundRuleTile.Neighbor.Grass:
                    GUI.DrawTexture(rect, Grass);
                    return;
                case GroundRuleTile.Neighbor.Dirt:
                    GUI.DrawTexture(rect, Dirt);
                    return;
            }

            base.RuleOnGUI(rect, position, neighbor);
        }
    }
}
#endif
