public class Rectangle
{
    private float[] leftCorner; //левый НИЖНИЙ угол
    private float lengthRec, widthRec;

    private float left, right, top, bottom;

    public float Left {
        get {
            return left;
        }
    }
    public float Right {
        get {
            return right;
        }
    }

    public float Top {
        get {
            return top;
        }
    }

    public float Bottom {
        get {
            return bottom;
        }
    }

    public Rectangle(float xLeftCorner, float yLeftCorner, float length, float width) {
        leftCorner = new float[] { xLeftCorner, yLeftCorner};
        lengthRec = length;
        widthRec = width;

        left = xLeftCorner;
        bottom = yLeftCorner;
        right = xLeftCorner + length;
        top = yLeftCorner + width;
    }
}

public class IntersectionRectangles 
{
    private float s;
    float GetSIntersection(Rectangle firstRec, Rectangle secondRec) { //Метод для вычисления площади пересечения прямоугольников

        float xIntersection = GetIntersectionSegment(firstRec.Left, firstRec.Right, secondRec.Left, secondRec.Right); //вычисляем пересечение отрезков по оси X
        float yIntersection = GetIntersectionSegment(firstRec.Bottom, firstRec.Top, secondRec.Bottom, secondRec.Top); //вычисляем пересечение отрезковы по оси Y

        s=xIntersection * yIntersection;
        return s;
    }

    float GetIntersectionSegment(float start1, float end1, float start2, float end2) {//Метод для вычисления пересечения отрезков
        float segmentIntersection = 0;

        float start = start1 > start2 ? start1 : start2;
        float end = end1 < end2 ? end1 : end2;

        segmentIntersection = (end - start) > 0 ? (end - start) : 0;
        return segmentIntersection;
    }
}
