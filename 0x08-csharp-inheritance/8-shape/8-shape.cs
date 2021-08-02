using System;

///<summary> Shape Class </summary>
class Shape
{
    ///<summary> Public method Area</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary> Rectangle Class </summary>
class Rectangle : Shape
{
    private int _width;
    private int _height;
    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                _width = value;
            }
        }
    }

    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                _height = value;
            }
        }
    }
    ///<summary> Public method Area</summary>
    public new int Area()
    {
        return _width * _height;
    }

    public override string ToString()
    {
        return "[Rectangle] " + _width + " / " + _height;
    }
}

///<summary> Rectangle Class </summary>
class Square : Rectangle
{
    private int _size;
    public int Size
    {
        get
        {
            return _size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                Height = value;
                Width = value;
                _size = value;
            }
        }
    }
}