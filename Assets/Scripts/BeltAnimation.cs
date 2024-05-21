using UnityEngine;

internal class BeltAnimation : MonoBehaviour
{
    #region Unity Callbacks

    private void Update()
    {
        if (ConveyorProperties.Instance.IsStarted)
        {
            float transition = Time.time * ConveyorProperties.Instance.BeltSpeed;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(transition, 0f);
        }
    }

    #endregion
}
