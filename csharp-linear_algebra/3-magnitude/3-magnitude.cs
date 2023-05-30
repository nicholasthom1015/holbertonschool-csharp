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
        
        // Calculate the sum of squares of the vector components
        for (double component : vector) {
            sumOfSquares += component * component;
        }
        
        // Calculate the magnitude by taking the square root of the sum of squares
        double magnitude = Math.sqrt(sumOfSquares);
        
        // Round the magnitude to the nearest hundredth
        BigDecimal roundedMagnitude = new BigDecimal(magnitude).setScale(2, RoundingMode.HALF_UP);
        
        return roundedMagnitude.doubleValue();
    }
}