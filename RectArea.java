class Rectengle
{
	int length,width;
	void getData(int x,int y)
	{
		length=x;
		width=y;
	}	
	int rectArea()
	{
		int area;
		area=length*width;
		return area;
	}
}
class RectArea
{
	public static void main(String args[])
	{
		int area1,area2;
		Rectengle rect1 = new Rectengle();
		Rectengle rect2 = new Rectengle();
		rect1.length=15;
		rect1.width=10;
		area1=rect1.rectArea();
		rect2.getData(20,15);
		area2=rect2.rectArea();
 
		System.out.println("Area1="+area1);
		System.out.println("Area2="+area2);
	}
}