class Room
{
	int length;
	int breadth;
	Room(int x,int y)
	{
		length=x;
		breadth=y;
	}
	int area()
	{
		return(length*breadth);
	}
}
class BedRoom extends Room
{
	int heigth;
	BedRoom(int x,int y,int z)
	{
		super(x,y);
		heigth=z;
	}
	int volume()
	{
		return(length*breadth*heigth);
	}
}
class TestInheritance
{
	public static void main(String args[])
	{
		BedRoom room1=new BedRoom(14,12,10);
		
		int area1=room1.area();
		int volume1=room1.volume();
		System.out.println("Area="+area1);
		System.out.println("Volume="+volume1);
	}
}






