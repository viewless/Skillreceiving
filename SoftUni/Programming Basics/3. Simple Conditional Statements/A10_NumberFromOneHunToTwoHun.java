import java.util.Scanner;

public class A10_NumberFromOneHunToTwoHun {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);

        int num = Integer.parseInt(Console.nextLine());

        if (num < 100){
            System.out.println("Less than 100");
        }
        else if (num >= 100 && num <= 200){
            System.out.println("Between 100 and 200");
        }
        else if (num > 200){
            System.out.println("Greater than 200");
        }
    }
}
