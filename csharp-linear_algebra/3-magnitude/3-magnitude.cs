import java.math.BigDecimal;
import java.math.RoundingMode;

public class VectorMath {
    public static double Magnitude(double[] vector) {
        int dimensions = vector.length;
        
        // Check if the vector is 2D or 3D
        if (dimensions != 2 && dimensions != 3) {
            return -1;
        }
        
        double sumOfSquares = 0;