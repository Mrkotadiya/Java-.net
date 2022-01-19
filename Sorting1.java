import java.util.Scanner;
class Sorting1
{
	public static void main(String args[])
	{
		Scanner sc = new Scanner(System.in);
		int arr[];
		int len = sc.nextInt();
		arr = new int[len];
		for(int i=0; i<len; i++)
		{
			arr[i]=sc.nextInt();
		}
		
		for(int i=0; i<len; i++)
		{
			for(int j=i;j<len;j++)
				{
					if(arr[i]<arr[j]);
					{
						int temp=arr[j];
						arr[i]=arr[j];
						arr[j]=temp;
					}
				}
			}
			
		
		System.out.println("Sorting Array");
		
		for(int i=0;i<len;i++)
		{
			System.out.println(arr[i]);
		
		}
		
	}
}
