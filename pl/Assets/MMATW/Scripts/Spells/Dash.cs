using MMATW.Scripts.Player;
using MMATW.Scripts.Scriptable_objects;
using UnityEngine;

namespace MMATW.Scripts.Spells
{
    [CreateAssetMenu(menuName = "Spells/Dash", fileName = "New Dash Spell")]
    public class Dash : SpellObject
    {
        public override void Cast(Transform parent, Vector3 position, Vector3 direction)
        {
            var playerMovement = parent.GetComponent<PlayerMovement>();

            // This realization is kinda cringe, but i don't care and won't rewrite it. I'm already lost my mind.
            playerMovement.Dash();
        }
    }
}