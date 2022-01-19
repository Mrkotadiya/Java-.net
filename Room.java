class Room
{
	int length,
	int breadth;
	
	Room(int x,int y)
      {
	 length=x;
	 breadth=y;
      }

      intarea()
      {
	return(length * breadth);
      }
}

class Bedroom extends Room
{
	int height;
	Bed Room(int x,int y,int z)
	{
		super(x,y);
		height=2;
	}

 	int volume()
	{
		return(length * breadth *height);
	}
}

class TestInheritance
{
	Public static void main(String args[])
	{
		BedRoom room1=new BedRoom(14,12,10);
		int area1=room1.area();
		int volume1=room1.volume();

	System.out.println("Area1="+ area 1);
	System.out.println("volume1="+volume);
	}
}