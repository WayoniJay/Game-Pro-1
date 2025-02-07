using UnityEngine;

namespace AG2189
{
    public interface IRollable
    {
        void RollObject();

        float GetSideFacingTowardDirection(Vector3? direction = default);
    }
}