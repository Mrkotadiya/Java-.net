class ThreadA extends Thread
{
	public void run()
	{
		for(i=0;i<=n=5;i++)
		System.out.println("From Thread A:"+i);
	}
	System.out.println("Exist From A");
}
class ThreadB extends Thread
{
	public void run()
	{
		for(i=0;i<=n=5;i++)
		System.out.println("From Thread B:"+i);
	}
	System.out.println("Exist From B");
}
class ThreadC extends Thread
{
	public void run()
	{
		for(i=0;i<=n=5;i++)
		System.out.println("From Thread C:"+i);
	}
	System.out.println("Exist From C");
}
class ThreadTest
{
	public static void main(String args[])
	{
		ThreadA a=new ThreadA();
		ThreadB b=new ThreadB();
		ThreadC c=new ThreadC();
		a.start();
		b.start();
		c.start();
	}
}