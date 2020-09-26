using UnityEngine;
using Vuforia;

public class NewBehaviourScript : MonoBehaviour
{
    public VirtualButtonBehaviour vbb;
    public Material model;

    private void Start()
    {
        vbb.RegisterOnButtonPressed(Pressed());
    }

    private System.Action<VirtualButtonBehaviour> Pressed()
    {
        model.color += new Color(0.1f, 0, 0);
        return null;
    }
}
