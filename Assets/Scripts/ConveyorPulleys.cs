using UnityEngine;

internal class ConveyorPulleys : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject frontPulley;
    [SerializeField] private GameObject backPulley;

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
            frontPulley.transform.Rotate(Vector3.up, ConveyorProperties.Instance.PulleySpeed * Time.deltaTime);
            backPulley.transform.Rotate(Vector3.up, ConveyorProperties.Instance.PulleySpeed * Time.deltaTime);
        }

    }

    private void FixedUpdate()
    {

    }



    #endregion


    #region Other Methods



    #endregion




}
