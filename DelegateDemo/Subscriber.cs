namespace DelegateDemo;
// Method => return type => float
public delegate float MyDelegateSubs(int a, int b);
public class Subscriber
{
    public float Add(int a, int b){
        return a+b;
    }
    public float Mul(int a, int b){
        return a*b;
    }
}
