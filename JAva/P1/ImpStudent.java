import P1.P2.Result
class ImplStudent
{
	public static void void main(String args[])
	{
		Result r1=new Result();
		System.out.println("Shree Uttar Gujarat BCA Collage");
		System.out.println("Roll NO="+r1.rno+"\tName:"+r1.Name);
		System.out.println("Class:"+r1.cls);
		System.out.println("Marks In : ");
		System.out.println("java:"+r1.java+"Vb.Net:"+r1.VB"IOT:"+r1.iot);
		System.out.println("Total Marks="+(r1.java+r1.vb+r1.iot));
	
	}

}