class Sorting
{
	public static void main(String args[])
	{
		int arr[]={1,2,5,7,6};
			int len=arr.length;
			for(int i=0;i<len;i++)
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