interface Area
{
	final static float pi=3.14f;
	float compute(float x,float y);
}
class Rectangle implements Area
{
	public float compute(float x,float y)
	{
		return(x*y);
	}
}
class Circle implements Area
{
	public float compute(float x,float y)
	{
		return(pi*x*x);
	}
}
class InterfaceTest
{
	public static void main(String args[])
	{
		Rectengle rect=new Rectengle();
		Circle cir=new Circle();
		float areaR=rect.compute(10,20);
		System.out.println("Area of Rectengle="+areaR);
		
		System.out.println("Area of Rectengle="+cir.compute(10,0));
	} 


}


	