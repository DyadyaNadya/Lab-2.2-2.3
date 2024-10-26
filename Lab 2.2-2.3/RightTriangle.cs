public class RightTriangle
{
    protected double a;
    protected double b;

    public double A
    {
        get { return a; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("����� ������ ������ ���� ������������� ������.");
            }
            a = value;
        }
    }

    public double B
    {
        get { return b; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("����� ������ ������ ���� ������������� ������.");
            }
            b = value;
        }
    }

    // ����������� � �����������
    public RightTriangle(double a, double b)
    {
        A = a;
        B = b;
    }

    //����������� �� ���������
    public RightTriangle()
    {
        A = 2;
        B = 3;
    }
    // ����������� �����������
    public RightTriangle(RightTriangle other)
    {
        A = other.A + 2;
        B = other.B + 5;
    }

    // ����� ��� ���������� ������� ������������
    public double CalculateArea()
    {
        return (A * B) / 2;
    }

    //���������� ��������� ++
    public static RightTriangle operator ++(RightTriangle triangle)
    {
        return new RightTriangle(triangle.A * 2, triangle.B * 2);
    }

    //���������� ��������� --
    public static RightTriangle operator --(RightTriangle triangle)
    {
        return new RightTriangle(triangle.A / 2, triangle.B / 2);
    }

    public static explicit operator double(RightTriangle triangle)
    {
        return triangle.CalculateArea();
    }

    public static implicit operator bool(RightTriangle triangle)
    {
        return triangle.A > 0 && triangle.B > 0;
    }

    // �������� �������� ��� ��������� �������� �������������
    public static bool operator <=(RightTriangle t1, RightTriangle t2)
    {
        return t1.CalculateArea() <= t2.CalculateArea();
    }

    public static bool operator >=(RightTriangle t1, RightTriangle t2)
    {
        return t1.CalculateArea() >= t2.CalculateArea();
    }
    // ���������� ������ ToString
    public override string ToString()
    {
        return $"����� A: {A}, ����� B: {B}, �������: {CalculateArea()}";
    }
}




