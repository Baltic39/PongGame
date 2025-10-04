using UnityEngine;

public class ALLGates : MonoBehaviour
{
    protected Rigidbody2D _rigitbody;
    public float speed = 50.0f;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody2D>();
    }
}


