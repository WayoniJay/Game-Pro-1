using UnityEngine;
using UnityEngine.InputSystem;

namespace AG2189
{
    public class WorldItem : Item, IInteractable
    {
        [SerializeField] private SphereCollider interactionArea;
        public float interactionAreaRadius = 2.0f;
        public LayerMask whoCanUse;

        private protected override void Start()
        {
            base.Start();
            SetUpTriggerArea();
        }

        internal override void Update()
        {
            base.Update();
            if (Keyboard.current[activationKey].wasPressedThisFrame)
            {
                Interact();
            }
        }

        public override void GetItemDescription()
        {
            if (IsUserInside())
            {
                base.GetItemDescription();
                Debug.Log($"{name} / {itemName}: This is a world item");
                // You could implement a wolrd space UI element that shows the item description
            }
        }

        internal bool IsUserInside()
        {
            return Physics.CheckSphere(transform.position, interactionAreaRadius, whoCanUse);
        }

        public void Interact()
        {
            if (IsUserInside())
            {
                Debug.Log($"Interacting with {itemName}");
            }
        }

        private void SetUpTriggerArea()
        {
            interactionArea = gameObject.AddComponent<SphereCollider>();
            interactionArea.isTrigger = true;
            interactionArea.radius = interactionAreaRadius;
        }
    } 
} 

