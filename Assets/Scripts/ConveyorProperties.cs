public class ConveyorProperties : MonoSingleton<ConveyorProperties>
{
    public bool IsStarted;
    public float PulleySpeed = 50f;
    public float BeltSpeed = 50f;
    public float ConveyorSpeed = 1f;
}
