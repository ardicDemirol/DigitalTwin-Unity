using UnityEngine;

internal class RotationalMovement : MonoBehaviour
{
    #region Variables

    public float RPS = 60f;
    private Rigidbody rb;

    #endregion


    #region Unity Callbacks

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }




    private void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(0f, RPS * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    #endregion

}
