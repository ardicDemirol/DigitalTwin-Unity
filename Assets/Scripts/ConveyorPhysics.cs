using UnityEngine;

internal class ConveyorPhysics : MonoBehaviour
{
    #region Variables

    Rigidbody rb;
    #endregion


    #region Unity Callbacks

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (ConveyorProperties.Instance.IsStarted)
        {
            Vector3 pos = rb.position;
            rb.position += ConveyorProperties.Instance.ConveyorSpeed * Time.fixedDeltaTime * Vector3.right;
            rb.MovePosition(pos);
        }
    }

    #endregion



}
