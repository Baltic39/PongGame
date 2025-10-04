using UnityEngine;

public class AIGgates : ALLGates
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigitbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y)
            {
                _rigitbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigitbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f)
            {
                _rigitbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
