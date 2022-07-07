namespace Palindrome;

public class Ball
{
    private string _color;
    private int _size;
    private int _weight;
    private int _speed;
    private int _position;
    private int _direction;
    
    public Ball(string color, int size, int weight, int speed, int position, int direction)
    {
        _color = color;
        _size = size;
        _weight = weight;
        _speed = speed;
        _position = position;
        _direction = direction;
    }
    
    public void PlayBall()
    {
        if (_direction == 1)
        {
            _position += _speed;
        }
        else
        {
            _position -= _speed;
        }
    }
}