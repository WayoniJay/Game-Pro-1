using UnityEngine;
using UnityEngine.InputSystem;

namespace AG2189
{
    public sealed class CollectableItem : WorldItem, ICollectible
    {

        public MeshRenderer objectMeshRenderer;
        public bool hasBeenCollected = false;

        private protected override void Start()
        {
            base.Start();
            objectMeshRenderer = GetComponent<MeshRenderer>();
        }

        internal override void Update()
        {
            base.Update();
            if (Keyboard.current[activationKey].wasPressedThisFrame)
            {
                if (!hasBeenCollected)
                {
                    hasBeenCollected = true;
                    Collect();
                }
                else
                {
                    hasBeenCollected = false;
                    Drop();
                }
            }
        }

        public override void GetItemDescription()
        {
            if (IsUserInside())
            {
                base.GetItemDescription();
                Debug.Log($"{name} / {itemName}: This is a collectible item");
                // You could implement a world space UI element that shows instructions for usage (how to pick up)
            }
        }

        public void Collect()
        {
            Debug.Log($"Collecting {itemName}");
            objectMeshRenderer.enabled = false;
            // TODO: Actually pick up the object or put it into character inventory (or library)
        }

        public void Drop()
        {
            Debug.Log($"Dropping {itemName}");
            objectMeshRenderer.enabled = true;
            // TODO: Actually drop the object back into the world or put it into an item object pool
        }
    } 
}

