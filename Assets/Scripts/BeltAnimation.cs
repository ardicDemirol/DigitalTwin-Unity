using UnityEngine;

internal class BeltAnimation : MonoBehaviour
{
    #region Variables

    #endregion


    #region Unity Callbacks

    private void Awake()
    {

    }


    private void Start()
    {

    }


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
