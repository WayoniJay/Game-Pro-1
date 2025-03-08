using UnityEngine;
using UnityEngine.Events;

namespace AG2189
{
    public class TriggerArea : MonoBehaviour
    {

        [SerializeField] private bool isPlayerInside = false;
        [SerializeField] private UnityEvent triggeredStayEvent;
        [SerializeField] private UnityEvent triggeredExitEvent;

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && !isPlayerInside)
            {
                isPlayerInside = true;
                ChangeMyStatus();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && isPlayerInside)
            {
                isPlayerInside = false;
                ChangeMyStatus();
            }

        }


        private void ChangeMyStatus()
        {
            if (isPlayerInside)
            {
                print("Player is inside me!");
                triggeredStayEvent.Invoke();
            }
            else
            {
                print("Player has exited!");
                triggeredExitEvent.Invoke();
            }
        }
    } 
}

