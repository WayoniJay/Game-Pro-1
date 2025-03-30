using UnityEngine;
using UnityEngine.InputSystem;

namespace AG2189
{
    public class Item : MonoBehaviour
    {

        public string itemName;
        public GameObject itemPrefab;
        public string itemDescription = "";
        [SerializeField] private protected Key activationKey = Key.E;
        [SerializeField] protected bool hasDescription = false;

        private protected virtual void Start()
        {
            if (!string.IsNullOrEmpty(itemDescription))
            {
                hasDescription = true;
            }
        }

        internal virtual void Update()
        {
            if (Keyboard.current[activationKey].wasPressedThisFrame && hasDescription)
            {
                GetItemDescription();
            }
        }

        public virtual void GetItemDescription()
        {
            Debug.Log($"The {itemName}: {itemDescription}");
        }

        //public void SetDescriptionLevel(bool level)
        //{ 
        //	hasDescription = level;
        //}
    } 
} 

